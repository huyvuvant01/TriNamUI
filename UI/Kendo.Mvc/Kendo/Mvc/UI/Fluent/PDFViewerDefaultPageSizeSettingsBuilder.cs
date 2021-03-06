// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.PDFViewerDefaultPageSizeSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class PDFViewerDefaultPageSizeSettingsBuilder
  {
    public PDFViewerDefaultPageSizeSettingsBuilder(PDFViewerDefaultPageSizeSettings container) => this.Container = container;

    protected PDFViewerDefaultPageSizeSettings Container { get; private set; }

    public PDFViewerDefaultPageSizeSettingsBuilder Width(
      double value)
    {
      this.Container.Width = new double?(value);
      return this;
    }

    public PDFViewerDefaultPageSizeSettingsBuilder Height(
      double value)
    {
      this.Container.Height = new double?(value);
      return this;
    }
  }
}
