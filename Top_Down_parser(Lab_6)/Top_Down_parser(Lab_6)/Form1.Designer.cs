namespace Top_Down_parser_Lab_6_
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
            Action = new Button();
            inpTB = new TextBox();
            outTB = new RichTextBox();
            SuspendLayout();
            // 
            // Action
            // 
            Action.FlatStyle = FlatStyle.Popup;
            Action.Location = new Point(335, 165);
            Action.Name = "Action";
            Action.Size = new Size(75, 23);
            Action.TabIndex = 0;
            Action.Text = "Action";
            Action.UseVisualStyleBackColor = true;
            Action.Click += Action_Click;
            // 
            // inpTB
            // 
            inpTB.Location = new Point(202, 37);
            inpTB.Multiline = true;
            inpTB.Name = "inpTB";
            inpTB.Size = new Size(390, 95);
            inpTB.TabIndex = 1;
            // 
            // outTB
            // 
            outTB.Location = new Point(258, 229);
            outTB.Name = "outTB";
            outTB.Size = new Size(247, 96);
            outTB.TabIndex = 2;
            outTB.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(outTB);
            Controls.Add(inpTB);
            Controls.Add(Action);
            Name = "Form1";
            Text = "Top Down parser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Action;
        private TextBox inpTB;
        private RichTextBox outTB;
    }
}