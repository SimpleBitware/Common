using System;

namespace SimpleBitware.Common.Abstractions;

public class DateTimeOffsetProvider: IDateTimeOffset
{
    public DateTimeOffset Now => DateTimeOffset.Now;
    public DateTimeOffset UtcNow => DateTimeOffset.UtcNow;
}
