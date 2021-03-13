using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;
using Microsoft.EntityFrameworkCore;

namespace FinalAssignment_Miller
{
    public partial class ReadOnlyDataForm : Form
    {
        EditNameForm enForm = new EditNameForm();
        EditAddressForm eaForm = new EditAddressForm();
        public static string currentFirstName;
        public static string currentLastName;
        public static int currentID;
        public static string currentStreet;
        public static string currentCity;
        public static string currentState;
        public static string currentZip;
        public ReadOnlyDataForm()
        {
            InitializeComponent();
            createDataContext();
        }
        private void createDataContext()
        {
            CustomerDataContext cdc = new CustomerDataContext();
            dataGridView1.DataSource = cdc.Customers.Join(cdc.Addresses, z => z.CustomerId, y => y.Customer.CustomerId,
                (y, z) => new { y.CustomerId, y.Firstname, y.Lastname, z.Street, z.City, z.State, z.Zip }).ToList().AsReadOnly();
            dataGridView1.Columns[0].Visible = false;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            EditNameButton.Enabled = true;
            EditAddressButton.Enabled = true;
        }

        private void EditNameButton_Click(object sender, EventArgs e)
        {
            int currentRow = dataGridView1.CurrentRow.Index;

            currentID = Convert.ToInt32(dataGridView1.Rows[currentRow].Cells[0].Value);
            currentFirstName = dataGridView1.Rows[currentRow].Cells[1].Value.ToString();
            currentLastName = dataGridView1.Rows[currentRow].Cells[2].Value.ToString();

            enForm.ShowDialog();

            createDataContext();
        }

        private void EditAddressButton_Click(object sender, EventArgs e)
        {
            int currentRow = dataGridView1.CurrentRow.Index;

            currentID = Convert.ToInt32(dataGridView1.Rows[currentRow].Cells[0].Value);
            currentFirstName = dataGridView1.Rows[currentRow].Cells[1].Value.ToString();
            currentLastName = dataGridView1.Rows[currentRow].Cells[2].Value.ToString();
            currentStreet = dataGridView1.Rows[currentRow].Cells[3].Value.ToString();
            currentCity = dataGridView1.Rows[currentRow].Cells[4].Value.ToString();
            currentState = dataGridView1.Rows[currentRow].Cells[5].Value.ToString();
            currentZip = dataGridView1.Rows[currentRow].Cells[6].Value.ToString();

            eaForm.ShowDialog();

            createDataContext();
        }
    }
}
