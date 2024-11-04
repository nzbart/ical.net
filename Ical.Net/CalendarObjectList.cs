﻿using System.Diagnostics.CodeAnalysis;
using Ical.Net.Collections;

namespace Ical.Net
{
    /// <summary>
    /// A collection of calendar objects.
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class CalendarObjectList : GroupedList<string, ICalendarObject>, ICalendarObjectList<ICalendarObject>
    {
    }
}