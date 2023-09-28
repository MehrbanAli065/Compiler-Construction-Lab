namespace Lab_4_graded_task
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
            analyze = new Button();
            outputTB = new RichTextBox();
            inpTB = new RichTextBox();
            SuspendLayout();
            // 
            // analyze
            // 
            analyze.Location = new Point(345, 372);
            analyze.Name = "analyze";
            analyze.Size = new Size(75, 23);
            analyze.TabIndex = 0;
            analyze.Text = "Analyze";
            analyze.UseVisualStyleBackColor = true;
            analyze.Click += analyze_Click;
            // 
            // outputTB
            // 
            outputTB.Location = new Point(252, 196);
            outputTB.Name = "outputTB";
            outputTB.Size = new Size(264, 96);
            outputTB.TabIndex = 1;
            outputTB.Text = "";
            // 
            // inpTB
            // 
            inpTB.Location = new Point(140, 75);
            inpTB.Name = "inpTB";
            inpTB.Size = new Size(511, 96);
            inpTB.TabIndex = 3;
            inpTB.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(inpTB);
            Controls.Add(outputTB);
            Controls.Add(analyze);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button analyze;
        private RichTextBox outputTB;
        private RichTextBox inpTB;
    }
}