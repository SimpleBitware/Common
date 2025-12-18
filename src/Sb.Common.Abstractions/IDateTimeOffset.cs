using System;

namespace Sb.Common.Abstractions
{
    public interface IDateTimeOffset
    {
        public DateTimeOffset Now { get; }
        public DateTimeOffset UtcNow { get; }
    }
}
