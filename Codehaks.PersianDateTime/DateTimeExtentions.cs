using System;
using static Codehaks.PersianDateTime.PersianDateTime;

namespace Codehaks.PersianDateTime
{
    public static class DateTimeExtentions
    {
        public static string ToPersianDate(this DateTime dateTime)
        {
            return PersianDateHelper.GetPersianDate(dateTime);
        }

        public static string ToPersianDateTime(this DateTime dateTime)
        {
            return PersianDateHelper.GetPersianDateTime(dateTime);
        }

        public static string ToFullPersianDateTime(this DateTime dateTime)
        {
            return PersianDateHelper.GetFullPersianDateTime(dateTime);
        }

        public static string ToFullPersianDate(this DateTime dateTime)
        {
            return PersianDateHelper.GetFullPersianDate(dateTime);
        }
    }
}