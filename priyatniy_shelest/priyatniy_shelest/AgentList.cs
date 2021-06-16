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
    public partial class AgentList : Form
    {
        public static string str = @"Data Source=DESKTOP-9EF573H\SQLEXPRESS;Initial Catalog=dem;Integrated Security=True;";
        SqlConnection connection = new SqlConnection(str);
        public AgentList()
        {
            InitializeComponent();
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT id_prod,Title, Weigth, OptCost FROM products ", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet data = new DataSet();
            adapter.Fill(data);
            outputData.DataSource = data.Tables[0];
            outputData.Columns[0].HeaderText = "Идентификатор";
            outputData.Columns[1].HeaderText = "Продукт";
            outputData.Columns[2].HeaderText = "Вес";
            outputData.Columns[3].HeaderText = "Оптовая цена";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void deleteBotton_Click(object sender, EventArgs e)
        {
            if (deleteBotton.Text == "")
            {
                MessageBox.Show("Заолните поле");
            }
            else
            {
                SqlCommand command = new SqlCommand("DELETE FROM products WHERE id_prod=" + deleteTextBox.Text, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Удалено");
                AgentList agentList = new AgentList();
                agentList.Show();
                this.Close();

            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Close();
        }

        private void searchTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void kd_searchTB(object sender, KeyEventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT id_prod,Title, Weigth, OptCost FROM products WHERE Title='"+searchTextbox.Text+"'", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet data = new DataSet();
            adapter.Fill(data);
            outputData.DataSource = data.Tables[0];
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            searchTextbox.Text = "";
            SqlCommand command = new SqlCommand("SELECT id_prod,Title, Weigth, OptCost FROM products ", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet data = new DataSet();
            adapter.Fill(data);
            outputData.DataSource = data.Tables[0];
        }
    }
}
