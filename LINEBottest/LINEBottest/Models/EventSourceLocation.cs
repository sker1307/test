using Microsoft.WindowsAzure.Storage.Table;

namespace LINEBottest.Models
{
    public class EventSourceLocation : EventSourceState
    {
        public string Location { get; set; }

        public EventSourceLocation() { }
    }
}