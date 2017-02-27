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

using SmartDocSystem;

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
        
        private void Plusbtn_Click(object sender, EventArgs e)
        {
            GroupBox fieldgrp = CreateGroupBox();
            this.mainLayoutPanel.Controls.Add(fieldgrp);
            
        }

        private GroupBox CreateGroupBox()
        {
            GroupBox newGrpBox = new GroupBox();
            CheckBox RequiredChkbx = new CheckBox();
            ComboBox AnswerTypeDDbx = new ComboBox();
            Label AnswerTypeLbl = new Label();
            Label DatatypeLbl = new Label();
            ComboBox DataTypeDDbx = new ComboBox();
            TextBox FieldNameTxtbx = new TextBox();
            Label FieldNameLbl = new Label();

            // 
            // checkBox1
            // 
            RequiredChkbx.AutoSize = true;
            RequiredChkbx.Location = new System.Drawing.Point(742, 37);
            RequiredChkbx.Name = "RequiredChkbx";
            RequiredChkbx.Size = new System.Drawing.Size(122, 21);
            RequiredChkbx.TabIndex = 16;
            RequiredChkbx.Text = "Required Field";
            RequiredChkbx.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            AnswerTypeDDbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            AnswerTypeDDbx.Items.AddRange(new object[] {
            "Short Answer",
            "Paragraph Answer"});
            AnswerTypeDDbx.Location = new System.Drawing.Point(581, 37);
            AnswerTypeDDbx.Name = "AnswerTypeDDbx";
            AnswerTypeDDbx.Size = new System.Drawing.Size(151, 24);
            AnswerTypeDDbx.TabIndex = 15;
            // 
            // label1
            // 
            AnswerTypeLbl.AutoSize = true;
            AnswerTypeLbl.Location = new System.Drawing.Point(490, 40);
            AnswerTypeLbl.Name = "AnswerTypeLbl";
            AnswerTypeLbl.Size = new System.Drawing.Size(94, 17);
            AnswerTypeLbl.TabIndex = 14;
            AnswerTypeLbl.Text = "Answer Type:";
            // 
            // label2
            // 
            DatatypeLbl.AutoSize = true;
            DatatypeLbl.Location = new System.Drawing.Point(281, 41);
            DatatypeLbl.Name = "DatatypeLbl";
            DatatypeLbl.Size = new System.Drawing.Size(69, 17);
            DatatypeLbl.TabIndex = 13;
            DatatypeLbl.Text = "Datatype:";
            // 
            // comboBox2
            // 
            DataTypeDDbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            DataTypeDDbx.FormattingEnabled = true;
            DataTypeDDbx.Items.AddRange(new object[] {
            "Integer",
            "String"});
            DataTypeDDbx.Location = new System.Drawing.Point(353, 39);
            DataTypeDDbx.Name = "DataTypeDDbx";
            DataTypeDDbx.Size = new System.Drawing.Size(121, 24);
            DataTypeDDbx.TabIndex = 12;
            // 
            // textBox2
            // 
            FieldNameTxtbx.Location = new System.Drawing.Point(89, 41);
            FieldNameTxtbx.Name = "FieldNameTxtbx";
            FieldNameTxtbx.Size = new System.Drawing.Size(175, 22);
            FieldNameTxtbx.TabIndex = 11;
            // 
            // label3
            // 
            FieldNameLbl.AutoSize = true;
            FieldNameLbl.Location = new System.Drawing.Point(4, 41);
            FieldNameLbl.Name = "FieldNameLbl";
            FieldNameLbl.Size = new System.Drawing.Size(83, 17);
            FieldNameLbl.TabIndex = 10;
            FieldNameLbl.Text = "Field Name:";

            // 
            // FieldGrp
            // 
            newGrpBox.Controls.Add(checkBox1);
            newGrpBox.Controls.Add(AnswerTypeDDbx);
            newGrpBox.Controls.Add(AnswerTypeLbl);
            newGrpBox.Controls.Add(DatatypeLbl);
            newGrpBox.Controls.Add(DataTypeDDbx);
            newGrpBox.Controls.Add(FieldNameTxtbx);
            newGrpBox.Controls.Add(FieldNameLbl);
            newGrpBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            newGrpBox.Location = new System.Drawing.Point(114, 90);
            newGrpBox.Name = "FieldGrp";
            newGrpBox.Size = new System.Drawing.Size(870, 100);
            newGrpBox.TabIndex = 10;
            newGrpBox.TabStop = false;
            newGrpBox.Text = "Field";
            return newGrpBox;
        }

        private void Createbtn_Click(object sender, EventArgs e)
        {
            // Validate that form has been fully filled out
            bool isFilledOut = true;
            var AllFieldTxtBxArr = this.Controls.Find("FieldNameTxtbx", true);
            var URLTxtbxArr = this.Controls.Find("URLtxtbx", true);
            var TableNameTxtbxArr = this.Controls.Find("TableNameTxtbx", true);
            var DataTypeDDbxArr = this.Controls.Find("DataTypeDDbx", true);
            var AnswerTypeDDbxArr = this.Controls.Find("AnswerTypeDDbx", true);
            foreach(var elem in AllFieldTxtBxArr)
            {
                if (string.IsNullOrWhiteSpace(elem.Text))
                    isFilledOut = false;
            }
            foreach (var elem in URLTxtbxArr)
            {
                if (string.IsNullOrWhiteSpace(elem.Text))
                    isFilledOut = false;
            }
            foreach (var elem in TableNameTxtbxArr)
            {
                if (string.IsNullOrWhiteSpace(elem.Text))
                    isFilledOut = false;
            }
            foreach (var elem in DataTypeDDbxArr)
            {
                if (string.IsNullOrWhiteSpace(elem.Text))
                    isFilledOut = false;
            }
            foreach (var elem in AnswerTypeDDbxArr)
            {
                if (string.IsNullOrWhiteSpace(elem.Text))
                    isFilledOut = false;
            }
            //if (isFilledOut)
            //{
            //    MessageBox.Show("You correctly filled out the form!");
            //    SmartDoc.MakeSmartDoc();
                
            //}
            //else
            //{
            //    MessageBox.Show("You DID NOT correctly filled out the form!");
            //}
            SmartDoc.MakeSmartDoc();
        }

        

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
