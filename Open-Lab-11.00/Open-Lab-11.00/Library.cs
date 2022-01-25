using System;
using System.Collections.Generic;
using System.Text;

namespace Open_Lab_11._00
{
    class Library
    {
        public int numberOfBooks;
        public int numbersOfStudents;
        public List<string> studentsList = new List<string>();
        public List<string> booksList = new List<string>();

        public void NewBook(string BookName, string Name)
        {
            booksList.Add(BookName);
            if (!studentsList.Contains(Name))
            {
                studentsList.Add(Name);
            }
        }

        public void WriteAll()
        {
            numberOfBooks = booksList.Count;
            numbersOfStudents = studentsList.Count;
            

            string stats = "Number of students:" + numbersOfStudents + "\n";
            stats += "Number of books:" + numberOfBooks + "\n";

            string title =  "\n" + "Customers:" + "\n";

            string Customer1 = "\n" + studentsList[0];
            for (int i = 0; i < 2; i++)
            {
                Customer1 += "\n" + booksList[i];
            }

            string Customer2 = "\n" + "\n" + studentsList[1];
            for (int i = 2; i < 4; i++)
            {
                Customer2 += "\n" + booksList[i];
            }


            string output = stats + title + Customer1 + Customer2;
            Console.WriteLine(output);
        }

    }
}
