using FindingNemo;
using System.Windows;

namespace WPFUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnGenerateEmpId_Click(object sender, RoutedEventArgs e)
        {
            string employeeId = Employee.GenerateEmployeeID(txtfirstName.Text, txtlastName.Text);
            txtEmplyeeId.Text = employeeId;
        }
    }
}
