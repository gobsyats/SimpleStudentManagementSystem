using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using MySql.Data.MySqlClient;


namespace StudentProject
{
    public partial class StudentForm : Form
    {
        MySqlConnection conn = new MySqlConnection(
            "datasource=localhost;port=3306;username=root;password=Govind@123;database=projectDB");


        public StudentForm()
        {
            InitializeComponent();
        }

        private void sButtonReset_Click(object sender, EventArgs e)
        {
            stextBoxName.Text = "";
            stextBoxAddress.Text = "";
            stextBoxPhone.Text = "";
            stextBoxSem.Text = "";
            sTextBoxSearch.Text = "";
            sComboBoxBranch.SelectedIndex = 0;
        }

        //Insert Data
        private void sButtonAdd_Click(object sender, EventArgs e)
        {

            try
            {
                conn.Open();
                String name = stextBoxName.Text;
                String address = stextBoxAddress.Text;
                long phone = Int64.Parse(stextBoxPhone.Text);
                int sem = Int32.Parse(stextBoxSem.Text);
                String branch = sComboBoxBranch.SelectedItem.ToString();
                String qry = "insert into student values ('" + name + "','" + address + "','" + phone + "','" + sem + "','" + branch + "')";

                MySqlCommand command = new MySqlCommand(qry, conn);
                int noOfRecords = command.ExecuteNonQuery();

                if (noOfRecords >= 1)
                {
                   
                    MessageBox.Show("Student Record Inserted", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sButtonReset.PerformClick();
                    show();
                }
                else
                {
                    MessageBox.Show("Error - Student Data Not Inserted", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                conn.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error - " + exp.ToString(), "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void sButtonUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                conn.Open();
                String name = stextBoxName.Text;
                String address = stextBoxAddress.Text;
                long phone = Int64.Parse(stextBoxPhone.Text);
                int sem = Int32.Parse(stextBoxSem.Text);
                String branch = sComboBoxBranch.SelectedItem.ToString();
                String qry = "update student set address = '"+address + "', phone = '" + phone + "', sem = '" + sem + "', branch = '" + branch + "' where sName = '"+name+"'";

                MySqlCommand command = new MySqlCommand(qry, conn);
                int noOfRecords = command.ExecuteNonQuery();

                if (noOfRecords >= 1)
                {
                    MessageBox.Show("Student Updated Successfully", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sButtonReset.PerformClick();
                    show();
                }
                else
                {
                    MessageBox.Show("Error - Student Data Not Updated", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error - " + exp.ToString(), "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            show();
        }

        void show()
        {
            //when we just want to fetch data
            MySqlDataAdapter ad = new MySqlDataAdapter("select * from student", conn);
            DataTable db = new DataTable();
            ad.Fill(db);
            dataGridView2.Rows.Clear();
            foreach (DataRow dr in db.Rows)
            {
                int n = dataGridView2.Rows.Add();
                dataGridView2.Rows[n].Cells[0].Value = dr[0].ToString();
                dataGridView2.Rows[n].Cells[1].Value = dr[1].ToString();
                dataGridView2.Rows[n].Cells[2].Value = dr[2].ToString();
                dataGridView2.Rows[n].Cells[3].Value = dr[3].ToString();
                dataGridView2.Rows[n].Cells[4].Value = dr[4].ToString();
            }

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            stextBoxName.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            stextBoxAddress.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
            stextBoxPhone.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
            stextBoxSem.Text = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
            sComboBoxBranch.SelectedItem = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void sButtonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                String name = stextBoxName.Text.ToString();
                
                String qry = "delete from student where sName= '"+name+"'";

                MySqlCommand command = new MySqlCommand(qry, conn);
                int noOfRecords = command.ExecuteNonQuery();

                if (noOfRecords >= 1)
                {
                    MessageBox.Show("Student Deleted Successfully", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sButtonReset.PerformClick();
                    show();
                }
                else
                {
                    MessageBox.Show("Error - Student Data Not Deleted", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                conn.Close();
            }catch(Exception ex)
            {
                MessageBox.Show("Error - " + ex.ToString(), "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void sTextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
               
                conn.Open();
                String searchQ = sTextBoxSearch.Text.ToString();
                MySqlDataAdapter ad = new MySqlDataAdapter("select * from student where sName like '%" + searchQ + "%'", conn);
                DataTable db = new DataTable();
                ad.Fill(db);
                dataGridView2.Rows.Clear();
                foreach (DataRow dr in db.Rows)
                {
                    int n = dataGridView2.Rows.Add();
                    dataGridView2.Rows[n].Cells[0].Value = dr[0].ToString();
                    dataGridView2.Rows[n].Cells[1].Value = dr[1].ToString();
                    dataGridView2.Rows[n].Cells[2].Value = dr[2].ToString();
                    dataGridView2.Rows[n].Cells[3].Value = dr[3].ToString();
                    dataGridView2.Rows[n].Cells[4].Value = dr[4].ToString();
                }
                conn.Close();
            }catch(Exception ex)
            {
                MessageBox.Show("Error - " + ex.ToString(), "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
