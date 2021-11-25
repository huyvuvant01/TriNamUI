// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.PDFViewerMessagesDialogsExportAsDialogSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class PDFViewerMessagesDialogsExportAsDialogSettingsBuilder
  {
    public PDFViewerMessagesDialogsExportAsDialogSettingsBuilder(
      PDFViewerMessagesDialogsExportAsDialogSettings container)
    {
      this.Container = container;
    }

    protected PDFViewerMessagesDialogsExportAsDialogSettings Container { get; private set; }

    public PDFViewerMessagesDialogsExportAsDialogSettingsBuilder Title(
      string value)
    {
      this.Container.Title = value;
      return this;
    }

    public PDFViewerMessagesDialogsExportAsDialogSettingsBuilder DefaultFileName(
      string value)
    {
      this.Container.DefaultFileName = value;
      return this;
    }

    public PDFViewerMessagesDialogsExportAsDialogSettingsBuilder Pdf(
      string value)
    {
      this.Container.Pdf = value;
      return this;
    }

    public PDFViewerMessagesDialogsExportAsDialogSettingsBuilder Png(
      string value)
    {
      this.Container.Png = value;
      return this;
    }

    public PDFViewerMessagesDialogsExportAsDialogSettingsBuilder Svg(
      string value)
    {
      this.Container.Svg = value;
      return this;
    }

    public PDFViewerMessagesDialogsExportAsDialogSettingsBuilder Labels(
      Action<PDFViewerMessagesDialogsExportAsDialogLabelsSettingsBuilder> configurator)
    {
      this.Container.Labels.PDFViewer = this.Container.PDFViewer;
      configurator(new PDFViewerMessagesDialogsExportAsDialogLabelsSettingsBuilder(this.Container.Labels));
      return this;
    }
  }
}
