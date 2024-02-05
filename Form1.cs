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

namespace _9__Trouble_At_Work
{
    public partial class Form1 : Form
    {
        private bool formChanged = false;
        private string selectedPath = "";
        private Excuse currentExcuse;
        private Random random;

        public Form1()
        {
            InitializeComponent();
            
            this.currentExcuse = new Excuse();
            this.random = new Random();
            lastUsedField.Value = DateTime.Now;
            labelFileDate.Text = "";


            this.currentExcuse.LastUsed = lastUsedField.Value;

        }

        private void selectFolder_Click(object sender, EventArgs e)
        {
            DialogResult folderBrowserResult = folderBrowserDialog1.ShowDialog();
            if(folderBrowserResult == DialogResult.OK)
            {
                this.selectedPath = folderBrowserDialog1.SelectedPath;
                this.open.Enabled = true;
                this.save.Enabled = true;
                this.randomExcuse.Enabled = true;
                this.saveFileDialog1.InitialDirectory = selectedPath;
                this.openFileDialog1.InitialDirectory = selectedPath;
            }
            
            
        }

        private void textExcuse_TextChanged(object sender, EventArgs e)
        {
            this.currentExcuse.Description = textExcuse.Text;
            
            this.updateForm(true);
        }

        private void textResult_TextChanged(object sender, EventArgs e)
        {
            this.currentExcuse.Results= textResult.Text;
            
            this.updateForm(true);
        }

        private void updateForm(bool changed)
        {
            if (!changed )
            {
                this.textExcuse.Text = currentExcuse.Description;
                this.textResult.Text = currentExcuse.Results;

                this.lastUsedField.Value = currentExcuse.LastUsed < lastUsedField.MinDate ? 
                    lastUsedField.MinDate : currentExcuse.LastUsed;
                if (!String.IsNullOrEmpty(currentExcuse.ExcusePath))
                {
                    labelFileDate.Text = File.GetLastWriteTime(currentExcuse.ExcusePath).ToString();
                }
                else
                {
                    labelFileDate.Text = "No date";
                }
                this.Text = "Excuse Manager";

            }
            else
                this.Text = "Excuse Manager*";
            this.formChanged = changed;
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.currentExcuse.Description) || String.IsNullOrEmpty(this.currentExcuse.Results))
            {
                MessageBox.Show("Please specify an excuse and a result", "Unable to Save", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }
            saveFileDialog1.InitialDirectory = this.selectedPath;
            saveFileDialog1.Filter = "(*.excuse)|*excuse";
            saveFileDialog1.FileName = currentExcuse.Description + ".excuse";
            DialogResult result = saveFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                
                this.currentExcuse.Save(Path.GetFullPath(saveFileDialog1.FileName));
                
                this.updateForm(false);
            }
        }

        private bool showDialog()
        {
            DialogResult continueResult = MessageBox.Show("The current Excuse hasn't been saved, continue?", "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            return (continueResult == DialogResult.No);

        }

        private void open_Click(object sender, EventArgs e)
        {
            if (this.formChanged)
            {
                if (this.showDialog())
                    return;


            }
                
            openFileDialog1.InitialDirectory = this.selectedPath;
            openFileDialog1.Filter = "(*.excuse)|*excuse";

            DialogResult result = openFileDialog1.ShowDialog();
            
            if(result == DialogResult.OK)
            {
                this.currentExcuse = new Excuse(Path.GetFullPath(openFileDialog1.FileName));
                
                this.updateForm(false);
            }

            
        }

        private void lastUsedField_ValueChanged(object sender, EventArgs e)
        {
            currentExcuse.LastUsed = lastUsedField.Value;
            
            this.updateForm(true);
        }

        private void randomExcuse_Click(object sender, EventArgs e)
        {
            if (this.formChanged)
            {
                if (this.showDialog())
                    return;

            }

            this.currentExcuse = new Excuse(this.selectedPath, random);
            
            this.updateForm(false);
        }
    }
}
