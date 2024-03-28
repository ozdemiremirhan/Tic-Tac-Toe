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

namespace OOP2_Lab4
{
    public partial class Form_SQL : Form
    {
        public Form_SQL()
        {
            InitializeComponent();
        }
        SqlConnection connection;
        string connectionText;
        public void ShowData(string data)
        {
            SqlDataAdapter da = new SqlDataAdapter(data, connectionText);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void button_Connect_Click(object sender, EventArgs e)
        {
            
            
            connectionText = textBox_Connect.Text;
            connection = new SqlConnection(connectionText);
            connection.Open();
            if (connection.State == ConnectionState.Open)
            {
                MessageBox.Show("Connected!","Connection",MessageBoxButtons.OK,MessageBoxIcon.Information);
                button_AddSQL.Visible = true;
                button_UpdateSQL.Visible = true;
                button_DeleteSQL.Visible = true;
                textBox_Delete.Visible = true;
                textBox_Delete.ForeColor = Color.Firebrick;
                textBox_Delete.Text = "Write ID of user to delete!";
                textBox_Search.ForeColor = Color.ForestGreen;
                textBox_Search.Text = "Write the Username to search!";
                button_Search.Visible = true;
                textBox_Search.Visible = true;
                ShowData("Select * from users");
                
            }
            else
                MessageBox.Show("Connection Error!");

            connection.Close();
        }
        
        private void button_AddSQL_Click(object sender, EventArgs e)
        {
            this.Hide();
            form2 = new Form2();
            form2.previousForm = "SQLpanel";
            form2.SqlConnection = connection;
            form2.ShowDialog();
            this.Close();
        }

        private void button_DeleteSQL_Click(object sender, EventArgs e)
        {
            connection.Open();
            
            SqlCommand command = new SqlCommand("delete from users where ID=@_ID",connection);
            command.Parameters.AddWithValue("@_ID", textBox_Delete.Text);
            command.ExecuteNonQuery();
            ShowData("Select * from users");
            connection.Close();
        }

        private void textBox_Delete_Enter(object sender, EventArgs e)
        {
            textBox_Delete.Clear();
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Select * from users where Username like '%" + textBox_Search.Text + "%'", connection);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            connection.Close();
        }
        Form2 form2=new Form2();
        private void button_UpdateSQL_Click(object sender, EventArgs e)
        {
            form2.SqlConnection = connection;
            form2.previousForm = "SQLpanel";
            if (form2.ID == null)
            {
                MessageBox.Show("Make a selection from table!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                form2.toUpdate = true;
                this.Hide();
                
                form2.ShowDialog();

                this.Close();
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                form2.ID = dataGridView1.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString();
                form2.UserType = dataGridView1.Rows[e.RowIndex].Cells["UserType"].FormattedValue.ToString();
                form2.Username = dataGridView1.Rows[e.RowIndex].Cells["Username"].FormattedValue.ToString();
                form2.Password = dataGridView1.Rows[e.RowIndex].Cells["Password"].FormattedValue.ToString();
                form2.NameSurname = dataGridView1.Rows[e.RowIndex].Cells["NameSurname"].FormattedValue.ToString();
                form2.Mail = dataGridView1.Rows[e.RowIndex].Cells["Mail"].FormattedValue.ToString();

            }

        }

        private void textBox_Search_Enter(object sender, EventArgs e)
        {
            textBox_Search.Clear();
        }

        private void button_BackLogin_Click(object sender, EventArgs e)
        {
            Form_loginScreen loginScreen = new Form_loginScreen();
            this.Hide();
            loginScreen.ShowDialog();
            this.Close();
        }
    }
}
