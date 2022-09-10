using System;
using System.Windows.Forms;

namespace WinFormUI
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void generateEmployeeIdButton_Click(object sender, EventArgs e)
        {
            string employeeId =  GenerateEmployeeID(firstNameText.Text, lastNameText.Text);
            employeeIdText.Text = employeeId;
        }

        private string GenerateEmployeeID(string firstName, string lastName)
        {
            return $@"{firstName.Substring(0, 4)}{firstName.Substring(0, 4)}{DateTime.Now.Millisecond}";
        }
    }
}
