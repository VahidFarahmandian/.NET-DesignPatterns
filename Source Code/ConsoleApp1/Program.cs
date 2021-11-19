using DotNet_Design_Patterns.Chapter5.Chain_of_Responsibility;
using DotNet_Design_Patterns.Chapter5.Command;
using DotNet_Design_Patterns.Chapter5.Interpreter;
using DotNet_Design_Patterns.Chapter5.Iterator.IEnumerable_IEnumerator;
using DotNet_Design_Patterns.Chapter5.Visitor;
using System;
using DotNet_Design_Patterns.Chapter5.Template_Method;
using DotNet_Design_Patterns.Chapter5.State;
using DotNet_Design_Patterns.Chapter5.Strategy;
using DotNet_Design_Patterns.Chapter5.Mediator;
using DotNet_Design_Patterns.Chapter5.Memento;
using DotNet_Design_Patterns.Chapter5.Observer;
using DotNet_Design_Patterns.Chapter4.Proxy;
using System.Threading.Tasks;
using DotNet_Design_Patterns.Chapter4.Flyweight;
using System.Collections.Generic;
using DotNet_Design_Patterns.Chapter4.Facade;
using DotNet_Design_Patterns.Chapter4.Decorator;
using DotNet_Design_Patterns.Chapter4.Composite;
using DotNet_Design_Patterns.Chapter4.Bridge;
using DotNet_Design_Patterns.Chapter4.Adapter;
using DotNet_Design_Patterns.Chapter1.SOLID;
using DotNet_Design_Patterns.Chapter6.Repository;
using DotNet_Design_Patterns.Chapter6.UnitOfWork;
using DotNet_Design_Patterns.Chapter6.Lazy_Load;
using System.Linq;
using DotNet_Design_Patterns.Chapter6.ServiceLayer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using DotNet_Design_Patterns.Chapter6.Identity_Map;

