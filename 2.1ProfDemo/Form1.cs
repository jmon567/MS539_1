namespace _2._1ProfDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            progressBar_StartStop.Style = ProgressBarStyle.Marquee;
            textBox_StartStop.Text = "Start";
            textBox_StartStop.BackColor = Color.Green;
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            progressBar_StartStop.Style = ProgressBarStyle.Blocks;
            textBox_StartStop.Text = "Stop";
            textBox_StartStop.BackColor = Color.Pink;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            button_start.Enabled = checkBox_enablePrompt.Checked;
            button_stop.Enabled = checkBox_enablePrompt.Checked;
        }

        private void button_newForm2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            //I love coding problems
        }
    }
}
