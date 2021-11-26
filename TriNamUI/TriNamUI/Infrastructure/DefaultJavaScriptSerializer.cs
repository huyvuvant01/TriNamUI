using Newtonsoft.Json;

namespace TriNamUI.Infrastructure
{
    public partial class DefaultJavaScriptSerializer : IJavaScriptSerializer
    {
        public string Serialize(object value)
        {
            return JsonConvert.SerializeObject(value).Replace("<", "\\u003c").Replace(">", "\\u003e");
        }
    }
}
