using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading;


namespace Ext_example
{
    public static class StringExtension
    {
        public static String ConvertToTitleCase(this string source)
        {
            CultureInfo CI=Thread.CurrentThread.CurrentCulture;
            TextInfo TI=CI.TextInfo;

            return TI.ToTitleCase(source);
        }
    }
}
