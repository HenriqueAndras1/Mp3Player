namespace MyMp3Player
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonNext;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            button3 = new Button();
            button5 = new Button();
            button6 = new Button();
            buttonPrev = new Button();
            buttonNext = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(64, 239);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(35, 27);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(148, 239);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(31, 27);
            button3.TabIndex = 1;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.Location = new Point(187, 239);
            button5.Margin = new Padding(4, 3, 4, 3);
            button5.Name = "button5";
            button5.Size = new Size(30, 27);
            button5.TabIndex = 2;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ActiveCaption;
            button6.Dock = DockStyle.Right;
            button6.FlatAppearance.BorderColor = Color.Yellow;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.Red;
            button6.Location = new Point(306, 0);
            button6.Margin = new Padding(4, 3, 4, 3);
            button6.Name = "button6";
            button6.Size = new Size(25, 27);
            button6.TabIndex = 3;
            button6.Text = "X";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // buttonPrev
            // 
            buttonPrev.FlatAppearance.BorderSize = 0;
            buttonPrev.FlatStyle = FlatStyle.Flat;
            buttonPrev.Image = (Image)resources.GetObject("buttonPrev.Image");
            buttonPrev.Location = new Point(107, 239);
            buttonPrev.Margin = new Padding(4, 3, 4, 3);
            buttonPrev.Name = "buttonPrev";
            buttonPrev.Size = new Size(33, 27);
            buttonPrev.TabIndex = 4;
            buttonPrev.UseVisualStyleBackColor = true;
            buttonPrev.Click += buttonPrev_Click;
            // 
            // buttonNext
            // 
            buttonNext.FlatAppearance.BorderSize = 0;
            buttonNext.FlatStyle = FlatStyle.Flat;
            buttonNext.Image = (Image)resources.GetObject("buttonNext.Image");
            buttonNext.Location = new Point(225, 239);
            buttonNext.Margin = new Padding(4, 3, 4, 3);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(29, 27);
            buttonNext.TabIndex = 5;
            buttonNext.UseVisualStyleBackColor = true;
            buttonNext.Click += buttonNext_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(64, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(190, 189);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(331, 27);
            panel1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(96, 1);
            label1.Name = "label1";
            label1.Size = new Size(130, 21);
            label1.TabIndex = 4;
            label1.Text = "C# Player Music";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(331, 301);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(buttonNext);
            Controls.Add(buttonPrev);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mp3 Player";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
    }
}
