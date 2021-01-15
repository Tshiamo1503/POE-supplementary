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
            this.Leftbt = new System.Windows.Forms.Button();
            this.Upbtn = new System.Windows.Forms.Button();
            this.Downbtn = new System.Windows.Forms.Button();
            this.Rightbtn = new System.Windows.Forms.Button();
            this.ATKgrpBox = new System.Windows.Forms.GroupBox();
            this.AtkLogBox = new System.Windows.Forms.RichTextBox();
            this.enemylist = new System.Windows.Forms.ComboBox();
            this.ATKbtn = new System.Windows.Forms.Button();
            this.MAPlb = new System.Windows.Forms.Label();
            this.Statbx = new System.Windows.Forms.RichTextBox();
            this.Savebtn = new System.Windows.Forms.Button();
            this.Loadbtn = new System.Windows.Forms.Button();
            this.ATKgrpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Leftbt
            // 
            this.Leftbt.Location = new System.Drawing.Point(12, 443);
            this.Leftbt.Name = "Leftbt";
            this.Leftbt.Size = new System.Drawing.Size(75, 23);
            this.Leftbt.TabIndex = 0;
            this.Leftbt.Text = "LEFT";
            this.Leftbt.UseVisualStyleBackColor = true;
            this.Leftbt.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Upbtn
            // 
            this.Upbtn.Location = new System.Drawing.Point(87, 414);
            this.Upbtn.Name = "Upbtn";
            this.Upbtn.Size = new System.Drawing.Size(75, 23);
            this.Upbtn.TabIndex = 1;
            this.Upbtn.Text = "UP";
            this.Upbtn.UseVisualStyleBackColor = true;
            this.Upbtn.Click += new System.EventHandler(this.Upbtn_Click);
            // 
            // Downbtn
            // 
            this.Downbtn.Location = new System.Drawing.Point(87, 472);
            this.Downbtn.Name = "Downbtn";
            this.Downbtn.Size = new System.Drawing.Size(75, 23);
            this.Downbtn.TabIndex = 2;
            this.Downbtn.Text = "DOWN";
            this.Downbtn.UseVisualStyleBackColor = true;
            this.Downbtn.Click += new System.EventHandler(this.Downbtn_Click);
            // 
            // Rightbtn
            // 
            this.Rightbtn.Location = new System.Drawing.Point(162, 443);
            this.Rightbtn.Name = "Rightbtn";
            this.Rightbtn.Size = new System.Drawing.Size(75, 23);
            this.Rightbtn.TabIndex = 3;
            this.Rightbtn.Text = "RIGHT";
            this.Rightbtn.UseVisualStyleBackColor = true;
            this.Rightbtn.Click += new System.EventHandler(this.Rightbtn_Click);
            // 
            // ATKgrpBox
            // 
            this.ATKgrpBox.Controls.Add(this.AtkLogBox);
            this.ATKgrpBox.Controls.Add(this.enemylist);
            this.ATKgrpBox.Controls.Add(this.ATKbtn);
            this.ATKgrpBox.Location = new System.Drawing.Point(12, 12);
            this.ATKgrpBox.Name = "ATKgrpBox";
            this.ATKgrpBox.Size = new System.Drawing.Size(252, 396);
            this.ATKgrpBox.TabIndex = 4;
            this.ATKgrpBox.TabStop = false;
            this.ATKgrpBox.Text = "Attack log";
            // 
            // AtkLogBox
            // 
            this.AtkLogBox.Location = new System.Drawing.Point(7, 21);
            this.AtkLogBox.Name = "AtkLogBox";
            this.AtkLogBox.Size = new System.Drawing.Size(239, 308);
            this.AtkLogBox.TabIndex = 3;
            this.AtkLogBox.Text = "";
            // 
            // enemylist
            // 
            this.enemylist.FormattingEnabled = true;
            this.enemylist.Location = new System.Drawing.Point(6, 335);
            this.enemylist.Name = "enemylist";
            this.enemylist.Size = new System.Drawing.Size(239, 24);
            this.enemylist.TabIndex = 2;
            // 
            // ATKbtn
            // 
            this.ATKbtn.Location = new System.Drawing.Point(7, 365);
            this.ATKbtn.Name = "ATKbtn";
            this.ATKbtn.Size = new System.Drawing.Size(239, 23);
            this.ATKbtn.TabIndex = 1;
            this.ATKbtn.Text = "Attack";
            this.ATKbtn.UseVisualStyleBackColor = true;
            this.ATKbtn.Click += new System.EventHandler(this.ATKbtn_Click);
            // 
            // MAPlb
            // 
            this.MAPlb.AutoSize = true;
            this.MAPlb.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MAPlb.Location = new System.Drawing.Point(266, 9);
            this.MAPlb.Name = "MAPlb";
            this.MAPlb.Size = new System.Drawing.Size(49, 24);
            this.MAPlb.TabIndex = 5;
            this.MAPlb.Text = "...";
            // 
            // Statbx
            // 
            this.Statbx.Location = new System.Drawing.Point(270, 377);
            this.Statbx.Name = "Statbx";
            this.Statbx.Size = new System.Drawing.Size(250, 118);
            this.Statbx.TabIndex = 6;
            this.Statbx.Text = "";
            // 
            // Savebtn
            // 
            this.Savebtn.Location = new System.Drawing.Point(526, 443);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(75, 23);
            this.Savebtn.TabIndex = 7;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // Loadbtn
            // 
            this.Loadbtn.Location = new System.Drawing.Point(526, 472);
            this.Loadbtn.Name = "Loadbtn";
            this.Loadbtn.Size = new System.Drawing.Size(75, 23);
            this.Loadbtn.TabIndex = 8;
            this.Loadbtn.Text = "Load";
            this.Loadbtn.UseVisualStyleBackColor = true;
            this.Loadbtn.Click += new System.EventHandler(this.Loadbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 507);
            this.Controls.Add(this.Loadbtn);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.Statbx);
            this.Controls.Add(this.MAPlb);
            this.Controls.Add(this.ATKgrpBox);
            this.Controls.Add(this.Rightbtn);
            this.Controls.Add(this.Downbtn);
            this.Controls.Add(this.Upbtn);
            this.Controls.Add(this.Leftbt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ATKgrpBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Leftbt;
        private System.Windows.Forms.Button Upbtn;
        private System.Windows.Forms.Button Downbtn;
        private System.Windows.Forms.Button Rightbtn;
        private System.Windows.Forms.GroupBox ATKgrpBox;
        private System.Windows.Forms.Button ATKbtn;
        private System.Windows.Forms.Label MAPlb;
        private System.Windows.Forms.RichTextBox Statbx;
        private System.Windows.Forms.ComboBox enemylist;
        private System.Windows.Forms.RichTextBox AtkLogBox;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.Button Loadbtn;
    }
}

