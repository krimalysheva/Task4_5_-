namespace Task6
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.BooksDGV = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Language = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountOfPages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameOfEdition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FieldOfStudy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectSearch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getInformationAboutBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getInformationAboutEditionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Run = new System.Windows.Forms.Button();
            this.BooksCB = new System.Windows.Forms.ComboBox();
            this.AddBttn = new System.Windows.Forms.Button();
            this.AFBttn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BooksDGV)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BooksDGV
            // 
            this.BooksDGV.AllowUserToAddRows = false;
            this.BooksDGV.AllowUserToDeleteRows = false;
            this.BooksDGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BooksDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BooksDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Author,
            this.Genre,
            this.Language,
            this.AmountOfPages,
            this.NameOfEdition,
            this.Year,
            this.Price,
            this.FieldOfStudy,
            this.SubjectSearch});
            this.BooksDGV.Location = new System.Drawing.Point(168, 23);
            this.BooksDGV.Name = "BooksDGV";
            this.BooksDGV.ReadOnly = true;
            this.BooksDGV.Size = new System.Drawing.Size(1035, 487);
            this.BooksDGV.TabIndex = 2;
            // 
            // Title
            // 
            this.Title.HeaderText = "Название";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // Author
            // 
            this.Author.HeaderText = "Автор";
            this.Author.Name = "Author";
            this.Author.ReadOnly = true;
            // 
            // Genre
            // 
            this.Genre.HeaderText = "Жанр";
            this.Genre.Name = "Genre";
            this.Genre.ReadOnly = true;
            // 
            // Language
            // 
            this.Language.HeaderText = "Язык";
            this.Language.Name = "Language";
            this.Language.ReadOnly = true;
            // 
            // AmountOfPages
            // 
            this.AmountOfPages.HeaderText = "Количество страниц";
            this.AmountOfPages.Name = "AmountOfPages";
            this.AmountOfPages.ReadOnly = true;
            // 
            // NameOfEdition
            // 
            this.NameOfEdition.HeaderText = "Название издания";
            this.NameOfEdition.Name = "NameOfEdition";
            this.NameOfEdition.ReadOnly = true;
            // 
            // Year
            // 
            this.Year.HeaderText = "Год издания";
            this.Year.Name = "Year";
            this.Year.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Цена";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // FieldOfStudy
            // 
            this.FieldOfStudy.HeaderText = "Область исследования";
            this.FieldOfStudy.Name = "FieldOfStudy";
            this.FieldOfStudy.ReadOnly = true;
            // 
            // SubjectSearch
            // 
            this.SubjectSearch.HeaderText = "Предметный указатель";
            this.SubjectSearch.Name = "SubjectSearch";
            this.SubjectSearch.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1203, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getInformationAboutBookToolStripMenuItem,
            this.getInformationAboutEditionToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // getInformationAboutBookToolStripMenuItem
            // 
            this.getInformationAboutBookToolStripMenuItem.Name = "getInformationAboutBookToolStripMenuItem";
            this.getInformationAboutBookToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.getInformationAboutBookToolStripMenuItem.Text = "Get information about book";
            // 
            // getInformationAboutEditionToolStripMenuItem
            // 
            this.getInformationAboutEditionToolStripMenuItem.Name = "getInformationAboutEditionToolStripMenuItem";
            this.getInformationAboutEditionToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.getInformationAboutEditionToolStripMenuItem.Text = "Get information about edition";
            // 
            // Run
            // 
            this.Run.Location = new System.Drawing.Point(48, 204);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(75, 23);
            this.Run.TabIndex = 4;
            this.Run.Text = "button1";
            this.Run.UseVisualStyleBackColor = true;
            this.Run.Click += new System.EventHandler(this.Run_Click);
            // 
            // BooksCB
            // 
            this.BooksCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BooksCB.FormattingEnabled = true;
            this.BooksCB.Location = new System.Drawing.Point(24, 60);
            this.BooksCB.Name = "BooksCB";
            this.BooksCB.Size = new System.Drawing.Size(121, 21);
            this.BooksCB.TabIndex = 5;
            // 
            // AddBttn
            // 
            this.AddBttn.Location = new System.Drawing.Point(48, 96);
            this.AddBttn.Name = "AddBttn";
            this.AddBttn.Size = new System.Drawing.Size(75, 23);
            this.AddBttn.TabIndex = 6;
            this.AddBttn.Text = "Add";
            this.AddBttn.UseVisualStyleBackColor = true;
            this.AddBttn.Click += new System.EventHandler(this.AddBttn_Click);
            // 
            // AFBttn
            // 
            this.AFBttn.Location = new System.Drawing.Point(48, 138);
            this.AFBttn.Name = "AFBttn";
            this.AFBttn.Size = new System.Drawing.Size(75, 23);
            this.AFBttn.TabIndex = 7;
            this.AFBttn.Text = "AssemblyForm";
            this.AFBttn.UseVisualStyleBackColor = true;
            this.AFBttn.Click += new System.EventHandler(this.AFBttn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1203, 505);
            this.Controls.Add(this.AFBttn);
            this.Controls.Add(this.AddBttn);
            this.Controls.Add(this.BooksCB);
            this.Controls.Add(this.Run);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.BooksDGV);
            this.Name = "MainForm";
            this.Text = "BookShop";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BooksDGV)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView BooksDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Language;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountOfPages;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameOfEdition;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn FieldOfStudy;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectSearch;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getInformationAboutBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getInformationAboutEditionToolStripMenuItem;
        private System.Windows.Forms.Button Run;
        private System.Windows.Forms.ComboBox BooksCB;
        private System.Windows.Forms.Button AddBttn;
        private System.Windows.Forms.Button AFBttn;
    }
}

