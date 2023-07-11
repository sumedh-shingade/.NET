using LMS;


public class Student:Person{

private string course;
private DateTime regisDate;
private int prn;

//default constructor

public Student(){
    
    this.course="CDAC";
    this.regisDate=new DateTime(2023,5,6);
    this.prn=100;
}
//parameterized constructor
public Student(string fname,string lname,DateTime bDate,string email,string course,DateTime rDate,int prn):base( fname,lname, bDate,email)
{

 
    this.course=course;
    this.regisDate=rDate;
    this.prn=prn;
}

public string Course{
get{return this.course ;}
set{this.course=value;}
}

public DateTime RegisDate{
    get{return this.regisDate;}
    set{this.regisDate=value;}
}

public int Prn{
get{return this.prn ;}
set{this.prn=value;}
}

public override string ToString(){
    return base.ToString()+" " +this.course+ " "+this.regisDate+" "+this.prn;
}



}
