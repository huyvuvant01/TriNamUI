// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.PDFViewerMessagesDialogsExportAsDialogLabelsSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class PDFViewerMessagesDialogsExportAsDialogLabelsSettingsBuilder
  {
    public PDFViewerMessagesDialogsExportAsDialogLabelsSettingsBuilder(
      PDFViewerMessagesDialogsExportAsDialogLabelsSettings container)
    {
      this.Container = container;
    }

    protected PDFViewerMessagesDialogsExportAsDialogLabelsSettings Container { get; private set; }

    public PDFViewerMessagesDialogsExportAsDialogLabelsSettingsBuilder FileName(
      string value)
    {
      this.Container.FileName = value;
      return this;
    }

    public PDFViewerMessagesDialogsExportAsDialogLabelsSettingsBuilder SaveAsType(
      string value)
    {
      this.Container.SaveAsType = value;
      return this;
    }

    public PDFViewerMessagesDialogsExportAsDialogLabelsSettingsBuilder Page(
      string value)
    {
      this.Container.Page = value;
      return this;
    }
  }
}
