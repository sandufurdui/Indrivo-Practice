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

namespace Library_GUI
{
    public partial class AuthorsForm : Form
    {
        SqlConnection Sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sandu\OneDrive\Desktop\Indrivo_Practice\Library_GUI\Library_GUI_DB.mdf;Integrated Security=True;Connect Timeout=30");
        int Author_Id = 0;
        /*form initialization*/
        public AuthorsForm()
        {
            InitializeComponent();
        }

        /*Links other forms*/
        private void txtBorrows_Click(object sender, EventArgs e)
        {
            new BorrowsForm().Show();
            this.Hide();
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            new StudentsForm().Show();
            this.Hide();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            new BooksForm().Show();
            this.Hide();
        }



        /*displayed data function*/
        void FillDataGridView()
        {
            if (Sqlcon.State == ConnectionState.Closed) Sqlcon.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("AuthorsViewandSearch", Sqlcon);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa.SelectCommand.Parameters.AddWithValue("@Author_Name", search_input.Text.Trim());
            DataTable data = new DataTable();
            sqlDa.Fill(data);
            dataGridView_Authors.DataSource = data;
            Sqlcon.Close();
        }
        /*insert button*/
        private void txtInsert_Click(object sender, EventArgs e)
        {
            try
            {

                if (Sqlcon.State == ConnectionState.Closed) Sqlcon.Open();
                SqlCommand sqlcmd = new SqlCommand("AuthorsInsert", Sqlcon);
                if (txtInsert.Text == "Insert")
                {
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcmd.Parameters.AddWithValue("@mode", "Add");
                    sqlcmd.Parameters.AddWithValue("@Id", 0);
                    sqlcmd.Parameters.AddWithValue("@First_Name", txtFirstName.Text);
                    sqlcmd.Parameters.AddWithValue("@Last_Name", txtSecondName.Text);
                    sqlcmd.Parameters.AddWithValue("@Birth_Date", txtBirthDate.Text);
                    sqlcmd.ExecuteNonQuery();
                    MessageBox.Show("Succesfully Added");
                } }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
            finally
            {
                Sqlcon.Close();
            }

        }
        /*search button*/
        private void search_button_Click_1(object sender, EventArgs e)
        {
            try
            {
                FillDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }
        /*edit button*/
        private void txtEdit_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (Sqlcon.State == ConnectionState.Closed) Sqlcon.Open();
                SqlCommand sqlcmd = new SqlCommand("AuthorsInsert", Sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.AddWithValue("@mode", "Edit");
                sqlcmd.Parameters.AddWithValue("@Id", Author_Id);
                sqlcmd.Parameters.AddWithValue("@First_Name", txtFirstName.Text);
                sqlcmd.Parameters.AddWithValue("@Last_Name", txtSecondName.Text);
                sqlcmd.Parameters.AddWithValue("@Birth_Date", txtBirthDate.Text);
                sqlcmd.ExecuteNonQuery();
                MessageBox.Show("Succesfully Edited");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
            finally
            {
                Sqlcon.Close();
            }
        }
        /*reset button*/
        private void txtReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
        /*reset function*/
        void Reset()
        {
            txtFirstName.Text = txtBirthDate.Text = txtSecondName.Text = "";
            txtEdit.Text = "Save";
            Author_Id = 0;
            txtDelete.Enabled = true;
        }
        /*delete button*/
        private void txtDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (Sqlcon.State == ConnectionState.Closed) Sqlcon.Open();
                SqlCommand sqlcmd = new SqlCommand("AuthorsDelete", Sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.AddWithValue("@Id", Author_Id);
                sqlcmd.ExecuteNonQuery();
                MessageBox.Show("Succesfully Deleted");
                Reset();
                FillDataGridView();
            }
            catch (Exception ex)
            {

            }
        }
        /*grid view*/
        private void dataGridView_Authors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_Authors.CurrentRow.Index != -1)
            {
                Author_Id = Convert.ToInt32(dataGridView_Authors.CurrentRow.Cells[0].Value.ToString());
                txtFirstName.Text = dataGridView_Authors.CurrentRow.Cells[1].Value.ToString();
                txtSecondName.Text = dataGridView_Authors.CurrentRow.Cells[2].Value.ToString();
                txtBirthDate.Text = dataGridView_Authors.CurrentRow.Cells[3].Value.ToString();
                txtDelete.Enabled = true;

            }
        }
        /*updated grid view*/
        private void dataGridView_Authors_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView_Authors.CurrentRow.Index != -1)
            {
                Author_Id = Convert.ToInt32(dataGridView_Authors.CurrentRow.Cells[0].Value.ToString());
                txtFirstName.Text = dataGridView_Authors.CurrentRow.Cells[1].Value.ToString();
                txtSecondName.Text = dataGridView_Authors.CurrentRow.Cells[2].Value.ToString();
                txtBirthDate.Text = dataGridView_Authors.CurrentRow.Cells[3].Value.ToString();
                txtDelete.Enabled = true;
            }
        }
    }
}
