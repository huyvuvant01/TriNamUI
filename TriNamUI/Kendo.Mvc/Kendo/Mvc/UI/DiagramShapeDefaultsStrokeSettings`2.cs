﻿// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.DiagramShapeDefaultsStrokeSettings`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class DiagramShapeDefaultsStrokeSettings<TShapeModel, TConnectionModel>
    where TShapeModel : class
    where TConnectionModel : class
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Color { get; set; }

    public string DashType { get; set; }

    public double? Width { get; set; }

    public Kendo.Mvc.UI.Diagram<TShapeModel, TConnectionModel> Diagram { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string color = this.Color;
      if ((color != null ? (color.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["color"] = (object) this.Color;
      string dashType = this.DashType;
      if ((dashType != null ? (dashType.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dashType"] = (object) this.DashType;
      if (this.Width.HasValue)
        dictionary["width"] = (object) this.Width;
      return dictionary;
    }
  }
}
