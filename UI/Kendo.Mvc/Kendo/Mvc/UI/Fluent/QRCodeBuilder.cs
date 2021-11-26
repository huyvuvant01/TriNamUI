// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.QRCodeBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class QRCodeBuilder : WidgetBuilderBase<QRCode, QRCodeBuilder>
  {
    public QRCodeBuilder(QRCode component)
      : base(component)
    {
    }

    public QRCodeBuilder Border(string color, int width)
    {
      this.Container.Border.QRCode = this.Container;
      this.Container.Border.Color = color;
      this.Container.Border.Width = new double?((double) width);
      return this;
    }

    public QRCodeBuilder Background(string value)
    {
      this.Container.Background = value;
      return this;
    }

    public QRCodeBuilder Border(Action<QRCodeBorderSettingsBuilder> configurator)
    {
      this.Container.Border.QRCode = this.Container;
      configurator(new QRCodeBorderSettingsBuilder(this.Container.Border));
      return this;
    }

    public QRCodeBuilder Color(string value)
    {
      this.Container.Color = value;
      return this;
    }

    public QRCodeBuilder Overlay(Action<QRCodeOverlaySettingsBuilder> configurator)
    {
      this.Container.Overlay.QRCode = this.Container;
      configurator(new QRCodeOverlaySettingsBuilder(this.Container.Overlay));
      return this;
    }

    public QRCodeBuilder Padding(double value)
    {
      this.Container.Padding = new double?(value);
      return this;
    }

    public QRCodeBuilder RenderAs(RenderingMode value)
    {
      this.Container.RenderAs = new RenderingMode?(value);
      return this;
    }

    public QRCodeBuilder Size(double value)
    {
      this.Container.Size = new double?(value);
      return this;
    }

    public QRCodeBuilder Value(string value)
    {
      this.Container.Value = value;
      return this;
    }

    public QRCodeBuilder Encoding(QREncoding value)
    {
      this.Container.Encoding = new QREncoding?(value);
      return this;
    }

    public QRCodeBuilder ErrorCorrection(QRErrorCorrectionLevel value)
    {
      this.Container.ErrorCorrection = new QRErrorCorrectionLevel?(value);
      return this;
    }
  }
}
