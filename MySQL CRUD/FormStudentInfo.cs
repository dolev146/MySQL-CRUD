namespace MySQL_CRUD
{
    public partial class FormStudentInfo : Form
    {
        public FormStudentInfo()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void Display()
        {
            DbStudent.DisplayAndSearch("SELECT ID, NAME, Class, Section FROM student_table", dataGridView1);  
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FormStudent form = new FormStudent(this);
            form.ShowDialog();
            
        }

        private void FormStudentInfo_Shown(object sender, EventArgs e)
        {
            Display();
        }
    }
}