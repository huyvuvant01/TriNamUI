// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.ChartSpacing
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class ChartSpacing
  {
    public ChartSpacing(int? margin)
    {
      this.Top = margin;
      this.Right = margin;
      this.Bottom = margin;
      this.Left = margin;
    }

    public ChartSpacing()
    {
    }

    public int? Top { get; set; }

    public int? Right { get; set; }

    public int? Bottom { get; set; }

    public int? Left { get; set; }

    public virtual Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.Top.HasValue)
        dictionary["top"] = (object) this.Top;
      if (this.Bottom.HasValue)
        dictionary["bottom"] = (object) this.Bottom;
      if (this.Left.HasValue)
        dictionary["left"] = (object) this.Left;
      if (this.Right.HasValue)
        dictionary["right"] = (object) this.Right;
      return dictionary;
    }
  }
}
