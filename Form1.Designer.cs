namespace OOP.WinFormsApp1
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
            Auto = new Button();
            Bus = new Button();
            SuspendLayout();
            // 
            // Auto
            // 
            Auto.Font = new Font("Segoe UI", 20F);
            Auto.Location = new Point(86, 79);
            Auto.Name = "Auto";
            Auto.Size = new Size(200, 125);
            Auto.TabIndex = 0;
            Auto.Text = "Corneta de Auto";
            Auto.UseVisualStyleBackColor = true;
            Auto.Click += button1_Click;
            // 
            // Bus
            // 
            Bus.Font = new Font("Segoe UI", 20F);
            Bus.Location = new Point(492, 79);
            Bus.Name = "Bus";
            Bus.Size = new Size(200, 125);
            Bus.TabIndex = 1;
            Bus.Text = "Corneta de Bus";
            Bus.UseVisualStyleBackColor = true;
            Bus.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Bus);
            Controls.Add(Auto);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button Auto;
        private Button Bus;
    }
}
