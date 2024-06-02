namespace _2_4_FlagsApp
{
    partial class form_flags
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
            label_instructions = new Label();
            label_country = new Label();
            picture_finland = new PictureBox();
            picture_france = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picture_finland).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picture_france).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label_instructions
            // 
            label_instructions.AutoSize = true;
            label_instructions.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_instructions.Location = new Point(477, 103);
            label_instructions.Name = "label_instructions";
            label_instructions.Size = new Size(556, 37);
            label_instructions.TabIndex = 0;
            label_instructions.Text = "Click a flag to see the name of its country!";
            // 
            // label_country
            // 
            label_country.BorderStyle = BorderStyle.FixedSingle;
            label_country.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_country.Location = new Point(397, 857);
            label_country.Name = "label_country";
            label_country.Size = new Size(732, 94);
            label_country.TabIndex = 1;
            label_country.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picture_finland
            // 
            picture_finland.Image = Properties.Resources.Finland;
            picture_finland.Location = new Point(98, 392);
            picture_finland.Name = "picture_finland";
            picture_finland.Size = new Size(373, 230);
            picture_finland.SizeMode = PictureBoxSizeMode.Zoom;
            picture_finland.TabIndex = 2;
            picture_finland.TabStop = false;
            
            // 
            // picture_france
            // 
            picture_france.Image = Properties.Resources.France;
            picture_france.Location = new Point(578, 392);
            picture_france.Name = "picture_france";
            picture_france.Size = new Size(357, 230);
            picture_france.SizeMode = PictureBoxSizeMode.Zoom;
            picture_france.TabIndex = 3;
            picture_france.TabStop = false;
          
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Germany;
            pictureBox3.Location = new Point(1056, 392);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(344, 230);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
           
            // 
            // form_flags
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1552, 1094);
            Controls.Add(pictureBox3);
            Controls.Add(picture_france);
            Controls.Add(picture_finland);
            Controls.Add(label_country);
            Controls.Add(label_instructions);
            Name = "form_flags";
            Text = "form_flags";
            ((System.ComponentModel.ISupportInitialize)picture_finland).EndInit();
            ((System.ComponentModel.ISupportInitialize)picture_france).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_instructions;
        private Label label_country;
        private PictureBox picture_finland;
        private PictureBox picture_france;
        private PictureBox pictureBox3;
    }
}
