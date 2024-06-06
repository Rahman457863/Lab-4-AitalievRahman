using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aitaliev Rahman : SEST-1-22");
        }

        private void Directory_Click(object sender, EventArgs e)
        {
            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                DialogResult result = folderBrowserDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                {
                    Directory1.Text = folderBrowserDialog.SelectedPath;
                    string selectedPath = folderBrowserDialog.SelectedPath;
                    string[] directories = Directory.GetDirectories(selectedPath);

                    // Очищаем ListBox
                    daddy.Items.Clear();

                    // Добавляем имена в ListBox
                    foreach (string directory in directories)
                    {
                        daddy.Items.Add(Path.GetFileName(directory));
                    }
                    string[] files = Directory.GetFiles(selectedPath);
                    foreach (string filePath in files)
                    {
                        FileInfo fileInfo = new FileInfo(filePath);
                        Console.WriteLine($"File Name: {fileInfo.Name}");
                        Console.WriteLine($"Size (bytes): {fileInfo.Length}");
                        Console.WriteLine($"Creation Time: {fileInfo.CreationTime}");
                        Console.WriteLine($"Last Access Time: {fileInfo.LastAccessTime}");
                        Console.WriteLine($"Last Write Time: {fileInfo.LastWriteTime}");
                        Console.WriteLine();
                        dataGridView1.Rows.Add(fileInfo.Name, fileInfo.Length, "Значение ячейки 3", "");
                    }
                }
            }
        }

        private void daddy_DoubleClick(object sender, EventArgs e)
        {
            if (daddy.SelectedItem != null)
            {
                string selectedFolder = Path.Combine(Directory1.Text, daddy.SelectedItem.ToString());

                Form2 form = new Form2(selectedFolder);
                form.ShowDialog();
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            DialogResult NoMom = MessageBox.Show("Продублировать файл?", caption: "No mom?", buttons: MessageBoxButtons.YesNoCancel);
            if(NoMom == DialogResult.Yes)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                DataGridViewRow newRow = (DataGridViewRow)selectedRow.Clone();

                foreach (DataGridViewCell cell in selectedRow.Cells)
                {
                    newRow.Cells[cell.ColumnIndex].Value = cell.Value;
                }

                dataGridView1.Rows.Insert(selectedRow.Index + 1, newRow);
            }
        }

        private async Task Delay(int num, int i)
        {
            await Task.Delay(num * 1000);
            dataGridView1.Rows[i].Cells["Calc_result"].Value = num.ToString();
        }

        

        private async void TRY_Click_1(object sender, EventArgs e)
        {
            Random random = new Random();
            Task[] na = new Task[dataGridView1.Rows.Count];
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                int randomNumber = random.Next(1, dataGridView1.Rows.Count + 1);
                na[i] = Delay(randomNumber, i);
            }
            await Task.WhenAll(na);
        }
    }
}
