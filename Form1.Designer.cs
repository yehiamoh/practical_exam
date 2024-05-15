namespace practical_exam
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
            this.ID = new System.Windows.Forms.TextBox();
            this.balance = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.openfileBtn = new System.Windows.Forms.Button();
            this.insertBtn = new System.Windows.Forms.Button();
            this.readBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.squezzeBtn = new System.Windows.Forms.Button();
            this.clearFomBtn = new System.Windows.Forms.Button();
            this.startFileBtn = new System.Windows.Forms.Button();
            this.endFileBtn = new System.Windows.Forms.Button();
            this.closeFileBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(218, 45);
            this.ID.Multiline = true;
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(354, 46);
            this.ID.TabIndex = 0;
            // 
            // balance
            // 
            this.balance.Location = new System.Drawing.Point(218, 257);
            this.balance.Multiline = true;
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(354, 46);
            this.balance.TabIndex = 1;
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(218, 182);
            this.LastName.Multiline = true;
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(354, 46);
            this.LastName.TabIndex = 2;
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(218, 117);
            this.firstName.Multiline = true;
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(354, 46);
            this.firstName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Account ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Last Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Balance";
            // 
            // openfileBtn
            // 
            this.openfileBtn.Location = new System.Drawing.Point(2, 348);
            this.openfileBtn.Name = "openfileBtn";
            this.openfileBtn.Size = new System.Drawing.Size(99, 34);
            this.openfileBtn.TabIndex = 8;
            this.openfileBtn.Text = "open file";
            this.openfileBtn.UseVisualStyleBackColor = true;
            this.openfileBtn.Click += new System.EventHandler(this.openfileBtn_Click);
            // 
            // insertBtn
            // 
            this.insertBtn.Enabled = false;
            this.insertBtn.Location = new System.Drawing.Point(127, 348);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(112, 34);
            this.insertBtn.TabIndex = 9;
            this.insertBtn.Text = "insert";
            this.insertBtn.UseVisualStyleBackColor = true;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // readBtn
            // 
            this.readBtn.Enabled = false;
            this.readBtn.Location = new System.Drawing.Point(258, 348);
            this.readBtn.Name = "readBtn";
            this.readBtn.Size = new System.Drawing.Size(112, 34);
            this.readBtn.TabIndex = 10;
            this.readBtn.Text = "read";
            this.readBtn.UseVisualStyleBackColor = true;
            this.readBtn.Click += new System.EventHandler(this.readBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Enabled = false;
            this.searchBtn.Location = new System.Drawing.Point(388, 348);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(123, 34);
            this.searchBtn.TabIndex = 11;
            this.searchBtn.Text = "search by ID";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Enabled = false;
            this.deleteBtn.Location = new System.Drawing.Point(517, 348);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(133, 34);
            this.deleteBtn.TabIndex = 12;
            this.deleteBtn.Text = "delete record";
            this.deleteBtn.UseVisualStyleBackColor = true;
            // 
            // squezzeBtn
            // 
            this.squezzeBtn.Enabled = false;
            this.squezzeBtn.Location = new System.Drawing.Point(665, 348);
            this.squezzeBtn.Name = "squezzeBtn";
            this.squezzeBtn.Size = new System.Drawing.Size(123, 34);
            this.squezzeBtn.TabIndex = 13;
            this.squezzeBtn.Text = "squeeze File";
            this.squezzeBtn.UseVisualStyleBackColor = true;
            // 
            // clearFomBtn
            // 
            this.clearFomBtn.Enabled = false;
            this.clearFomBtn.Location = new System.Drawing.Point(634, 45);
            this.clearFomBtn.Name = "clearFomBtn";
            this.clearFomBtn.Size = new System.Drawing.Size(112, 34);
            this.clearFomBtn.TabIndex = 14;
            this.clearFomBtn.Text = "Clear form";
            this.clearFomBtn.UseVisualStyleBackColor = true;
            this.clearFomBtn.Click += new System.EventHandler(this.clearFomBtn_Click);
            // 
            // startFileBtn
            // 
            this.startFileBtn.Enabled = false;
            this.startFileBtn.Location = new System.Drawing.Point(634, 117);
            this.startFileBtn.Name = "startFileBtn";
            this.startFileBtn.Size = new System.Drawing.Size(112, 34);
            this.startFileBtn.TabIndex = 15;
            this.startFileBtn.Text = "start File";
            this.startFileBtn.UseVisualStyleBackColor = true;
            this.startFileBtn.Click += new System.EventHandler(this.startFileBtn_Click);
            // 
            // endFileBtn
            // 
            this.endFileBtn.Enabled = false;
            this.endFileBtn.Location = new System.Drawing.Point(634, 194);
            this.endFileBtn.Name = "endFileBtn";
            this.endFileBtn.Size = new System.Drawing.Size(112, 34);
            this.endFileBtn.TabIndex = 16;
            this.endFileBtn.Text = "end File";
            this.endFileBtn.UseVisualStyleBackColor = true;
            this.endFileBtn.Click += new System.EventHandler(this.endFileBtn_Click);
            // 
            // closeFileBtn
            // 
            this.closeFileBtn.Enabled = false;
            this.closeFileBtn.Location = new System.Drawing.Point(634, 257);
            this.closeFileBtn.Name = "closeFileBtn";
            this.closeFileBtn.Size = new System.Drawing.Size(112, 34);
            this.closeFileBtn.TabIndex = 17;
            this.closeFileBtn.Text = "Close file";
            this.closeFileBtn.UseVisualStyleBackColor = true;
            this.closeFileBtn.Click += new System.EventHandler(this.closeFileBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.Red;
            this.ExitBtn.Location = new System.Drawing.Point(665, 404);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(112, 34);
            this.ExitBtn.TabIndex = 18;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.closeFileBtn);
            this.Controls.Add(this.endFileBtn);
            this.Controls.Add(this.startFileBtn);
            this.Controls.Add(this.clearFomBtn);
            this.Controls.Add(this.squezzeBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.readBtn);
            this.Controls.Add(this.insertBtn);
            this.Controls.Add(this.openfileBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.balance);
            this.Controls.Add(this.ID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox ID;
        private TextBox balance;
        private TextBox LastName;
        private TextBox firstName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button openfileBtn;
        private Button insertBtn;
        private Button readBtn;
        private Button searchBtn;
        private Button deleteBtn;
        private Button squezzeBtn;
        private Button clearFomBtn;
        private Button startFileBtn;
        private Button endFileBtn;
        private Button closeFileBtn;
        private Button ExitBtn;
    }
}