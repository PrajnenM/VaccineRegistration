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

namespace VaccineRegistration
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
                /////Hello
            {
                String str = "Data Source=.;Initial Catalog=CTU_8025;Integrated Security=True";

            String queryTwo = "insert into RegisteredUsers(Id, Surname, Firstname, Gender, Province)" +
                "Values('" + textID.Text + "','" + textSurname.Text + "','" + textFirstName.Text + "','" + GendersCB.Text + "','" + ProvinceCB.Text + "')";

            String query = "select * from data";

            SqlConnection con = new SqlConnection(str);

            SqlCommand cmd = new SqlCommand(queryTwo, con);

            con.Open();
            cmd.ExecuteNonQuery();



            MessageBox.Show("Thank you for registering to get the COVID-19 Vaccine");

            con.Close();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }
    }
}
