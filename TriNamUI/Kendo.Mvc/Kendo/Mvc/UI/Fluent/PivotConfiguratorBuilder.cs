// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.PivotConfiguratorBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class PivotConfiguratorBuilder : 
    WidgetBuilderBase<PivotConfigurator, PivotConfiguratorBuilder>
  {
    public PivotConfiguratorBuilder(PivotConfigurator component)
      : base(component)
    {
    }

    public PivotConfiguratorBuilder Messages(
      Action<PivotConfiguratorMessagesBuilder> addViewAction)
    {
      PivotConfiguratorMessagesBuilder configuratorMessagesBuilder = new PivotConfiguratorMessagesBuilder(this.Component.Messages);
      addViewAction(configuratorMessagesBuilder);
      return this;
    }

    public PivotConfiguratorBuilder Filterable(bool value)
    {
      this.Container.Filterable = new bool?(value);
      return this;
    }

    public PivotConfiguratorBuilder Filterable()
    {
      this.Container.Filterable = new bool?(true);
      return this;
    }

    public PivotConfiguratorBuilder Sortable(
      Action<PivotConfiguratorSortableSettingsBuilder> configurator)
    {
      this.Container.Sortable.Enabled = new bool?(true);
      this.Container.Sortable.PivotConfigurator = this.Container;
      configurator(new PivotConfiguratorSortableSettingsBuilder(this.Container.Sortable));
      return this;
    }

    public PivotConfiguratorBuilder Sortable()
    {
      this.Container.Sortable.Enabled = new bool?(true);
      return this;
    }

    public PivotConfiguratorBuilder Sortable(bool enabled)
    {
      this.Container.Sortable.Enabled = new bool?(enabled);
      return this;
    }

    public PivotConfiguratorBuilder Height(double value)
    {
      this.Container.Height = new double?(value);
      return this;
    }
  }
}
