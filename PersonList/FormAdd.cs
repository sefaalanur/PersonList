using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace PersonList
{
    public partial class FormAdd : Form
    {
        public FormAdd()
        {
            InitializeComponent();
        }
        NpgsqlConnection conn = new NpgsqlConnection(@"Server=localhost;Port=5434;User Id=postgres;Password=sefa2024;Database=PhoneContact");
        private void btnSave_Click(object sender, EventArgs e)
        {
            var name = nameBox.Text;
            var surname = snmaeBox.Text;
            var phone = phoneBox2.Text;
            var email = mailBox6.Text;
            DateTime birthday = dateTimePicker1.Value;
            addperson(
            name: name, surname: surname, phone: phone, email: email, birthday: birthday);         
        }
        void addperson(string name, string surname, string phone, string email, DateTime birthday)
        {
            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                conn.Open();
                cmd.CommandText = $"INSERT INTO persons(name, surname, phone, email, birthday) VALUES('{name}', '{surname}', '{phone}', '{email}', '{birthday}')";

                int x = cmd.ExecuteNonQuery();
                MessageBox.Show("Added person:" + x);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
          finally
            {
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }    
        }
        
    }

    }
