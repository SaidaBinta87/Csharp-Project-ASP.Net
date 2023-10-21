using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VaccinationManagement
{
    public partial class ShowStatus : Form
    {
        private DataAccess Da { get; set; }
        public ShowStatus()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            this.PopulateGridView();
        }


        private void PopulateGridView(string sql = "select * from CandidateInfo;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvShowStatus.AutoGenerateColumns = false;
            this.dgvShowStatus.DataSource = ds.Tables[0];
        }

        private void btnEnterID_Click(object sender, EventArgs e)
        {
            string sql = "select * from CandidateInfo where CandidateId = " + this.txtEnterID.Text + ";";
            this.PopulateGridView(sql);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormRegister S1 = new FormRegister();
            S1.Show();
            this.Hide();
        }
    }
}
