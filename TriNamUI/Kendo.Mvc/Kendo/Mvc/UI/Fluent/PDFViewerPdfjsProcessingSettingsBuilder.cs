// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.PDFViewerPdfjsProcessingSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class PDFViewerPdfjsProcessingSettingsBuilder
  {
    public PDFViewerPdfjsProcessingSettingsBuilder File(
      Action<PDFViewerPdfjsProcessingFileSettingsBuilder> configurator)
    {
      configurator(new PDFViewerPdfjsProcessingFileSettingsBuilder(this.Container.File));
      return this;
    }

    public PDFViewerPdfjsProcessingSettingsBuilder File(
      string url)
    {
      this.Container.File.Url = url;
      return this;
    }

    public PDFViewerPdfjsProcessingSettingsBuilder(PDFViewerPdfjsProcessingSettings container) => this.Container = container;

    protected PDFViewerPdfjsProcessingSettings Container { get; private set; }
  }
}
