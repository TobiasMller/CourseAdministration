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
    /// Interaction logic for CreateCourseWindow.xaml
    /// </summary>
    public partial class CreateCourseWindow : Window
    {
        List<Student> newList = new List<Student>();
        public CreateCourseWindow()
        {
            InitializeComponent();
            getStudentsToListBox();


        }

        private void CreateCourse_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(CourseName.Text.ToString()))
            {

            }
            else 
            { 
                //CourseController.CreateCourse(CourseName.Text.ToString(), RoomName.Text.ToString());
                CourseController.addStudentToCourse(newList, new Course(CourseName.Text.ToString(), RoomName.Text.ToString()));
                this.Close();
            }
        }

        private void getStudentsToListBox()
        {
            {
                foreach (var student in StudentController.getStudents())
                {
                    ChooseStudentList.Items.Add(student);
                }
            }
        }

        private void ChooseStudentList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            
            Student student = ChooseStudentList.SelectedItem as Student;
            ChooseStudentList.Items.Remove(student);
            newList.Add(student);
            ChosenStudentsList.Items.Add(student);

        }
    }
}
