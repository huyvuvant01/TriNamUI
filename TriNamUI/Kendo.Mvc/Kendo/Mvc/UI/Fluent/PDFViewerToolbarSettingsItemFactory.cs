// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.PDFViewerToolbarSettingsItemFactory
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class PDFViewerToolbarSettingsItemFactory
  {
    public PDFViewerToolbarSettingsItemFactory(List<PDFViewerToolbarSettingsItem> container) => this.Container = container;

    protected List<PDFViewerToolbarSettingsItem> Container { get; private set; }

    public virtual PDFViewerToolbarSettingsItemBuilder Add(
      string toolName)
    {
      PDFViewerToolbarSettingsItem container = new PDFViewerToolbarSettingsItem(toolName);
      container.PDFViewer = this.PDFViewer;
      this.Container.Add(container);
      return new PDFViewerToolbarSettingsItemBuilder(container);
    }

    public PDFViewer PDFViewer { get; set; }

    public virtual PDFViewerToolbarSettingsItemBuilder Add()
    {
      PDFViewerToolbarSettingsItem container = new PDFViewerToolbarSettingsItem();
      container.PDFViewer = this.PDFViewer;
      this.Container.Add(container);
      return new PDFViewerToolbarSettingsItemBuilder(container);
    }
  }
}
