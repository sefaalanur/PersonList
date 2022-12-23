using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonList
{
    public partial class FormEdit : Form
    {
        NpgsqlConnection conn = new NpgsqlConnection(@"Server=localhost;Port=5434;User Id=postgres;Password=sefa2024;Database=PhoneContact");
        public FormEdit()
        {
            InitializeComponent();
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(IdBox1.Text);
            var name = NameBox2.Text;
            var surname = SnameBox3.Text;
            var phone = PhoneBox4.Text;
            var email = EmailBox5.Text;
            DateTime birthday = dateTimePicker2.Value;
            PersonEdit(
            id: id, name: name, surname: surname, phone: phone, email: email, birthday: birthday);
        }
        void PersonEdit(int id, string name, string surname, string phone, string email, DateTime birthday)
        {
            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                conn.Open();
                cmd.CommandText = "UPDATE persons SET name = :name, surname = :surname, phone = :phone, email = :email, birthday = :birthday WHERE id = :id";
                cmd.Parameters.AddWithValue(":name", name);
                cmd.Parameters.AddWithValue(":surname", surname);
                cmd.Parameters.AddWithValue(":phone", phone);
                cmd.Parameters.AddWithValue(":email", email);
                cmd.Parameters.AddWithValue(":birthday", birthday);
                cmd.Parameters.AddWithValue(":id", id);
                int x = cmd.ExecuteNonQuery();
                MessageBox.Show("Succesfully edited:" + x);

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
