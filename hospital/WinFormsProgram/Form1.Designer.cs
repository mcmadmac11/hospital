namespace WinFormsProgram
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
            this.components = new System.ComponentModel.Container();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxDoctorName = new System.Windows.Forms.TextBox();
            this.textBoxdate = new System.Windows.Forms.TextBox();
            this.textBoxtimeOfDay = new System.Windows.Forms.TextBox();
            this.btnCreateAppt = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "AcceptButton", true));
            this.textBoxName.Location = new System.Drawing.Point(72, 22);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 0;
            this.textBoxName.Text = "Name";
            this.textBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // textBoxDoctorName
            // 
            this.textBoxDoctorName.Location = new System.Drawing.Point(72, 72);
            this.textBoxDoctorName.Name = "textBoxDoctorName";
            this.textBoxDoctorName.Size = new System.Drawing.Size(100, 20);
            this.textBoxDoctorName.TabIndex = 1;
            this.textBoxDoctorName.Text = "Doctor Name";
            this.textBoxDoctorName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxDoctorName.TextChanged += new System.EventHandler(this.textBoxDoctorName_TextChanged);
            // 
            // textBoxdate
            // 
            this.textBoxdate.Location = new System.Drawing.Point(72, 125);
            this.textBoxdate.Name = "textBoxdate";
            this.textBoxdate.Size = new System.Drawing.Size(100, 20);
            this.textBoxdate.TabIndex = 2;
            this.textBoxdate.Text = "Select Date";
            this.textBoxdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxdate.TextChanged += new System.EventHandler(this.textBoxdate_TextChanged);
            // 
            // textBoxtimeOfDay
            // 
            this.textBoxtimeOfDay.Location = new System.Drawing.Point(72, 182);
            this.textBoxtimeOfDay.Name = "textBoxtimeOfDay";
            this.textBoxtimeOfDay.Size = new System.Drawing.Size(100, 20);
            this.textBoxtimeOfDay.TabIndex = 3;
            this.textBoxtimeOfDay.Text = "Time Of Day";
            this.textBoxtimeOfDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxtimeOfDay.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnCreateAppt
            // 
            this.btnCreateAppt.Location = new System.Drawing.Point(82, 208);
            this.btnCreateAppt.Name = "btnCreateAppt";
            this.btnCreateAppt.Size = new System.Drawing.Size(75, 23);
            this.btnCreateAppt.TabIndex = 4;
            this.btnCreateAppt.Text = "Create Appt";
            this.btnCreateAppt.UseVisualStyleBackColor = true;
            this.btnCreateAppt.Click += new System.EventHandler(this.btnCreateAppt_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(WinFormsProgram.Form1);
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 320);
            this.Controls.Add(this.btnCreateAppt);
            this.Controls.Add(this.textBoxtimeOfDay);
            this.Controls.Add(this.textBoxdate);
            this.Controls.Add(this.textBoxDoctorName);
            this.Controls.Add(this.textBoxName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxDoctorName;
        private System.Windows.Forms.TextBox textBoxdate;
        private System.Windows.Forms.TextBox textBoxtimeOfDay;
        private System.Windows.Forms.Button btnCreateAppt;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}

