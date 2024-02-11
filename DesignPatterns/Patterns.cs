using CodingInterviewSolutions.DesignPatterns.AbstractFactoryPattern.AbstractFactory;
using CodingInterviewSolutions.DesignPatterns.AbstractFactoryPattern.Interfaces;
using CodingInterviewSolutions.DesignPatterns.AdapterPattern;
using CodingInterviewSolutions.DesignPatterns.BridgePattern.Solution;
using CodingInterviewSolutions.DesignPatterns.BuilderPattern;
using CodingInterviewSolutions.DesignPatterns.ChainOfResponsibilityPattern;
using CodingInterviewSolutions.DesignPatterns.CompositePattern.Solution.Component;
using CodingInterviewSolutions.DesignPatterns.CompositePattern.Solution.Composite;
using CodingInterviewSolutions.DesignPatterns.CompositePattern.Solution.Leaf;
using CodingInterviewSolutions.DesignPatterns.CompositePattern.Solution2;
using CodingInterviewSolutions.DesignPatterns.DecoratorPattern.Component;
using CodingInterviewSolutions.DesignPatterns.DecoratorPattern.ConcreteComponent;
using CodingInterviewSolutions.DesignPatterns.DecoratorPattern.ConcreteDecorator;
using CodingInterviewSolutions.DesignPatterns.FacadePattern;
using CodingInterviewSolutions.DesignPatterns.FactoryPattern;
using CodingInterviewSolutions.DesignPatterns.FlyweightPattern.Solution;
using CodingInterviewSolutions.DesignPatterns.MediatorPatten;
using CodingInterviewSolutions.DesignPatterns.MementoPattern;
using CodingInterviewSolutions.DesignPatterns.ObserverPattern.Observer;
using CodingInterviewSolutions.DesignPatterns.ObserverPattern.Subject;
using CodingInterviewSolutions.DesignPatterns.PrototypePattern;
using CodingInterviewSolutions.DesignPatterns.ProxyPattern.Proxy;
using CodingInterviewSolutions.DesignPatterns.ProxyPattern.Subject;
using CodingInterviewSolutions.DesignPatterns.SingletonPattern;
using CodingInterviewSolutions.DesignPatterns.StatePattern;
using CodingInterviewSolutions.DesignPatterns.StatePattern.Enums;
using CodingInterviewSolutions.DesignPatterns.StrategyPattern;
using CodingInterviewSolutions.DesignPatterns.StrategyPattern.Strategy;
using CodingInterviewSolutions.DesignPatterns.TemplateMethodPattern;
using CodingInterviewSolutions.DesignPatterns.VisitorPattern.Solution;

namespace CodingInterviewSolutions.DesignPatterns
{
    internal class Patterns
    {
        public void AbstractFactoryPattern()
        {
            // Fetch the Regular Bike and Car Details
            // Creating RegularVehicleFactory instance
            IVehicleFactory regularVehicleFactory = new RegularVehicleFactory();
            //regularVehicleFactory.CreateBike() will create and return Regular Bike
            IBike regularBike = regularVehicleFactory.CreateBike();
            regularBike.GetDetails();
            //regularVehicleFactory.CreateCar() will create and return Regular Car
            ICar regularCar = regularVehicleFactory.CreateCar();
            regularCar.GetDetails();
            // Fetch the Sports Bike and Car Details Created
            // Creating SportsVehicleFactory instance 
            IVehicleFactory sportsVehicleFactory = new SportsVehicleFactory();
            //sportsVehicleFactory.CreateBike() will create and return Sports Bike
            IBike sportsBike = sportsVehicleFactory.CreateBike();
            sportsBike.GetDetails();
            //sportsVehicleFactory.CreateCar() will create and return Sports Car
            ICar sportsCar = sportsVehicleFactory.CreateCar();
            sportsCar.GetDetails();
        }

        public void AdapterPatten()
        {
            Target target = new Adapter(new Adaptee());
            target.Request();
        }

        public void BridgePattern()
        {
            // Except for the initialization phase, where an Abstraction object i.e. LongMessage or ShortMessage
            // linked with a specific Implementation object i.e. new EmailMessageSender() or new SmsMessageSender(), 
            // the client code should only depend on the Abstraction class i.e. AbstractMessage 

            AbstractMessage longMessage = new LongMessage(new EmailMessageSender());
            longMessage.SendMessage("Hello");

            AbstractMessage shortMessage = new ShortMessage(new SmsMessageSender());
            shortMessage.SendMessage("Hello");
        }

