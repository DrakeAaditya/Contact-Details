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
    public partial class Retrive : Form
    {
        String myconnection = "SERVER=127.0.0.1;DATABASE=dotnet;UID=root;PASSWORD=aaditya";
        String phno, query;
        public Retrive()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            phno = "+91" + textBox1.Text;

            query = "SELECT name FROM contacts WHERE phno = '" + phno + "'";
            MySqlConnection connection = new MySqlConnection(myconnection);
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataAdapter myAdapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable("My Table");
            myAdapter.Fill(table);
            foreach (DataRow row in table.Rows)
            {
                textBox2.Text = row.ItemArray[0].ToString();
            }
        }
    }
}
