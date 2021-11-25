// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.DiagramShapeEditableSettings`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class DiagramShapeEditableSettings<TShapeModel, TConnectionModel>
    where TShapeModel : class
    where TConnectionModel : class
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public bool? Connect { get; set; }

    public List<DiagramShapeEditableSettingsTool<TShapeModel, TConnectionModel>> Tools { get; set; } = new List<DiagramShapeEditableSettingsTool<TShapeModel, TConnectionModel>>();

    public bool? Enabled { get; set; }

    public Kendo.Mvc.UI.Diagram<TShapeModel, TConnectionModel> Diagram { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.Connect.HasValue)
        dictionary["connect"] = (object) this.Connect;
      IEnumerable<Dictionary<string, object>> source = this.Tools.Select<DiagramShapeEditableSettingsTool<TShapeModel, TConnectionModel>, Dictionary<string, object>>((Func<DiagramShapeEditableSettingsTool<TShapeModel, TConnectionModel>, Dictionary<string, object>>) (i => i.Serialize()));
      if (source.Any<Dictionary<string, object>>())
        dictionary["tools"] = (object) source;
      return dictionary;
    }
  }
}
