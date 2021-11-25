// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.QRCodeOverlaySettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class QRCodeOverlaySettingsBuilder
  {
    public QRCodeOverlaySettingsBuilder(QRCodeOverlaySettings container) => this.Container = container;

    protected QRCodeOverlaySettings Container { get; private set; }

    public QRCodeOverlaySettingsBuilder Height(double value)
    {
      this.Container.Height = new double?(value);
      return this;
    }

    public QRCodeOverlaySettingsBuilder Type(string value)
    {
      this.Container.Type = value;
      return this;
    }

    public QRCodeOverlaySettingsBuilder ImageUrl(string value)
    {
      this.Container.ImageUrl = value;
      return this;
    }

    public QRCodeOverlaySettingsBuilder Width(double value)
    {
      this.Container.Width = new double?(value);
      return this;
    }
  }
}
