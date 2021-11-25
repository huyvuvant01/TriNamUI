﻿// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ArcGaugeScaleLabelsPaddingSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class ArcGaugeScaleLabelsPaddingSettingsBuilder
  {
    public ArcGaugeScaleLabelsPaddingSettingsBuilder(ArcGaugeScaleLabelsPaddingSettings container) => this.Container = container;

    protected ArcGaugeScaleLabelsPaddingSettings Container { get; private set; }

    public ArcGaugeScaleLabelsPaddingSettingsBuilder Top(
      double value)
    {
      this.Container.Top = new double?(value);
      return this;
    }

    public ArcGaugeScaleLabelsPaddingSettingsBuilder Bottom(
      double value)
    {
      this.Container.Bottom = new double?(value);
      return this;
    }

    public ArcGaugeScaleLabelsPaddingSettingsBuilder Left(
      double value)
    {
      this.Container.Left = new double?(value);
      return this;
    }

    public ArcGaugeScaleLabelsPaddingSettingsBuilder Right(
      double value)
    {
      this.Container.Right = new double?(value);
      return this;
    }
  }
}
