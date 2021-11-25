// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.FloatingActionButtonAlignOffsetBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class FloatingActionButtonAlignOffsetBuilder
  {
    private readonly FloatingActionButtonAlignOffset container;

    public FloatingActionButtonAlignOffsetBuilder(FloatingActionButtonAlignOffset settings) => this.container = settings;

    public FloatingActionButtonAlignOffsetBuilder Horizontal(
      string value)
    {
      this.container.Horizontal = value;
      return this;
    }

    public FloatingActionButtonAlignOffsetBuilder Horizontal(
      int value)
    {
      this.container.Horizontal = value.ToString() + "px";
      return this;
    }

    public FloatingActionButtonAlignOffsetBuilder Vertical(
      string value)
    {
      this.container.Vertical = value;
      return this;
    }

    public FloatingActionButtonAlignOffsetBuilder Vertical(
      int value)
    {
      this.container.Vertical = value.ToString() + "px";
      return this;
    }
  }
}
