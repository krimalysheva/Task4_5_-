namespace Task6
{
    partial class AddBook
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
            this.Create_RunBttn = new System.Windows.Forms.Button();
            this.BooksDGV = new System.Windows.Forms.DataGridView();
            this.property = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BooksDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // Create_RunBttn
            // 
            this.Create_RunBttn.Location = new System.Drawing.Point(194, 382);
            this.Create_RunBttn.Name = "Create_RunBttn";
            this.Create_RunBttn.Size = new System.Drawing.Size(75, 23);
            this.Create_RunBttn.TabIndex = 0;
            this.Create_RunBttn.Text = "Выполнить";
            this.Create_RunBttn.UseVisualStyleBackColor = true;
            this.Create_RunBttn.Click += new System.EventHandler(this.Create_RunBttn_Click);
            // 
            // BooksDGV
            // 
            this.BooksDGV.AllowUserToAddRows = false;
            this.BooksDGV.AllowUserToDeleteRows = false;
            this.BooksDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BooksDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.property,
            this.value});
            this.BooksDGV.Location = new System.Drawing.Point(38, 23);
            this.BooksDGV.Name = "BooksDGV";
            this.BooksDGV.Size = new System.Drawing.Size(422, 344);
            this.BooksDGV.TabIndex = 1;
            // 
            // property
            // 
            this.property.HeaderText = "property";
            this.property.Name = "property";
            // 
            // value
            // 
            this.value.HeaderText = "value";
            this.value.Name = "value";
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 450);
            this.Controls.Add(this.BooksDGV);
            this.Controls.Add(this.Create_RunBttn);
            this.Name = "AddBook";
            this.Text = "AddBook";
            this.Load += new System.EventHandler(this.AddBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BooksDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Create_RunBttn;
        private System.Windows.Forms.DataGridView BooksDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn property;
        private System.Windows.Forms.DataGridViewTextBoxColumn value;
    }
}