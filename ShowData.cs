using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using MySql.Data.MySqlClient;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class ShowData : Form
    {
        public ShowData()
        {
            InitializeComponent();
             String conString = "server=localhost;user=root;password=;database=c#";
            MySqlConnection con = new MySqlConnection(conString);
         
                con.Open();
                String command = "select * from user ";
                MySqlCommand cmd = new MySqlCommand(command, con);
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                dataGridView1.DataSource = dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            
        }
    }
}
