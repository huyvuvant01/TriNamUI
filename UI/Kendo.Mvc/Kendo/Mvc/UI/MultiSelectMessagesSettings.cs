// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.MultiSelectMessagesSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class MultiSelectMessagesSettings
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Clear { get; set; }

    public string DeleteTag { get; set; }

    public string DownArrow { get; set; }

    public string NoData { get; set; }

    public string SingleTag { get; set; }

    public MultiSelect MultiSelect { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string clear = this.Clear;
      if ((clear != null ? (clear.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["clear"] = (object) this.Clear;
      string deleteTag = this.DeleteTag;
      if ((deleteTag != null ? (deleteTag.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["deleteTag"] = (object) this.DeleteTag;
      string downArrow = this.DownArrow;
      if ((downArrow != null ? (downArrow.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["downArrow"] = (object) this.DownArrow;
      string noData = this.NoData;
      if ((noData != null ? (noData.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["noData"] = (object) this.NoData;
      string singleTag = this.SingleTag;
      if ((singleTag != null ? (singleTag.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["singleTag"] = (object) this.SingleTag;
      return dictionary;
    }
  }
}
