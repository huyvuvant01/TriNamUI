// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.EditorFileBrowserSchemaModelSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class EditorFileBrowserSchemaModelSettings
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Id { get; set; }

    public EditorFileBrowserSchemaModelFieldsSettings Fields { get; } = new EditorFileBrowserSchemaModelFieldsSettings();

    public Editor Editor { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string id = this.Id;
      if ((id != null ? (id.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["id"] = (object) this.Id;
      Dictionary<string, object> source = this.Fields.Serialize();
      if (source.Any<KeyValuePair<string, object>>())
        dictionary["fields"] = (object) source;
      return dictionary;
    }
  }
}
