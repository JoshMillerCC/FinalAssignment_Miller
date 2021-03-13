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

namespace FinalAssignment_Miller
{
    public partial class EditAddressForm : Form
    {
        public EditAddressForm()
        {
            InitializeComponent();
        }

        private void EditAddressForm_Shown(object sender, EventArgs e)
        {
            nameLabel.Text = ReadOnlyDataForm.currentFirstName + " " + ReadOnlyDataForm.currentLastName;
            textBox1.Text = ReadOnlyDataForm.currentStreet;
            textBox2.Text = ReadOnlyDataForm.currentCity;
            textBox3.Text = ReadOnlyDataForm.currentState;
            textBox4.Text = ReadOnlyDataForm.currentZip;
        }

        private void UpdateAddressButton_Click(object sender, EventArgs e)
        {
            CustomerDataContext cdc = new CustomerDataContext();
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("No fields may be empty!");
            }
            else
            {
                Address newAddy = cdc.Addresses.Single(upd => upd.CustomerId == ReadOnlyDataForm.currentID);
                newAddy.Street = textBox1.Text;
                newAddy.City = textBox2.Text;
                newAddy.State = textBox3.Text;
                newAddy.Zip = textBox4.Text;
                cdc.SaveChanges();
                this.Close();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
