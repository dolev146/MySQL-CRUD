using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySQL_CRUD
{
    public partial class FormStudent : Form
    {
        private readonly FormStudentInfo _parent;

        public void Clear()
        {
            txtName.Text = "";
            txtReg.Text = "";
            txtClass.Text = "";
            txtSection.Text = "";
        }


        public FormStudent(FormStudentInfo parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim().Length < 3)
            {
                MessageBox.Show("Student name is empty ( < 3 ).");
            }

            if (txtReg.Text.Trim().Length < 1)
            {
                MessageBox.Show("Student Reg is empty ( > 1 ).");
            }

            if (txtClass.Text.Trim().Length == 0)
            {
                MessageBox.Show("Student Class is empty ( > 1 ).");
            }

            if (txtSection.Text.Trim().Length == 0)
            {
                MessageBox.Show("Student Section is empty ( > 1 ).");
            }

            if (btnSave.Text == "Save")
            {
                Student std = new Student(txtName.Text.Trim(), txtReg.Text.Trim(), txtClass.Text.Trim(), txtSection.Text.Trim());
                DbStudent.AddStudent(std);
                Clear();
            }
            _parent.Display();
        }
    }
}
