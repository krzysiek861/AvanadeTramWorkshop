using Avanade.AzureTramWorkshop.Common;
using Avanade.AzureTramWorkshop.WeightSensor;

Console.WriteLine($"{DateTime.UtcNow} - Start Weight Sensor");

var sensor = new Sensor();
var sender = new MessageSender<Sensor>(sensor);

while (true)
{
    await sender.Run();
}