namespace ConsoleApp1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            #region Chapter 3
            #region Singleton
            //Parallel.Invoke(
            //    () =>
            //    {
            //        DbConnectionManager obj1 = DbConnectionManager.GetInstance();
            //        Console.WriteLine($"obj1: {obj1.GetHashCode()}");
            //    },
            //    () =>
            //    {
            //        DbConnectionManager obj2 = DbConnectionManager.GetInstance();
            //        Console.WriteLine($"obj2: {obj2.GetHashCode()}");
            //    });
            // DbConnectionManager obj1 = DbConnectionManager.GetInstance();
            //  DbConnectionManager obj2 = DbConnectionManager.GetInstance();
            //Console.WriteLine($"obj1: {obj1.GetHashCode()}, obj2: {obj2.GetHashCode()}");
            #endregion

            #region Prototype
            //IPant jean1 = new JeanPant()
            //{
            //    Price = 10000,
            //    ClothInfo = new Cloth()
            //    {
            //        Color = "Red"
            //    }
            //};
            //IPant cotton1 = new CottonPant()
            //{
            //    Price = 7000,
            //    ClothInfo = new Cloth()
            //    {
            //        Color = "Red"
            //    }
            //};
            //IPant fabric1 = new FabricPant()
            //{
            //    Price = 12000,
            //    ClothInfo = new Cloth()
            //    {
            //        Color = "Blue"
            //    }
            //};
            //PantRegistry registry = new PantRegistry();
            //registry.Add(jean1);
            //registry.Add(cotton1);
            //registry.Add(fabric1);
            //Console.WriteLine($"{jean1}");
            //Console.WriteLine($"{registry.GetByType(typeof(JeanPant))}");
            //Console.WriteLine($"{registry.GetByColor("Red")}");

            //IPant jean2 = jean1.Clone();
            //jean2.Price = 11000;
            //jean2.ClothInfo.Color = "Geen";

            //Console.WriteLine($"jean1: {jean1}");
            //Console.WriteLine($"jean2: {jean2}");
            #endregion

            #region Builder
            //CellPhoneDirector director = new CellPhoneDirector(new Samsung());
            //var phone = director.Construct();
            //Console.WriteLine($"Body: {phone.BodyMaterial}, Camera: {phone.CameraResolution}, Monitor: {phone.MonitorSize}, OS: {phone.OSName}");

            //director = new CellPhoneDirector(new Apple());
            //phone = director.Construct();
            //Console.WriteLine($"Body: {phone.BodyMaterial}, Camera: {phone.CameraResolution}, Monitor: {phone.MonitorSize}, OS: {phone.OSName}");
            #endregion

            #region Abstract Factory
            //new Client(new IranKhodro()).CreatePetrolCar();
            //new Client(new Saipa()).CreateDieselCar();
            #endregion

            #region Factory Method
            //DoorManufacturer manufacturer = new Carpenter();
            //manufacturer.CreateDoor();
            //DoorManufacturer manufacturer2 = new StarndardDoorManufacturer<WoodenDoor>();
            //manufacturer.CreateDoor();
            #endregion

            #endregion

            #region Chapter 4

            #region Adapter
            /* Pluggable Adapter
            //Adapter adapter1 = new(new Adaptee());
            //adapter1.Request("Hello Vahid");

            //Adapter adapter2 = new(new Target());
            //adapter2.Request("Hi my name is Vahid");
            */

            //IExternalService service = new ExternalService();
            //service.Url = "http://something.com/api/user";
            //service.Get("pageIndex = 1");

            //IExternalService service = new ServiceAdapter();
            //service.Url = "http://something.com/api/user";
            //service.Get("pageIndex=1");
            //service.Post(null);

            #endregion

            #region Bridge

            //IServiceBus bus = new BasicBus()
            //{
            //    Logger = new TextLogger()
            //};
            //bus.Call("https://google.com");

            #endregion

            #region Composite

            //IMenuComponent menu = new Menu()
            //{
            //    Text = "Overview",
            //    Url = "/overview.html",
            //    Children = new List<IMenuComponent>()
            //    {
            //        new MenuItem{Text ="Intro",Url="/intro.html"},
            //        new MenuItem{Text ="Architecture Component",Url="/arch.html"},
            //        new MenuItem{Text ="Class Libraries",Url="/class.html"},
            //        new Menu{
            //            Text ="Tutorials",
            //            Url="/tutorials.html",
            //            Children=new List<IMenuComponent>
            //            {
            //                new MenuItem{Text ="Template Changes",Url="/tpl.html"},
            //                new Menu{
            //                    Text ="Use Visual Studio",
            //                    Url="/vs.html",
            //                    Children=new List<IMenuComponent>
            //                    {
            //                        new MenuItem{Text ="New Project",Url="/new-project.html"},
            //                        new MenuItem{Text ="Debug",Url="/debug.html"},
            //                        new MenuItem{Text ="Publish",Url="/publish.html"}
            //                    }
            //                }
            //            }
            //        }
            //    }
            //};

            //Console.WriteLine(menu.Print());

            #endregion

            #region Decorator

            //IPhoto photo = new Photo("C:\\sample.png");
            //photo.GetPhoto();//returns the original photo

            //WatermarkDecorator watermarkDecorator = new WatermarkDecorator(photo, "Sample Watermark");
            //watermarkDecorator.GetPhoto();

            //BlackWhiteDecorator blackWhiteDecorator = new BlackWhiteDecorator(photo);
            //blackWhiteDecorator.GetPhoto();

            #endregion

            #region Facade

            //TicketInquiry ticketInquiry = new TicketInquiry();
            //foreach (var item in ticketInquiry.Inquiry(new DateTime(2021,01,02),"Tehran","Urmia"))
            //{
            //    Console.WriteLine(item.ToString());
            //}

            #endregion

            #region Flyweight

            //List<Tree> trees = new();
            //TreeType type = new TreeFactory()["pine", "green", "short"];
            //Tree tree1 = new(type, 1, 1);
            //trees.Add(tree1);
            //Tree tree2 = new(type, 2, 2);
            //trees.Add(tree2);
            //Tree tree3 = new(type, 3, 3);
            //trees.Add(tree3);

            //foreach (var item in trees)
            //{
            //    item.Draw(item);
            //}

            #endregion

            #region Proxy

            //IGISService gisService = new GISServiceProxy();
            //Console.WriteLine(gisService.GetLatLng("Urmia"));
            //Console.WriteLine(gisService.GetLatLng("Tehran"));
            //Console.WriteLine(gisService.GetLatLng("Urmia"));

            //Remote Proxy
            //IRemoteService service = new RemoteProxy();
            //Console.WriteLine(await service.GetAllAsync());
            //Console.WriteLine(await service.GetAsync(2));

            #endregion

            #endregion

            #region Chapter 5

            #region Observer

            //IShoeObserver customerObserver = new CustomerObserver();
            //IShoeObserver loggingObserver = new LoggingObserver();

            //IShoeNotifier notifier = new ShoeNotifier();
            //notifier.Subscribe(customerObserver);
            //notifier.Subscribe(loggingObserver);
            //notifier.Notify(new Shoe { Size = 45, Color = "Red" });
            //ChangeManager.GetInstance().Notify(new Shoe { Size = 45, Color = "Red" });

            #endregion

            #region Memento

            //SurveyCaretaker caretaker = new();
            //Survey originator = new();
            //originator.SetAnswer(1, "A");
            //originator.SetAnswer(2, "B");
            //caretaker.AddMemento(originator.SaveDraft());
            //originator.SetAnswer(3, "C");
            //caretaker.AddMemento(originator.SaveDraft());
            //originator.SetAnswer(4, "D");
            //originator.RestoreDraft(caretaker.GetMemento());
            //originator.Submit();

            #endregion

            #region Mediator

            //IChatroom room = new Chatroom();
            //IParticipant p1 = new Participant("vahid", room);
            //IParticipant p2 = new Participant("ali", room);
            //IParticipant p3 = new Participant("reza", room);
            //room.Login(p1);
            //room.Login(p2);
            //room.Login(p3);

            //IParticipant sender = room.GetParticipant("vahid");
            //IParticipant receiver = room.GetParticipant("ali");
            //sender.Send(receiver.Name, "hello");

            //room.Logout(p1);
            //room.Logout(p2);
            //room.Logout(p3);
            #endregion

            #region Strategy

            //ExportContext export = new ExportContext(new XMLExporter());
            //export.Process(new { Name = "Vahid", LastName = "Farahmandian" });
            ////ExportContext export = new(new Export(Exporter.XMLExport));
            ////export.Process(new { Name = "Vahid", LastName = "Farahmandian" });


            #endregion

            #region State

            //TicketContext context = new(new AssignState());
            //context.Process();
            //context.Process(); 
            //context.Process(); 
            //context.Process();

            #endregion

            #region Template Method

            //DataReader reader = new CSVReader();
            //reader.Import();

            #endregion

            #region Visitor
            //Invoice invoice = new(new GoldenUsersVisitor());
            //invoice.Items.Add(new Food() { Cost = 100 });
            //invoice.Items.Add(new Cosmetics() { Cost = 150 });
            //invoice.Items.Add(new HomeAppliances() { Cost = 1000 });
            //Console.WriteLine($"Total: {invoice.Calculate()}");
            #endregion

            #region Interpreter
            //string query = "Select SomeMethod, OtherMethod From Config";
            //SqlContext context = new() { Namespace = "Sample" };
            //var expressionParts = Regex.Split(query, " From ", RegexOptions.IgnoreCase).Select(x => x.Trim()).ToArray();
            //LiteralExpression methodExpression = new(expressionParts[0][6..]);
            //LiteralExpression classExpression = new(expressionParts[1]);
            //SelectExpression selectExpression = new(methodExpression);
            //FromExpression fromExpression = new(classExpression);
            //QueryExpression queryExpression = new(selectExpression, fromExpression);
            //Console.WriteLine(queryExpression.Interpret(context));
            #endregion

            #region Command
            //EmployeeManager employeeManager = new(1);
            //Recruitment recruitment = new();
            //recruitment.Commands.Add(new CreateEmailCommand(employeeManager));
            //recruitment.Commands.Add(new DesignIdentityCardCommand(employeeManager));
            //recruitment.Commands.Add(new DesignVisitingCardCommand(employeeManager));
            //recruitment.Invoke();
            #endregion

            #region Chain of Responsibility
            //RequestHandler authenticationHandler = new AuthenticationHandler();
            //RequestHandler authorizationHandler = new AuthorizationHandler();
            //RequestHandler loggingHandler = new LoggingHandler();
            //authenticationHandler.ContinueWith(authorizationHandler);
            //authorizationHandler.ContinueWith(loggingHandler);
            //authenticationHandler.Handle(new Request
            //{
            //    IP = "192.168.1.1",
            //    Username = "vahid",
            //    Url = "http://abc.com/get"
            //});
            #endregion

            #region Iterator
            //InstagramCollection social = new InstagramCollection(0);
            //foreach (var item in social)
            //{
            //    Console.WriteLine(item);
            //}
            //var socialEnum = social.GetEnumerator();
            //while (socialEnum.MoveNext())
            //{
            //    Console.WriteLine(socialEnum.Current);
            //}

            //var profiles = social.CreateMaleIterator();
            //while (profiles.HasNext())
            //{
            //    Console.WriteLine(profiles.Next());
            //}
            //Console.WriteLine("###############");
            //while (!profiles.IsFirst())
            //{
            //    Console.WriteLine(profiles.Prev());
            //}
            #endregion

            #endregion

            #region Chapter 6

            #region Identity Map

            //IUserRepository userRepository = new DotNet_Design_Patterns.Chapter6.Identity_Map.UserRepository();
            //var user1 = userRepository.Get(1);
            //var user2 = userRepository.Get(1);

            /*Identity Map in EF*/
            //var services = new ServiceCollection();
            //services.AddDbContext<SampleDbContext2>(options => options.UseSqlServer("Data Source=.;Initial Catalog=PSO;Integrated Security=True"));
            //var serviceProvider = services.BuildServiceProvider();

            //SampleDbContext2 ctx = serviceProvider.GetService<SampleDbContext2>();

            //ctx.Users.Add(new DotNet_Design_Patterns.Chapter6.Repository.User { Id = 1, Name = "Vahid" });
            //ctx.Users.Add(new DotNet_Design_Patterns.Chapter6.Repository.User { Id = 2, Name = "Ali" });


            //var query1 = ctx.Users.Where(x => x.Name == "Vahid");

            //var user1 = query1.FirstOrDefault();
            //var user2 = query1.FirstOrDefault();

            //var query2 = ctx.Users.Where(x => x.Id == 1);

            //var user3 = query2.FirstOrDefault();

            //Console.WriteLine(user1.GetHashCode());
            //Console.WriteLine(user2.GetHashCode());
            //Console.WriteLine(user3.GetHashCode());

            //user1.Name = "Ali";
            //Console.WriteLine(user3.Name);
            #endregion

            #region Service Layer

            //IUserService userService = new UserService();
            //userService.Add(new DotNet_Design_Patterns.Chapter6.ServiceLayer.User { Username = "user5", Password = "123456" });

            #endregion

            #region Repository

            //IRepository<User, int> repository = new UserRepository();
            //repository.Add(new User { Id = 6, Name = "Narges" });
            //repository.Update(new User { Id = 3, Name = "Alireza" });
            //repository.Delete(4);
            //Console.WriteLine(repository.Find(1));
            //foreach (User user in repository.GetAll())
            //{
            //    Console.WriteLine(user);
            //}

            #endregion

            #region UnitOfWork

            //IUnitOfWork unitOfWork = new UnitOfWork();
            //unitOfWork.UserRepository.Add(new User { Id = 1, Name = "Ahmad" });
            //unitOfWork.BankAccountRepository.Add(new BankAccount { Id = 1001, AccountNumber = 1002003001 });
            //unitOfWork.Commit();

            #endregion

            #region Lazy Load

            //Customer customer = CustomerDbSet.Customers.FirstOrDefault(x => x.Id == 1);
            //List<Order> orders = customer.Orders;
            //List<Order> orders2 = customer.Orders;

            #endregion

            #endregion

            Console.Read();
        }
    }
}
