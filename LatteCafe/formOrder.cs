using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace LatteCafe
{
    public partial class formOrder : Form
    {
        SqlConnection menuConnection;
        SqlCommand menuCommand;
        SqlDataAdapter menuAdapter;
        DataTable menuTable;
        CurrencyManager menuManager;

        SqlCommand meneCCommand;
        SqlDataAdapter menoCAdapter;
        DataTable menuCTable;

        public formOrder()
        {
            InitializeComponent();
        }
        CurrencyManager currency;
        private void formOrder_Load(object sender, EventArgs e)
        {
            /*try
            {
                 
                menuConnection = new SqlConnection("Data source = NUTTY;" +
                    "Initial Catalog = LatteCafeDB;" +
                    "User ID = user1; Password = mypass1");
                // Open the connection   
                menuConnection.Open();
                // Establish command object
                menuCommand = new SqlCommand("Select MenuId, MenuPrice from Menu$ ORDER BY MenuId",
                                       menuConnection);
                // Establish data adapter/data table
                menuAdapter = new SqlDataAdapter();
                menuAdapter.SelectCommand = menuCommand;
                menuTable = new DataTable();
                menuAdapter.Fill(menuTable);
                // Bind controls to data table
                textMenuId.DataBindings.Add("Text", menuTable, "MenuId");
                textPrice.DataBindings.Add("Text", menuTable, "MenuPrice");

                // Establish currency manager
                menuManager = (CurrencyManager)
                this.BindingContext[menuTable];

                meneCCommand = new SqlCommand("Select MenuCPName from MenuCostPrice$ ");
                menoCAdapter = new SqlDataAdapter();
                menoCAdapter.SelectCommand = meneCCommand;
                menuCTable = new DataTable();
                menoCAdapter.Fill(menuCTable);
                comboMenuName.DataSource = menuCTable;
                comboMenuName.DisplayMember = "MenuCPName";
                comboMenuName.ValueMember = "MenuCPId";
                comboMenuName.DataBindings.Add("SelectedValue", menuTable, "MenuCPId");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "เกิดข้อผิดพลาดในการสร้างการสั่งอาหาร",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            this.Show();*/

            /* SqlConnection conn = new SqlConnection("Data Source = NUTTY;Initial Catalog=LatteCafeDB;User ID=user1;Password=mypass1");
             SqlCommand cmd = new SqlCommand("Select MenuCPName from MenuCostPrice$", conn);
             SqlDataAdapter dataAdapter = new SqlDataAdapter();
             dataAdapter.SelectCommand = cmd;
             DataTable dt = new DataTable();
             dataAdapter.Fill(dt);


             listMenu.DataBindings.Add("Text", dt, "MenuCPName");

             listMenu.DataSource = dt;
             listMenu.DisplayMember = "MenuCPName";
             listMenu.ValueMember = "MenuId";
             listMenu.DataBindings.Add("SelectedValue", dt, "MenuId");*/


        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
           if(menuManager.Position == menuManager.Count  - 1)
           {
                Console.Beep();
           }
           menuManager.Position++;
        }
    }
}
