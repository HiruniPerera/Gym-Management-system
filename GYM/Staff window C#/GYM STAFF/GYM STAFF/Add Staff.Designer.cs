namespace GYM_STAFF
{
    partial class Add_Staff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Staff));
            this.btnHome1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxAdd = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSLastname = new System.Windows.Forms.TextBox();
            this.txtSAge = new System.Windows.Forms.TextBox();
            this.txtSContact = new System.Windows.Forms.TextBox();
            this.txtSFirstname = new System.Windows.Forms.TextBox();
            this.txtSEmail = new System.Windows.Forms.TextBox();
            this.txtSID = new System.Windows.Forms.TextBox();
            this.radioButtonAddFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonAddMale = new System.Windows.Forms.RadioButton();
            this.dateTimePickerAdd = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHome1
            // 
            this.btnHome1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome1.Image = ((System.Drawing.Image)(resources.GetObject("btnHome1.Image")));
            this.btnHome1.Location = new System.Drawing.Point(53, 43);
            this.btnHome1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHome1.Name = "btnHome1";
            this.btnHome1.Size = new System.Drawing.Size(60, 55);
            this.btnHome1.TabIndex = 81;
            this.btnHome1.UseVisualStyleBackColor = true;
            this.btnHome1.Click += new System.EventHandler(this.btnHome1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(287, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 46);
            this.label1.TabIndex = 80;
            this.label1.Text = "Add New Staff Members";
            // 
            // comboBoxAdd
            // 
            this.comboBoxAdd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAdd.FormattingEnabled = true;
            this.comboBoxAdd.Items.AddRange(new object[] {
            "Morning",
            "Aftenoon",
            "Evening",
            "Night"});
            this.comboBoxAdd.Location = new System.Drawing.Point(752, 336);
            this.comboBoxAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxAdd.Name = "comboBoxAdd";
            this.comboBoxAdd.Size = new System.Drawing.Size(232, 24);
            this.comboBoxAdd.TabIndex = 79;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.SeaGreen;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(600, 427);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(124, 52);
            this.btnClear.TabIndex = 78;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(307, 427);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(124, 52);
            this.btnAdd.TabIndex = 77;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSLastname
            // 
            this.txtSLastname.BackColor = System.Drawing.SystemColors.Window;
            this.txtSLastname.Location = new System.Drawing.Point(276, 268);
            this.txtSLastname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSLastname.Name = "txtSLastname";
            this.txtSLastname.Size = new System.Drawing.Size(232, 22);
            this.txtSLastname.TabIndex = 76;
            // 
            // txtSAge
            // 
            this.txtSAge.Location = new System.Drawing.Point(276, 379);
            this.txtSAge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSAge.Name = "txtSAge";
            this.txtSAge.Size = new System.Drawing.Size(232, 22);
            this.txtSAge.TabIndex = 75;
            this.txtSAge.TextChanged += new System.EventHandler(this.txtSAge_TextChanged);
            this.txtSAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSAge_KeyPress);
            // 
            // txtSContact
            // 
            this.txtSContact.Location = new System.Drawing.Point(752, 207);
            this.txtSContact.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSContact.Name = "txtSContact";
            this.txtSContact.Size = new System.Drawing.Size(244, 22);
            this.txtSContact.TabIndex = 74;
            this.txtSContact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSContact_KeyPress);
            // 
            // txtSFirstname
            // 
            this.txtSFirstname.Location = new System.Drawing.Point(276, 209);
            this.txtSFirstname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSFirstname.Name = "txtSFirstname";
            this.txtSFirstname.Size = new System.Drawing.Size(232, 22);
            this.txtSFirstname.TabIndex = 73;
            // 
            // txtSEmail
            // 
            this.txtSEmail.Location = new System.Drawing.Point(752, 148);
            this.txtSEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSEmail.Name = "txtSEmail";
            this.txtSEmail.Size = new System.Drawing.Size(244, 22);
            this.txtSEmail.TabIndex = 72;
            this.txtSEmail.Leave += new System.EventHandler(this.txtSEmail_Leave);
            // 
            // txtSID
            // 
            this.txtSID.Location = new System.Drawing.Point(276, 148);
            this.txtSID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSID.Name = "txtSID";
            this.txtSID.Size = new System.Drawing.Size(232, 22);
            this.txtSID.TabIndex = 71;
            // 
            // radioButtonAddFemale
            // 
            this.radioButtonAddFemale.AutoSize = true;
            this.radioButtonAddFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAddFemale.Location = new System.Drawing.Point(859, 262);
            this.radioButtonAddFemale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonAddFemale.Name = "radioButtonAddFemale";
            this.radioButtonAddFemale.Size = new System.Drawing.Size(95, 28);
            this.radioButtonAddFemale.TabIndex = 70;
            this.radioButtonAddFemale.TabStop = true;
            this.radioButtonAddFemale.Text = "Female";
            this.radioButtonAddFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonAddMale
            // 
            this.radioButtonAddMale.AutoSize = true;
            this.radioButtonAddMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAddMale.Location = new System.Drawing.Point(752, 262);
            this.radioButtonAddMale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonAddMale.Name = "radioButtonAddMale";
            this.radioButtonAddMale.Size = new System.Drawing.Size(72, 28);
            this.radioButtonAddMale.TabIndex = 69;
            this.radioButtonAddMale.TabStop = true;
            this.radioButtonAddMale.Text = "Male";
            this.radioButtonAddMale.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerAdd
            // 
            this.dateTimePickerAdd.Location = new System.Drawing.Point(276, 319);
            this.dateTimePickerAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerAdd.Name = "dateTimePickerAdd";
            this.dateTimePickerAdd.Size = new System.Drawing.Size(241, 22);
            this.dateTimePickerAdd.TabIndex = 68;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(584, 268);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 25);
            this.label11.TabIndex = 67;
            this.label11.Text = "Gender";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(85, 319);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 25);
            this.label10.TabIndex = 66;
            this.label10.Text = "Joined Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(584, 207);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 25);
            this.label9.TabIndex = 65;
            this.label9.Text = "Contact number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(584, 148);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 25);
            this.label8.TabIndex = 64;
            this.label8.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(127, 219);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 25);
            this.label7.TabIndex = 63;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(85, 377);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 25);
            this.label6.TabIndex = 62;
            this.label6.Text = "Age";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(584, 334);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 25);
            this.label5.TabIndex = 61;
            this.label5.Text = "Woking Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(85, 148);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 25);
            this.label4.TabIndex = 60;
            this.label4.Text = "Staff ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(85, 266);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 59;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 207);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 58;
            this.label2.Text = "First Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 36);
            this.panel1.TabIndex = 100;
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(977, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(43, 36);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(1020, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(43, 36);
            this.button3.TabIndex = 0;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Add_Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1067, 533);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnHome1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxAdd);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSLastname);
            this.Controls.Add(this.txtSAge);
            this.Controls.Add(this.txtSContact);
            this.Controls.Add(this.txtSFirstname);
            this.Controls.Add(this.txtSEmail);
            this.Controls.Add(this.txtSID);
            this.Controls.Add(this.radioButtonAddFemale);
            this.Controls.Add(this.radioButtonAddMale);
            this.Controls.Add(this.dateTimePickerAdd);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Add_Staff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Staff";
            this.Load += new System.EventHandler(this.Add_Staff_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHome1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtSLastname;
        private System.Windows.Forms.TextBox txtSAge;
        private System.Windows.Forms.TextBox txtSContact;
        private System.Windows.Forms.TextBox txtSFirstname;
        private System.Windows.Forms.TextBox txtSEmail;
        private System.Windows.Forms.TextBox txtSID;
        private System.Windows.Forms.RadioButton radioButtonAddFemale;
        private System.Windows.Forms.RadioButton radioButtonAddMale;
        private System.Windows.Forms.DateTimePicker dateTimePickerAdd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}