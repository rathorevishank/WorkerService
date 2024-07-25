Worker Service Project
This project is a Worker Service in C# that processes messages from an Azure Service Bus queue. It runs as a Windows Service, ensuring reliable and scalable background processing.

Steps to Set Up and Run the Worker Service
Clone the Repository:
git clone https://github.com/rathorevishank/WorkerService.git
cd WorkerService

Install .NET SDK: Ensure you have the .NET SDK installed. You can download it from the .NET website.
Install Required NuGet Packages:
dotnet restore

Configure Azure Service Bus:
Open the appsettings.json file.
Replace "your_connection_string" with your Azure Service Bus connection string.
Replace "your_queue_name" with the name of your queue.
JSON

{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  },
  "ServiceBusConnectionString": "your_connection_string",
  "QueueName": "your_queue_name"
}
AI-generated code. Review and use carefully. More info on FAQ.
Build the Project:
dotnet build

Publish the Project:
dotnet publish -c Release -o ./publish

Create and Install the Windows Service:
Open a Command Prompt as Administrator.
Use the sc command to create the service. Replace YourServiceName with the desired name of your service and YourServicePath with the path to your published executable:
sc create YourServiceName binPath= "YourServicePath\YourExecutable.exe"

Start the Service:
sc start YourServiceName

Example
Assuming your service is named MyWorkerService and the executable is located at C:\Services\MyWorkerService\MyWorkerService.exe, the commands would be:

sc create MyWorkerService binPath= "C:\Services\MyWorkerService\MyWorkerService.exe"
sc start MyWorkerService

Additional Commands
Stopping the Service:
sc stop YourServiceName

Deleting the Service:
sc delete YourServiceName

Description of the Project
This project is a Worker Service in C# that processes messages from an Azure Service Bus queue. It runs as a Windows Service, ensuring reliable and scalable background processing.
