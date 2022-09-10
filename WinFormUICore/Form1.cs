using FindingNemo;

namespace WinFormUICore
{
    public partial class formDashboard : Form
    {
        public formDashboard()
        {
            InitializeComponent();
        }

        private void btnGenerateEmpID_Click(object sender, EventArgs e)
        {
            string employeeId = Employee.GenerateEmployeeID(txtFirstName.Text, txtLastName.Text);
            txtEmployeeId.Text = employeeId;
        }
    }
}