// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.PDFViewerMessagesSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class PDFViewerMessagesSettingsBuilder
  {
    public PDFViewerMessagesSettingsBuilder(PDFViewerMessagesSettings container) => this.Container = container;

    protected PDFViewerMessagesSettings Container { get; private set; }

    public PDFViewerMessagesSettingsBuilder DefaultFileName(
      string value)
    {
      this.Container.DefaultFileName = value;
      return this;
    }

    public PDFViewerMessagesSettingsBuilder Toolbar(
      Action<PDFViewerMessagesToolbarSettingsBuilder> configurator)
    {
      this.Container.Toolbar.PDFViewer = this.Container.PDFViewer;
      configurator(new PDFViewerMessagesToolbarSettingsBuilder(this.Container.Toolbar));
      return this;
    }

    public PDFViewerMessagesSettingsBuilder ErrorMessages(
      Action<PDFViewerMessagesErrorMessagesSettingsBuilder> configurator)
    {
      this.Container.ErrorMessages.PDFViewer = this.Container.PDFViewer;
      configurator(new PDFViewerMessagesErrorMessagesSettingsBuilder(this.Container.ErrorMessages));
      return this;
    }

    public PDFViewerMessagesSettingsBuilder Dialogs(
      Action<PDFViewerMessagesDialogsSettingsBuilder> configurator)
    {
      this.Container.Dialogs.PDFViewer = this.Container.PDFViewer;
      configurator(new PDFViewerMessagesDialogsSettingsBuilder(this.Container.Dialogs));
      return this;
    }
  }
}
