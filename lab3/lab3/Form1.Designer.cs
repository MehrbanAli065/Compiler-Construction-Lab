namespace lab3
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
            validate = new Button();
            tb = new TextBox();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // validate
            // 
            validate.Location = new Point(322, 233);
            validate.Name = "validate";
            validate.Size = new Size(129, 54);
            validate.TabIndex = 0;
            validate.Text = "validate";
            validate.UseVisualStyleBackColor = true;
            validate.Click += validate_Click;
            // 
            // tb
            // 
            tb.Location = new Point(148, 172);
            tb.Name = "tb";
            tb.Size = new Size(484, 23);
            tb.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 172);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 2;
            label1.Text = "input text:";
            // 
            // button1
            // 
            button1.Location = new Point(724, 425);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Next";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(tb);
            Controls.Add(validate);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button validate;
        private TextBox tb;
        private Label label1;
        private Button button1;
    }
}