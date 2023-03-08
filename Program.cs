
//Logger logger = new Logger();
//logger.FileLogger("this Logger Is File Txt.");

//NewFatucherLoggerDecorator newLogger = new NewFatucherLoggerDecorator(logger);
//newLogger.DatabseLogger("this Logger Is Databse.");


//using DeginPaterrn.Decorator.DecoratorVsInheritance;

//ConcreteWindow window = new ConcreteWindow("red");
//Console.WriteLine(window.GetColor());

//ConcreteDecoratorScrollWindow windowDecorator = new ConcreteDecoratorScrollWindow(window , "blue");
//Console.WriteLine(windowDecorator.GetColor());

//ConcreteDecoratorShdowWindow windowDecorator2 = new ConcreteDecoratorShdowWindow(window, "silver");
//windowDecorator2.SetColor("oreng");
//Console.WriteLine(windowDecorator2.GetColor());
//Console.WriteLine(windowDecorator.GetColor());
//Console.WriteLine(window.GetColor());

//using DeginPaterrn.Decorator;
//using System.Net;

//WebClient webClient = new WebClient();
//var source = webClient.DownloadString("https://www.google.com/");
//Console.WriteLine(source);

//WebClinetDecorator webClinetDecorator = new WebClinetDecorator(webClient);
//var source2 = webClinetDecorator.DownloadString("https://www.google.com/");
//Console.WriteLine(source2);

//using DeginPaterrn.Facade;

//Facade.RigesterUser();

//using DeginPaterrn.Bridge;

//RefinedAbstraction refinedAbstraction = new RefinedAbstraction();
//refinedAbstraction.Function();


//using DeginPaterrn.Proxy;

////ILogger logger = new Logger();
//ILogger logger = new VirtualProxyLogger();
//logger.InfoLogger("this is info logger ....");

//using DeginPaterrn.Composite;

//CompositeTreeStructure treeStructure = new CompositeTreeStructure(new CompositeTreeStructureDto()
//{
//    Id = 1,
//    Name = "Root Tree Structure",
//    Description = "This Is Root Tree Structure",
//    Children = new List<TreeStructure>()
//    {
//        new LifeTreeStructure(new LifeTreeStructureDto { Id = 2 , Name = "Life 1" , Description = "This Is Life 1 In Tree Structure" }),
//        new LifeTreeStructure(new LifeTreeStructureDto { Id = 3 , Name = "Life 2" , Description = "This Is Life 2 In Tree Structure" }),
//        new LifeTreeStructure(new LifeTreeStructureDto { Id = 4 , Name = "Life 3" , Description = "This Is Life 3 In Tree Structure" }),
//        new LifeTreeStructure(new LifeTreeStructureDto { Id = 5 , Name = "Life 4" , Description = "This Is Life 4 In Tree Structure" }),
//        new CompositeTreeStructure(new CompositeTreeStructureDto()
//        { 
//            Id = 6 ,
//            Name = "Composite 1" ,
//            Description = "This Is Composite 1 In Tree Structure",
//            Children = new List<TreeStructure>()
//            {
//                new LifeTreeStructure(new LifeTreeStructureDto { Id = 7 , Name = "Life 1-1" , Description = "This Is Life 1-1 In Tree Structure" }),
//                new LifeTreeStructure(new LifeTreeStructureDto { Id = 8 , Name = "Life 1-2" , Description = "This Is Life 1-2 In Tree Structure" }),
//                new CompositeTreeStructure(new CompositeTreeStructureDto()
//                {
//                    Id = 9 ,
//                    Name = "Composite 1-3" ,
//                    Description = "This Is Composite 1-3 In Tree Structure",
//                    Children = new List<TreeStructure>()
//                    {
//                        new LifeTreeStructure(new LifeTreeStructureDto { Id = 10 , Name = "Life 1-3-1" , Description = "This Is Life 1-3-1 In Tree Structure" }),
//                        new CompositeTreeStructure(new CompositeTreeStructureDto()
//                        {
//                            Id = 10 ,
//                            Name = "Composite 1-3-2" ,
//                            Description = "This Is Composite 1-3-2 In Tree Structure",
//                            Children = new List<TreeStructure>() {}
//                        })
//                    }
//                })
//            }
//        }),
//    }
//});

//treeStructure.AddTree(new LifeTreeStructure(new LifeTreeStructureDto { Id = 11, Name = "Life 5", Description = "This Is Life 5 In Tree Structure" }));

//treeStructure.DisplayTree(5);

//using DeginPaterrn.Flyweight;

//FlyweightFactory flyweightFactory = new FlyweightFactory();

