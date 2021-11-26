using System.Collections.Generic;

namespace TriNamUI.Infrastructure
{
    public partial interface IJavaScriptInitializer
    {
        IJavaScriptSerializer CreateSerializer();

        string Initialize(string id, string name, IDictionary<string, object> options);

        string InitializeFor(string selector, string name, IDictionary<string, object> options);

        string Serialize(IDictionary<string, object> value);
    }
}
