using BusinessLogic.BLL;
using CourseWPF.Windows;
using DataAccess.Model;
using DataAccess.Repositories;
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
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace CourseWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            populateCourseListbox();
            populateStudentListbox();

        }


        //------------------- WINDOWS ----------------------------------------------
        private void CreateStudentsWindow_Click(object sender, RoutedEventArgs e)
        {
            Window createStudentWindow = new CreateStudentWindow();
            createStudentWindow.Show();

            createStudentWindow.Closed += CreateStudentsWindowClosed;
        }

        private void CreateCourseWindow_Click(object sender, RoutedEventArgs e)
        {
            Window createCourseWindow = new CreateCourseWindow();
            createCourseWindow.Show();

            createCourseWindow.Closed += CreateCourseWindowClosed;
            
        }

        private void StudentList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Student student = StudentList.SelectedItem as Student;
            Window showStudent = new StudentsCoursesAndDetail(student);

            showStudent.Closed += CreateStudentsWindowClosed;

            showStudent.Show();

            StudentsAttendingCourse.Items.Clear();



        }


        //--------------------------- END WINDOW -------------------------------------------------------------


        private void CreateStudentsWindowClosed(object sender, EventArgs e)
        {
            populateStudentListbox();
        }


        private void CreateCourseWindowClosed(object sender, EventArgs e)
        {
            populateCourseListbox();
        }


        //--------------------------- Initial data in textfields ---------------------------------------------
        private void populateStudentListbox()
              {
                  StudentList.Items.Clear();
                  foreach (Student student in StudentController.getStudents())
                  {
                      StudentList.Items.Add(student);
                  }
              }
        
              private void populateCourseListbox()
              {
                  CoursesList.Items.Clear();

                  foreach (Course course in CourseController.getCourses())
                  {
                      CoursesList.Items.Add(course);
                  }
              }

        private void CourseListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Course selectedCourse = CoursesList.SelectedItem as Course;

            if (selectedCourse != null)
            {
                
                StudentsAttendingCourse.Items.Clear();


                foreach (Student student in selectedCourse.Students)
                {
                    StudentsAttendingCourse.Items.Add(student);
                }

                
            }
        }

        private void CoursesList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            
                Course course = CoursesList.SelectedItem as Course;
                Window showCourseDetailsWindow = new CourseDetail(course);

                showCourseDetailsWindow.Closed += CreateCourseWindowClosed;

                showCourseDetailsWindow.Show();
        }
    } 
}
