using Avanade.AzureTramWorkshop.Common;
using Avanade.AzureTramWorkshop.EngineTemperatureSensor;

Console.WriteLine($"{DateTime.UtcNow} - Engine Temperature Sensor");

var sensor = new Sensor();
var sender = new MessageSender<Sensor>(sensor);

while (true)
{
    await sender.Run();
}