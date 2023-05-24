using BusinessLogic.BLL;
using DataAccess.Model;
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
    /// Interaction logic for StudentsCoursesAndDetail.xaml
    /// </summary>
    public partial class StudentsCoursesAndDetail : Window
    {

        private Student Thestudent;
        public StudentsCoursesAndDetail(Student student)
        {
            this.Thestudent = student;
            InitializeComponent();
            coursesOnStudent();
            StudentDetail.DataContext = this.Thestudent;
        }

        public void coursesOnStudent()
        {
            Student selectedStudent = Thestudent;
            
            foreach (var course in selectedStudent.courses)
            {
                coursesWhichTheStudentIsAttending.Items.Add(course);
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            var selectedStudent = Thestudent.Id;
            StudentController.deleteStudent(selectedStudent);
            this.Close();

        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            {
                StudentController.editStudent(Thestudent);
                this.Close();
            }
        }
    }
}