        public void BuilderPattern()
        {
            TravelAgent travelAgent = new TravelAgent();
            CustomHolidayPackageBuilder packageBuilder = new CustomHolidayPackageBuilder();

            travelAgent.CreatePackage(packageBuilder, true, true, false, new[] { "Beach trip", "Mountain hiking" });

            var holidayPackage = packageBuilder.GetPackage();
            holidayPackage.DisplayPackageDetails();
        }

        public void ChainOfResponsibilityPattern()
        {
            AutomatedTellerMachine automatedTellerMachine = new AutomatedTellerMachine();
            automatedTellerMachine.Withdraw(5800);
        }

        public void CompositePattern()
        {
            #region Solution - FileSystem
            DirectoryImpl mainDirectory = new DirectoryImpl("Main");
            IFileSystem mainFile = new FileImpl("MainFile");
            mainDirectory.Add(mainFile);

            DirectoryImpl subDirectory = new DirectoryImpl("Sub");
            IFileSystem subFile = new FileImpl("SubFile");
            subDirectory.Add(subFile);

            mainDirectory.Add(subDirectory);

            mainDirectory.LinuxLsCommand();
            #endregion

            #region Solution - ArithmeticExpression
            IArithmeticExpression two = new Number(2);
            IArithmeticExpression one = new Number(1);
            IArithmeticExpression seven = new Number(7);

            IArithmeticExpression additionExpression
                = new LogicalExpression(one, seven, Operation.Add);

            IArithmeticExpression finalExpression
                = new LogicalExpression(two, additionExpression, Operation.Multiply);

            int output = finalExpression.Evaluate();
            Console.WriteLine($"Output for Expression 2 * (1+7) = {output}");

            #endregion
        }

        public void DecoratorPattern()
        {
            Pizza pizza1 = new ExtraCheese(new Farmhouse());
            Console.WriteLine($"Total Cost is : {pizza1.Cost()}");

            Pizza pizza2 = new Mushroom(new ExtraCheese(new Farmhouse()));
            Console.WriteLine($"Total Cost is : {pizza2.Cost()}");
        }

        public void Facade()
        {
            // Create an Instance of Customer Class
            Customer customer = new Customer()
            {
                Name = "Pranaya",
                Email = "info@dotnettutorials.net",
                MobileNumber = "1234567890",
                Address = "BBSR, Odisha, India"
            };
            //Using Facade Class
            CustomerRegistrationFacade customerRegistration = new CustomerRegistrationFacade();
            customerRegistration.RegisterCustomer(customer);
        }

        public void FactoryPattern()
        {
            FactoryPatternImpl factroyPattern = new FactoryPatternImpl();
            factroyPattern.Execute("circle");
            factroyPattern.Execute("SQUARE");
            factroyPattern.Execute("ReCTanGle");
        }

        public void FlyweightPattern()
        {
            int x = 0, y = 100;
            // Creating int.MaxValue of Human Robots (Huge Memory consumption)
            for (int i = 0; i < 100; i++, x++, y--)
            {
                RobotFactory robotFactory = new RobotFactory();
                var robot = robotFactory.GetRobotFromType(RobotType.Human);
                robot.Display(x, y);
            }
        }

        public void MediatorPattern()
        {
            IMediator mediator = new Mediator();
            IBidder bidderGoku = new Bidder("Goku", mediator);
            IBidder bidderLuffy = new Bidder("Luffy", mediator);
            IBidder bidderNaruto = new Bidder("Naruto", mediator);

            bidderGoku.AddBid(100);
            bidderLuffy.AddBid(200);
            bidderNaruto.AddBid(300);

            bidderGoku.AddBid(400);

        }

        public void MementoPattern()
        {
            BankAccountOriginator account = new BankAccountOriginator(1000.00M);
            TransactionHistoryCaretaker history = new TransactionHistoryCaretaker();

            account.Deposit(200);
            history.SaveState(account);  // Balance: 1200

            account.Withdraw(100);
            history.SaveState(account);  // Balance: 1100

            account.Withdraw(50);
            history.SaveState(account);  // Balance: 1050

            // Oops! That last withdrawal was a mistake. Let's undo it.
            account.RestoreFromMemento(history.UndoTransaction());

            Console.WriteLine($"Current Balance: ${account.Balance}");
            // Outputs: Current Balance: $1100.00
        }

        public void ObserverPattern()
        {
            // Create IBM stock and attach investors
            IBM ibm = new IBM("IBM", 120.00);
            ibm.Add(new Investor("Sorros"));
            ibm.Add(new Investor("Berkshire"));
            // Fluctuating prices will notify investors
            ibm.Price = 120.10;
            ibm.Price = 121.00;
            ibm.Price = 120.50;
            ibm.Price = 120.75;
        }

