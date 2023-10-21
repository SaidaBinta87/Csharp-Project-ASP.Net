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
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string sql = "select * from UserInfo where ID = '" + this.txtUserID.Text + "' and Password = '" + this.txtPassword.Text + "';";
            SqlConnection sqlcon = new SqlConnection("Data Source=DESKTOP-T7D4QD4;Initial Catalog=Vaccination;User ID=sa;Password=Saida244");
            sqlcon.Open();
            SqlCommand sqlcom = new SqlCommand(sql, sqlcon);
            SqlDataAdapter sda = new SqlDataAdapter(sqlcom);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            //string data = ds.Tables[0].Rows[3][0].ToString();
            //MessageBox.Show(data);
            if (ds.Tables[0].Rows.Count == 1)
            {
                this.Hide();
                MessageBox.Show("Login Confirmed");
                string userName = ds.Tables[0].Rows[0][1].ToString();

                if (ds.Tables[0].Rows[0][3].ToString() == "admin")
                {
                    new FormAdmin(this, userName).Show();
                }
                else if (ds.Tables[0].Rows[0][3].ToString() == "register")
                {
                    new FormRegister(this, userName).Show();
                }
            }
            else
            {
                MessageBox.Show("Login Denied");
            }

            sqlcon.Close();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
           
                this.txtUserID.Clear();
                this.txtPassword.Clear();
            
        }
    }
    
}
