// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.OrgChartEditableSettings`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class OrgChartEditableSettings<T> where T : class
  {
    public Kendo.Mvc.UI.Form<T> Form { get; set; }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      if (this.Form != null)
        dictionary["form"] = (object) this.Form.Serialize();
      return dictionary;
    }

    public bool? Create { get; set; }

    public bool? Destroy { get; set; }

    public bool? Fields { get; set; }

    public bool? Parent { get; set; }

    public bool? Enabled { get; set; }

    public Kendo.Mvc.UI.OrgChart<T> OrgChart { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.Create.HasValue)
        dictionary["create"] = (object) this.Create;
      if (this.Destroy.HasValue)
        dictionary["destroy"] = (object) this.Destroy;
      if (this.Fields.HasValue)
        dictionary["fields"] = (object) this.Fields;
      if (this.Parent.HasValue)
        dictionary["parent"] = (object) this.Parent;
      return dictionary;
    }
  }
}
