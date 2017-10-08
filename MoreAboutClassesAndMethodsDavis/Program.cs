using System;

namespace MoreAboutClassesAndMethodsDavis
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Car myCar = new Car();
            ///Whenever this line of code is executed, the .net framework has
            /// to go and create a spot in the computer's memory large enough to
            /// hold a new instance of the car class.
            ///The computer has addresses in its memory like street addresses
            /// where it temporarily stores values during the lifetime of a 
            /// variable or an object.
            /// The Memory must be large enough for the particular data type
            /// and uses an address for it for use. Every time you access myCar
            /// you just have a reference to a place in the computer's memory.
            /// You have "The handle to the bucket"
            /// NOTE: the .net framework goes through memory once in a while 
            /// by counting references, so if we are no longer holding onto a 
            /// reference, then it will remove data stored in that spot in computer's 
            /// memory. This process is called 'garbage collection.'

            // set myCar's properties

            Car myOtherCar = myCar;
            ///This is two reference to same object in memory. Though you did not
            /// create a new instance of a class, just set it equal. Two references 
            /// to same object, aka two handles on same bucket, or two strings to
            /// one balloon. Garbage collection will remove things without something
            /// 'pointing'/referencing to it. 

            // myOtherCar = null;
            // myCar = null;
            //At somepoint in the future when code hits 'null', those objects will
            //be removed from memory. No set amount of time, indeterminate.

            //At some point in the future, you must learn about deterministic finalization
            //but it is advanced. Can use internet search

            ///Notice '()' on second car, () is the method invokation operator.
            /// You are creating a new method every time you create an instance of
            /// the class. This method is refered to as a 'constructor', and it allows
            /// the developer to write some code at the moment of instantiation
            /// or the moment when a new instance of that class is created.
            /// Constructors can put that new instance of that class into a valid state.

            ///Overloaded constructors: (see below) but now every time you create an 
            /// instance of car, you get two versions of the method which can
            /// be seen with the up down arrow keys while writing the new class
            /// during the typing of the '()'
            /// The first version takes no parameters, while the second take 4 input
            /// parameters. Helps put new intance of class in a valid state to begin with
            /// (see below)
            Car myThirdCar = new Car("Ford", "Escape", 2005, "White");

            //If we were to create an overloaded method that conflicts with existing
            //constructor(two of the same public car like below). If we try to run our
            //code, you will get an error because the car class already defines a member
            //of car with the same parameter type. Method's signatures MUST be different!
            //While the name didn't change, the data type didn't change.
            //Parameter names don't affect method signature! Just the data types and the number
            //of parameters

            //if not personally created, a default constructor with no input parameters
            //and no body will be created automatically for you. And it will do nothing
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
        public double originalPrice
        {
            get;
            set;
        }

        public Car()
        {
            //you could load this from a configuration file, a database, etc.
            // I'll just harcode in this instance
            this.Make = "Nissan";//now every instance of a car class is set to Make = "Nissan"
        }

        public Car(string make, string model, int year, string color)
        {
            //Overloaded constructor example
            Make = make;
            Model = model;
            Year = year;
            Color = color;
        }
        /*
		public Car(string someOtherInputParameter, string model, int year, string color)
		{
            Make = someOtherInputParameter;
			Model = model;
			Year = year;
			Color = color;
		}
		*/
    }
}
