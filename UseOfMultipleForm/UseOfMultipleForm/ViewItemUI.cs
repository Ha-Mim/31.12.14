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
        public ViewItemUI(List<Student> students )
        {
            InitializeComponent();
        }

        private void ViewItemUI_Load(object sender, EventArgs e)
        {

        }
    }
}
