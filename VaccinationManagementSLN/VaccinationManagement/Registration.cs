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
    public partial class Registration : Form
    {
        private DataAccess Da { get; set; }
        public Registration()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            this.AutoId();
        }
        private void PopulateGridView(string sql = "select * from CandidateInfo;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvREG.AutoGenerateColumns = false;
            this.dgvREG.DataSource = ds.Tables[0];
        }


        private void btnSaveClick(object sender, EventArgs e)
        {
            var sql = @"Select * from CandidateInfo where CandidateId = " + this.txtId.Text + ";";
            var ds = this.Da.ExecuteQuery(sql);
            if (ds.Tables[0].Rows.Count == 0)
            {
                try
                {
                    sql = @"insert into CandidateInfo values(" + this.txtId.Text + ", '" + this.txtName.Text + "', '" + this.dtpDOB.Text + "','" + this.cmbVaccine.Text + "');";
                    var rowCount = this.Da.ExecuteDMLQuery(sql);



                    if (rowCount == 1)
                    {
                        MessageBox.Show("Data insertion operation completed.");
                    }
                    else
                    {
                        MessageBox.Show("Data insertion operation failed.");
                    }

                    this.PopulateGridView(sql);

                }


                catch (Exception exc)
                {
                    MessageBox.Show("An error has occured, please try again later. Error msg: " + exc.Message);
                }
            }


            else
            {

                MessageBox.Show("An error has occured, please try again");
            }
           

        }


        


        private void AutoId()
        {
            var sql = "select * from CandidateInfo order by CandidateId desc;";
            DataTable dt = this.Da.ExecuteQueryTable(sql);

            string lastId = dt.Rows[0][0].ToString();
            string temp = lastId;
            int no = Convert.ToInt32(temp);

            string newId = (++no).ToString();
            this.txtId.Text = newId;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormRegister S1 = new FormRegister();
            S1.Show();
            this.Hide();
        }
    }
}
