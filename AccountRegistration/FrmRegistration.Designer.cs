namespace AccountRegistration
{
    partial class FrmRegistration
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.StudNoB = new System.Windows.Forms.TextBox();
            this.LastNameB = new System.Windows.Forms.TextBox();
            this.ProgramCB = new System.Windows.Forms.ComboBox();
            this.FirstNameB = new System.Windows.Forms.TextBox();
            this.MiddleNameB = new System.Windows.Forms.TextBox();
            this.AgeB = new System.Windows.Forms.TextBox();
            this.ContactNoB = new System.Windows.Forms.TextBox();
            this.AddressB = new System.Windows.Forms.RichTextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(180, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student No.:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Program:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "First Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(304, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Middle Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Age:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(164, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Contact No.:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Address:";
            // 
            // StudNoB
            // 
            this.StudNoB.Location = new System.Drawing.Point(27, 35);
            this.StudNoB.Name = "StudNoB";
            this.StudNoB.Size = new System.Drawing.Size(134, 20);
            this.StudNoB.TabIndex = 9;
            // 
            // LastNameB
            // 
            this.LastNameB.Location = new System.Drawing.Point(27, 83);
            this.LastNameB.Name = "LastNameB";
            this.LastNameB.Size = new System.Drawing.Size(134, 20);
            this.LastNameB.TabIndex = 10;
            // 
            // ProgramCB
            // 
            this.ProgramCB.FormattingEnabled = true;
            this.ProgramCB.Location = new System.Drawing.Point(167, 35);
            this.ProgramCB.Name = "ProgramCB";
            this.ProgramCB.Size = new System.Drawing.Size(175, 21);
            this.ProgramCB.TabIndex = 11;
            // 
            // FirstNameB
            // 
            this.FirstNameB.Location = new System.Drawing.Point(167, 83);
            this.FirstNameB.Name = "FirstNameB";
            this.FirstNameB.Size = new System.Drawing.Size(134, 20);
            this.FirstNameB.TabIndex = 12;
            // 
            // MiddleNameB
            // 
            this.MiddleNameB.Location = new System.Drawing.Point(307, 83);
            this.MiddleNameB.Name = "MiddleNameB";
            this.MiddleNameB.Size = new System.Drawing.Size(134, 20);
            this.MiddleNameB.TabIndex = 13;
            // 
            // AgeB
            // 
            this.AgeB.Location = new System.Drawing.Point(27, 131);
            this.AgeB.Name = "AgeB";
            this.AgeB.Size = new System.Drawing.Size(134, 20);
            this.AgeB.TabIndex = 14;
            // 
            // ContactNoB
            // 
            this.ContactNoB.Location = new System.Drawing.Point(167, 131);
            this.ContactNoB.Name = "ContactNoB";
            this.ContactNoB.Size = new System.Drawing.Size(134, 20);
            this.ContactNoB.TabIndex = 15;
            // 
            // AddressB
            // 
            this.AddressB.Location = new System.Drawing.Point(27, 179);
            this.AddressB.Name = "AddressB";
            this.AddressB.Size = new System.Drawing.Size(414, 115);
            this.AddressB.TabIndex = 16;
            this.AddressB.Text = "";
            // 
            // FrmRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 347);
            this.Controls.Add(this.AddressB);
            this.Controls.Add(this.ContactNoB);
            this.Controls.Add(this.AgeB);
            this.Controls.Add(this.MiddleNameB);
            this.Controls.Add(this.FirstNameB);
            this.Controls.Add(this.ProgramCB);
            this.Controls.Add(this.LastNameB);
            this.Controls.Add(this.StudNoB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "FrmRegistration";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox StudNoB;
        private System.Windows.Forms.TextBox LastNameB;
        private System.Windows.Forms.ComboBox ProgramCB;
        private System.Windows.Forms.TextBox FirstNameB;
        private System.Windows.Forms.TextBox MiddleNameB;
        private System.Windows.Forms.TextBox AgeB;
        private System.Windows.Forms.TextBox ContactNoB;
        private System.Windows.Forms.RichTextBox AddressB;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

