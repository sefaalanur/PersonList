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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            displayPerson();
        }
        NpgsqlConnection conn = new NpgsqlConnection(@"Server=localhost;Port=5434;User Id=postgres;Password=sefa2024;Database=PhoneContact");
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAdd formAdd = new FormAdd();
            formAdd.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FormEdit formedit = new FormEdit();
            formedit.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            FormDelete formDelete = new FormDelete();
            formDelete.Show();
        }

        private void dgView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void displayPerson()
        {
            try
            {

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                conn.Open();
                cmd.CommandText = "SELECT * FROM persons";
                NpgsqlDataReader dr = cmd.ExecuteReader();

                List<person> persons = new List<person>();
                while (dr.Read())
                {
                    var book = new person(
                        id: dr.GetInt32(0),
                        name: dr.GetString(1),
                        surname: dr.GetString(2),
                        phone: dr.GetString(3),
                        email: dr.GetString(4),
                        birthday: dr.GetDateTime(5)
                        );
                    persons.Add(book);
                }
                dgView1.DataSource = persons;
            }
            catch (NpgsqlException ex)
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
