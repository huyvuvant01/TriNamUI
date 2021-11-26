// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.TreeListFilterableMessagesSettings`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class TreeListFilterableMessagesSettings<T> where T : class
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string And { get; set; }

    public string Clear { get; set; }

    public string Filter { get; set; }

    public string Info { get; set; }

    public string Title { get; set; }

    public string IsFalse { get; set; }

    public string IsTrue { get; set; }

    public string Or { get; set; }

    public Kendo.Mvc.UI.TreeList<T> TreeList { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string and = this.And;
      if ((and != null ? (and.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["and"] = (object) this.And;
      string clear = this.Clear;
      if ((clear != null ? (clear.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["clear"] = (object) this.Clear;
      string filter = this.Filter;
      if ((filter != null ? (filter.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["filter"] = (object) this.Filter;
      string info = this.Info;
      if ((info != null ? (info.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["info"] = (object) this.Info;
      string title = this.Title;
      if ((title != null ? (title.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["title"] = (object) this.Title;
      string isFalse = this.IsFalse;
      if ((isFalse != null ? (isFalse.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["isFalse"] = (object) this.IsFalse;
      string isTrue = this.IsTrue;
      if ((isTrue != null ? (isTrue.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["isTrue"] = (object) this.IsTrue;
      string or = this.Or;
      if ((or != null ? (or.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["or"] = (object) this.Or;
      return dictionary;
    }
  }
}
