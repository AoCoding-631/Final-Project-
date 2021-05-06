using Systems;
using System.Collections.Generic;
using System.Linq;

class Patron : Person
{
  public string FirstName;
  public string LastName;
  public string LibraryId;
	public string DateTime StartDate;
	public string DateTime EndDate;
	public bool IsAccountActive;
  public int FineAmountDue;
  public string RentalCart;

}
public Patron() 
        {
          Patron = new Patron();
          Console.WriteLine("Patron constructor");
        }

        public Patron(string fname, string lname,string LibraryId) 
        {
          FirstName = fname;
          LastName = lname;
          LibraryId = id;
          FineAmountDue = 0;
          StartDate.Today;
          IsAccountActive = true;
        }


public Display(){

  Console.WriteLine("Patron ID : " + id + fname + lname);
}

public AddToRentalCart(){

  Console.WriteLine("Added to rental cart" "Patron" + fname,lname);
}

public RemoveFromRentalCart(){
  
  Console.WriteLine("Added to rental cart" "Patron" + fname,lname);
}

  }


