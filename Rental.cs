using Systems;
using System.Collections.Generic;
using System.Linq;

class Rental
{
  public string Book { get; set; }
  public string DateTime DateRented{get; set;}
  public string DateTime DateDue {get; set;}
}

public static void RentalCart{

List<Rental> RentalCart = new List<Rental>();
{
  Rental.Add(new Rental() {RentalName="How to cook", PartId=1234});
        Rental.Add(new Rental() { RentalName = "how to clean", PartId = 1334 });
        Rental.Add(new Rental() { RentalName= "how to wash clothes", PartId = 1434 });
        Rental.Add(new Rental() { RentalName = "how to wash shoes", PartId = 1534 });
        Rental.Add(new Rental() { RentalName = "how to wash hats", PartId = 1634 });

}
public Rental() 
        {
          Rental = new Rental();
          Console.WriteLine("Rental constructor");
        }

 public Rental(Book b1): this(b1,DateTime.Today)
    {            
    }


public Rental(string Book, string DateRented, string DateDue)
        {
          Book = book;
          DateRented = rented;
          DateDue = due;
        }


}