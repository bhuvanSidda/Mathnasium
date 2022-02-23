using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HLProjectMathnasium
{
    public partial class MenuForm : Form
    {
        public List<string> myData = new List<string>();

        public MenuForm()
        {
            InitializeComponent();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            this.Name = "Main Menu Form";

            SetUpGridView();
        }

        public void SetUpGridView()
        {
            grid_myData.ReadOnly = true;
            grid_myData.ColumnCount = 3;

            grid_myData.Columns[0].Name = "Name";
            grid_myData.Columns[1].Name = "Instructor";
            grid_myData.Columns[2].Name = "Date";
        }

        public void AddItem(string name, string instructor, string date)
        {
            string[] rowList = new string[] { name, instructor, date };

            myData.Add(name + "            " + instructor + "                " + date);

            grid_myData.Rows.Add(rowList);
        }

        public string[] GetGridData()
        {
            string[] list = new string[myData.Count + 1];
            list[0] = "name----------" + "Instructor----------" + "Date----------";

            for(int i = 0; i < myData.Count; i++)
            {
                list[i + 1] = myData[i];
            }

            return list;
        }

        public void OpenImport()
        {
            ImportForm myImport = new ImportForm(this);
            myImport.ShowDialog();
        }
        public void OpenExport()
        {
            ExportForm myExport = new ExportForm(this);
            myExport.ShowDialog();
        }


        private void btn_export_Click(object sender, EventArgs e)
        {
            OpenExport();
        }

        private void btn_import_Click(object sender, EventArgs e)
        {
            OpenImport();
        }
    }
}
