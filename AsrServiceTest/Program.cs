using AsrServiceTest.Data;
using AsrServiceTest.Data.IData;
using AsrServiceTest.Register;
using AsrServiceTest.Register.IRegister;
using AsrServiceTest.Services;
using AsrServiceTest.Services.IServices;
using AsrServiceTest.UserConsoleView;
using Autofac;
using Microsoft.Extensions.DependencyInjection;
using System.Security.Cryptography;

internal class Program
{
    private static void Main(string[] args)
    {
        var serviceProvider = new ServiceCollection()
            .AddSingleton<IPaymentData, PaymentData>()
            .AddTransient<IProduct, Oil>()
            .AddTransient<IProduct, Wheels>()       
            .AddTransient<IManager, Manager>()
            .AddTransient<IConsoleOutputResService, ConsoleOutputResService>()
            .AddTransient<IConsoleView, ConsoleView>()
            .AddTransient<IProductSelection, ProductSelection>()
            .AddTransient<IDiagnostics, Diagnostics>()
            .AddTransient<IReplacement, Replacement>()
            .AddTransient<IPayment, Payment>()
            .AddTransient<ISavePaymentData, SavePaymentData>()
            .AddTransient<IPaymentOverview, PaymentOverview>()


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

