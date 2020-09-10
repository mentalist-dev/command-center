using System.Threading.Tasks;

namespace Mentalist.CommandCenter.Events
{
    public interface IEventSink
    {
        Task Push<TEvent>(TEvent @event);
    }

    public class NoOpEventSink : IEventSink
    {
        public Task Push<TEvent>(TEvent @event)
        {
            return Task.CompletedTask;
        }
    }
}
