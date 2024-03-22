using AsrServiceTest;
using AsrServiceTest.DAL;
using AsrServiceTest.DAL.IRepositories;
using AsrServiceTest.DAL.Repositories;
using AsrServiceTest.Data;
using AsrServiceTest.Data.IData;
using AsrServiceTest.Register;
using AsrServiceTest.Register.IRegister;
using AsrServiceTest.Services;
using AsrServiceTest.Services.IServices;
using AsrServiceTest.UserConsoleView;
using AsrServiceTest.UserConsoleView.IMenu;
using Autofac;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

internal class Program
{
    private static void Main(string[] args)
    {
        var serviceProvider = new ServiceCollection()
            .AddSingleton<AppDbContext>()            
            .AddTransient<IProduct, Oil>()
            .AddTransient<IProduct, Wheels>()
            .AddTransient<IManager, Manager>()
            .AddTransient<IConsoleOutputResService, ConsoleOutputResService>()
            .AddTransient<ITransactionManager,TransactionsManager>()
            .AddTransient<IConsoleView, ConsoleView>()
            .AddTransient<ITransactionsMenu, TransactionsMenu>()
            .AddTransient<IProductSelection, ProductSelection>()
            .AddTransient<IDiagnostics, Diagnostics>()
            .AddTransient<IReplacement, Replacement>()
            .AddTransient<IPayment, Payment>()
            .AddSingleton<IOrderLineRepository,OrderLineRepository>()
            .AddTransient<ISavePaymentData, SavePaymentData>()
            .AddTransient<ITransactionsOverview, TransactionsOverview>()
            

            .BuildServiceProvider();
        
        var program = serviceProvider.GetService<IConsoleView>();
        program.ConsoleInterface();





        //var builder = new ContainerBuilder();

        //builder.RegisterType<Oil>().As<IProduct>();
        //builder.RegisterType<Wheels>().As<IProduct>();
        //builder.RegisterType<PaymentData>().As<IPaymentData>().SingleInstance();
        //builder.RegisterType<ProductSelection>().As<IProductSelection>();
        //builder.RegisterType<Diagnostics>().As<IDiagnostics>();
        //builder.RegisterType<ConsoleView>().As<IConsoleView>();
        //builder.RegisterType<Replacement>().As<IReplacement>();
        //builder.RegisterType<Payment>().As<IPayment>();
        //builder.RegisterType<PaymentOverview>().As<IPaymentOverview>();
        //builder.RegisterType<SavePaymentData>().As<ISavePaymentData>();
        //builder.RegisterType<ConsoleOutputResService>().As<IConsoleOutputResService>();

        //var container = builder.Build();

        //using (var scope = container.BeginLifetimeScope())
        //{
        //    var consoleView = scope.Resolve<IConsoleView>();
        //    consoleView.ConsoleInterface();
        //}
    }

}

