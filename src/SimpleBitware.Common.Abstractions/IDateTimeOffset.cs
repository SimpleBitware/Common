using System;

namespace SimpleBitware.Common.Abstractions;

public interface IDateTimeOffset
{
    public DateTimeOffset Now { get; }
    public DateTimeOffset UtcNow { get; }
}
