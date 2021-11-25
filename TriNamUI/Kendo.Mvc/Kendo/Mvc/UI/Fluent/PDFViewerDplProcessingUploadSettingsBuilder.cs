// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.PDFViewerDplProcessingUploadSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class PDFViewerDplProcessingUploadSettingsBuilder
  {
    public PDFViewerDplProcessingUploadSettingsBuilder(
      PDFViewerDplProcessingUploadSettings container)
    {
      this.Container = container;
    }

    protected PDFViewerDplProcessingUploadSettings Container { get; private set; }

    public PDFViewerDplProcessingUploadSettingsBuilder Url(
      string value)
    {
      this.Container.Url = value;
      return this;
    }

    public PDFViewerDplProcessingUploadSettingsBuilder SaveField(
      string value)
    {
      this.Container.SaveField = value;
      return this;
    }
  }
}
