// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.FilterMessagesSettings`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class FilterMessagesSettings<T> where T : class
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string AddExpression { get; set; }

    public string AddGroup { get; set; }

    public string And { get; set; }

    public string Apply { get; set; }

    public string Close { get; set; }

    public string Fields { get; set; }

    public string Operators { get; set; }

    public string Or { get; set; }

    public Kendo.Mvc.UI.Filter<T> Filter { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string addExpression = this.AddExpression;
      if ((addExpression != null ? (addExpression.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["addExpression"] = (object) this.AddExpression;
      string addGroup = this.AddGroup;
      if ((addGroup != null ? (addGroup.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["addGroup"] = (object) this.AddGroup;
      string and = this.And;
      if ((and != null ? (and.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["and"] = (object) this.And;
      string apply = this.Apply;
      if ((apply != null ? (apply.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["apply"] = (object) this.Apply;
      string close = this.Close;
      if ((close != null ? (close.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["close"] = (object) this.Close;
      string fields = this.Fields;
      if ((fields != null ? (fields.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["fields"] = (object) this.Fields;
      string operators = this.Operators;
      if ((operators != null ? (operators.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["operators"] = (object) this.Operators;
      string or = this.Or;
      if ((or != null ? (or.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["or"] = (object) this.Or;
      return dictionary;
    }
  }
}
