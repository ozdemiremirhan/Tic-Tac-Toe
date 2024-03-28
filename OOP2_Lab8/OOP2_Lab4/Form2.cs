using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace OOP2_Lab4
{
    public partial class Form2 : Form
    {
        public string ID { get; set; }
        public string UserType { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string NameSurname { get; set; }
        public string Mail { get; set; }
        public bool toUpdate { get; set; }
        public string previousForm { get; set; }
        public SqlConnection SqlConnection { get; set; }
        public Form2()
        {
            InitializeComponent();
        }
        
        private void button_Back_Click(object sender, EventArgs e)
        {
            if (previousForm == "adminpanel")
            {
                Form_adminPanel adminPanel = new Form_adminPanel();
                this.Hide();
                adminPanel.ShowDialog();
                this.Close();
            }
            else if(previousForm == "loginscreen")
            {
                Form_loginScreen loginScreen = new Form_loginScreen();
                this.Hide();
                loginScreen.ShowDialog();
                this.Close();
            }
            else if (previousForm == "SQLpanel")
            {
                Form_SQL SQL = new Form_SQL();
                this.Hide();
                SQL.ShowDialog();
                this.Close();
            }
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            if (toUpdate == true)
            {
                textBox_ID.Enabled = false;
                SqlConnection.Open();
                SqlCommand command1 = new SqlCommand(" update users set UserType='" + textBox_UserType.Text + "',Username='" + textBox_Username.Text + "',Password='" + textBox_Password.Text + "',NameSurname='" + textBox_NameSurname.Text + "',mail='" + textBox_Mail.Text + "' where ID ='" + ID+"'", SqlConnection);
                command1.ExecuteNonQuery();
                SqlConnection.Close();
                label_FeedBack.ForeColor = Color.ForestGreen;
                label_FeedBack.Text = "Successfully Saved";
            }
            else
            {
                SqlConnection.Open();
                SqlCommand command = new SqlCommand("insert into users(ID, UserType, Username, Password, NameSurname, mail) values (@_ID,@_UserType,@_Username,@_Password,@_NameSurname,@_mail)", SqlConnection);
                command.Parameters.AddWithValue("@_ID", textBox_ID.Text);
                command.Parameters.AddWithValue("@_UserType", textBox_UserType.Text);
                command.Parameters.AddWithValue("@_Username", textBox_Username.Text);
                command.Parameters.AddWithValue("@_Password", textBox_Password.Text);
                command.Parameters.AddWithValue("@_NameSurname", textBox_NameSurname.Text);
                command.Parameters.AddWithValue("@_mail", textBox_Mail.Text);
                command.ExecuteNonQuery();
                SqlConnection.Close();







                string file = System.IO.Directory.GetCurrentDirectory() + @"\152120211074.xml";
                if (File.Exists(file))
                {
                    XDocument x = XDocument.Load(file);
                    x.Element("users").Add(
                        new XElement("user",
                        new XElement("ID", textBox_ID.Text),
                        new XElement("UserType", textBox_UserType.Text),
                        new XElement("Username", textBox_Username.Text),
                        new XElement("Password", textBox_Password.Text),
                        new XElement("NameSurname", textBox_NameSurname.Text),
                        new XElement("Mail", textBox_Mail.Text)
                        ));
                    x.Save(file);
                }
                else
                {
                    using (XmlWriter xmlWriter = XmlWriter.Create(file))
                    {

                        xmlWriter.WriteStartDocument();
                        xmlWriter.WriteStartElement("users");

                        xmlWriter.WriteStartElement("user");

                        xmlWriter.WriteStartElement("ID");
                        xmlWriter.WriteString(textBox_ID.Text);
                        xmlWriter.WriteEndElement();

                        xmlWriter.WriteStartElement("UserType");
                        xmlWriter.WriteString(textBox_UserType.Text);
                        xmlWriter.WriteEndElement();

                        xmlWriter.WriteStartElement("Username");
                        xmlWriter.WriteString(textBox_Username.Text);
                        xmlWriter.WriteEndElement();

                        xmlWriter.WriteStartElement("Password");
                        xmlWriter.WriteString(textBox_Password.Text);
                        xmlWriter.WriteEndElement();

                        xmlWriter.WriteStartElement("NameSurname");
                        xmlWriter.WriteString(textBox_NameSurname.Text);
                        xmlWriter.WriteEndElement();

                        xmlWriter.WriteStartElement("Mail");
                        xmlWriter.WriteString(textBox_Mail.Text);
                        xmlWriter.WriteEndElement();

                        xmlWriter.WriteEndElement();


                        xmlWriter.Flush();

                    }
                }

                textBox_ID.Clear();
                textBox_UserType.Clear();
                textBox_Username.Clear();
                textBox_Password.Clear();
                textBox_NameSurname.Clear();
                textBox_Mail.Clear();


                label_FeedBack.ForeColor = Color.ForestGreen;
                label_FeedBack.Text = "Successfully Saved";
            }
            

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (toUpdate == true)
            {
                textBox_ID.Text = ID;
                textBox_ID.Enabled = false;
                textBox_UserType.Text = UserType;
                textBox_Username.Text = Username;
                textBox_Password.Text = Password;
                textBox_NameSurname.Text = NameSurname;
                textBox_Mail.Text = Mail;

            }
        }
        
    }
}
