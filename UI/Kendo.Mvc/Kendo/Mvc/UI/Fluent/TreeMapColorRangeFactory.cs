// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.TreeMapColorRangeFactory
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class TreeMapColorRangeFactory
  {
    private readonly TreeMap container;

    public TreeMapColorRangeFactory(TreeMap component) => this.container = component;

    public TreeMapColorRangeFactory AddRange(
      string fromColor,
      string toColor)
    {
      this.container.ColorRanges.Add(new string[2]
      {
        fromColor,
        toColor
      });
      return new TreeMapColorRangeFactory(this.container);
    }
  }
}
