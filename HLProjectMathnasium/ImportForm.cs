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
    public partial class ImportForm : Form
    {
        public string MyName { get; set; }
        public string Instructor { get; set; }
        public string Date { get; set; }

        public MenuForm MyMenuForm { get; set; }


        public ImportForm(MenuForm myMenu)
        {
            MyMenuForm = myMenu;

            InitializeComponent();
        }

        private void ImportForm_Load(object sender, EventArgs e)
        {
            this.Name = "Import Form";
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MyName))
            {
                return;
            }
            if (string.IsNullOrEmpty(Instructor))
            {
                return;
            }
            if (string.IsNullOrEmpty(Date))
            {
                return;
            }
            MyMenuForm.AddItem(MyName, Instructor, Date);
            this.Close();
        }

        private void tbox_name_TextChanged(object sender, EventArgs e)
        {
            MyName = tbox_name.Text;
        }

        private void tbox_instructor_TextChanged(object sender, EventArgs e)
        {
            Instructor = tbox_instructor.Text;

        }

        private void tbox_time_TextChanged(object sender, EventArgs e)
        {
            Date = tbox_time.Text;

        }
    }
}
