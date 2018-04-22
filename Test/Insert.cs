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
using MySql.Data.MySqlClient;

namespace Test
{
    public partial class Insert : Form
    {
        String myconnection = "SERVER=127.0.0.1;DATABASE=dotnet;UID=root;PASSWORD=aaditya";
        String name, phno, query;

        
        public Insert()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;
            phno = "+91" + textBox2.Text;

            try
            {
                query = "Insert into contacts values('" + name + "','" + phno + "')";
                MySqlConnection connection = new MySqlConnection(myconnection);
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader myReader;
                connection.Open();
                myReader = command.ExecuteReader();
                MessageBox.Show("Data Saved");
                connection.Close();
            }
            /*catch (DuplicateWaitObjectException) { 
                MessageBox.Show("Entered Phone Number already exists 45");
            }*/
            catch (Exception) { 
                MessageBox.Show("Entered Phone Number already exists");
            }

        }
    }
}
