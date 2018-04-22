using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Test
{
    public partial class Update : Form
    {
        String myconnection = "SERVER=127.0.0.1;DATABASE=dotnet;UID=root;PASSWORD=aaditya";
        String name, phno, query;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            phno = "+91" + textBox1.Text;
            name = textBox2.Text;

            query = "UPDATE contacts SET name = '" + name + "' WHERE phno = '" + phno + "'";
            MySqlConnection connection = new MySqlConnection(myconnection);
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader myReader;
            connection.Open();
            myReader = command.ExecuteReader();
            MessageBox.Show("Data Updated Sucessfully");
            connection.Close();
        }

        public Update()
        {
            InitializeComponent();
        }

        private void Update_Load(object sender, EventArgs e)
        {
                        
        }
    }
}
