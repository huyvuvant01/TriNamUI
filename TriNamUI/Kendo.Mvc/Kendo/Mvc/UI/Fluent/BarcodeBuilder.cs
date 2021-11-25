// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.BarcodeBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class BarcodeBuilder : WidgetBuilderBase<Barcode, BarcodeBuilder>
  {
    public BarcodeBuilder(Barcode component)
      : base(component)
    {
    }

    public BarcodeBuilder Padding(double padding)
    {
      this.Container.Padding.Barcode = this.Container;
      this.Container.Padding.Bottom = new double?(padding);
      this.Container.Padding.Top = new double?(padding);
      this.Container.Padding.Left = new double?(padding);
      this.Container.Padding.Right = new double?(padding);
      return this;
    }

    public BarcodeBuilder Encoding(BarcodeSymbology encoding)
    {
      this.Container.Encoding = encoding;
      return this;
    }

    public BarcodeBuilder RenderAs(RenderingMode value)
    {
      this.Container.RenderAs = new RenderingMode?(value);
      return this;
    }

    public BarcodeBuilder Background(string value)
    {
      this.Container.Background = value;
      return this;
    }

    public BarcodeBuilder Border(Action<BarcodeBorderSettingsBuilder> configurator)
    {
      this.Container.Border.Barcode = this.Container;
      configurator(new BarcodeBorderSettingsBuilder(this.Container.Border));
      return this;
    }

    public BarcodeBuilder Checksum(bool value)
    {
      this.Container.Checksum = new bool?(value);
      return this;
    }

    public BarcodeBuilder Checksum()
    {
      this.Container.Checksum = new bool?(true);
      return this;
    }

    public BarcodeBuilder Color(string value)
    {
      this.Container.Color = value;
      return this;
    }

    public BarcodeBuilder Height(double value)
    {
      this.Container.Height = new double?(value);
      return this;
    }

    public BarcodeBuilder Padding(Action<BarcodePaddingSettingsBuilder> configurator)
    {
      this.Container.Padding.Barcode = this.Container;
      configurator(new BarcodePaddingSettingsBuilder(this.Container.Padding));
      return this;
    }

    public BarcodeBuilder Text(Action<BarcodeTextSettingsBuilder> configurator)
    {
      this.Container.Text.Barcode = this.Container;
      configurator(new BarcodeTextSettingsBuilder(this.Container.Text));
      return this;
    }

    public BarcodeBuilder Value(string value)
    {
      this.Container.Value = value;
      return this;
    }

    public BarcodeBuilder Width(double value)
    {
      this.Container.Width = new double?(value);
      return this;
    }
  }
}
