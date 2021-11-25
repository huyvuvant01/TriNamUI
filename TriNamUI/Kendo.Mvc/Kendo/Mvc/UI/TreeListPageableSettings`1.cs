// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.TreeListPageableSettings`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class TreeListPageableSettings<T> where T : class
  {
    public int[] PageSizes { get; set; }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      if (this.PageSizes != null && this.PageSizes.Length != 0)
        dictionary["pageSizes"] = (object) this.PageSizes;
      return dictionary;
    }

    public bool? AlwaysVisible { get; set; }

    public double? PageSize { get; set; }

    public bool? PreviousNext { get; set; }

    public bool? Numeric { get; set; }

    public double? ButtonCount { get; set; }

    public bool? Input { get; set; }

    public bool? Refresh { get; set; }

    public bool? Responsive { get; set; }

    public bool? Info { get; set; }

    public TreeListPageableMessagesSettings<T> Messages { get; } = new TreeListPageableMessagesSettings<T>();

    public bool? Enabled { get; set; }

    public Kendo.Mvc.UI.TreeList<T> TreeList { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.AlwaysVisible.HasValue)
        dictionary["alwaysVisible"] = (object) this.AlwaysVisible;
      if (this.PageSize.HasValue)
        dictionary["pageSize"] = (object) this.PageSize;
      if (this.PreviousNext.HasValue)
        dictionary["previousNext"] = (object) this.PreviousNext;
      if (this.Numeric.HasValue)
        dictionary["numeric"] = (object) this.Numeric;
      if (this.ButtonCount.HasValue)
        dictionary["buttonCount"] = (object) this.ButtonCount;
      if (this.Input.HasValue)
        dictionary["input"] = (object) this.Input;
      if (this.Refresh.HasValue)
        dictionary["refresh"] = (object) this.Refresh;
      if (this.Responsive.HasValue)
        dictionary["responsive"] = (object) this.Responsive;
      if (this.Info.HasValue)
        dictionary["info"] = (object) this.Info;
      Dictionary<string, object> source = this.Messages.Serialize();
      if (source.Any<KeyValuePair<string, object>>())
        dictionary["messages"] = (object) source;
      return dictionary;
    }
  }
}
