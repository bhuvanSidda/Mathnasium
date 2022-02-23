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

namespace HLProjectMathnasium
{
    public partial class ExportForm : Form
    {
        public MenuForm MyMenuForm;

        string _path = "";

        public ExportForm(MenuForm menuForm)
        {
            MyMenuForm = menuForm;
            InitializeComponent();
        }

        //https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/file-system/how-to-write-to-a-text-file

        private void btn_pdf_Click(object sender, EventArgs e)
        {
            SearchForFileLocation();

            WriteToFile();
        }
        //https://help.syncfusion.com/file-formats/pdf/create-pdf-file-in-c-sharp-vb-net
        //https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.savefiledialog?view=windowsdesktop-6.0
        public void SearchForFileLocation()
        {
            SaveFileDialog myFileExplorer = new SaveFileDialog();
            myFileExplorer.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            myFileExplorer.ShowDialog();

            _path = myFileExplorer.FileName;
        }


        public void WriteToFile()
        {
            string[] lines = MyMenuForm.GetGridData();

            File.WriteAllLines(_path, lines);

            this.Close();
        }

    }
}
