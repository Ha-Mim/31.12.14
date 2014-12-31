using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UseOfMultipleForm
{
    public partial class AddItemUI : Form
    {
        private List<Student> _students;

        public AddItemUI(List<Student> students  )
        {
            _students = students;
            InitializeComponent();
        }

        private void AddItemUI_Load(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Student aStudent = new Student();
            aStudent.Name = nameTextBox.Text;
            aStudent.Email = emailTextBox.Text;
            _students.Add(aStudent);
            MessageBox.Show("Student Information has been Added");

        }
    }
}
