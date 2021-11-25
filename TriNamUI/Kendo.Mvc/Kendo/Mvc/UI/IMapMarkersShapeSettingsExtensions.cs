// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.IMapMarkersShapeSettingsExtensions
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public static class IMapMarkersShapeSettingsExtensions
  {
    public static void SerializeShape(
      this IMapMarkersShapeSettings self,
      Dictionary<string, object> settings)
    {
      if (self.ShapeName.HasValue())
      {
        settings["shape"] = (object) self.ShapeName;
      }
      else
      {
        MapMarkersShape? shape = self.Shape;
        if (!shape.HasValue)
          return;
        shape = self.Shape;
        string str = shape.ToString();
        settings["shape"] = (object) (str.ToLowerInvariant()[0].ToString() + str.Substring(1));
      }
    }
  }
}
