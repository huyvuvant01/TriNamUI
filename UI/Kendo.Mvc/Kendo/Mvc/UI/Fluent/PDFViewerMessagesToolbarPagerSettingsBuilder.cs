// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.PDFViewerMessagesToolbarPagerSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class PDFViewerMessagesToolbarPagerSettingsBuilder
  {
    public PDFViewerMessagesToolbarPagerSettingsBuilder(
      PDFViewerMessagesToolbarPagerSettings container)
    {
      this.Container = container;
    }

    protected PDFViewerMessagesToolbarPagerSettings Container { get; private set; }

    public PDFViewerMessagesToolbarPagerSettingsBuilder First(
      string value)
    {
      this.Container.First = value;
      return this;
    }

    public PDFViewerMessagesToolbarPagerSettingsBuilder Previous(
      string value)
    {
      this.Container.Previous = value;
      return this;
    }

    public PDFViewerMessagesToolbarPagerSettingsBuilder Next(
      string value)
    {
      this.Container.Next = value;
      return this;
    }

    public PDFViewerMessagesToolbarPagerSettingsBuilder Last(
      string value)
    {
      this.Container.Last = value;
      return this;
    }

    public PDFViewerMessagesToolbarPagerSettingsBuilder Of(
      string value)
    {
      this.Container.Of = value;
      return this;
    }

    public PDFViewerMessagesToolbarPagerSettingsBuilder Page(
      string value)
    {
      this.Container.Page = value;
      return this;
    }

    public PDFViewerMessagesToolbarPagerSettingsBuilder Pages(
      string value)
    {
      this.Container.Pages = value;
      return this;
    }
  }
}
