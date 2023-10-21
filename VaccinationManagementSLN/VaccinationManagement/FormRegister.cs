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
    public partial class FormRegister : Form
    {
        
        public FormRegister()
        {
            InitializeComponent();
        }
        private FormUser Fl { get; set; }

        public FormRegister(FormUser fl, string text) : this()
        {
            this.Fl = fl;
            this.lblRegister.Text += text;
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            Registration R1 = new Registration();
            R1.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowStatus S1 = new ShowStatus();
            S1.Show();
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
