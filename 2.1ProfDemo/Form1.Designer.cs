namespace _2._1ProfDemo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            button_start = new Button();
            button_stop = new Button();
            progressBar_StartStop = new ProgressBar();
            textBox_StartStop = new TextBox();
            checkBox_enablePrompt = new CheckBox();
            panel1 = new Panel();
            button_newForm2 = new Button();
            errorProvider1 = new ErrorProvider(components);
            numericUpDown_max20 = new NumericUpDown();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_max20).BeginInit();
            SuspendLayout();
            // 
            // button_start
            // 
            button_start.BackColor = Color.Lime;
            button_start.Font = new Font("Segoe Print", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_start.Location = new Point(13, 48);
            button_start.Name = "button_start";
            button_start.Size = new Size(186, 96);
            button_start.TabIndex = 0;
            button_start.Text = "Start";
            button_start.UseVisualStyleBackColor = false;
            button_start.Click += button_start_Click;
            // 
            // button_stop
            // 
            button_stop.BackColor = Color.FromArgb(255, 128, 128);
            button_stop.Font = new Font("Segoe Print", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_stop.Location = new Point(472, 48);
            button_stop.Name = "button_stop";
            button_stop.Size = new Size(186, 96);
            button_stop.TabIndex = 1;
            button_stop.Text = "Stop";
            button_stop.UseVisualStyleBackColor = false;
            button_stop.Click += button_stop_Click;
            // 
            // progressBar_StartStop
            // 
            progressBar_StartStop.Location = new Point(23, 32);
            progressBar_StartStop.Name = "progressBar_StartStop";
            progressBar_StartStop.Size = new Size(1105, 46);
            progressBar_StartStop.TabIndex = 2;
            // 
            // textBox_StartStop
            // 
            textBox_StartStop.BorderStyle = BorderStyle.FixedSingle;
            textBox_StartStop.Font = new Font("Segoe Print", 16.125F, FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox_StartStop.Location = new Point(399, 331);
            textBox_StartStop.Name = "textBox_StartStop";
            textBox_StartStop.Size = new Size(372, 83);
            textBox_StartStop.TabIndex = 3;
            textBox_StartStop.TextAlign = HorizontalAlignment.Center;
            // 
            // checkBox_enablePrompt
            // 
            checkBox_enablePrompt.AutoSize = true;
            checkBox_enablePrompt.Location = new Point(145, 360);
            checkBox_enablePrompt.Name = "checkBox_enablePrompt";
            checkBox_enablePrompt.Size = new Size(203, 36);
            checkBox_enablePrompt.TabIndex = 4;
            checkBox_enablePrompt.Text = "Click to Enable";
            checkBox_enablePrompt.UseVisualStyleBackColor = true;
            checkBox_enablePrompt.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(button_start);
            panel1.Controls.Add(button_stop);
            panel1.Location = new Point(244, 446);
            panel1.Name = "panel1";
            panel1.Size = new Size(693, 149);
            panel1.TabIndex = 5;
            // 
            // button_newForm2
            // 
            button_newForm2.Location = new Point(475, 688);
            button_newForm2.Name = "button_newForm2";
            button_newForm2.Size = new Size(204, 67);
            button_newForm2.TabIndex = 6;
            button_newForm2.Text = "New Form";
            button_newForm2.UseVisualStyleBackColor = true;
            button_newForm2.Click += button_newForm2_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // numericUpDown_max20
            // 
            numericUpDown_max20.Location = new Point(439, 202);
            numericUpDown_max20.Name = "numericUpDown_max20";
            numericUpDown_max20.Size = new Size(240, 39);
            numericUpDown_max20.TabIndex = 7;
            numericUpDown_max20.Validating += numericUpDown_max20_Validating;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1733, 1114);
            Controls.Add(numericUpDown_max20);
            Controls.Add(button_newForm2);
            Controls.Add(panel1);
            Controls.Add(checkBox_enablePrompt);
            Controls.Add(textBox_StartStop);
            Controls.Add(progressBar_StartStop);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_max20).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_start;
        private Button button_stop;
        private ProgressBar progressBar_StartStop;
        private TextBox textBox_StartStop;
        private CheckBox checkBox_enablePrompt;
        private Panel panel1;
        private Button button_newForm2;
        private ErrorProvider errorProvider1;
        private NumericUpDown numericUpDown_max20;
    }
}
