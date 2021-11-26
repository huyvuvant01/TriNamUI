// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.TileLayoutContainerBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class TileLayoutContainerBuilder
  {
    public TileLayoutContainerBuilder(TileLayoutContainer container) => this.Container = container;

    protected TileLayoutContainer Container { get; private set; }

    public TileLayoutContainerBuilder BodyTemplate(string value)
    {
      this.Container.BodyTemplate = value;
      return this;
    }

    public TileLayoutContainerBuilder BodyTemplateId(string templateId)
    {
      this.Container.BodyTemplateId = templateId;
      return this;
    }

    public TileLayoutContainerBuilder ColSpan(double value)
    {
      this.Container.ColSpan = new double?(value);
      return this;
    }

    public TileLayoutContainerBuilder Header(
      Action<TileLayoutContainerHeaderSettingsBuilder> configurator)
    {
      this.Container.Header.TileLayout = this.Container.TileLayout;
      configurator(new TileLayoutContainerHeaderSettingsBuilder(this.Container.Header));
      return this;
    }

    public TileLayoutContainerBuilder RowSpan(double value)
    {
      this.Container.RowSpan = new double?(value);
      return this;
    }
  }
}
