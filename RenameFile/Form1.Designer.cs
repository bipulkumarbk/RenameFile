namespace RenameFile
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
            this.ExcelName = new System.Windows.Forms.TextBox();
            this.SelectExcel = new System.Windows.Forms.Button();
            this.RenameFile = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SelectFolder = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Filecount = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // ExcelName
            // 
            this.ExcelName.Location = new System.Drawing.Point(12, 42);
            this.ExcelName.Name = "ExcelName";
            this.ExcelName.ReadOnly = true;
            this.ExcelName.Size = new System.Drawing.Size(202, 20);
            this.ExcelName.TabIndex = 0;
            // 
            // SelectExcel
            // 
            this.SelectExcel.Location = new System.Drawing.Point(236, 42);
            this.SelectExcel.Name = "SelectExcel";
            this.SelectExcel.Size = new System.Drawing.Size(142, 23);
            this.SelectExcel.TabIndex = 1;
            this.SelectExcel.Text = "Select CSV File";
            this.SelectExcel.UseVisualStyleBackColor = true;
            this.SelectExcel.Click += new System.EventHandler(this.SelectExcel_Click);
            // 
            // RenameFile
            // 
            this.RenameFile.Location = new System.Drawing.Point(90, 300);
            this.RenameFile.Name = "RenameFile";
            this.RenameFile.Size = new System.Drawing.Size(177, 23);
            this.RenameFile.TabIndex = 2;
            this.RenameFile.Text = "Rename File";
            this.RenameFile.UseVisualStyleBackColor = true;
            this.RenameFile.Click += new System.EventHandler(this.RenameFile_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(418, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(370, 391);
            this.dataGridView1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(202, 20);
            this.textBox1.TabIndex = 4;
            // 
            // SelectFolder
            // 
            this.SelectFolder.Location = new System.Drawing.Point(236, 87);
            this.SelectFolder.Name = "SelectFolder";
            this.SelectFolder.Size = new System.Drawing.Size(142, 23);
            this.SelectFolder.TabIndex = 5;
            this.SelectFolder.Text = "Select Folder for File Rename";
            this.SelectFolder.UseVisualStyleBackColor = true;
            this.SelectFolder.Click += new System.EventHandler(this.SelectFolder_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(13, 138);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(372, 150);
            this.dataGridView2.TabIndex = 6;
            // 
            // Filecount
            // 
            this.Filecount.AutoSize = true;
            this.Filecount.Location = new System.Drawing.Point(13, 117);
            this.Filecount.Name = "Filecount";
            this.Filecount.Size = new System.Drawing.Size(0, 13);
            this.Filecount.TabIndex = 7;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(16, 360);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(369, 10);
            this.progressBar1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Filecount);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.SelectFolder);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.RenameFile);
            this.Controls.Add(this.SelectExcel);
            this.Controls.Add(this.ExcelName);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ExcelName;
        private System.Windows.Forms.Button SelectExcel;
        private System.Windows.Forms.Button RenameFile;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button SelectFolder;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label Filecount;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

