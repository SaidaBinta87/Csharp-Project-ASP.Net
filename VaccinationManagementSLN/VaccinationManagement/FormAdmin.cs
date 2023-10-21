using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VaccinationManagement
{
    public partial class FormAdmin : Form
    {
        private FormUser Fl { get; set; }
        public FormAdmin()
        {
            InitializeComponent();
        }

        public FormAdmin(FormUser fl, string text) : this()
         {
           this.Fl = fl;
           this.lblAdmin.Text += text;
        }

       

        private void btnEditInfo_click(object sender, EventArgs e)
        {
            FormEditAndShow E1 = new FormEditAndShow();
            E1.Show();
            this.Hide();

        }

        private void Back_Click(object sender, EventArgs e)
        {
            FormUser S1 = new FormUser();
            S1.Show();
            this.Hide();
        }
    }
}
