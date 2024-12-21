using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class SignUP : Form
    {
        public SignUP()
        {
            InitializeComponent();
        }

      

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            String Unm = txtunm.Text.ToString();
            String pass = txtPass.Text.ToString();

            String num = txtnum.Text.ToString();

            String email = txtmail.Text.ToString();
            String conString = "server=localhost;user=root;password=;database=c#";
            MySqlConnection con = new MySqlConnection(conString);
            try
            {
                con.Open();

                // Using parameterized queries to prevent SQL injection
                String Command = "INSERT INTO user (unm, pass, mobil, email,img) VALUES (@unm, @pass, @mobil, @email,@imgs)";

                MySqlCommand cmd = new MySqlCommand(Command, con);

                // Adding parameters to the query to avoid SQL injection
                cmd.Parameters.AddWithValue("@unm", Unm);
                cmd.Parameters.AddWithValue("@pass", pass);
                cmd.Parameters.AddWithValue("@mobil", num);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@imgs", getImage());

                // Execute the query and check the result
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    MessageBox.Show("Registration Done");
                }
                else
                {
                    MessageBox.Show("Try Again");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 sgn = new Form1();
            sgn.Show();
            this.Hide();
         


        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(f.FileName);
             


            }
        }
        private byte[] getImage()
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms,pictureBox1.Image.RawFormat);
            return ms.GetBuffer();
        }
       
    }
}
