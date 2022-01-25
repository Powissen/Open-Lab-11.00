using System;

namespace Open_Lab_11._00
{
    class Program
    {
        public static void Main(string[] args)
        {
            Library schoolLibrary = new Library();

            schoolLibrary.studentsList.Add("John");
            Book HarryPotter = new Book("Harry Potter", 230, "novela", "J.K. Rowling", 2011);
            Book Martan = new Book("Marťan", 320, "sci-fi", "Andy Weir", 2015);
            schoolLibrary.NewBook("Harry Potter", "John");
            schoolLibrary.NewBook("Marťan", "John");


            schoolLibrary.studentsList.Add("Poul");
            Book TigriTim = new Book("Tigrí tím", 150, "dobrodružné", "Thomas Brezina", 2012);
            Book GrazlikGabo = new Book("Grázlik Gabo", 145, "detské", "Francesca Simonová", 2014);
            schoolLibrary.NewBook("TigriTim", "Poul");
            schoolLibrary.NewBook("Grázlik Gabo", "Poul");

            schoolLibrary.WriteAll();
        }
    }
}