//SoliderConcreteFlyweight soliderConcreteFlyweight = (SoliderConcreteFlyweight)flyweightFactory.GetObject(nameof(SoliderConcreteFlyweight) , "test1");
//soliderConcreteFlyweight.Operation();

//SoliderConcreteFlyweight soliderConcreteFlyweight2 = (SoliderConcreteFlyweight) flyweightFactory.GetObject(nameof(SoliderConcreteFlyweight) , "test2");
//soliderConcreteFlyweight.Operation();

//ArrowConcreteFlyweight arrowConcreteFlyweight = (ArrowConcreteFlyweight)flyweightFactory.GetObject(nameof(ArrowConcreteFlyweight), "test3");
//arrowConcreteFlyweight.Operation();

//UnsheardFlyweight unsheardFlyweight = new UnsheardFlyweight(new List<IFlyweight>()
//{
//    flyweightFactory.GetObject(nameof(SoliderConcreteFlyweight) , "test1"),
//    flyweightFactory.GetObject(nameof(SoliderConcreteFlyweight) , "test2"),
//    flyweightFactory.GetObject(nameof(ArrowConcreteFlyweight) , "test3"),
//});
//unsheardFlyweight.Operation();

//using DeginPaterrn.Adapter;

//IAdaptee circle = new CircleObject();
//circle.Operation();

//IAdaptee square = new SquareObject();
//square.Operation();

//IAdaptee diamond = new DiamondObject();
//diamond.Operation();

//IAdaptee adapteeObject3D = new AdapteeObject3D();
//adapteeObject3D.Operation();


//using DeginPaterrn.Prototype;

//IPrototype sampleObjectClone = new SampleObjectClone();

//SampleObjectClone sampleObjectClone2 = (SampleObjectClone)sampleObjectClone.ShallowClone();
//SampleObjectClone sampleObjectClone3 = (SampleObjectClone)sampleObjectClone.ShallowClone();

//SampleObjectClone sampleObjectClone4 = (SampleObjectClone)sampleObjectClone.DeepClone();
//SampleObjectClone sampleObjectClone5 = (SampleObjectClone)sampleObjectClone.DeepClone();

//Console.WriteLine(sampleObjectClone2 == sampleObjectClone3);
//Console.WriteLine(sampleObjectClone3 == sampleObjectClone4);
//Console.WriteLine(sampleObjectClone2 == sampleObjectClone2);

//Console.WriteLine(sampleObjectClone5 == sampleObjectClone4);
//Console.WriteLine(sampleObjectClone5 == sampleObjectClone2);
//Console.WriteLine(sampleObjectClone5 == sampleObjectClone5);


//using DeginPaterrn.Singletone;

//SampleObjectSingletone sampleObjectSingletone1 = SampleObjectSingletone.GetInstance();
//SampleObjectSingletone sampleObjectSingletone2 = SampleObjectSingletone.GetInstance();

//Console.WriteLine(sampleObjectSingletone1 == sampleObjectSingletone2);

//using DeginPaterrn.Factory_Method;

//ISmsSernder smsSernderOne = SmsSernderCreateor.SmsSernderFactoryMethod();
//ISmsSernder smsSernderTwo = SmsSernderCreateor.SmsSernderFactoryMethod(SmsSernderType.ShahParkSms);

//smsSernderOne.Send(new SmsSernderDto()
//{
//    Line = "+988965894",
//    Message = "This is Message Test",
//    Receiver = "Hossein Ghojavand",
//    Sender = "System",
//});
//smsSernderTwo.Send(new SmsSernderDto()
//{
//    Line = "+983216458",
//    Message = "This is Message Test",
//    Receiver = "Hossein Ghojavand",
//    Sender = "System",
//});

//Console.WriteLine("============================= --Reports-- ====================================");

//for (int i = 0; i < smsSernderOne.GetList().Count; i++)
//{
//    SmsSernderDto sms = smsSernderOne.GetList()[i];
//    Console.WriteLine($"{i}- Line:{sms.Line} Sender:{sms.Sender} - Receiver:{sms.Receiver} - Message:{sms.Message} ({nameof(SmsSernderType.IranSms)})");
//}
//for (int i = 0; i < smsSernderTwo.GetList().Count; i++)
//{
//    SmsSernderDto sms = smsSernderTwo.GetList()[i];
//    Console.WriteLine($"{i}- Line:{sms.Line} Sender:{sms.Sender} - Receiver:{sms.Receiver} - Message:{sms.Message} ({nameof(SmsSernderType.ShahParkSms)})");
//}

