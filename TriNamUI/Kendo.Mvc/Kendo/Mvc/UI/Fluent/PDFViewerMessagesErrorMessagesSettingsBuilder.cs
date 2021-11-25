// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.PDFViewerMessagesErrorMessagesSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class PDFViewerMessagesErrorMessagesSettingsBuilder
  {
    public PDFViewerMessagesErrorMessagesSettingsBuilder(
      PDFViewerMessagesErrorMessagesSettings container)
    {
      this.Container = container;
    }

    protected PDFViewerMessagesErrorMessagesSettings Container { get; private set; }

    public PDFViewerMessagesErrorMessagesSettingsBuilder NotSupported(
      string value)
    {
      this.Container.NotSupported = value;
      return this;
    }

    public PDFViewerMessagesErrorMessagesSettingsBuilder ParseError(
      string value)
    {
      this.Container.ParseError = value;
      return this;
    }

    public PDFViewerMessagesErrorMessagesSettingsBuilder NotFound(
      string value)
    {
      this.Container.NotFound = value;
      return this;
    }
  }
}
