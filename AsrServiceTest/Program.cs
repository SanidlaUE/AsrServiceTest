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
        //var serviceProvider = new ServiceCollection()
        //    .AddTransient<Oil>()
        //    .AddTransient<Wheels>()
        //    .AddTransient<ITool>(provider => provider.GetService<Oil>())
        //    .AddTransient<ITool>(provider => provider.GetService<Wheels>())
        //    .AddTransient<IToolSelection, ToolSelection>()
        //    .AddTransient<IDiagnostics, Diagnostics>()
        //    .AddTransient<IConsoleView, ConsoleView>()

        //    .BuildServiceProvider();


        //var toolSelection = serviceProvider.GetService<IToolSelection>();
        //var consoleView = serviceProvider.GetService<IConsoleView>();
        //var diagnostics = serviceProvider.GetService<IDiagnostics>();
        //consoleView.ConsoleInterface(diagnostics, toolSelection);
        //diagnostics.CheckState(toolSelection);

        var builder = new ContainerBuilder();

        builder.RegisterType<Oil>().As<ITool>();
        builder.RegisterType<Wheels>().As<ITool>();
        builder.RegisterType<PaymentData>().As<IPaymentData>();
        builder.RegisterType<ToolSelection>().As<IToolSelection>();
        builder.RegisterType<Diagnostics>().As<IDiagnostics>();
        builder.RegisterType<ConsoleView>().As<IConsoleView>();
        builder.RegisterType<Replacement>().As<IReplacement>();
        builder.RegisterType<Payment>().As<IPayment>();
        builder.RegisterType<PaymentOverview>().As<IPaymentOverview>(); 
        builder.RegisterType<SavePaymentData>().As<ISavePaymentData>();
        builder.RegisterType<ConsoleOutputResService>().As<IConsoleOutputResService>();

        var container = builder.Build();

        using(var scope = container.BeginLifetimeScope())
        {
            var oil = new Oil();
            var wheels = new Wheels();
            var paymentData = new PaymentData();
            var consoleOutputResService = new ConsoleOutputResService();
            var savePaymentData = new SavePaymentData(paymentData);
            var paymentOverview = new PaymentOverview(paymentData,consoleOutputResService);
            var toolSelection = new ToolSelection(oil, wheels, consoleOutputResService);
            var payment = new Payment(consoleOutputResService);           
            var replacement = new Replacement(toolSelection, consoleOutputResService, payment, savePaymentData);
            var diagnostics = new Diagnostics(toolSelection,consoleOutputResService);
            var consoleView = new ConsoleView(diagnostics,replacement,paymentOverview);

            consoleView.ConsoleInterface();
        }

    }
}
