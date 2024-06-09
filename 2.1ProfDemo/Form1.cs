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
            try {
                if(!checkBox_enablePrompt.Checked)
            {
                    errorProvider1.SetError(checkBox_enablePrompt, "Use enable checkbox");
                }
            else
                {
                    errorProvider1.SetError(checkBox_enablePrompt, "");
                    progressBar_StartStop.Style = ProgressBarStyle.Marquee;
                    textBox_StartStop.Text = "Start";
                    textBox_StartStop.BackColor = Color.Green;
                }

            }catch 
            {
                this.Close();
            }
           

        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            if (!checkBox_enablePrompt.Checked)
            {
                errorProvider1.SetError(checkBox_enablePrompt, "Use enable checkbox");

            }
            else
            {
                errorProvider1.SetError(checkBox_enablePrompt, "");
                progressBar_StartStop.Style = ProgressBarStyle.Blocks;
                textBox_StartStop.Text = "Stop";
                textBox_StartStop.BackColor = Color.Pink;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // button_start.Enabled = checkBox_enablePrompt.Checked;
            //button_stop.Enabled = checkBox_enablePrompt.Checked;
        }

        private void button_newForm2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();

        }

        private void numericUpDown_max20_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            int output = (int) numericUpDown_max20.Value;
            if (numericUpDown_max20.Value >20) 
            {
                errorProvider1.SetError(numericUpDown_max20, "Max input of 20 allowed");
                e.Cancel = true;
            
            }else
            {
                errorProvider1.SetError(numericUpDown_max20, "");
                int outputValidated = (int) numericUpDown_max20.Value;
            }
        }
    }
}
