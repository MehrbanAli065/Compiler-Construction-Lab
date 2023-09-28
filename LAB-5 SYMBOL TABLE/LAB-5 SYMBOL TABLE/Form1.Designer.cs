namespace LAB_5_SYMBOL_TABLE
{
    partial class Form1
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
            Add = new Button();
            remove = new Button();
            tb1 = new TextBox();
            tb2 = new TextBox();
            SuspendLayout();
            // 
            // Add
            // 
            Add.Location = new Point(295, 347);
            Add.Name = "Add";
            Add.Size = new Size(75, 35);
            Add.TabIndex = 0;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // remove
            // 
            remove.Location = new Point(394, 347);
            remove.Name = "remove";
            remove.Size = new Size(83, 35);
            remove.TabIndex = 1;
            remove.Text = "Remove";
            remove.UseVisualStyleBackColor = true;
            remove.Click += remove_Click;
            // 
            // tb1
            // 
            tb1.Location = new Point(246, 125);
            tb1.Name = "tb1";
            tb1.Size = new Size(100, 23);
            tb1.TabIndex = 2;
            // 
            // tb2
            // 
            tb2.Location = new Point(403, 125);
            tb2.Name = "tb2";
            tb2.Size = new Size(100, 23);
            tb2.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tb2);
            Controls.Add(tb1);
            Controls.Add(remove);
            Controls.Add(Add);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Add;
        private Button remove;
        private TextBox tb1;
        private TextBox tb2;
    }
}