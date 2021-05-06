using System;

class LibraryCollection{

  private string PatronList;
  public string BookList;

}    

List<Patron> PatronList = new List<Patron>();
{
  Patron.Add(new Patron() {PatronName="How to cook", Id=1234});
        Patron.Add(new Patron() { PatronName = "how to clean", Id = 1334 });
        Patron.Add(new Patron() { PatronName= "how to wash clothes", Id = 1434 });
        Patron.Add(new Patron() {PatronName = "how to wash shoes", Id = 1534 });
        Patron.Add(new Patron() { PatronName = "how to wash hats", Id = 1634 });

        Console.WriteLine("Added successfully Tim Smith");

}
public void AddPatron()
        {
           Patron.Add(new Patron() {PatronName="Tim Smith", Id=1234});
          
          Console.WriteLine("Added successfully Tim Smith");

        }

public void RemovePatron()
        {
      Patron.Remove(new Patron() {PatronName="Joanna Carrier", Id=1334});

      Console.WriteLine("Removed successfully Joanna Carrier");

        }

public void	DisplayPatronInfo(){
     Console.WriteLine("Display Patron info: {0} {1} {2}", PatronList,BookList);
}

public void	AddToCollection(){
  BookList b = new BookList(b);
          BookList.Add(b);
  Console.WriteLine("Added successfully");

}
public void	RemoveFromCollection(){
     Patron p= PatronList.Find(p=>p.BookList == p);
      BookList.Remove(p);

  Console.WriteLine("Removed successfully");
}

public void	DisplayCollection(){
  foreach(PatronList p in BookList)
  {
     Console.WriteLine("Display Collection info: {0} {1} {2}", PatronList,BookList);
    
}
public void	ProcessRental(){

  Patron = Console.ReadLine();
  foreach(Rentalcart in Patron p)
  {
    Console.WriteLine("Course info: {0} {1} {2}",PatronList,BookList);

}
public void	ProcessRetuns(){

  Patron = Console.ReadLine();
  Book = Console.ReadLine();

}
}