// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.BarcodeTextSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class BarcodeTextSettingsBuilder
  {
    public BarcodeTextSettingsBuilder(BarcodeTextSettings container) => this.Container = container;

    protected BarcodeTextSettings Container { get; private set; }

    public BarcodeTextSettingsBuilder Margin(double margin)
    {
      this.Container.Margin.Barcode = this.Container.Barcode;
      this.Container.Margin.Top = new double?(margin);
      this.Container.Margin.Bottom = new double?(margin);
      this.Container.Margin.Left = new double?(margin);
      this.Container.Margin.Right = new double?(margin);
      return this;
    }

    public BarcodeTextSettingsBuilder Color(string value)
    {
      this.Container.Color = value;
      return this;
    }

    public BarcodeTextSettingsBuilder Font(string value)
    {
      this.Container.Font = value;
      return this;
    }

    public BarcodeTextSettingsBuilder Margin(
      Action<BarcodeTextMarginSettingsBuilder> configurator)
    {
      this.Container.Margin.Barcode = this.Container.Barcode;
      configurator(new BarcodeTextMarginSettingsBuilder(this.Container.Margin));
      return this;
    }

    public BarcodeTextSettingsBuilder Visible(bool value)
    {
      this.Container.Visible = new bool?(value);
      return this;
    }
  }
}
