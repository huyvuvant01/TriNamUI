// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.PDFViewerMessagesToolbarSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class PDFViewerMessagesToolbarSettingsBuilder
  {
    public PDFViewerMessagesToolbarSettingsBuilder(PDFViewerMessagesToolbarSettings container) => this.Container = container;

    protected PDFViewerMessagesToolbarSettings Container { get; private set; }

    public PDFViewerMessagesToolbarSettingsBuilder Open(
      string value)
    {
      this.Container.Open = value;
      return this;
    }

    public PDFViewerMessagesToolbarSettingsBuilder ExportAs(
      string value)
    {
      this.Container.ExportAs = value;
      return this;
    }

    public PDFViewerMessagesToolbarSettingsBuilder Download(
      string value)
    {
      this.Container.Download = value;
      return this;
    }

    public PDFViewerMessagesToolbarSettingsBuilder Pager(
      Action<PDFViewerMessagesToolbarPagerSettingsBuilder> configurator)
    {
      this.Container.Pager.PDFViewer = this.Container.PDFViewer;
      configurator(new PDFViewerMessagesToolbarPagerSettingsBuilder(this.Container.Pager));
      return this;
    }
  }
}
