using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartDocSystem
{
    public partial class SmartDocSystem : Form
    {
        public SmartDocSystem()
        {
            InitializeComponent();
            GroupBox fieldgrp = CreateGroupBox();
            this.mainLayoutPanel.Controls.Add(fieldgrp);
        }
        
        private void Plusbtn_Click_1(object sender, EventArgs e)
        {
            GroupBox fieldgrp = CreateGroupBox();
            this.mainLayoutPanel.Controls.Add(fieldgrp);
            
        }

        private GroupBox CreateGroupBox()
        {
            GroupBox newGrpBox = new GroupBox();
            CheckBox checkBox1 = new CheckBox();
            ComboBox comboBox1 = new ComboBox();
            Label label1 = new Label();
            Label label2 = new Label();
            ComboBox comboBox2 = new ComboBox();
            TextBox textBox2 = new TextBox();
            Label label3 = new Label();

            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new System.Drawing.Point(742, 37);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new System.Drawing.Size(122, 21);
            checkBox1.TabIndex = 16;
            checkBox1.Text = "Required Field";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox1.Items.AddRange(new object[] {
            "Short Answer",
            "Paragraph Answer"});
            comboBox1.Location = new System.Drawing.Point(581, 37);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(151, 24);
            comboBox1.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(490, 40);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(94, 17);
            label1.TabIndex = 14;
            label1.Text = "Answer Type:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(281, 41);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(69, 17);
            label2.TabIndex = 13;
            label2.Text = "Datatype:";
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] {
            "Integer",
            "Double",
            "String"});
            comboBox2.Location = new System.Drawing.Point(353, 39);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new System.Drawing.Size(121, 24);
            comboBox2.TabIndex = 12;
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(89, 41);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(175, 22);
            textBox2.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(4, 41);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(83, 17);
            label3.TabIndex = 10;
            label3.Text = "Field Name:";

            // 
            // FieldGrp
            // 
            newGrpBox.Controls.Add(checkBox1);
            newGrpBox.Controls.Add(comboBox1);
            newGrpBox.Controls.Add(label1);
            newGrpBox.Controls.Add(label2);
            newGrpBox.Controls.Add(comboBox2);
            newGrpBox.Controls.Add(textBox2);
            newGrpBox.Controls.Add(label3);
            newGrpBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            newGrpBox.Location = new System.Drawing.Point(114, 90);
            newGrpBox.Name = "FieldGrp";
            newGrpBox.Size = new System.Drawing.Size(870, 100);
            newGrpBox.TabIndex = 10;
            newGrpBox.TabStop = false;
            newGrpBox.Text = "Field";
            return newGrpBox;
        }
        
    }


    public static class ControlExtensions
    {
        public static T Clone<T>(this T controlToClone)
            where T : Control
        {
            PropertyInfo[] controlProperties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            T instance = Activator.CreateInstance<T>();

            foreach (PropertyInfo propInfo in controlProperties)
            {
                if (propInfo.CanWrite)
                {
                    if (propInfo.Name != "WindowTarget")
                        propInfo.SetValue(instance, propInfo.GetValue(controlToClone, null), null);
                }
            }

            return instance;
        }
    }
}
