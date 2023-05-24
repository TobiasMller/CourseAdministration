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
    /// Interaction logic for CourseDetail.xaml
    /// </summary>
    public partial class CourseDetail : Window
    {

        private Course TheCourse;
        public CourseDetail(Course course)
        {
            this.TheCourse = course;
            InitializeComponent();
            StudentsInTheCourse();
            CourseDetails.DataContext = this.TheCourse;
        }

        public void StudentsInTheCourse()
        {
            Course selectedCourse = TheCourse;

            foreach (var course in selectedCourse.Students)
            {
                StudentsAttendingTheCourse.Items.Add(course);
            }
        }

        private void DeleteCourseButton_Click(object sender, RoutedEventArgs e)
        {
            var selectedCourse = TheCourse.Id;
            CourseController.deleteCourse(selectedCourse);
            this.Close();
        }
        private void EditCourseButton_Click(object sender, EventArgs e)
        {
            {
                CourseController.editCourse(TheCourse);
                this.Close();
            }
        }
    }
}