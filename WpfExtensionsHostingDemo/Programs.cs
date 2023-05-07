// After adding the following usings, the publish succeeds.
//using Microsoft.Extensions.Hosting;
//using Wpf.Extensions.Hosting;

using WpfExtensionsHostingDemo;

var builder = WpfApplication<App, MainWindow>.CreateBuilder(args);

var app = builder.Build();
await app.RunAsync();
