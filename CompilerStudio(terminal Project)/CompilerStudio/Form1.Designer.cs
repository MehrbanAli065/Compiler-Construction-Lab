namespace CompilerStudio
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
            this.btnS = new System.Windows.Forms.Button();
            this.btnLA = new System.Windows.Forms.Button();
            this.btnFF = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.tbINP = new System.Windows.Forms.TextBox();
            this.tbS = new System.Windows.Forms.TextBox();
            this.tbL = new System.Windows.Forms.TextBox();
            this.tbFF = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.exm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnS
            // 
            this.btnS.Location = new System.Drawing.Point(199, 347);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(142, 52);
            this.btnS.TabIndex = 0;
            this.btnS.Text = "Semantic Anayze";
            this.btnS.UseVisualStyleBackColor = true;
            this.btnS.Click += new System.EventHandler(this.btnS_Click);
            // 
            // btnLA
            // 
            this.btnLA.Location = new System.Drawing.Point(474, 347);
            this.btnLA.Name = "btnLA";
            this.btnLA.Size = new System.Drawing.Size(146, 52);
            this.btnLA.TabIndex = 1;
            this.btnLA.Text = "Lexical Analyse";
            this.btnLA.UseVisualStyleBackColor = true;
            this.btnLA.Click += new System.EventHandler(this.btnLA_Click);
            // 
            // btnFF
            // 
            this.btnFF.Location = new System.Drawing.Point(753, 347);
            this.btnFF.Name = "btnFF";
            this.btnFF.Size = new System.Drawing.Size(131, 52);
            this.btnFF.TabIndex = 2;
            this.btnFF.Text = "FirstFollow";
            this.btnFF.UseVisualStyleBackColor = true;
            this.btnFF.Click += new System.EventHandler(this.btnFF_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Silver;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Location = new System.Drawing.Point(978, 105);
            this.btnClear.Name = "btnClear";
            this.btnClear.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnClear.Size = new System.Drawing.Size(133, 52);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Silver;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Location = new System.Drawing.Point(978, 263);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(133, 55);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(1058, 12);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "===>>";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // tbINP
            // 
            this.tbINP.Location = new System.Drawing.Point(199, 61);
            this.tbINP.Multiline = true;
            this.tbINP.Name = "tbINP";
            this.tbINP.Size = new System.Drawing.Size(658, 257);
            this.tbINP.TabIndex = 6;
            // 
            // tbS
            // 
            this.tbS.Location = new System.Drawing.Point(133, 405);
            this.tbS.Multiline = true;
            this.tbS.Name = "tbS";
            this.tbS.Size = new System.Drawing.Size(259, 235);
            this.tbS.TabIndex = 7;
            // 
            // tbL
            // 
            this.tbL.Location = new System.Drawing.Point(417, 405);
            this.tbL.Multiline = true;
            this.tbL.Name = "tbL";
            this.tbL.Size = new System.Drawing.Size(259, 235);
            this.tbL.TabIndex = 8;
            // 
            // tbFF
            // 
            this.tbFF.Location = new System.Drawing.Point(700, 405);
            this.tbFF.Multiline = true;
            this.tbFF.Name = "tbFF";
            this.tbFF.Size = new System.Drawing.Size(259, 235);
            this.tbFF.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Olive;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(411, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "Compiler Studio";
            // 
            // exm
            // 
            this.exm.Location = new System.Drawing.Point(13, 133);
            this.exm.Name = "exm";
            this.exm.Size = new System.Drawing.Size(166, 54);
            this.exm.TabIndex = 12;
            this.exm.Text = "Show input example";
            this.exm.UseVisualStyleBackColor = true;
            this.exm.Click += new System.EventHandler(this.exm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(1145, 652);
            this.Controls.Add(this.exm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbFF);
            this.Controls.Add(this.tbL);
            this.Controls.Add(this.tbS);
            this.Controls.Add(this.tbINP);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnFF);
            this.Controls.Add(this.btnLA);
            this.Controls.Add(this.btnS);
            this.Name = "Form1";
            this.Text = "CompilerStudio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.Button btnLA;
        private System.Windows.Forms.Button btnFF;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox tbINP;
        private System.Windows.Forms.TextBox tbS;
        private System.Windows.Forms.TextBox tbL;
        private System.Windows.Forms.TextBox tbFF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exm;
    }
}

