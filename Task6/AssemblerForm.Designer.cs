namespace Task6
{
    partial class AssemblerForm
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
            this.ClassesCB = new System.Windows.Forms.ComboBox();
            this.PropertiesCB = new System.Windows.Forms.ComboBox();
            this.ClassLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.InterfacesCB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ConstructorsCB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MethodsCB = new System.Windows.Forms.ComboBox();
            this.NewObjectBttn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClassesCB
            // 
            this.ClassesCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClassesCB.FormattingEnabled = true;
            this.ClassesCB.Location = new System.Drawing.Point(47, 42);
            this.ClassesCB.Name = "ClassesCB";
            this.ClassesCB.Size = new System.Drawing.Size(121, 21);
            this.ClassesCB.TabIndex = 0;
            this.ClassesCB.SelectedIndexChanged += new System.EventHandler(this.ClassesCB_SelectedIndexChanged);
            // 
            // PropertiesCB
            // 
            this.PropertiesCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PropertiesCB.FormattingEnabled = true;
            this.PropertiesCB.Location = new System.Drawing.Point(47, 119);
            this.PropertiesCB.Name = "PropertiesCB";
            this.PropertiesCB.Size = new System.Drawing.Size(121, 21);
            this.PropertiesCB.TabIndex = 1;
            this.PropertiesCB.SelectedIndexChanged += new System.EventHandler(this.PropertiesCB_SelectedIndexChanged);
            // 
            // ClassLabel
            // 
            this.ClassLabel.AutoSize = true;
            this.ClassLabel.Location = new System.Drawing.Point(85, 26);
            this.ClassLabel.Name = "ClassLabel";
            this.ClassLabel.Size = new System.Drawing.Size(32, 13);
            this.ClassLabel.TabIndex = 2;
            this.ClassLabel.Text = "Class";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Properties";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Interfaces";
            // 
            // InterfacesCB
            // 
            this.InterfacesCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InterfacesCB.FormattingEnabled = true;
            this.InterfacesCB.Location = new System.Drawing.Point(47, 193);
            this.InterfacesCB.Name = "InterfacesCB";
            this.InterfacesCB.Size = new System.Drawing.Size(121, 21);
            this.InterfacesCB.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Constructors";
            // 
            // ConstructorsCB
            // 
            this.ConstructorsCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ConstructorsCB.FormattingEnabled = true;
            this.ConstructorsCB.Location = new System.Drawing.Point(47, 268);
            this.ConstructorsCB.Name = "ConstructorsCB";
            this.ConstructorsCB.Size = new System.Drawing.Size(121, 21);
            this.ConstructorsCB.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Methods";
            // 
            // MethodsCB
            // 
            this.MethodsCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MethodsCB.FormattingEnabled = true;
            this.MethodsCB.Location = new System.Drawing.Point(47, 335);
            this.MethodsCB.Name = "MethodsCB";
            this.MethodsCB.Size = new System.Drawing.Size(121, 21);
            this.MethodsCB.TabIndex = 12;
            // 
            // NewObjectBttn
            // 
            this.NewObjectBttn.Location = new System.Drawing.Point(47, 404);
            this.NewObjectBttn.Name = "NewObjectBttn";
            this.NewObjectBttn.Size = new System.Drawing.Size(135, 23);
            this.NewObjectBttn.TabIndex = 13;
            this.NewObjectBttn.Text = "Create New Object";
            this.NewObjectBttn.UseVisualStyleBackColor = true;
            this.NewObjectBttn.Click += new System.EventHandler(this.NewObjectBttn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Methods Run";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AssemblerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NewObjectBttn);
            this.Controls.Add(this.MethodsCB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ConstructorsCB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.InterfacesCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ClassLabel);
            this.Controls.Add(this.PropertiesCB);
            this.Controls.Add(this.ClassesCB);
            this.Name = "AssemblerForm";
            this.Text = "AssemblerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ClassesCB;
        private System.Windows.Forms.ComboBox PropertiesCB;
        private System.Windows.Forms.Label ClassLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox InterfacesCB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ConstructorsCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox MethodsCB;
        private System.Windows.Forms.Button NewObjectBttn;
        private System.Windows.Forms.Button button1;
    }
}