using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
    public static class DateConvertor
    {
        public static string ToShamsi(this DateTime date)
        {
            System.Globalization.PersianCalendar pc = new System.Globalization.PersianCalendar();
            return string.Format("{0}/{1}/{2}", pc.GetYear(date), pc.GetMonth(date).ToString("00"), pc.GetDayOfMonth(date).ToString("00"));
        }
    }
}
