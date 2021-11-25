// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.SkeletonContainerGridGapSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class SkeletonContainerGridGapSettingsBuilder
  {
    public SkeletonContainerGridGapSettingsBuilder(SkeletonContainerGridGapSettings container) => this.Container = container;

    protected SkeletonContainerGridGapSettings Container { get; private set; }

    public SkeletonContainerGridGapSettingsBuilder Columns(
      double value)
    {
      this.Container.Columns = new double?(value);
      return this;
    }

    public SkeletonContainerGridGapSettingsBuilder Rows(
      double value)
    {
      this.Container.Rows = new double?(value);
      return this;
    }
  }
}
