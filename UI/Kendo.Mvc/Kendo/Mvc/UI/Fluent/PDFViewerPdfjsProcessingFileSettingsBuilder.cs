// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.PDFViewerPdfjsProcessingFileSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class PDFViewerPdfjsProcessingFileSettingsBuilder
  {
    public PDFViewerPdfjsProcessingFileSettingsBuilder(
      PDFViewerPdfjsProcessingFileSettings container)
    {
      this.Container = container;
    }

    protected PDFViewerPdfjsProcessingFileSettings Container { get; private set; }

    public PDFViewerPdfjsProcessingFileSettingsBuilder Url(
      string value)
    {
      this.Container.Url = value;
      return this;
    }

    public PDFViewerPdfjsProcessingFileSettingsBuilder Data(
      object value)
    {
      this.Container.Data = value;
      return this;
    }

    public PDFViewerPdfjsProcessingFileSettingsBuilder CMapUrl(
      string value)
    {
      this.Container.CMapUrl = value;
      return this;
    }

    public PDFViewerPdfjsProcessingFileSettingsBuilder CMapPacked(
      bool value)
    {
      this.Container.CMapPacked = new bool?(value);
      return this;
    }
  }
}
