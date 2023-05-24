using BusinessLogic.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CourseWPF.Windows
{
    /// <summary>
    /// Interaction logic for CreateStudentWindow.xaml
    /// </summary>
    public partial class CreateStudentWindow : Window
    {
        public CreateStudentWindow()
        {
            InitializeComponent();
        }

        private void CreateStudent_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(StudentName.Text.ToString()))
            {

            }
            else
            {
                StudentController.createStudent(StudentName.Text.ToString(), Int32.Parse(StudentAge.Text.ToString()));
                this.Close();
            }
        }


    }
}
