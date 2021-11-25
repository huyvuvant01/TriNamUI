// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.GanttPdfMarginSettingsBuilder`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class GanttPdfMarginSettingsBuilder<TTaskModel, TDependenciesModel>
    where TTaskModel : class, IGanttTask
    where TDependenciesModel : class, IGanttDependency
  {
    public GanttPdfMarginSettingsBuilder(
      GanttPdfMarginSettings<TTaskModel, TDependenciesModel> container)
    {
      this.Container = container;
    }

    protected GanttPdfMarginSettings<TTaskModel, TDependenciesModel> Container { get; private set; }

    public GanttPdfMarginSettingsBuilder<TTaskModel, TDependenciesModel> Bottom(
      double value)
    {
      this.Container.Bottom = new double?(value);
      return this;
    }

    public GanttPdfMarginSettingsBuilder<TTaskModel, TDependenciesModel> Left(
      double value)
    {
      this.Container.Left = new double?(value);
      return this;
    }

    public GanttPdfMarginSettingsBuilder<TTaskModel, TDependenciesModel> Right(
      double value)
    {
      this.Container.Right = new double?(value);
      return this;
    }

    public GanttPdfMarginSettingsBuilder<TTaskModel, TDependenciesModel> Top(
      double value)
    {
      this.Container.Top = new double?(value);
      return this;
    }
  }
}
