using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Library");
    
    Console.WriteLine("New book");
    Book b1 = new Book();
    b1.FirstName = "JK";
    b1.LastName="Rowling";
    b1.PublishedOn = Convert.ToDateTime("01/01/1997");
    b1.Intro();
    b1.Display();

    Book b1 = new Book("IT1050", "Programming Logic", 3, "Online");
    Book b2 = new Course("IT1150", "Intro to Web Programming", 3, "In-Person");
    Book b3 = new Course("IT2650", "Intro to Java Programming", 4, "In-Person");
    Book b4 = new Course("IT1025", "Intro to Computers", 3, "Blended");
    Book b5 = new Course("IT2030", "Intro to ASP Programming", 3, "Online");

    librarycollection();
    AddPatron();
    DisplayPatronInfo();
    RemovePatron();
    DisplayPatronInfo();

  }
}