//using DeginPaterrn.AbstractFactory;
//using DeginPaterrn.AbstractFactory.Services.CatecoryService;
//using DeginPaterrn.AbstractFactory.Services.UserService;

//ICatecoryService catecoryService = AbstractFactory.CreateCatecoryService(CatecoryServiceType.LeftCatecoryService);
//IUserService userService = AbstractFactory.CreateUserService(UserServiceType.LegalUserService);

//catecoryService.Excute();
//userService.Excute();


//using DeginPaterrn.Builder;
//using DeginPaterrn.Builder.Services.UserService;

//IDirctorUserService dirctorUserService = new DirctorUserService();

//dirctorUserService.SetFullRealUserInformation("Hossein" , "ghojavand" , 23 , "Tehran" , 02112345678);
//IUserService realUserService = dirctorUserService.GetRealUser();

//dirctorUserService.SetFullLegalUserInformation("Hossein", "ghojavand", 23, "Tehran", 02112345678);
//IUserService legalUserService = dirctorUserService.GetRealUser();

//Console.WriteLine($"RealUser --- {nameof(realUserService.Firstname)}: {realUserService.Firstname} - {nameof(realUserService.Lastname)}: {realUserService.Lastname} - {nameof(realUserService.Age)}: {realUserService.Age} - {nameof(realUserService.City)}: {realUserService.City} - {nameof(realUserService.Phone)}: {realUserService.Phone}");
//Console.WriteLine($"LegalUser --- {nameof(legalUserService.Firstname)}: {legalUserService.Firstname} - {nameof(legalUserService.Lastname)}: {legalUserService.Lastname} - {nameof(legalUserService.Age)}: {legalUserService.Age} - {nameof(legalUserService.City)}: {legalUserService.City} - {nameof(legalUserService.Phone)}: {legalUserService.Phone}");

//using DeginPaterrn.Strategy;
//IStrategy sortId = new SortAlgorithmById();
//IStrategy sortPrice = new SortAlgorithmByPrice();

//IContect contect = new Contect(sortId);
//contect.SortData();

//contect = new Contect(sortPrice);
//contect.SortData();

//StrategyArrayUsers strategyArrayUsers = new StrategyArrayUsers();
//strategyArrayUsers.Excte(nameof(User.Firstname));

//using DeginPaterrn.ChainResponsibility;

//ChainResponsibility stepOne = new ChainResponsibilityConcreate();
//ChainResponsibility stepTwo = new ChainResponsibilityConcreate2();
//ChainResponsibility stepThree = new ChainResponsibilityConcreate3();

//stepOne.SetSuccessor(stepTwo);
//stepTwo.SetSuccessor(stepThree);

//Console.WriteLine("--------------------------------------------------");
//stepOne.RequestHandeler(50);
//Console.WriteLine("--------------------------------------------------");
//stepOne.RequestHandeler(80);
//Console.WriteLine("--------------------------------------------------");
//stepOne.RequestHandeler(100);
//Console.WriteLine("--------------------------------------------------");

//CheckUserActiveUser checkUserActiveUser = new CheckUserActiveUser();
//CreateOrder createOrder = new CreateOrder();
//SendOrderToDriver sendOrderToDriver = new SendOrderToDriver();
//CheckTest checkTest = new CheckTest();

//checkUserActiveUser
//    .SetSuccessor(checkTest)
//    .SetSuccessor(createOrder)
//    .SetSuccessor(sendOrderToDriver);


//checkUserActiveUser.Execute(new RequestContextSanpp
//{
//    UserId = 1,
//    Origin = new PointSanpp { Lat = 53.3636, Lng = 54.22 },
//    Destination = new PointSanpp { Lat = 53.3636, Lng = 54.22 },
//});


//using DeginPaterrn.Command;
//using DeginPaterrn.Command.Services;

//var concreteCommandOne = new ConcreteCommandOne<IServiceOne>(new ServiceOne());
//var invokerCommandOne = new InvokerCommand<IServiceOne>(concreteCommandOne);

//invokerCommandOne.ExcuteCommand();

//using DeginPaterrn.Observer;

//ConcreteSubject subject = new ConcreteSubject();
//subject.SubjectState = "MySubjectState";

//IObserverbel observableOne = new ConcreteObserver("observableOne", subject);
//IObserverbel observableTwo = new ConcreteObserver("observableTwo", subject);
//IObserverbel observableThree = new ConcreteObserver("observableThree", subject);
//IObserverbel observableFour = new ConcreteObserver("observableFour", subject);

//subject.AttechObserver(observableOne);
//subject.AttechObserver(observableTwo);
//subject.AttechObserver(observableThree);
//subject.AttechObserver(observableFour);

