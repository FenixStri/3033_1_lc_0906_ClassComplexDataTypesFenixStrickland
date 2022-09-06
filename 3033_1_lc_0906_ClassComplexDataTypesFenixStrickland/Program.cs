//Fenix Strickland
//Class Complex DataTypes


int i;
string str;

str = new string("Fenix Strickland This is a str"); //102
str = "another str"; //103

i = 20;


HotelRoom hm;
hm = new HotelRoom();//110

hm = new HotelRoom(2, false); //112
HotelRoom hm2;
hm2 = hm; //112

HotelRoom hm1 = new HotelRoom(3, true);



hm.nBeds = 2;

// complex datatype
// string 
string str2 = new string("str1");
str2 = "sTR2 this is mis 3033 001";

// DateTime TimeSpan

DateTime dt1;
dt1 = new DateTime();

dt1 = DateTime.Now;

DateTime dt2 = new DateTime(2000,2,20,8,30,0);

TimeSpan ts1 = dt1 - dt2;



Console.ReadLine();

//memberfields
//

public class HotelRoom
{
    // overload vs override
    //member function = every room has 1
    public HotelRoom()
    {

    }
    // this
    public HotelRoom(int nBeds, bool canSmoke) //overload
    {
        this.nBeds = nBeds;
        this.canSmoke = canSmoke;

    }

    //datatype1 function_name()
    //{
    //    ...
    //    return var;
    //}
    //member fields
   public int nBeds;
   public bool canSmoke;
   public string coffeeMachine;
   public static string restaurant;
}