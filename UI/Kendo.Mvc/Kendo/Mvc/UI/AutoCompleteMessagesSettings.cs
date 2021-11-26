// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.AutoCompleteMessagesSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class AutoCompleteMessagesSettings
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Clear { get; set; }

    public string NoData { get; set; }

    public AutoComplete AutoComplete { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string clear = this.Clear;
      if ((clear != null ? (clear.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["clear"] = (object) this.Clear;
      string noData = this.NoData;
      if ((noData != null ? (noData.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["noData"] = (object) this.NoData;
      return dictionary;
    }
  }
}
