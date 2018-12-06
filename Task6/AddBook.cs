using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Books.BL;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Task6
{
    public partial class AddBook : Form
    {
        public AddBook()
        {
           
        }

        Type newBook;
        Book book;
        public object result;
        public AddBook(Type tbook, object obj)
        {
            newBook = tbook;
            book = (Book)obj;
            InitializeComponent();
            PropertyInfo[] properties = newBook.GetProperties();
            BooksDGV.RowCount = properties.Length;
            for (int i = 0; i < properties.Length; i++)
            {
                BooksDGV[0, i].Value = properties[i].Name;
            }
        }

        private void AddBook_Load(object sender, EventArgs e)
        {
          
        }
       
        private void Create_RunBttn_Click(object sender, EventArgs e)
        {
            
            PropertyInfo[] properties = newBook.GetProperties();
            //Type t = newBook.MakeGenericType(newBook);
            int i = 0;
            if(properties.Length == 10)
            {
                book = new Encyclopedia();
                //+
                i = 2;
            }
           
            book.NameOfEdition = BooksDGV[1, i].Value.ToString();
            book.Title = BooksDGV[1, i + 1].Value.ToString();
            book.Author = BooksDGV[1, i + 2].Value.ToString();
            book.Genre = BooksDGV[1, i + 3].Value.ToString();
            book.Language = BooksDGV[1, i + 4].Value.ToString();
            book.AmountOfPages = Convert.ToInt32(BooksDGV[1, i + 5].Value.ToString());
            book.Year = Convert.ToInt32(BooksDGV[1, i + 6].Value.ToString());
            book.Price = Convert.ToInt32(BooksDGV[1, i + 7].Value.ToString());
            if (i > 0)
            {
                Encyclopedia enc = new Encyclopedia();
                enc = (Encyclopedia)book;
                enc.FieldOfStudy = BooksDGV[1, 0].Value.ToString();
                enc.SubjectSearch = Convert.ToBoolean(BooksDGV[1, 1].Value.ToString());
                result = enc;
            }
            else
                result = book;
            //Book nbook = (Book)Activator.CreateInstance(t);
        }
    }
}
