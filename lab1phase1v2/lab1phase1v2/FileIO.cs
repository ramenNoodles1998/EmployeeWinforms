using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;


namespace lab1phase1v2
{
    public class FileIO:  IFileAccess
    {
        private OpenFileDialog openFileDialog;
        
        
        public SortedDictionary<string, Employee> EmployeeDB = new SortedDictionary<string, Employee>();

        private Stream fileStream;
        private static FileIO instance = null;


        public Stream FileStream
        {
            get
            {
                return this.fileStream;
            }
            set
            {
                this.fileStream = value;
            }
        }

        public static FileIO Instance
        {
            get
            {


                if (instance == null)
                {
                    instance = new FileIO();
                }
                return instance;

            }
        }
        public FileIO()
        {
            
        }


        public void SaveFileDB()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text|*.txt";
            saveFileDialog.Title = "Roman's Save File Dialog";
            saveFileDialog.Filter = "Text|*.txt";
        }

        public void ReadDB()
        {
            BinaryFormatter formatter = new BinaryFormatter();

            Employee emp;
            //x = (HourlyEmployee)formatter.Deserialize(fileStream);
            SortedDictionary<string, Employee> EmployeeDB1 = new SortedDictionary<string, Employee>();
            foreach (KeyValuePair<string, Employee> entry in EmployeeDB)
            {
               
                emp = (Employee)formatter.Deserialize(fileStream);
                EmployeeDB1.Add(emp.empId.ToString(), emp);
            }


            EmployeeDB = EmployeeDB1;

            fileStream.Close();
        }

        public void WriteDB()
        {
            
            BinaryFormatter formatter = new BinaryFormatter();
            
            
            
            foreach(KeyValuePair<string, Employee> entry in EmployeeDB)
            {
                formatter.Serialize(fileStream, entry.Value);
                
            }
            fileStream.Close();
        }
        public void OpenFileDB()
        {
            openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Roman's Open File Dialog";
            openFileDialog.Filter = "Text|*.txt";            

            if (openFileDialog.ShowDialog() == DialogResult.OK)  
            {
                
                fileStream = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.ReadWrite);
                
                
            }

            

        }
        
    }
}
