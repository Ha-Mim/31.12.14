using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UseOfMultipleForm
{
    public partial class ViewItemUI : Form
    {
        private List<Student> _students;

        public ViewItemUI(List<Student> students )
        {
            _students = students;
            InitializeComponent();
        }

        private void ViewItemUI_Load(object sender, EventArgs e)
        {

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            foreach (Student student1 in _students)
            {
                ListViewItem myView = new ListViewItem(student1.Name);
                myView.SubItems.Add(student1.Email);
                showListView.Items.Add(myView);
            }
        }
    }
}
