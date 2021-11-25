// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.SkeletonContainerGridSettingsItemBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class SkeletonContainerGridSettingsItemBuilder
  {
    public SkeletonContainerGridSettingsItemBuilder(SkeletonContainerGridSettingsItem container) => this.Container = container;

    protected SkeletonContainerGridSettingsItem Container { get; private set; }

    public SkeletonContainerGridSettingsItemBuilder ColStart(
      double value)
    {
      this.Container.ColStart = new double?(value);
      return this;
    }

    public SkeletonContainerGridSettingsItemBuilder ColSpan(
      double value)
    {
      this.Container.ColSpan = new double?(value);
      return this;
    }

    public SkeletonContainerGridSettingsItemBuilder RowStart(
      double value)
    {
      this.Container.RowStart = new double?(value);
      return this;
    }

    public SkeletonContainerGridSettingsItemBuilder RowSpan(
      double value)
    {
      this.Container.RowSpan = new double?(value);
      return this;
    }

    public SkeletonContainerGridSettingsItemBuilder Shape(
      SkeletonContainerItemShape value)
    {
      this.Container.Shape = new SkeletonContainerItemShape?(value);
      return this;
    }
  }
}
