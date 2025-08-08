namespace attendance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            /*var lookOrCreateButton = lookOrCreateFile.CreateButton();
            this.Controls.Add(lookOrCreateButton);*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LookForFile.lookForFile(textBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateFile.createFile(textBox1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string content = LoadFile.loadFile(textBox1.Text);
        }
    }
}
