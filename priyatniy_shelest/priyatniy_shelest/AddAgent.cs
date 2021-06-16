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

namespace priyatniy_shelest
{
    public partial class AddAgent : Form
    {
        public static string str = @"Data Source=DESKTOP-9EF573H\SQLEXPRESS;Initial Catalog=dem;Integrated Security=True;";
        SqlConnection connection = new SqlConnection(str);
        public AddAgent()
        {
            InitializeComponent();
            connection.Open();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (titleTextBox.Text == "" || costTextBox.Text == ""|| weigthTextBox.Text==""|| placeTextBox.Text == "")
            {
                MessageBox.Show("Не все обязательные поля заполнены");
            }
            else { 
                string nam = titleTextBox.Text;
                int cost= Convert.ToInt32(costTextBox.Text);
                int ves=Convert.ToInt32(weigthTextBox.Text);
                int sclad= Convert.ToInt32(placeTextBox.Text);
                string adres=AddressTextBox.Text;
                int opt=Convert.ToInt32(optcostTextBox.Text);
                SqlCommand command = new SqlCommand("INSERT INTO products (Title,Cost,Weigth,Place,Address_s,OptCost) VALUES ('"+nam+"',"+cost+","+ves+","+sclad+",'"+adres+"',"+opt+")",connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Добавлено");
                Main main = new Main();
                main.Show();
                this.Close();
            }
        }
    }
}
