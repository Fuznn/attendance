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
            try
            {
                // This will Select INI file 
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "INI files (*.ini)|*.ini|All files (*.*)|*.*";
                ofd.Title = "Select Attendance INI File";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = ofd.FileName; // This will show the path of the selected file in the textbox

                    // This will clear the contents of the DataGridView before adding new data
                    dataGridView1.Columns.Clear();
                    dataGridView1.Rows.Clear();
                    dataGridView1.Columns.Add("Name", "Name");
                    dataGridView1.Columns.Add("Tardiness", "Tardiness");
                    dataGridView1.Columns.Add("Status", "Status");

                    string[] lines = File.ReadAllLines(ofd.FileName);

                    string name = "";
                    string tardiness = "";
                    string status = "";

                    foreach (var line in lines)
                    {
                        if (string.IsNullOrWhiteSpace(line) || !line.Contains("="))
                            continue;

                        var parts = line.Split(new char[] { '=' }, 2);
                        string key = parts[0].Trim();
                        string value = parts.Length > 1 ? parts[1].Trim() : "";

                        if (key.Equals("Name", StringComparison.OrdinalIgnoreCase))
                            name = value;
                        else if (key.Equals("Tardiness", StringComparison.OrdinalIgnoreCase))
                            tardiness = value;
                        else if (key.Equals("Status", StringComparison.OrdinalIgnoreCase))
                            status = value;
                    }
                    dataGridView1.Rows.Add(name, tardiness, status);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateFile.createFile(textBox1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string content = LoadFile.loadFile(textBox1.Text);
            string filePath = textBox1.Text;
            string fileContent = LoadFile.loadFile(filePath);
            MessageBox.Show(fileContent);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
