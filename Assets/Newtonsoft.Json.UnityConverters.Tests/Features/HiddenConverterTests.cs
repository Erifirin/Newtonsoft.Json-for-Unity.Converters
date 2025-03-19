using System;
using System.Linq;
using NUnit.Framework;

namespace Newtonsoft.Json.UnityConverters.Tests
{
    public class HiddenConverterTests
    {
        [Test]
        public void AssertNotRegistered()
        {
            var hiddenConverterRegistered = UnityConverterInitializer.defaultUnityConvertersSettings.Converters
                .Any(x => x.GetType() == typeof(HiddenConverter));

            Assert.IsFalse(hiddenConverterRegistered, "HiddenConverter registered, but should not.");
        }


        [JsonConverterOptions(Hidden = true)]
        internal class HiddenConverter : JsonConverter
        {
            public override bool CanConvert(Type objectType) => false;

            public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
            {
                throw new NotImplementedException();
            }

            public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
            {
                throw new NotImplementedException();
            }
        }
    }
}
