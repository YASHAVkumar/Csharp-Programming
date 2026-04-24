using System;
namespace Singleton
{
    public class SingletonDemo
    {
        //This variable value will be increment by 1 each time the object of the class is created
        private static int Counter = 0;

        //This variable is going to store the Singleton Instance
        // private static SingletonDemo Instance = null;
        // private static readonly object _lock = new();

        private static readonly Lazy<SingletonDemo> Instance = new(() => new SingletonDemo());

        //The following Static Method is going to return the Singleton Instance
        public static SingletonDemo GetInstance()
        {
            // if(Instance==null)  //check 1 
            // lock (_lock)
            // {
            // //If the variable instance is null, then create the Singleton instance 
            // //else return the already created singleton instance
            // //This version is not thread safe
            // Instance ??= new SingletonDemo(); //check 2
            // }
            // //Return the Singleton Instance
            // return Instance;
            return Instance.Value;
        }

        //Constructor is Private means, from outside the class we cannot create an instance of this class
        private SingletonDemo()
        {
            //Each Time the Constructor called, increment the Counter value by 1
            Counter++;
            Console.WriteLine("Counter Value " + Counter.ToString());
        }

        //The following can be accesed from outside of the class by using the Singleton Instance
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class Singleton
    {
        private static Singleton _instance;

        private Singleton() { }

        public static Singleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Singleton();
                }
                return _instance;
            }
        }

        public void DoSomething()
        {
            // Method implementation
        }
    }


public static class TemperatureConverter
{
    public static double CelsiusToFahrenheit(string temperatureCelsius)
    {
        // Convert argument to double for calculations.
        double celsius = Double.Parse(temperatureCelsius);

        // Convert Celsius to Fahrenheit.
        double fahrenheit = (celsius * 9 / 5) + 32;

        return fahrenheit;
    }

    public static double FahrenheitToCelsius(string temperatureFahrenheit)
    {
        // Convert argument to double for calculations.
        double fahrenheit = Double.Parse(temperatureFahrenheit);

        // Convert Fahrenheit to Celsius.
        double celsius = (fahrenheit - 32) * 5 / 9;

        return celsius;
    }
    }

}