// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.TileLayoutGapSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class TileLayoutGapSettingsBuilder
  {
    public TileLayoutGapSettingsBuilder(TileLayoutGapSettings container) => this.Container = container;

    protected TileLayoutGapSettings Container { get; private set; }

    public TileLayoutGapSettingsBuilder Columns(double value)
    {
      this.Container.Columns = new double?(value);
      return this;
    }

    public TileLayoutGapSettingsBuilder Rows(double value)
    {
      this.Container.Rows = new double?(value);
      return this;
    }
  }
}
