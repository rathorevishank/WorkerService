using WorkerService;

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddHostedService<Worker>();

builder.Services.AddWindowsService();  //add package Microsoft.Extensions.Hosting.WindowsServices
var host = builder.Build();
host.Run();
