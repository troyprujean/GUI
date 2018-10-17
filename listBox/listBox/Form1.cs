using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace listBox
{
    public partial class formMain : Form
    {
        List<Details> people = new List<Details>();
        public formMain()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Details newPerson = new Details();
            newPerson.FirstName = txtFirstName.Text;
            newPerson.LastName = txtLastName.Text;
            newPerson.Age = int.Parse(txtAge.Text);
            people.Add(newPerson);
            // Clear all text boxes
            txtFirstName.Text = null;
            txtLastName.Text = null;
            txtAge.Text = null;
            // User feedback
            lblOutput.Text = "Record Created!";
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            lblOutput.Text = null;
        }

        private void btnDisplayAllRecords_Click(object sender, EventArgs e)
        {
            // User feedback
            lblOutput.Text = "Displaying all records";
            // Loop to iterate through the list and populate the array
            foreach (var person in people)
            {
                lbxResults.Items.Add(person.DisplayName());
                lbxResults.Items.Add($"Age: {person.Age}");
                lbxResults.Items.Add("--------------------");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lbxResults.Items.Clear();
            txtFirstName.Text = null;
            txtLastName.Text = null;
            txtAge.Text = null;
            lblOutput.Text = null;
        }

        private void txtFirstName_Enter(object sender, EventArgs e)
        {
            lblOutput.Text = null;
        }

        private void txtLastName_Enter(object sender, EventArgs e)
        {
            lblOutput.Text = null;
        }

        private void txtAge_Enter(object sender, EventArgs e)
        {
            lblOutput.Text = null;
        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {
            int validateInt;
            if (int.TryParse(txtAge.Text, out validateInt))
            {
                lblOutput.Text = null;
                btnAdd.Enabled = true;
            }
            else
            {
                lblOutput.Text = "Please enter a valid age";
                btnAdd.Enabled = false;
            }
        }
    }
}
