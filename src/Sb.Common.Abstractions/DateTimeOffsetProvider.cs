using System;

namespace Sb.Common.Abstractions
{
    public class DateTimeOffsetProvider: IDateTimeOffset
    {
        public DateTimeOffset Now => DateTimeOffset.Now;
        public DateTimeOffset UtcNow => DateTimeOffset.UtcNow;
    }
}
