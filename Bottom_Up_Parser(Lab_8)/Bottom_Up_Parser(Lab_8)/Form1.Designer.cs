namespace Bottom_Up_Parser_Lab_8_
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
            colorDialog1 = new ColorDialog();
            VariableTextBox = new TextBox();
            ValidateButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // VariableTextBox
            // 
            VariableTextBox.Location = new Point(232, 110);
            VariableTextBox.Name = "VariableTextBox";
            VariableTextBox.Size = new Size(313, 23);
            VariableTextBox.TabIndex = 0;
            // 
            // ValidateButton
            // 
            ValidateButton.Location = new Point(342, 176);
            ValidateButton.Name = "ValidateButton";
            ValidateButton.Size = new Size(75, 23);
            ValidateButton.TabIndex = 1;
            ValidateButton.Text = "Validate";
            ValidateButton.UseVisualStyleBackColor = true;
            ValidateButton.Click += ValidateButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 26.25F, FontStyle.Underline | FontStyle.Strikeout, GraphicsUnit.Point);
            label1.Location = new Point(246, 28);
            label1.Name = "label1";
            label1.Size = new Size(270, 40);
            label1.TabIndex = 2;
            label1.Text = "Bottom Up Parser";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(ValidateButton);
            Controls.Add(VariableTextBox);
            Name = "Form1";
            Text = "Bottom Up Parser";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ColorDialog colorDialog1;
        private TextBox VariableTextBox;
        private Button ValidateButton;
        private Label label1;
    }
}