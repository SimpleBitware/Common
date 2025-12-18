using System;

namespace Sb.Common.Abstractions
{
    public class DateTimeProvider : IDateTime
    {
        public DateTime Now => DateTime.Now;

        public DateTime UtcNow => DateTime.UtcNow;

        public DateTime Today => DateTime.Today;
    }
}
