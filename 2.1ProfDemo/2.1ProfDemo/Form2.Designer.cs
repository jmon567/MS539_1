namespace _2._1ProfDemo
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button_returnForm1 = new Button();
            SuspendLayout();
            // 
            // button_returnForm1
            // 
            button_returnForm1.Location = new Point(449, 547);
            button_returnForm1.Name = "button_returnForm1";
            button_returnForm1.Size = new Size(150, 46);
            button_returnForm1.TabIndex = 0;
            button_returnForm1.Text = "Return";
            button_returnForm1.UseVisualStyleBackColor = true;
            button_returnForm1.Click += button_returnForm1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 821);
            Controls.Add(button_returnForm1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private Button button_returnForm1;
    }
}