using ChainOfResponsibilityDesignPattern;
using CompositeDesignPattern;
using FacadeDesignPattern;
using FactoryMethodDesignPattern;
using Singleton;

#if false
#region  Singleton
Parallel.Invoke(
			() =>
			{
				SingletonDemo fromTeachaer = SingletonDemo.GetInstance();
				fromTeachaer.PrintDetails("From Teacher");
			},
			() =>
			{
				//Call the GetInstance static method to get the Singleton Instance
				SingletonDemo fromStudent = SingletonDemo.GetInstance();
				fromStudent.PrintDetails("From Student");
			}

);

 Console.WriteLine("Please select the convertor direction");
        Console.WriteLine("1. From Celsius to Fahrenheit.");
        Console.WriteLine("2. From Fahrenheit to Celsius.");
        Console.Write(":");
        string selection = Console.ReadLine();	
        double F, C = 0;
        switch (selection)
        {
            case "1":
                Console.Write("Please enter the Celsius temperature: ");
                F = TemperatureConverter.CelsiusToFahrenheit(Console.ReadLine());
                Console.WriteLine("Temperature in Fahrenheit: {0:F2}", F);
                break;
            case "2":
                Console.Write("Please enter the Fahrenheit temperature: ");
                C = TemperatureConverter.FahrenheitToCelsius(Console.ReadLine());
                Console.WriteLine("Temperature in Celsius: {0:F2}", C);
                break;
            default:
                Console.WriteLine("Please select a convertor.");
                break;
        }
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();

#endregion
#endif

#if false
#region  Factory Method

            // The client code works with an instance of a concrete creator
            // The CreateProduct will return the actual product instance via the product interface
            //PlatinumFactory CreateProduct method will return an instance of Platinum Product via the CreditCard interface
            CreditCard creditCard = new TitaniumFactory().CreateProduct();
            if (creditCard != null)
            {
                Console.WriteLine("Card Type : " + creditCard.GetCardType());
                Console.WriteLine("Credit Limit : " + creditCard.GetCreditLimit());
                Console.WriteLine("Annual Charge :" + creditCard.GetAnnualCharge());
            }
            else
            {
                Console.Write("Invalid Card Type");
            }
            Console.WriteLine("--------------");
            //MoneyBackFactory CreateProduct method will return an instance of Platinum Product via the CreditCard interface
            creditCard = new MoneyBackFactory().CreateProduct();
            if (creditCard != null)
            {
                Console.WriteLine("Card Type : " + creditCard.GetCardType());
                Console.WriteLine("Credit Limit : " + creditCard.GetCreditLimit());
                Console.WriteLine("Annual Charge :" + creditCard.GetAnnualCharge());
            }
            else
            {
                Console.Write("Invalid Card Type");
            }
            Console.ReadLine();
        
#endregion
#endif

#if false
#region  Composite Design pattern 
             // The client code works with all of the components (Both Leaf and Composite) via the base interface i.e. IComponent.
            // IComponent means the class that implements the IComponent Interface
            //Creating Leaf Objects or you can say child objects
            IComponent hardDisk = new Leaf("Hard Disk", 2000);
            IComponent ram = new Leaf("RAM", 3000);
            IComponent cpu = new Leaf("CPU", 2000);
            IComponent mouse = new Leaf("Mouse", 2000);
            IComponent keyboard = new Leaf("Keyboard", 2000);
            //Creating Composite Objects
            Composite motherBoard = new Composite("MotherBoard");
            Composite cabinet = new Composite("Cabinet");
            Composite peripherals = new Composite("Peripherals");
            Composite computer = new Composite("Computer");
            //Creating Tree Structure i.e. Adding Child Components inside the Composite Component
            //Adding CPU and RAM in Mother Board
            motherBoard.AddComponent(cpu);
            motherBoard.AddComponent(ram);
            //Adding Mother Board and Hard Disk in Cabinet
            cabinet.AddComponent(motherBoard);
            cabinet.AddComponent(hardDisk);
            //Adding Mouse and Keyboard in peripherals
            peripherals.AddComponent(mouse);
            peripherals.AddComponent(keyboard);
            //Adding Cabinet and Peripherals in Computer
            computer.AddComponent(cabinet);
            computer.AddComponent(peripherals);
            //To Display the Price of the Computer i.e. it will display the Price of all components
            Console.WriteLine("Price of Computer Composite Components");
            computer.DisplayPrice();
            // //To display the Price of the Keyboard
            Console.WriteLine("\nPrice of Keyboard Child or Leaf Component:");
            keyboard.DisplayPrice();
            
            // //To display the Price of the Cabinet
            Console.WriteLine("\nPrice of Cabinet Composite Component:");
            cabinet.DisplayPrice();
            // Console.Read();
#endregion
#endif

#if false
#region  Composite pattern
            Order order = new ();
            order.PlaceOrder();
            Console.Read();
#endregion
#endif

            ATM atm = new ();
            Console.WriteLine("Requested Amount 4600");
            atm.Withdraw(4600);
            // Console.WriteLine("\nRequested Amount 1900");
            // atm.Withdraw(1900);
            // Console.WriteLine("\nRequested Amount 600");
            // atm.Withdraw(600);
            // Console.WriteLine("\nRequested Amount 750");
            // atm.Withdraw(750);
            Console.Read();