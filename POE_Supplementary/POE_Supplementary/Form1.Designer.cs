namespace POE_Supplementary
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.ATKgrpBox = new System.Windows.Forms.GroupBox();
            this.ATKbtn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.MAPlbl = new System.Windows.Forms.Label();
            this.ATKgrpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(77, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(77, 156);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(150, 127);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // ATKgrpBox
            // 
            this.ATKgrpBox.Controls.Add(this.ATKbtn);
            this.ATKgrpBox.Controls.Add(this.listBox1);
            this.ATKgrpBox.Location = new System.Drawing.Point(10, 185);
            this.ATKgrpBox.Name = "ATKgrpBox";
            this.ATKgrpBox.Size = new System.Drawing.Size(215, 253);
            this.ATKgrpBox.TabIndex = 4;
            this.ATKgrpBox.TabStop = false;
            this.ATKgrpBox.Text = "Attack log";
            // 
            // ATKbtn
            // 
            this.ATKbtn.Location = new System.Drawing.Point(7, 224);
            this.ATKbtn.Name = "ATKbtn";
            this.ATKbtn.Size = new System.Drawing.Size(202, 23);
            this.ATKbtn.TabIndex = 1;
            this.ATKbtn.Text = "button5";
            this.ATKbtn.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(6, 21);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(203, 196);
            this.listBox1.TabIndex = 0;
            // 
            // MAPlbl
            // 
            this.MAPlbl.AutoSize = true;
            this.MAPlbl.Font = new System.Drawing.Font("SimSun", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MAPlbl.Location = new System.Drawing.Point(246, 13);
            this.MAPlbl.Name = "MAPlbl";
            this.MAPlbl.Size = new System.Drawing.Size(57, 28);
            this.MAPlbl.TabIndex = 5;
            this.MAPlbl.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 450);
            this.Controls.Add(this.MAPlbl);
            this.Controls.Add(this.ATKgrpBox);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ATKgrpBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox ATKgrpBox;
        private System.Windows.Forms.Button ATKbtn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label MAPlbl;
    }
}

