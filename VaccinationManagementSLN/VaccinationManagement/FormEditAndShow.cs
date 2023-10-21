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
    public partial class FormEditAndShow : Form
    {
        private DataAccess Da { get; set; }
        public FormEditAndShow()
        {
            InitializeComponent();

            this.Da = new DataAccess();

            this.PopulateGridView();
        }

        private void FormEditAndShow_Load(object sender, EventArgs e)
        {
            this.dgvAdminPage.ClearSelection();
            this.AutoId();
        }


        private void PopulateGridView(string sql = "select * from CandidateInfo;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvAdminPage.AutoGenerateColumns = false;
            this.dgvAdminPage.DataSource = ds.Tables[0];
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = "select * from CandidateInfo where CandidateId = "+ this.txtSearchID.Text + ";";
            this.PopulateGridView(sql);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var sql = "select * from CandidateInfo where VaccineName like '" + this.txtSearch.Text + "%';";


            this.PopulateGridView(sql);
        }



        private bool IsValidToUpdate()
        {
            if (String.IsNullOrEmpty(this.txtID.Text) || String.IsNullOrEmpty(this.txtName.Text) ||
                String.IsNullOrEmpty(this.dtpDOB.Text) || String.IsNullOrEmpty(this.cmbVaccine.Text))
            {
                return false;
            }
            else
                return true;

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsValidToUpdate())
                {
                    MessageBox.Show("Please Fill all the information");
                    return;
                }

                var sql = "select * from CandidateInfo where CandidateId = '" + this.txtID.Text + "';";
                var ds = this.Da.ExecuteQuery(sql);
                if (ds.Tables[0].Rows.Count == 1)
                {

                    sql = @"update CandidateInfo
                            set CandidateId = '" + this.txtID.Text + @"',
                            CandidateName = " + this.txtName.Text + @",
                            DOB = " + this.dtpDOB.Text + @",
                            VaccineName = '" + this.cmbVaccine.Text + @"'; ";
                    var rowCount = this.Da.ExecuteDMLQuery(sql);

                    if (rowCount == 1)
                    {
                        MessageBox.Show("Data update operation completed.");
                    }
                    else
                    {
                        MessageBox.Show("Data update operation failed.");
                    }
                }

                else
                {
                    sql = @"insert into CandidateInfo values('" + this.txtID.Text + "', '" + this.txtName.Text + "', '" + this.dtpDOB.Text + "', '" + this.cmbVaccine.Text + "');";
                    var rowCount = this.Da.ExecuteDMLQuery(sql);

                    if (rowCount == 1)
                    {
                        MessageBox.Show("Data insertion operation completed.");
                    }
                    else
                    {
                        MessageBox.Show("Data insertion operation failed.");
                    }
                    this.RefreshContent();
                    this.PopulateGridView();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured, please try again later. Error msg: " + exc.Message);
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
            this.txtID.Text = newId;
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.txtID.Clear();
            this.txtName.Clear();
            this.dtpDOB.Text = "";
            this.cmbVaccine.SelectedIndex = -1;
       
            this.AutoId();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvAdminPage.SelectedRows.Count < 1)
                {
                    MessageBox.Show("No row selected, Please select a row first.", "Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    return;
                }

                var id = this.dgvAdminPage.CurrentRow.Cells[0].Value.ToString();
                var name = this.dgvAdminPage.CurrentRow.Cells[1].Value.ToString();

                var sql = "delete from CandidateInfo where CandidateId = '" + id + "';";
                var rowCount = this.Da.ExecuteDMLQuery(sql);

                if (rowCount == 1)
                {
                    MessageBox.Show(name + " has been deleted from Table.");
                }
                else
                {
                    MessageBox.Show("Data deletion operation failed.");
                }
                this.PopulateGridView();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured, please try again later. Error msg: " + exc.Message);
            }
        }

        private void dgvCandidateInfo_DoubleClick(object sender, EventArgs e)
        {
            this.txtID.Text = this.dgvAdminPage.CurrentRow.Cells["CandidateId"].Value.ToString();
            this.txtName.Text = this.dgvAdminPage.CurrentRow.Cells["CandidateName"].Value.ToString();
            this.dtpDOB.Text = this.dgvAdminPage.CurrentRow.Cells["DOB"].Value.ToString();
            this.cmbVaccine.Text = this.dgvAdminPage.CurrentRow.Cells["VaccineName"].Value.ToString();
        }
        private void RefreshContent()
        {
            this.txtID.Clear();
            this.txtName.Clear();
            this.dtpDOB.Text = "";
            this.cmbVaccine.SelectedIndex = -1;

            this.AutoId();


        }

        private void Back_Click(object sender, EventArgs e)
        {
            FormAdmin S1 = new FormAdmin();
            S1.Show();
            this.Hide();
        }
    }
    
}
