using System;
using System.Globalization;

  class Book
  {
        //Auto-implemented properties
        public string  ISBN { get; set; }
        public string  Title { get; set; }
        public virtual DateTime PublishedOn { get; set; }
        public string AuthorInfo { get; set; }
        public string PublishedBy { get; set; }
        

        public Book() 
        {
          //Book = new Book();
          Console.WriteLine("Book constructor");
        }

        public Book(string ISBN, string Title,string AuthorInfo) 
        {
          ISBN = ISBN;
          Title = Title;
          AuthorInfo = Author;
          //PermanentAddress = new Address();
          Console.WriteLine("Book constructor");
        }

    public Book(string ISBN, string Title,
    string AuthorInfo, string PublishedOn, string PublishedBy)  
        {  
           PublishedOn = DateTime.Now;
           PublishedBy ="Unknown";
        }        
        
       public void Display()
      {
        Console.WriteLine("Book info");
        Console.WriteLine(ISBN);
        Console.WriteLine(Title);
        Console.WriteLine(AuthorInfo);
        Console.WriteLine(PublishedOn);
        Console.WriteLine(PublishedBy);

        }
      }
    }