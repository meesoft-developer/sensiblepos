using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;
using NLog.Targets;
using NLog.Config;
namespace SensiblePOS
{
    static class Program
    {
        private static readonly NLog.Logger _logger = NLog.LogManager.GetCurrentClassLogger(); 
        
        [STAThread]
        static void Main()
        {
            IConfigurationBuilder builder = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", true, true);
            //.AddEnvironmentVariables();
            var configuration = builder.Build();
            var language = configuration.GetSection($"AppSettings:Language").Get<string>();
            if(language == "EN")
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
            }
            else
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("th-TH");
            }

            var config = new LoggingConfiguration(); 
            var fileTarget = new FileTarget("logToFile")
            {
                FileName = "${basedir}/logs/app-log.txt",
                Layout = "${longdate} ${level} ${message}  ${exception}",
                ArchiveFileName = "${basedir}/logs/archives/app-log.{#}.txt",
                ArchiveEvery = FileArchivePeriod.Day,
                ArchiveNumbering = ArchiveNumberingMode.Rolling,
                MaxArchiveFiles = 60
            };
            config.AddTarget(fileTarget);
            config.AddRuleForAllLevels(fileTarget);
            NLog.LogManager.Configuration = config;

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
