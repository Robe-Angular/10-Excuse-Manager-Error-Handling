
namespace _9__Trouble_At_Work
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textExcuse = new System.Windows.Forms.TextBox();
            this.textResult = new System.Windows.Forms.TextBox();
            this.selectFolder = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.randomExcuse = new System.Windows.Forms.Button();
            this.open = new System.Windows.Forms.Button();
            this.labelFileDate = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.lastUsedField = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Excuse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Results";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Last Used";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "File date";
            // 
            // textExcuse
            // 
            this.textExcuse.Location = new System.Drawing.Point(79, 6);
            this.textExcuse.Name = "textExcuse";
            this.textExcuse.Size = new System.Drawing.Size(229, 20);
            this.textExcuse.TabIndex = 2;
            this.textExcuse.TextChanged += new System.EventHandler(this.textExcuse_TextChanged);
            // 
            // textResult
            // 
            this.textResult.Location = new System.Drawing.Point(79, 32);
            this.textResult.Name = "textResult";
            this.textResult.Size = new System.Drawing.Size(229, 20);
            this.textResult.TabIndex = 3;
            this.textResult.TextChanged += new System.EventHandler(this.textResult_TextChanged);
            // 
            // selectFolder
            // 
            this.selectFolder.Location = new System.Drawing.Point(12, 129);
            this.selectFolder.Name = "selectFolder";
            this.selectFolder.Size = new System.Drawing.Size(66, 29);
            this.selectFolder.TabIndex = 6;
            this.selectFolder.Text = "Folder";
            this.selectFolder.UseVisualStyleBackColor = true;
            this.selectFolder.Click += new System.EventHandler(this.selectFolder_Click);
            // 
            // save
            // 
            this.save.Enabled = false;
            this.save.Location = new System.Drawing.Point(100, 129);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(66, 29);
            this.save.TabIndex = 7;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // randomExcuse
            // 
            this.randomExcuse.Enabled = false;
            this.randomExcuse.Location = new System.Drawing.Point(278, 129);
            this.randomExcuse.Name = "randomExcuse";
            this.randomExcuse.Size = new System.Drawing.Size(106, 29);
            this.randomExcuse.TabIndex = 9;
            this.randomExcuse.Text = "Random Excuse";
            this.randomExcuse.UseVisualStyleBackColor = true;
            this.randomExcuse.Click += new System.EventHandler(this.randomExcuse_Click);
            // 
            // open
            // 
            this.open.Enabled = false;
            this.open.Location = new System.Drawing.Point(188, 129);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(66, 29);
            this.open.TabIndex = 8;
            this.open.Text = "Open";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // labelFileDate
            // 
            this.labelFileDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelFileDate.Location = new System.Drawing.Point(79, 84);
            this.labelFileDate.Name = "labelFileDate";
            this.labelFileDate.Size = new System.Drawing.Size(229, 20);
            this.labelFileDate.TabIndex = 10;
            this.labelFileDate.Text = "label5";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.SelectedPath = "C:\\Users\\HP\\source\\repos\\HeadFirstCS\\10 Exception Magnets";
            // 
            // lastUsedField
            // 
            this.lastUsedField.Location = new System.Drawing.Point(79, 58);
            this.lastUsedField.Name = "lastUsedField";
            this.lastUsedField.Size = new System.Drawing.Size(229, 20);
            this.lastUsedField.TabIndex = 11;
            this.lastUsedField.Value = new System.DateTime(2023, 8, 26, 19, 8, 10, 0);
            this.lastUsedField.ValueChanged += new System.EventHandler(this.lastUsedField_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 213);
            this.Controls.Add(this.lastUsedField);
            this.Controls.Add(this.labelFileDate);
            this.Controls.Add(this.randomExcuse);
            this.Controls.Add(this.open);
            this.Controls.Add(this.save);
            this.Controls.Add(this.selectFolder);
            this.Controls.Add(this.textResult);
            this.Controls.Add(this.textExcuse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Excuse Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textExcuse;
        private System.Windows.Forms.TextBox textResult;
        private System.Windows.Forms.Button selectFolder;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button randomExcuse;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.Label labelFileDate;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.DateTimePicker lastUsedField;
    }
}

