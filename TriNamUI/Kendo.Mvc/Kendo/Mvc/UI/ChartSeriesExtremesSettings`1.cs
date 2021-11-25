// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.ChartSeriesExtremesSettings`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class ChartSeriesExtremesSettings<T> where T : class
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Background { get; set; }

    public ClientHandlerDescriptor BackgroundHandler { get; set; }

    public ChartSeriesExtremesBorderSettings<T> Border { get; } = new ChartSeriesExtremesBorderSettings<T>();

    public double? Size { get; set; }

    public ClientHandlerDescriptor SizeHandler { get; set; }

    public string Type { get; set; }

    public ClientHandlerDescriptor TypeHandler { get; set; }

    public double? Rotation { get; set; }

    public ClientHandlerDescriptor RotationHandler { get; set; }

    public Kendo.Mvc.UI.Chart<T> Chart { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      ClientHandlerDescriptor backgroundHandler = this.BackgroundHandler;
      if ((backgroundHandler != null ? (backgroundHandler.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary["background"] = (object) this.BackgroundHandler;
      }
      else
      {
        string background = this.Background;
        if ((background != null ? (background.HasValue() ? 1 : 0) : 0) != 0)
          dictionary["background"] = (object) this.Background;
      }
      Dictionary<string, object> source = this.Border.Serialize();
      if (source.Any<KeyValuePair<string, object>>())
        dictionary["border"] = (object) source;
      ClientHandlerDescriptor sizeHandler = this.SizeHandler;
      double? nullable;
      if ((sizeHandler != null ? (sizeHandler.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary["size"] = (object) this.SizeHandler;
      }
      else
      {
        nullable = this.Size;
        if (nullable.HasValue)
          dictionary["size"] = (object) this.Size;
      }
      ClientHandlerDescriptor typeHandler = this.TypeHandler;
      if ((typeHandler != null ? (typeHandler.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary["type"] = (object) this.TypeHandler;
      }
      else
      {
        string type = this.Type;
        if ((type != null ? (type.HasValue() ? 1 : 0) : 0) != 0)
          dictionary["type"] = (object) this.Type;
      }
      ClientHandlerDescriptor rotationHandler = this.RotationHandler;
      if ((rotationHandler != null ? (rotationHandler.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary["rotation"] = (object) this.RotationHandler;
      }
      else
      {
        nullable = this.Rotation;
        if (nullable.HasValue)
          dictionary["rotation"] = (object) this.Rotation;
      }
      return dictionary;
    }
  }
}
