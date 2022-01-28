using System;
using System.Collections.Generic;
using System.Text;

namespace Open_Lab_11._00
{
    class Library
    {
        public int numberOfBooks;
        public int numbersOfStudents;
        private List<string> studentsList = new List<string>();
        private List<Book> booksList = new List<Book>();

        public void AddBook(Book book)
        {
            booksList.Add(book);
        }

        public void RemoveBook(string nameOfBookToRemove)
        {
            Book bookToRemove = null;
            foreach (Book book in booksList)
            {
                if (book.Title == nameOfBookToRemove)
                {
                    bookToRemove = book;
                }
            }

            booksList.Remove(bookToRemove);
        }

        public void AddStudent(string nameOfStudent)
        {
            studentsList.Add(nameOfStudent);
        }

        public override string ToString()
        {
            string output;

            numberOfBooks = booksList.Count;
            numbersOfStudents = studentsList.Count;
            

            output = "Number of students:" + numbersOfStudents + "\n";
            output += "Number of books:" + numberOfBooks + "\n";

            output += "\n" + "Customers:" + "\n";

            output += "\n" + studentsList[0];
            for (int i = 0; i < 2; i++)
            {
                output += "\n" + booksList[i];
            }

            output += "\n" + "\n" + studentsList[1];
            for (int i = 2; i < 4; i++)
            {
                output += "\n" + booksList[i];
            }

            return output;
        }

    }
}
