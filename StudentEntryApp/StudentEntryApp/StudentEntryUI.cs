using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentEntryApp
{
    public partial class StudentEntryUI : Form
    {
        public Department aDepartment;
        public StudentEntryUI()
        {
            InitializeComponent();
        }

        private void deptSaveButton_Click(object sender, EventArgs e)
        {
            aDepartment = new Department(deptCodeTextBox.Text,deptNmaeTextBox.Text);
            MessageBox.Show("Department Created");
        }

        private void studentSaveButton_Click(object sender, EventArgs e)
        {
            Student aStudent = new Student(studentNameTextBox.Text,studentEmailextBox.Text,studentRegNoTextBox.Text);
            string messg = aDepartment.AddStudent(aStudent);
            MessageBox.Show(messg);
        }

        private void showDetailsButton_Click(object sender, EventArgs e)
        {
            string info = "Code: " + aDepartment.Code + "Name: " + aDepartment.Name + "\n";
            info += "Student Reg No: \tName \tEmail\n";
            foreach (Student aStudent in aDepartment.GetStudents())
            {
                string aRow = aStudent.RegNo + "\t" + aStudent.Name + "\t" + aStudent.Email + "\n";
                info += aRow;
            }
            MessageBox.Show(info);
        }
    }
}
