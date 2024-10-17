using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Storage;

namespace MyTest
{
    class LocalStorage
    {
        private static string data = "just_data";

        public static void SetValue(string value)
        {
            Preferences.Set(data, value);
        }
        public static string GetValue()
        {
                return Preferences.Get(data, data);
        }
    }
}
