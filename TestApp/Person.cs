namespace LMS;


public class Person{

      private string firstName;
      private string lastName;
      private DateTime bDate;
      private string email;


//default constructor

public Person(){

this.firstName="sumedh";
this.lastName="shingade";
this.bDate=new DateTime(2000,09,01);
this.email="sumedhshingade1@gmail.com";
}

//parameterized constructor

public Person(string fname,string lname, DateTime birthDate,string email)
{
this.firstName=fname;
this.lastName=lname;
this.bDate=birthDate;
this.email=email;
}



  //getters and setters using classical 
	public void SetFirstName(string name){
	this.firstName=name;
}
public string GetFirstName()
{
	return this.firstName;

}



// getter abd setter using property
public string LastName{
        get{return this.lastName;}
        set{this.lastName=value;}
    }

public DateTime BDate{
get{return this.bDate;}
set{this.bDate=value;}
}

public string Email{
get{return this.email;}
set{this.email=value;}
}




//toString method
public override  string ToString(){
return this.firstName+" "+ lastName + " " +this.bDate +" "+this.email ;

}


}





