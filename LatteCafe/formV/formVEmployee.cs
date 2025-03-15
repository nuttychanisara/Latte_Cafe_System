using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LatteCafe.Class;
using LatteCafe.formUpdate;

namespace LatteCafe.formV
{
    public partial class formVEmployee : Form
    {
        public formVEmployee()
        {
            InitializeComponent();
        }

        public Label getIDs = new Label();

        clsView view = new clsView();

        private void formVEmployee_Load(object sender, EventArgs e)
        {
            view.viewEmployee(dataGridView1);
            textBox1.Text = dataGridView1.RowCount.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                view.selectImageFromEmployee(row.Cells[0].Value.ToString(), pictureBox1);
                //concartenate firstname lastname and othername and in between set an empty space
                groupBox2.Text = row.Cells[1].Value.ToString() + "'s Image";
                txtFullname.Text = row.Cells[1].Value.ToString() + " " + row.Cells[2].Value.ToString() + " " + row.Cells[3].Value.ToString();
                txtResidence.Text = row.Cells[7].Value.ToString();
                txtEmail.Text = row.Cells[8].Value.ToString();

                //since the first column holds the id
                //we will assign the the label to the first column of the grid
                getIDs.Text = row.Cells[0].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtSearcshFname.Text.Trim().Length > 0)
            {
                view.searcshEmployeeByFirstName(txtSearcshFname.Text, dataGridView1);

            }
            else
            {

                //recall this method
                view.viewEmployee(dataGridView1);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtFullname.Text.Trim().Equals(""))
            {
                MessageBox.Show("please select an employee", "SAVED - Fronty", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            //instantiating the update employee form class
            formEmployee updateEmpForm = new formEmployee();
            updateEmpForm.textBox1.Text = getIDs.Text.Trim();

            updateEmpForm.ShowDialog();

            // refresh datagrid
            view.viewEmployee(dataGridView1);
        }
    }
}
