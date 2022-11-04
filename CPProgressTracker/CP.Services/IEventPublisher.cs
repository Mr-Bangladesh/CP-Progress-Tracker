using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP.Services
{
    /// <summary>
    /// Represents an event publisher
    /// </summary>
    public interface IEventPublisher
    {
        /// <summary>
        /// Publish event to consumers
        /// </summary>
        /// <typeparam name="TEvent">Type of event</typeparam>
        /// <param name="event">Event object</param>
        void Publish<TEvent>(TEvent @event);
    }
}
