namespace TaskMastrProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DatabaseHelper.InitializeDatabase(); // Ensure database is set up
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addTask at = new addTask();
            at.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            deleteTask dlt = new deleteTask();
            dlt.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            editTask dlt = new editTask();
            dlt.Show();
            this.Hide();
        }
    }
}
