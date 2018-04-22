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
    public partial class Delete : Form
    {
        String myconnection = "SERVER=127.0.0.1;DATABASE=dotnet;UID=root;PASSWORD=aaditya";
        String phno, query;

        public Delete()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            phno = "+91" + textBox1.Text;
            
            query = "DELETE FROM contacts WHERE phno = '" + phno + "'";
            MySqlConnection connection = new MySqlConnection(myconnection);
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader myReader;
            connection.Open();
            myReader = command.ExecuteReader();
            MessageBox.Show("Data Deleted Sucessfully");
            connection.Close();
        }
    }
}
