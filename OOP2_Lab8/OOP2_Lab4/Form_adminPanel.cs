using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace OOP2_Lab4
{
    public partial class Form_adminPanel : Form
    {
        public Form_adminPanel()
        {
            InitializeComponent();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.ShowDialog();
            this.Close();
            form2.previousForm = "adminpanel";
        }

        private void button_List_Click(object sender, EventArgs e)
        {
            Load();
        }
        private void Load()
        {
            String file = System.IO.Directory.GetCurrentDirectory() + @"\152120211074.xml";
            XmlDocument x = new XmlDocument();
            DataSet ds = new DataSet();
            XmlReader xmlFile;
            xmlFile = XmlReader.Create(file, new XmlReaderSettings());
            ds.ReadXml(xmlFile);
            dataGridView1.DataSource = ds.Tables[0];
            xmlFile.Close();


        }
        Form2 form2 = new Form2();
        private void button_Update_Click(object sender, EventArgs e)
        {
            if (form2.ID == null)
            {
                MessageBox.Show("List users and make a selection!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                form2.toUpdate = true;
                this.Hide();
                Delete1(form2.ID);
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
        private void Delete1(String ID)
        {
            String file = System.IO.Directory.GetCurrentDirectory() + @"\152120211074.xml";
            XDocument doc = XDocument.Load(file);

            // Use LINQ to find the user that you want to delete
            var userToDelete = doc.Descendants("user").FirstOrDefault(user => user.Element("ID").Value == ID);


            // If the user is found, remove the user element from the XML tree
            userToDelete.Remove();

            // Save the modified XML back to the file
            doc.Save(file);
        }
        private void Delete2(String ID)
        {
            String file = System.IO.Directory.GetCurrentDirectory() + @"\152120211074.xml";
            XDocument doc = XDocument.Load(file);

            // Use LINQ to find the user that you want to delete
            var userToDelete = doc.Descendants("user").FirstOrDefault(user => user.Element("ID").Value == ID);


            // If the user is found, remove the user element from the XML tree
            if (userToDelete != null)
            {
                userToDelete.Remove();
                MessageBox.Show("Successfully deleted!","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("User not found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Save the modified XML back to the file
            doc.Save(file);
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (textBox_delete.Text == "")
            {
                label_warning.ForeColor = Color.Firebrick;
                label_warning.Text = "Please enter a user ID for delete operation";
            }
            else
            {
                label_warning.Text = "";
                Delete2(textBox_delete.Text);
                Load();
                textBox_delete.Clear();
            }
            
        }
    }
}
