// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.GanttTooltipSettingsBuilder`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class GanttTooltipSettingsBuilder<TTaskModel, TDependenciesModel>
    where TTaskModel : class, IGanttTask
    where TDependenciesModel : class, IGanttDependency
  {
    public GanttTooltipSettingsBuilder(
      GanttTooltipSettings<TTaskModel, TDependenciesModel> container)
    {
      this.Container = container;
    }

    protected GanttTooltipSettings<TTaskModel, TDependenciesModel> Container { get; private set; }

    public GanttTooltipSettingsBuilder<TTaskModel, TDependenciesModel> Template(
      string value)
    {
      this.Container.Template = value;
      return this;
    }

    public GanttTooltipSettingsBuilder<TTaskModel, TDependenciesModel> TemplateId(
      string templateId)
    {
      this.Container.TemplateId = templateId;
      return this;
    }

    public GanttTooltipSettingsBuilder<TTaskModel, TDependenciesModel> Visible(
      bool value)
    {
      this.Container.Visible = new bool?(value);
      return this;
    }
  }
}
