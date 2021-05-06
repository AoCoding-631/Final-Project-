using System;
using System.Collections.Generic;

public class Author : Person
{
  List<Books> BookList = new List<Books>();

  public string Id { get; set; }
  public string FirstName{get; set;}
  public string LastName {get; set;}
  public string Email {get; set;}  
  
  
  public Author() : base()
  {
    Console.WriteLine("Author constructor");
  }

  public Author(string fname, string lname, string email) : base(fname, lname)
  {
        FirstName = fname;
        LastName = lname;  
        Email = email;
        Console.WriteLine("Author constructor");

      }


  public override string ToString()
  {
  return "Book: " + title + " Author: " + Author;
  }


 public void AddBooks(Book b1) {
          AddBook a = new AddBook(b1);
          BookList.Add(a);
          Console.WriteLine("Book added");
        }

        public void DisplayInfo(Book b1)
        {
           BookList.SingleOrDefault(a=>a.BookAdded.Id == a.Id).Status="Book info";
        }

         public void DisplayBooks(Book b1)
        {
           BookList a = BookList.Find(a=>a.BookAdded.Id == a.Id);
           Booklist.Remove(a);
        }
         public void TypeText RemoveBook(string ISBN)
        {
           BookList a = BookList.Find(a=>a.BookAdded.Id == a.Id);
           Booklist.Remove(a);
        }
         
  public override void Intro()
  {
    base.Intro();
    Console.WriteLine("current read:  " + Book);
  }
}