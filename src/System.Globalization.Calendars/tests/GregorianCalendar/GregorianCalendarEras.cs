// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Xunit;

namespace System.Globalization.Tests
{
    public class GregorianCalendarEras
    {
        [Theory]
        [InlineData(GregorianCalendarTypes.Arabic)]
        [InlineData(GregorianCalendarTypes.Localized)]
        [InlineData(GregorianCalendarTypes.MiddleEastFrench)]
        [InlineData(GregorianCalendarTypes.TransliteratedEnglish)]
        [InlineData(GregorianCalendarTypes.TransliteratedFrench)]
        [InlineData(GregorianCalendarTypes.USEnglish)]
        public void Eras(GregorianCalendarTypes calendarType)
        {
            Calendar calendar = new GregorianCalendar(calendarType);
            Assert.Equal(new int[] { 1 }, calendar.Eras);
        }
    }
}
