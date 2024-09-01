using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NugetCiAppveyor.Utilities.Extensions
{
    public static class StringExtension
    {
        public static string ToString(this List<string> value)
        {
            return JsonConvert.SerializeObject(value);
        }
    }
}
