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
using Microsoft.Data.SqlClient;

namespace FinalAssignment_Miller
{
    public partial class EditNameForm : Form
    {
        public EditNameForm()
        {
            InitializeComponent();
        }

        private void EditNameForm_Shown(object sender, EventArgs e)
        {
            textBox1.Text = ReadOnlyDataForm.currentFirstName;
            textBox2.Text = ReadOnlyDataForm.currentLastName;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            CustomerDataContext cdc = new CustomerDataContext();
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("First Name cannot be empty");
            }
            else
            {
                var customerID = new SqlParameter("@id", ReadOnlyDataForm.currentID);
                var customerFirstName = new SqlParameter("@firstName", textBox1.Text);
                cdc.Database.ExecuteSqlRaw("EXECUTE updateCustomer @firstName, @id", customerFirstName, customerID);
                this.Close();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
