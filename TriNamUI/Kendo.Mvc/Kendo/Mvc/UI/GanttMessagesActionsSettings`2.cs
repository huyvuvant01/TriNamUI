// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.GanttMessagesActionsSettings`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class GanttMessagesActionsSettings<TTaskModel, TDependenciesModel>
    where TTaskModel : class, IGanttTask
    where TDependenciesModel : class, IGanttDependency
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string AddChild { get; set; }

    public string Append { get; set; }

    public string InsertAfter { get; set; }

    public string InsertBefore { get; set; }

    public string Pdf { get; set; }

    public Kendo.Mvc.UI.Gantt<TTaskModel, TDependenciesModel> Gantt { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string addChild = this.AddChild;
      if ((addChild != null ? (addChild.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["addChild"] = (object) this.AddChild;
      string append = this.Append;
      if ((append != null ? (append.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["append"] = (object) this.Append;
      string insertAfter = this.InsertAfter;
      if ((insertAfter != null ? (insertAfter.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["insertAfter"] = (object) this.InsertAfter;
      string insertBefore = this.InsertBefore;
      if ((insertBefore != null ? (insertBefore.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["insertBefore"] = (object) this.InsertBefore;
      string pdf = this.Pdf;
      if ((pdf != null ? (pdf.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["pdf"] = (object) this.Pdf;
      return dictionary;
    }
  }
}
