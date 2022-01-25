using System;
using System.Collections.Generic;
using System.Text;

namespace Open_Lab_11._00
{

    public class Book
    {
        public static List<string> categoryList = new List<string>() { "detské", "romantické", "náučné", "sci-fi", "dobrodružné" };
        private string title;
        private int pages;
        private string category;
        private string author;
        private int releaseDate;


        public Book()
        {
            title = "-1";
            pages = -1;
            category = "-1";
            author = "-1";
            releaseDate = -1;
        }
        public Book(string title, int pages)
        {
            this.title = title;
            this.pages = pages;
            category = "-1";
            author = "-1";
            releaseDate = -1;
        }
        public Book(string title, int pages, string category, string author, int releaseDate)
        {
            this.title = title;
            this.pages = pages;
            this.category = category;
            this.author = author;
            this.releaseDate = releaseDate;
        }



        public void Title(string NewTitle)
        {
            title = NewTitle;
        }
        public void Pages(int NewPages)
        {
            pages = NewPages;
            if (pages < 0)
            {
                pages = 1;
            }
        }
        public string Category { get; set; }
        public void Author(string NewAuthor)
        {
            author = NewAuthor;
        }
        public void ReleaseDate(int NewReleaseDate)
        {
            releaseDate = NewReleaseDate;
            if (releaseDate < 1450 || releaseDate > 2021)
            {
                releaseDate = -1;
            }
        }

        public override string ToString()
        {
            string output = title + pages + category + author + releaseDate;
            return output;
        }

    }
}
