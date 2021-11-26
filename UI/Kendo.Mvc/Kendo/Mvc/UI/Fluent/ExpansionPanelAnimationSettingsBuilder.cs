// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ExpansionPanelAnimationSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class ExpansionPanelAnimationSettingsBuilder
  {
    public ExpansionPanelAnimationSettingsBuilder(ExpansionPanelAnimationSettings container) => this.Container = container;

    protected ExpansionPanelAnimationSettings Container { get; private set; }

    public ExpansionPanelAnimationSettingsBuilder Collapse(
      Action<ExpansionPanelAnimationCollapseSettingsBuilder> configurator)
    {
      this.Container.Collapse.ExpansionPanel = this.Container.ExpansionPanel;
      configurator(new ExpansionPanelAnimationCollapseSettingsBuilder(this.Container.Collapse));
      return this;
    }

    public ExpansionPanelAnimationSettingsBuilder Expand(
      Action<ExpansionPanelAnimationExpandSettingsBuilder> configurator)
    {
      this.Container.Expand.ExpansionPanel = this.Container.ExpansionPanel;
      configurator(new ExpansionPanelAnimationExpandSettingsBuilder(this.Container.Expand));
      return this;
    }
  }
}