//subject.Notify();

//using DeginPaterrn.Memento;

//Originator originator = new Originator();

//originator.ExsampleState = "Red";

//Caretaker caretaker = new Caretaker();
//caretaker.Memento = originator.CreateMemento();

//originator.ExsampleState = "Green";
//originator.ExsampleState = "Blue";
//originator.ExsampleState = "Pink";

//Console.WriteLine("===================================================================================================");

//originator.SetMemento(caretaker.Memento);

//using DeginPaterrn.Visitor;

//ISnapp ChikenOne = new SnappFoodElement("ChikenOne", "1000");
//ISnapp ChikenTwo = new SnappFoodElement("ChikenTwo", "2000");
//ISnapp ChikenThree = new SnappFoodElement("ChikenThree", "3000");
//ISnapp ChikenFour = new SnappFoodElement("ChikenFour", "4000");
//ISnapp ChikenFive = new SnappFoodElement("ChikenFive", "5000");

//ISnapp PencelOne = new SnappBoxElement("PencelOne", "1000");
//ISnapp PencelTwo = new SnappBoxElement("PencelTwo", "2000");
//ISnapp PencelThree = new SnappBoxElement("PencelThree", "3000");
//ISnapp PencelFour = new SnappBoxElement("PencelFour", "4000");
//ISnapp PencelFive = new SnappBoxElement("PencelFive", "5000");

//ISnapp MilkeOne = new SnappMarketElement("MilkeOne", "1000");
//ISnapp MilkeTwo = new SnappMarketElement("MilkeTwo", "2000");
//ISnapp MilkeThree = new SnappMarketElement("MilkeThree", "3000");
//ISnapp MilkeFour = new SnappMarketElement("MilkeFour", "4000");
//ISnapp MilkeFive = new SnappMarketElement("MilkeFive", "5000");


//ElementSnappStructure objectStructure = new ElementSnappStructure();

//objectStructure.Add(ChikenOne);
//objectStructure.Add(ChikenTwo);
//objectStructure.Add(ChikenThree);
//objectStructure.Add(ChikenFour);
//objectStructure.Add(ChikenFive);

//objectStructure.Add(PencelOne);
//objectStructure.Add(PencelTwo);
//objectStructure.Add(PencelThree);
//objectStructure.Add(PencelFour);
//objectStructure.Add(PencelFive);

//objectStructure.Add(MilkeOne);
//objectStructure.Add(MilkeTwo);
//objectStructure.Add(MilkeThree);
//objectStructure.Add(MilkeFour);
//objectStructure.Add(MilkeFive);

//IVisitor visitorReport = new VisitorReport();
//IVisitor visitorInformation = new VisitorInformation();

//Console.WriteLine("===============================================================================");
//objectStructure.Accept(visitorReport);
//Console.WriteLine("===============================================================================");
//objectStructure.Accept(visitorInformation);
//Console.WriteLine("===============================================================================");

//using DeginPaterrn.Mediator;
//using DeginPaterrn.Mediator.Services;

//Products products = new Products();
//Users users = new Users();

//Mediator mediator = new ConcreateMediator(products , users);

//products.SetMediator(mediator);
//users.SetMediator(mediator);

//products.Send("Exsample Sand Message From Product");
//Console.WriteLine("=================================================");
//users.Send("Exsample Sand Message From User");

//using DeginPaterrn.State;

//Context context = new Context();

//for (int i = 0; i < 3 ; i++)
//    context.Request();

//using DeginPaterrn.Interpreter;


//IList<IExpressionDateTime> expressionDateTimes = new List<IExpressionDateTime>();
//Context context = new Context(DateTime.Now);

//while (true)
//{
//    Console.WriteLine("Please select the expression dateTime:");
//    string? input = Console.ReadLine();

//    if (input != null)
//        context.Expression = input.ToUpper();
//    else
//        Console.WriteLine("Please enter the desired date format.");

//    string[] formats = context.Expression.Split(' ');

//    foreach (string format in formats)
//    {
//        switch (format)
//        {
//            case "YYYY":
//                expressionDateTimes.Add(new CocreateExpressionYers());
//                break;

//            case "MM":
//                expressionDateTimes.Add(new CocreateExpressionMonth());
//                break;

//            case "DD":
//                expressionDateTimes.Add(new CocreateExpressionDay());
//                break;
//        }
//    }

//    foreach (IExpressionDateTime expressionDateTime in expressionDateTimes)
//        expressionDateTime.Interpret(context);

//    Console.WriteLine(context.Expression);

//    Console.ReadKey();
//}
