namespace SmartDocSystem
{
    partial class SmartDocSystem
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
            this.Title = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Plusbtn = new System.Windows.Forms.Button();
            this.Createbtn = new System.Windows.Forms.Button();
            this.Cancelbtn = new System.Windows.Forms.Button();
            this.mainLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.URLlbl = new System.Windows.Forms.Label();
            this.URLtxtbx = new System.Windows.Forms.TextBox();
            this.FieldGrp = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.mainLayoutPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Title.Enabled = false;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Title.Location = new System.Drawing.Point(119, 12);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(1213, 49);
            this.Title.TabIndex = 1;
            this.Title.Text = "Smart Document System";
            this.Title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(2, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(63, 15);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Tool Box";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.Plusbtn);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(8, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(69, 162);
            this.panel1.TabIndex = 3;
            // 
            // Plusbtn
            // 
            this.Plusbtn.Image = global::SmartDocSystem.Properties.Resources.plus_circular_mini_button_icon_REV;
            this.Plusbtn.Location = new System.Drawing.Point(8, 32);
            this.Plusbtn.Name = "Plusbtn";
            this.Plusbtn.Size = new System.Drawing.Size(45, 45);
            this.Plusbtn.TabIndex = 3;
            this.Plusbtn.UseVisualStyleBackColor = true;
            this.Plusbtn.Click += new System.EventHandler(this.Plusbtn_Click_1);
            // 
            // Createbtn
            // 
            this.Createbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Createbtn.Enabled = false;
            this.Createbtn.Location = new System.Drawing.Point(857, 530);
            this.Createbtn.Name = "Createbtn";
            this.Createbtn.Padding = new System.Windows.Forms.Padding(5);
            this.Createbtn.Size = new System.Drawing.Size(138, 33);
            this.Createbtn.TabIndex = 5;
            this.Createbtn.Text = "Create Smart Doc";
            this.Createbtn.UseVisualStyleBackColor = false;
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Cancelbtn.Location = new System.Drawing.Point(406, 530);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Padding = new System.Windows.Forms.Padding(5);
            this.Cancelbtn.Size = new System.Drawing.Size(75, 33);
            this.Cancelbtn.TabIndex = 6;
            this.Cancelbtn.Text = "Cancel";
            this.Cancelbtn.UseVisualStyleBackColor = false;
            // 
            // mainLayoutPanel
            // 
            this.mainLayoutPanel.AutoScroll = true;
            this.mainLayoutPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mainLayoutPanel.Controls.Add(this.groupBox1);
            this.mainLayoutPanel.Location = new System.Drawing.Point(119, 98);
            this.mainLayoutPanel.Name = "mainLayoutPanel";
            this.mainLayoutPanel.Size = new System.Drawing.Size(1213, 407);
            this.mainLayoutPanel.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.URLlbl);
            this.groupBox1.Controls.Add(this.URLtxtbx);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(973, 68);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // URLlbl
            // 
            this.URLlbl.AutoSize = true;
            this.URLlbl.Location = new System.Drawing.Point(6, 36);
            this.URLlbl.Name = "URLlbl";
            this.URLlbl.Size = new System.Drawing.Size(169, 17);
            this.URLlbl.TabIndex = 11;
            this.URLlbl.Text = "URL for housing XML file:";
            // 
            // URLtxtbx
            // 
            this.URLtxtbx.Location = new System.Drawing.Point(181, 31);
            this.URLtxtbx.Name = "URLtxtbx";
            this.URLtxtbx.Size = new System.Drawing.Size(780, 22);
            this.URLtxtbx.TabIndex = 12;
            // 
            // FieldGrp
            // 
            this.FieldGrp.Location = new System.Drawing.Point(0, 0);
            this.FieldGrp.Name = "FieldGrp";
            this.FieldGrp.Size = new System.Drawing.Size(200, 100);
            this.FieldGrp.TabIndex = 0;
            this.FieldGrp.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(742, 37);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(122, 21);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "Required Field";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Items.AddRange(new object[] {
            "Short Answer",
            "Paragraph Answer"});
            this.comboBox1.Location = new System.Drawing.Point(581, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 25);
            this.comboBox1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(490, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Answer Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Datatype:";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Integer",
            "Double",
            "String"});
            this.comboBox2.Location = new System.Drawing.Point(353, 39);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 25);
            this.comboBox2.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(89, 41);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(175, 22);
            this.textBox2.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Field Name:";
            // 
            // SmartDocSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1406, 606);
            this.Controls.Add(this.mainLayoutPanel);
            this.Controls.Add(this.Cancelbtn);
            this.Controls.Add(this.Createbtn);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.panel1);
            this.Name = "SmartDocSystem";
            this.Text = "SmartDocSystem";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.mainLayoutPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Createbtn;
        private System.Windows.Forms.Button Cancelbtn;
        private System.Windows.Forms.Button Plusbtn;
        private System.Windows.Forms.FlowLayoutPanel mainLayoutPanel;
        private System.Windows.Forms.GroupBox FieldGrp;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label URLlbl;
        private System.Windows.Forms.TextBox URLtxtbx;
    }
}

