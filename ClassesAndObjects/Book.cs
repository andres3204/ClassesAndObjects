using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    internal class Book
    {
        public string title;
        public string name;
        public int pages;

        //Parameter with no arguments
        public Book()
        {

        }

        //Parameter with arguments
        public Book(string aTitle, string aName, int aPages)
        {
            title = aTitle;
            name = aName;
            pages = aPages;
        }
    }
}
