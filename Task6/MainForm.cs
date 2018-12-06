using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Books.BL;

namespace Task6
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Assembly asm = typeof(IEdition).GetTypeInfo().Assembly;
            var types = asm.DefinedTypes.Where(x => x.ImplementedInterfaces.Contains(typeof(IEdition)));
            foreach (var type in types)
            {
                if (type.Name != "Book")
                    BooksCB.Items.Add(type);
            }
            BooksCB.SelectedIndex = 0;
            books = new List<Book>();
        }

        public List<Book> books;
        
        private void Run_Click(object sender, EventArgs e)
        {
            string toMB = "";
            //Type type = typeof(Book);

            //foreach (var str in output)
            //    toMB += str + ' ';
            
            //foreach(Type i in type.GetInterfaces())
            //{
            //    toMB += i.Name;
            //}
            //MessageBox.Show(toMB);


            //Assembly assembly = Assembly.GetAssembly(typeof(Book));
            //assembly.Location;
            Assembly asm = typeof(IEdition).GetTypeInfo().Assembly; 

            var types = asm.DefinedTypes.Where(x => x.ImplementedInterfaces.Contains(typeof(IEdition)));
            foreach (var type in types)
            {
                //do stuff 
                toMB+= type.Name + ' ' + '-' + ' ' + type.FullName +"\n";
            }
            MessageBox.Show(toMB);

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void AddBttn_Click(object sender, EventArgs e)
        {
            Type book = (Type)BooksCB.SelectedItem;
            //AddBook addBookForm = new AddBook(book);
            //addBookForm.Show();
        }

        private void AFBttn_Click(object sender, EventArgs e)
        {
            AssemblerForm asbF = new AssemblerForm(this);
            asbF.Show();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text files(.txt)|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string[] lines = System.IO.File.ReadAllLines(ofd.FileName, Encoding.GetEncoding("windows-1251"));
                books = Parsing.Parse(lines);
                PutInDGV(BooksDGV);
            }
        }
        public void UpDate(object obj)
        {
            books.Add((Book)obj);
            PutInDGV(BooksDGV);
        }
        private void PutInDGV(DataGridView DGV)
        {
            DGV.RowCount = books.Count + 1;
            for (int i = 0; i < books.Count; i++)
            {
                string[] input = books[i].ToStringM();
                for (int j = 0; j < 10; j++)
                {
                    DGV[j, i].Value = input[j];
                }
            }
        }
    }
}
