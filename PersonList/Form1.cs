using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
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
        public void updateList()
        {
            displayPerson();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAdd formAdd = new FormAdd(this);
            formAdd.Show();

            updateList();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FormEdit formedit = new FormEdit(this);
            formedit.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int rowindex = dgView1.CurrentCell.RowIndex;

            var id = dgView1.Rows[rowindex].Cells[0].Value.ToString();

            int uid = Convert.ToInt32(id);
            deletePerson(uid);

            updateList();
            //FormDelete formDelete = new FormDelete();
            //formDelete.Show();
        }

        void displayPerson()
        {
            try
            {

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                conn.Open();
                cmd.CommandText = "SELECT * FROM persons ORDER BY id ASC ";
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
        void birthdaycurrentweek()
        {
            try
            {

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                conn.Open();
                cmd.CommandText = "SELECT name, birthday FROM persons";
                NpgsqlDataReader reader = cmd.ExecuteReader();

                bool found = false;
                while (reader.Read())
                {
                    DateTime currentDate = DateTime.Today;
                    int thisdate = currentDate.Day;
                    int thismonth = currentDate.Month;
                    DateTime birthday = (DateTime)reader["birthday"];
                    int day = birthday.Day;
                    int month = birthday.Month;

                    if (thisdate+7 >=  day && thismonth==month)
                    {
                    
                        MessageBox.Show(string.Format("{0} has a birthday on {1:dd/MM/yyyy}", reader["name"], birthday));
                    found = true;
                    }
                }

               
                if (!found)
                {
                    MessageBox.Show("No birthdays found in this week");
                }
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

        private void currentweek_Click(object sender, EventArgs e)
        {
            birthdaycurrentweek();
        }


    }
        
    }

