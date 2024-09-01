using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NugetCiAppveyor.Utility.Extensions
{
    public static class StringExtension
    {
        public static string ToCamelCase(this string str) 
        { 
            return str.ToCamelCase();
        }

        public static string ToSerialize(this List<string> list)
        {
            return JsonConvert.SerializeObject(list);
        }
    }
}
