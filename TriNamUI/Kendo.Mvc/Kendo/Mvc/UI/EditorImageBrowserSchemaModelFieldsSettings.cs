// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.EditorImageBrowserSchemaModelFieldsSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class EditorImageBrowserSchemaModelFieldsSettings
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public EditorImageBrowserSchemaModelFieldsNameSettings Name { get; } = new EditorImageBrowserSchemaModelFieldsNameSettings();

    public EditorImageBrowserSchemaModelFieldsTypeSettings Type { get; } = new EditorImageBrowserSchemaModelFieldsTypeSettings();

    public EditorImageBrowserSchemaModelFieldsSizeSettings Size { get; } = new EditorImageBrowserSchemaModelFieldsSizeSettings();

    public Editor Editor { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      Dictionary<string, object> source1 = this.Name.Serialize();
      if (source1.Any<KeyValuePair<string, object>>())
        dictionary["name"] = (object) source1;
      Dictionary<string, object> source2 = this.Type.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
        dictionary["type"] = (object) source2;
      Dictionary<string, object> source3 = this.Size.Serialize();
      if (source3.Any<KeyValuePair<string, object>>())
        dictionary["size"] = (object) source3;
      return dictionary;
    }
  }
}
