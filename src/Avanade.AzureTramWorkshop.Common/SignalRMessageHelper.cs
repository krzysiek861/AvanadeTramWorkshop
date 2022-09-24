using Microsoft.Azure.WebJobs.Extensions.SignalRService;

namespace Avanade.AzureTramWorkshop.Common
{
    public static class SignalRMessageHelper
    {
        public static SignalRMessage CreateMessage(string name, string value)
        {
            var data = new SignalRMessageData
            {
                Name = name,
                Value = value
            };

            var message = new SignalRMessage
            {
                Target = "newMessage",
                Arguments = new[] { data }
            };

            return message;
        }
    }
}
