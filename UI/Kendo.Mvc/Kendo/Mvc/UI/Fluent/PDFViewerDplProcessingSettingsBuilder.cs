// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.PDFViewerDplProcessingSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class PDFViewerDplProcessingSettingsBuilder
  {
    public PDFViewerDplProcessingSettingsBuilder(PDFViewerDplProcessingSettings container) => this.Container = container;

    protected PDFViewerDplProcessingSettings Container { get; private set; }

    public PDFViewerDplProcessingSettingsBuilder Read(
      Action<PDFViewerDplProcessingReadSettingsBuilder> configurator)
    {
      this.Container.Read.PDFViewer = this.Container.PDFViewer;
      configurator(new PDFViewerDplProcessingReadSettingsBuilder(this.Container.Read));
      return this;
    }

    public PDFViewerDplProcessingSettingsBuilder Upload(
      Action<PDFViewerDplProcessingUploadSettingsBuilder> configurator)
    {
      this.Container.Upload.PDFViewer = this.Container.PDFViewer;
      configurator(new PDFViewerDplProcessingUploadSettingsBuilder(this.Container.Upload));
      return this;
    }

    public PDFViewerDplProcessingSettingsBuilder Download(
      Action<PDFViewerDplProcessingDownloadSettingsBuilder> configurator)
    {
      this.Container.Download.PDFViewer = this.Container.PDFViewer;
      configurator(new PDFViewerDplProcessingDownloadSettingsBuilder(this.Container.Download));
      return this;
    }

    public PDFViewerDplProcessingSettingsBuilder LoadOnDemand(
      bool value)
    {
      this.Container.LoadOnDemand = new bool?(value);
      return this;
    }

    public PDFViewerDplProcessingSettingsBuilder LoadOnDemand()
    {
      this.Container.LoadOnDemand = new bool?(true);
      return this;
    }
  }
}
