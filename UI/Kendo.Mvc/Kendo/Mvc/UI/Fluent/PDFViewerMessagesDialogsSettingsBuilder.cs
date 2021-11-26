// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.PDFViewerMessagesDialogsSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class PDFViewerMessagesDialogsSettingsBuilder
  {
    public PDFViewerMessagesDialogsSettingsBuilder(PDFViewerMessagesDialogsSettings container) => this.Container = container;

    protected PDFViewerMessagesDialogsSettings Container { get; private set; }

    public PDFViewerMessagesDialogsSettingsBuilder ExportAsDialog(
      Action<PDFViewerMessagesDialogsExportAsDialogSettingsBuilder> configurator)
    {
      this.Container.ExportAsDialog.PDFViewer = this.Container.PDFViewer;
      configurator(new PDFViewerMessagesDialogsExportAsDialogSettingsBuilder(this.Container.ExportAsDialog));
      return this;
    }

    public PDFViewerMessagesDialogsSettingsBuilder OkText(
      string value)
    {
      this.Container.OkText = value;
      return this;
    }

    public PDFViewerMessagesDialogsSettingsBuilder Save(
      string value)
    {
      this.Container.Save = value;
      return this;
    }

    public PDFViewerMessagesDialogsSettingsBuilder Cancel(
      string value)
    {
      this.Container.Cancel = value;
      return this;
    }
  }
}
