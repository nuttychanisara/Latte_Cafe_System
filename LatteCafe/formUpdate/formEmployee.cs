using LatteCafe.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatteCafe.formUpdate
{
    public partial class formEmployee : Form
    {
        Select select = new Select();
        Update update = new Update();

        public formEmployee()
        {
            InitializeComponent();
        }
        void selectDetails()
        {
            try
            {
                Select selectClass = new Select();

                string sql = "select fname,lname,oname,gender,dob,phone,resAddress,emailAdd,ref_fname,ref_lname,ref_phone,photo  from tblEmployee where empID='" + textBox1.Text + "'";
                SqlConnection con = new SqlConnection(selectClass.dbPath);
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtFname.Text = reader["fname"].ToString();
                    txtLname.Text = reader["lname"].ToString();
                    txtOname.Text = reader["oname"].ToString();
                    cboGender.Text = reader["gender"].ToString();
                    dptBDay.Text = reader["dob"].ToString();
                    txtPhone.Text = reader["phone"].ToString();
                    txtResAddress.Text = reader["resAddress"].ToString();
                    txtEmail.Text = reader["emailAdd"].ToString();
                    txtRFname.Text = reader["ref_fname"].ToString();
                    txtRLname.Text = reader["ref_lname"].ToString();
                    txtRPhone.Text = reader["ref_phone"].ToString();

                    MemoryStream ms = new MemoryStream((byte[])reader["photo"]);
                    PicEmp.Image = new Bitmap(ms);
                }
                else
                {

                    clearAll();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        void clearAll()
        {
            txtFname.Clear();
            txtLname.Clear();
            txtOname.Clear();
            cboGender.SelectedIndex = 0;

            txtPhone.Clear();
            txtResAddress.Clear();
            txtEmail.Clear();
            txtRFname.Clear();
            txtRLname.Clear();
            txtRPhone.Clear();
            PicEmp.Image = null;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            update.updateEmployee(textBox1.Text, txtFname.Text, txtLname.Text, txtOname.Text, cboGender, dptBDay, txtPhone.Text, txtResAddress.Text, txtEmail.Text, txtRFname.Text, txtRLname.Text, txtRPhone.Text, PicEmp);
            clearAll();
        }
    }
}
