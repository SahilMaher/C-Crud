using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;

using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUP signup=new SignUP();
            
          
            signup.Show();
            this.Hide();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String uname = unmTxt.Text;
            String pass = passTxt.Text;
            String conString = "server=localhost;user=root;password=;database=c#";
            MySqlConnection con = new MySqlConnection(conString);
         
                con.Open();
                String command = "select * from user where unm=@unm and pass=@pass";

                MySqlCommand cmd = new MySqlCommand(command, con);
                cmd.Parameters.AddWithValue("@unm", uname);
                cmd.Parameters.AddWithValue("@pass", pass);
                int res = Convert.ToInt32( cmd.ExecuteScalar());
                if (res > 0)
                {
                    ShowData show = new ShowData();
                    show.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Try Again");
                }
            
            

        }
        
    }
}
