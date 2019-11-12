using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace lab1phase1v2
{
    public interface IFileAccess
    {

        void OpenFileDB();  //Utilizes OpenFileDialog and sets the "fileStream" property
        void SaveFileDB();  //Utilizes SaveFileDialog and sets the "fileStream" property
        void ReadDB();      //Deserializes the "fileStream" and sets the EmployeeDB
        void WriteDB();     //Serializes the EmployeeDB and writes to the "fileStream"
    }
}
