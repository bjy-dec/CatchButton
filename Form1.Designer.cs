namespace CatchButton
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
            mybutton = new Button();
            SuspendLayout();
            // 
            // mybutton
            // 
            mybutton.BackColor = Color.FromArgb(192, 192, 255);
            mybutton.Font = new Font("한컴 고딕", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 129);
            mybutton.ForeColor = SystemColors.HotTrack;
            mybutton.Location = new Point(349, 149);
            mybutton.Name = "mybutton";
            mybutton.Size = new Size(160, 80);
            mybutton.TabIndex = 0;
            mybutton.Text = "나를 잡아봐";
            mybutton.UseVisualStyleBackColor = false;
            mybutton.MouseEnter += mybutton_MouseEnter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mybutton);
            Name = "Form1";
            Text = "버튼 잡기 게임";
            Load += Form1_Load_1;
            ResumeLayout(false);
        }

        #endregion

        private Button mybutton;
    }
}
