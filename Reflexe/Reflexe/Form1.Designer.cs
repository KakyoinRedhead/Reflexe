namespace Reflexe
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            jablko1 = new Jablko();
            bryle1 = new Bryle();
            jablko2 = new Jablko();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(jablko1);
            flowLayoutPanel1.Controls.Add(bryle1);
            flowLayoutPanel1.Controls.Add(jablko2);
            flowLayoutPanel1.Location = new Point(12, 12);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(582, 426);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(676, 12);
            button1.Name = "button1";
            button1.Size = new Size(112, 55);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // jablko1
            // 
            jablko1.Location = new Point(3, 3);
            jablko1.Name = "jablko1";
            jablko1.Size = new Size(150, 150);
            jablko1.TabIndex = 0;
            // 
            // bryle1
            // 
            bryle1.Location = new Point(159, 3);
            bryle1.Name = "bryle1";
            bryle1.Size = new Size(150, 150);
            bryle1.TabIndex = 1;
            // 
            // jablko2
            // 
            jablko2.Location = new Point(315, 3);
            jablko2.Name = "jablko2";
            jablko2.Size = new Size(150, 150);
            jablko2.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(flowLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private Jablko jablko1;
        private Bryle bryle1;
        private Jablko jablko2;
    }
}