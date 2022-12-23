using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace PersonList
{
    public partial class FormDelete : Form
    {
        public FormDelete()
        {
            InitializeComponent();
            
        }
        NpgsqlConnection conn = new NpgsqlConnection(@"Server=localhost;Port=5434;User Id=postgres;Password=sefa2024;Database=PhoneContact");

        void deletePerson(int id)
        {
            if (id > 0)
            {
                try
                {

                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = conn;
                    conn.Open();
                    cmd.CommandText = "DELETE FROM persons WHERE id = @id";
                    NpgsqlParameter param = new NpgsqlParameter();
                    param.ParameterName = "id";
                    param.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Integer;
                    param.Value = id;
                    cmd.Parameters.Add(param);
                    
                    int i = cmd.ExecuteNonQuery();
                    MessageBox.Show(i + "person deleted from the contact book");

                }
                catch (NpgsqlException ex)
                {
                    MessageBox.Show(ex.Message);
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
            else
            {
                MessageBox.Show("Please enter a valid value!");
            }
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
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            displayPerson();
        }

        private void btnDel_Click_1(object sender, EventArgs e)
        {
            int uid = Convert.ToInt32(IdelBox.Text);
            deletePerson(uid);
        }
    }
}
