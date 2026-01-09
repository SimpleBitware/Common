using System;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleBitware.Common.Abstractions;

public interface ITask
{
    Task Delay(int millisecondsDelay);
    Task Delay(int millisecondsDelay, CancellationToken cancellationToken);
    Task Delay(TimeSpan delay);
    Task Delay(TimeSpan delay, CancellationToken cancellationToken);
}
