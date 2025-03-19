using System;

namespace Newtonsoft.Json.UnityConverters
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class JsonConverterOptionsAttribute : Attribute
    {
        public bool Hidden { get; set; }
    }
}
