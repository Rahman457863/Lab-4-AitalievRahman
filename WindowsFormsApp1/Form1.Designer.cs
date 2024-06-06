namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.Directory1 = new System.Windows.Forms.TextBox();
            this.daddy = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calc_result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRY = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 21);
            this.button1.TabIndex = 0;
            this.button1.Text = "About";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Directory1
            // 
            this.Directory1.Location = new System.Drawing.Point(265, 12);
            this.Directory1.Name = "Directory1";
            this.Directory1.ReadOnly = true;
            this.Directory1.Size = new System.Drawing.Size(236, 20);
            this.Directory1.TabIndex = 1;
            this.Directory1.Click += new System.EventHandler(this.Directory_Click);
            // 
            // daddy
            // 
            this.daddy.FormattingEnabled = true;
            this.daddy.Location = new System.Drawing.Point(555, 11);
            this.daddy.Name = "daddy";
            this.daddy.Size = new System.Drawing.Size(336, 121);
            this.daddy.TabIndex = 2;
            this.daddy.DoubleClick += new System.EventHandler(this.daddy_DoubleClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Size,
            this.Modification,
            this.Calc_result});
            this.dataGridView1.Location = new System.Drawing.Point(20, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(441, 278);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // Name
            // 
            this.Name.HeaderText = "Daddy_name";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // Size
            // 
            this.Size.HeaderText = "Size (doesn\'t matter)";
            this.Size.Name = "Size";
            this.Size.ReadOnly = true;
            // 
            // Modification
            // 
            this.Modification.HeaderText = "dification";
            this.Modification.Name = "Modification";
            this.Modification.ReadOnly = true;
            // 
            // Calc_result
            // 
            this.Calc_result.HeaderText = "result";
            this.Calc_result.Name = "Calc_result";
            this.Calc_result.ReadOnly = true;
            // 
            // TRY
            // 
            this.TRY.Location = new System.Drawing.Point(124, 328);
            this.TRY.Name = "TRY";
            this.TRY.Size = new System.Drawing.Size(215, 58);
            this.TRY.TabIndex = 4;
            this.TRY.Text = "TRY IT";
            this.TRY.UseVisualStyleBackColor = true;
            this.TRY.Click += new System.EventHandler(this.TRY_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1784, 761);
            this.Controls.Add(this.TRY);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.daddy);
            this.Controls.Add(this.Directory1);
            this.Controls.Add(this.button1);
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Directory1;
        private System.Windows.Forms.ListBox daddy;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modification;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calc_result;
        private System.Windows.Forms.Button TRY;
    }
}