        public void PrototypePattern()
        {
            // Creating an Instance of Employee Class
            Employee emp1 = new Employee();
            emp1.Name = "Anurag";
            emp1.Department = "IT";
            // Instead of using Assignment Operator, now use the Clone method to create a Cloned Object
            // Both emp1 and emp2 having different Memory Address
            Employee emp2 = emp1.GetClone(isDeepCopy: false);
            // Changing the Name Property Value of emp2 instance, 
            // will not change the Name Property Value of emp1 instance
            emp2.Name = "Pranaya";
            Console.WriteLine("Emplpyee 1: ");
            Console.WriteLine("Name: " + emp1.Name + ", Department: " + emp1.Department);
            Console.WriteLine("Emplpyee 2: ");
            Console.WriteLine("Name: " + emp2.Name + ", Department: " + emp2.Department);
        }

        public void ProxyPattern()
        {
            IEmployeeDAO employeeDAO = new EmployeeProxyDAO();
            employeeDAO.Create("Naruto", "Ninja");
            employeeDAO.Create("Boruto", "Ninja");
            employeeDAO.Create("Luffy", "Admin");

            employeeDAO.Delete("Naruto");
        }

        public void SingletonPattern()
        {
            SingletonDemo singleton = SingletonDemo.Instance;
            singleton.Data = 123;
            Console.WriteLine($"SingletonOne Data is {singleton.Data}");
            SingletonDemo singleton2 = SingletonDemo.Instance;
            Console.WriteLine($"SingletonTwo Data is {singleton2.Data}");
        }

        public void StatePattern()
        {
            Car car = new SomeCar();
            Console.WriteLine($"Current Car State Is: {car.CurrentState}");
            car.TakeAction(CarAction.Start);
            Console.WriteLine($"Current Car State Is: {car.CurrentState}");
            car.TakeAction(CarAction.Stop);
            Console.WriteLine($"Current Car State Is: {car.CurrentState}");
            car.TakeAction(CarAction.Start);
            Console.WriteLine($"Current Car State Is: {car.CurrentState}");
            car.TakeAction(CarAction.Run);
            Console.WriteLine($"Current Car State Is: {car.CurrentState}");
            car.TakeAction(CarAction.Stop);
            Console.WriteLine($"Current Car State Is: {car.CurrentState}");
            car.TakeAction(CarAction.Run);
            Console.WriteLine($"Current Car State Is: {car.CurrentState}");
        }

        public void StrategyPattern()
        {
            Context unsortedList = new Context();
            unsortedList.Add("Tom");
            unsortedList.Add("Jerry");
            unsortedList.Add("Ash");
            unsortedList.Add("Tyson");
            unsortedList.Add("Naruto");
            unsortedList.Add("Luffy");

            unsortedList.SetSortingAlgorithm(new BubbleSortConcreteStrategy());
            unsortedList.Sort();

            unsortedList.SetSortingAlgorithm(new MergeSortConcreteStrategy());
            unsortedList.Sort();

            unsortedList.SetSortingAlgorithm(new QuickSortConcreteStrategy());
            unsortedList.Sort();
        }

        public void TemplateMethodPattern()
        {
            Console.WriteLine("Build a Concrete House\n");
            HouseTemplate houseTemplate = new ConcreteHouse();
            //Call the Template Method to Build the Concrete House
            houseTemplate.BuildHouse();
            Console.WriteLine();
            Console.WriteLine("Build a Wooden House\n");
            houseTemplate = new WoodenHouse();
            //Call the Template Method to Build the Wooden House
            houseTemplate.BuildHouse();
        }

        public void VisitorPattern()
        {
            IRoom classicRoom = new ClassicRoom();
            IRoom deluxRoom = new DeluxRoom();

            IRoomVisitor roomVisitor = new RoomPriceVisitor();
            classicRoom.Accept(roomVisitor);

            Console.WriteLine($"Room price of {nameof(ClassicRoom)}: $ {classicRoom.RoomPrice}");

            deluxRoom.Accept(roomVisitor);
            Console.WriteLine($"Room price of {nameof(DeluxRoom)}: $ {deluxRoom.RoomPrice}");

            IRoomVisitor maintanenceVisitor = new MaintanenceVisitor();
            classicRoom.Accept(maintanenceVisitor);
            deluxRoom.Accept(maintanenceVisitor);
        }

    }
}
