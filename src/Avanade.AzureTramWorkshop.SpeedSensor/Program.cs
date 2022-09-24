using Avanade.AzureTramWorkshop.Common;
using Avanade.AzureTramWorkshop.SpeedSensor;

Console.WriteLine($"{DateTime.UtcNow} - Start Speed Sensor");

var sensor = new Sensor();
var sender = new MessageSender<Sensor>(sensor);

while (true)
{
    await sender.Run();
}