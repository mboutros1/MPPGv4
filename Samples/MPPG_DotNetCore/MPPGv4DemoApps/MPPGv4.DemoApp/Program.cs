using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MPPGv4.ServiceFactory;
using MPPGv4.UIFactory;
using System;
using System.IO;

namespace MPPGv4.DemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json");

            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", true, true)
                .Build();

            IServiceCollection services = new ServiceCollection();
            services.AddSingleton<IConfiguration>(config);
            services.AddSingleton<IMppgv4UIFactory, Mppgv4UIfactory>();
            services.AddSingleton<IProcessCardSwipeClient, ProcessCardSwipeClient>();
            services.AddSingleton<IProcessKeyPadEntryClient, ProcessKeyPadEntryClient>();
            services.AddSingleton<IProcessDataClient, ProcessDataClient>();
            services.AddSingleton<IProcessManualEntryClient, ProcessManualEntryClient>();
            services.AddSingleton<IProcessTokenClient, ProcessTokenClient>();
            IServiceProvider serviceProvider = services.BuildServiceProvider();
            var uiFactory = serviceProvider.GetService<IMppgv4UIFactory>();

            while (true)
            {
                try
                {
                    Console.WriteLine("Please Select an option or service operation");
                    Console.WriteLine("Enter Option number (1:ProcessCardSwipe, 2: ProcessManualEntry, 3: ProcessData, 4: ProcessKeyPadEntry, 5:ProcessToken)");
                    var keyInfo = Console.ReadKey();
                    Console.WriteLine();

                    switch (keyInfo.Key)
                    {
                        case ConsoleKey.D1:
                            uiFactory.ShowUI(MPPGv4UI.PROCESSCARDSWIPE);
                            break;
                        case ConsoleKey.D2:
                            uiFactory.ShowUI(MPPGv4UI.PROCESSMANUALENTRY);
                            break;
                        case ConsoleKey.D3:
                            uiFactory.ShowUI(MPPGv4UI.PROCESSDATA);
                            break;
                        case ConsoleKey.D4:
                            uiFactory.ShowUI(MPPGv4UI.PROCESSKEYPADENTRY);
                            break;
                        case ConsoleKey.D5:
                            uiFactory.ShowUI(MPPGv4UI.PROCESSTOKEN);
                            break;
                    }
                    bool decision = Confirm("Would you like to Continue with other Request");
                    if (decision)
                        continue;
                    else
                        break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public static bool Confirm(string title)
        {
            ConsoleKey response;
            do
            {
                Console.Write($"{ title } [y/n] ");
                response = Console.ReadKey(false).Key;
                if (response != ConsoleKey.Enter)
                {
                    Console.WriteLine();
                }
            } while (response != ConsoleKey.Y && response != ConsoleKey.N);

            return (response == ConsoleKey.Y);
        }
    }
}
