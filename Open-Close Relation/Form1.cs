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

namespace Open_Close_Relation
{
    public partial class Form1 : Form
    {
        private SqlConnection conn = new SqlConnection("Server=DESKTOP-3LUSQFK\\SQLEXPRESS01; Database=Northwind; Integrated Security=true;");
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonaction_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                buttonaction.Text = "Disconnect";
                labelstate.Text = "Connection open";
                return;
            }
            conn.Close();
            buttonaction.Text = "Connect";
            labelstate.Text = "Connection closed";

        }
    }
}
