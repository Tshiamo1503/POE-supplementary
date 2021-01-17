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
            this.Shopbtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ATKgrpBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Leftbt
            // 
            this.Leftbt.Location = new System.Drawing.Point(3, 45);
            this.Leftbt.Name = "Leftbt";
            this.Leftbt.Size = new System.Drawing.Size(72, 31);
            this.Leftbt.TabIndex = 0;
            this.Leftbt.Text = "LEFT";
            this.Leftbt.UseVisualStyleBackColor = true;
            this.Leftbt.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Upbtn
            // 
            this.Upbtn.Location = new System.Drawing.Point(116, 3);
            this.Upbtn.Name = "Upbtn";
            this.Upbtn.Size = new System.Drawing.Size(72, 31);
            this.Upbtn.TabIndex = 1;
            this.Upbtn.Text = "UP";
            this.Upbtn.UseVisualStyleBackColor = true;
            this.Upbtn.Click += new System.EventHandler(this.Upbtn_Click);
            // 
            // Downbtn
            // 
            this.Downbtn.Location = new System.Drawing.Point(116, 87);
            this.Downbtn.Name = "Downbtn";
            this.Downbtn.Size = new System.Drawing.Size(72, 31);
            this.Downbtn.TabIndex = 2;
            this.Downbtn.Text = "DOWN";
            this.Downbtn.UseVisualStyleBackColor = true;
            this.Downbtn.Click += new System.EventHandler(this.Downbtn_Click);
            // 
            // Rightbtn
            // 
            this.Rightbtn.Location = new System.Drawing.Point(229, 45);
            this.Rightbtn.Name = "Rightbtn";
            this.Rightbtn.Size = new System.Drawing.Size(72, 31);
            this.Rightbtn.TabIndex = 3;
            this.Rightbtn.Text = "RIGHT";
            this.Rightbtn.UseVisualStyleBackColor = true;
            this.Rightbtn.Click += new System.EventHandler(this.Rightbtn_Click);
            // 
            // ATKgrpBox
            // 
            this.ATKgrpBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ATKgrpBox.Controls.Add(this.AtkLogBox);
            this.ATKgrpBox.Controls.Add(this.enemylist);
            this.ATKgrpBox.Controls.Add(this.ATKbtn);
            this.ATKgrpBox.Location = new System.Drawing.Point(12, 12);
            this.ATKgrpBox.Name = "ATKgrpBox";
            this.ATKgrpBox.Size = new System.Drawing.Size(407, 373);
            this.ATKgrpBox.TabIndex = 4;
            this.ATKgrpBox.TabStop = false;
            this.ATKgrpBox.Text = "Attack log";
            // 
            // AtkLogBox
            // 
            this.AtkLogBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AtkLogBox.Location = new System.Drawing.Point(7, 21);
            this.AtkLogBox.Name = "AtkLogBox";
            this.AtkLogBox.Size = new System.Drawing.Size(394, 282);
            this.AtkLogBox.TabIndex = 3;
            this.AtkLogBox.Text = "";
            // 
            // enemylist
            // 
            this.enemylist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.enemylist.FormattingEnabled = true;
            this.enemylist.Location = new System.Drawing.Point(7, 309);
            this.enemylist.Name = "enemylist";
            this.enemylist.Size = new System.Drawing.Size(394, 24);
            this.enemylist.TabIndex = 2;
            // 
            // ATKbtn
            // 
            this.ATKbtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ATKbtn.Location = new System.Drawing.Point(7, 339);
            this.ATKbtn.Name = "ATKbtn";
            this.ATKbtn.Size = new System.Drawing.Size(394, 23);
            this.ATKbtn.TabIndex = 1;
            this.ATKbtn.Text = "Attack";
            this.ATKbtn.UseVisualStyleBackColor = true;
            this.ATKbtn.Click += new System.EventHandler(this.ATKbtn_Click);
            // 
            // MAPlb
            // 
            this.MAPlb.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.MAPlb.AutoSize = true;
            this.MAPlb.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MAPlb.Location = new System.Drawing.Point(425, 12);
            this.MAPlb.Name = "MAPlb";
            this.MAPlb.Size = new System.Drawing.Size(49, 24);
            this.MAPlb.TabIndex = 5;
            this.MAPlb.Text = "...";
            // 
            // Statbx
            // 
            this.Statbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Statbx.AutoWordSelection = true;
            this.Statbx.Location = new System.Drawing.Point(362, 395);
            this.Statbx.Name = "Statbx";
            this.Statbx.Size = new System.Drawing.Size(246, 127);
            this.Statbx.TabIndex = 6;
            this.Statbx.Text = "";
            // 
            // Savebtn
            // 
            this.Savebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Savebtn.Location = new System.Drawing.Point(615, 470);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(75, 23);
            this.Savebtn.TabIndex = 7;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // Loadbtn
            // 
            this.Loadbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Loadbtn.Location = new System.Drawing.Point(615, 499);
            this.Loadbtn.Name = "Loadbtn";
            this.Loadbtn.Size = new System.Drawing.Size(75, 23);
            this.Loadbtn.TabIndex = 8;
            this.Loadbtn.Text = "Load";
            this.Loadbtn.UseVisualStyleBackColor = true;
            this.Loadbtn.Click += new System.EventHandler(this.Loadbtn_Click);
            // 
            // Shopbtn
            // 
            this.Shopbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Shopbtn.Location = new System.Drawing.Point(425, 351);
            this.Shopbtn.Name = "Shopbtn";
            this.Shopbtn.Size = new System.Drawing.Size(183, 34);
            this.Shopbtn.TabIndex = 9;
            this.Shopbtn.Text = "Shop";
            this.Shopbtn.UseVisualStyleBackColor = true;
            this.Shopbtn.Click += new System.EventHandler(this.Shopbtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.Rightbtn, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.Upbtn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Leftbt, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Downbtn, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 395);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(341, 127);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 534);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Shopbtn);
            this.Controls.Add(this.Loadbtn);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.Statbx);
            this.Controls.Add(this.MAPlb);
            this.Controls.Add(this.ATKgrpBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ATKgrpBox.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
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
        private System.Windows.Forms.Button Shopbtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

