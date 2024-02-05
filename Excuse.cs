using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace _9__Trouble_At_Work
{
    [Serializable]
    class Excuse
    {
        
        private string description;

        
        public string Description { 
            get { return this.description; }
            set { this.description = value; }
        }

        private string results;
        public string Results
        {
            get { return this.results; }
            set { this.results = value; }
        }

        private DateTime lastUsed;

        public DateTime LastUsed
        {
            get { return this.lastUsed; }
            set { this.lastUsed = value; }
        }

        private string excusePath;
        public string ExcusePath
        {
            get { return this.excusePath; }
            set { this.excusePath = value; }
        }

        public void OpenFile(string path)
        {
            /*
            string[] linesOnFile = File.ReadAllLines(path);
            this.description = linesOnFile[0];
            this.results = linesOnFile[1];
            this.lastUsed = Convert.ToDateTime(linesOnFile[2]);
            */
            try
            {
                using (Stream input = File.OpenRead(path))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    Excuse openExcuse = (Excuse)bf.Deserialize(input);
                    this.description = openExcuse.description.Replace(".excuse", "");
                    this.results = openExcuse.results;
                    this.lastUsed = openExcuse.lastUsed;

                }
                this.excusePath = path;
            }
            catch (System.Runtime.Serialization.SerializationException)
            {
                MessageBox.Show("The file is invalid", "Invalid File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lastUsed = DateTime.Now;
            }
            
        }

        public void Save(string path)
        {
            /*
            string stringToWrite = string.Format(
                    "{0}\n{1}\n{2}\n"
                , this.description, this.results, this.LastUsed);

            */

            using (Stream output = File.Create(path))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(output,this);
            }
                
        }

        public Excuse()
        {
            this.description = "";
            this.results = "";
        }

        public Excuse(string path)
        {
            this.OpenFile(path);
            this.excusePath = path;
        }
        
        public Excuse(string directoryPath, Random random)
        {
            DirectoryInfo directory = new DirectoryInfo(directoryPath);
            FileInfo[] filesOnDirectory = directory.GetFiles("*.excuse");

            int randomNumber = random.Next(filesOnDirectory.Length);
            if(filesOnDirectory.Length == 0)
            {
                MessageBox.Show("Not files", "Not Files", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            Console.WriteLine(randomNumber);
            
            FileInfo fileSelected = filesOnDirectory[randomNumber];
            this.OpenFile(fileSelected.FullName);
        }
    }
}
