using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP.Services
{
    /// <summary>
    /// Consumer interface
    /// </summary>
    /// <typeparam name="T">Type</typeparam>
    public interface IConsumer<T>
    {
        /// <summary>
        /// Handle event
        /// </summary>
        /// <param name="eventMessage">Event</param>
        void HandleEvent(T eventMessage);
    }
}
