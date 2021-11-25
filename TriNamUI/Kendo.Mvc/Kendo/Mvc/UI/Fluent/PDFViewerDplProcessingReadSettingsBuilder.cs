// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.PDFViewerDplProcessingReadSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class PDFViewerDplProcessingReadSettingsBuilder
  {
    public PDFViewerDplProcessingReadSettingsBuilder(PDFViewerDplProcessingReadSettings container) => this.Container = container;

    protected PDFViewerDplProcessingReadSettings Container { get; private set; }

    public PDFViewerDplProcessingReadSettingsBuilder Url(
      string value)
    {
      this.Container.Url = value;
      return this;
    }

    public PDFViewerDplProcessingReadSettingsBuilder PageField(
      string value)
    {
      this.Container.PageField = value;
      return this;
    }

    public PDFViewerDplProcessingReadSettingsBuilder Type(
      string value)
    {
      this.Container.Type = value;
      return this;
    }

    public PDFViewerDplProcessingReadSettingsBuilder DataType(
      string value)
    {
      this.Container.DataType = value;
      return this;
    }
  }
}
