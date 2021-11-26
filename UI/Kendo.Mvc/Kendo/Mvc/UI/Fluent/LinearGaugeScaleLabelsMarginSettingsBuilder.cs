// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.LinearGaugeScaleLabelsMarginSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class LinearGaugeScaleLabelsMarginSettingsBuilder
  {
    public LinearGaugeScaleLabelsMarginSettingsBuilder(
      LinearGaugeScaleLabelsMarginSettings container)
    {
      this.Container = container;
    }

    protected LinearGaugeScaleLabelsMarginSettings Container { get; private set; }

    public LinearGaugeScaleLabelsMarginSettingsBuilder Top(
      double value)
    {
      this.Container.Top = new double?(value);
      return this;
    }

    public LinearGaugeScaleLabelsMarginSettingsBuilder Bottom(
      double value)
    {
      this.Container.Bottom = new double?(value);
      return this;
    }

    public LinearGaugeScaleLabelsMarginSettingsBuilder Left(
      double value)
    {
      this.Container.Left = new double?(value);
      return this;
    }

    public LinearGaugeScaleLabelsMarginSettingsBuilder Right(
      double value)
    {
      this.Container.Right = new double?(value);
      return this;
    }
  }
}
