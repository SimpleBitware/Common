using System;

namespace Sb.Common.Abstractions
{
    public interface IDateTime
    {
        DateTime Now { get; }
        DateTime UtcNow { get; }
        DateTime Today { get; }
    }
}
