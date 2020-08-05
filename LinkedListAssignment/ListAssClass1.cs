using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListAssignment
{

    class Person
    {
        int age;
        string fname;
        string lname;
        string city;
        public Person()
        {

        }
        public Person(int _age,string _fname,string _lname,string _city)
        {
            age = _age;
            fname = _fname;
            lname = _lname;
            city = _city;

        }
        public void DisplayPerson()
        {
            Console.WriteLine("Age :{0}", age);
            Console.WriteLine("FirstName:{0}", fname);
            Console.WriteLine("LastName:{0}", lname);
            Console.WriteLine("City:{0}", city);
        }


    }
    class ListAssClass1
    {
        public static void Main()
        {
           // List<Person>  = new List<Person>();
            List<Person> P = new List<Person>();
            Person Per = new Person(21,"Lohitha","Anumala","Vjayawada");


            Person per2 = new Person(21, "Asmin", "Shaik", "Tadepalli");
            Per.DisplayPerson();
            P.Add(per2);
            per2.DisplayPerson();



            

           
        }
    }
}
