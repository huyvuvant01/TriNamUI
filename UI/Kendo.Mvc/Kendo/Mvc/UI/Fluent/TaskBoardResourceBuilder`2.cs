// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.TaskBoardResourceBuilder`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections;

namespace Kendo.Mvc.UI.Fluent
{
  public class TaskBoardResourceBuilder<TCard, TColumn>
    where TCard : class
    where TColumn : class
  {
    public TaskBoardResourceBuilder(TaskBoardResource<TCard, TColumn> container) => this.Container = container;

    protected TaskBoardResource<TCard, TColumn> Container { get; private set; }

    public TaskBoardResourceBuilder<TCard, TColumn> BindTo(
      IEnumerable dataSource)
    {
      this.Container.DataSource = new Kendo.Mvc.UI.DataSource(this.Container.TaskBoard.ModelMetadataProvider);
      this.Container.DataSource.Data = dataSource;
      return this;
    }

    public TaskBoardResourceBuilder<TCard, TColumn> DataSource(
      Action<ReadOnlyDataSourceBuilder> configurator)
    {
      this.Container.DataSource = new Kendo.Mvc.UI.DataSource(this.Container.TaskBoard.ModelMetadataProvider);
      configurator(new ReadOnlyDataSourceBuilder(this.Container.DataSource, this.Container.TaskBoard.ViewContext, this.Container.TaskBoard.UrlGenerator));
      return this;
    }

    public TaskBoardResourceBuilder<TCard, TColumn> DataColorField(
      string value)
    {
      this.Container.DataColorField = value;
      return this;
    }

    public TaskBoardResourceBuilder<TCard, TColumn> DataTextField(
      string value)
    {
      this.Container.DataTextField = value;
      return this;
    }

    public TaskBoardResourceBuilder<TCard, TColumn> DataValueField(
      string value)
    {
      this.Container.DataValueField = value;
      return this;
    }

    public TaskBoardResourceBuilder<TCard, TColumn> Field(string value)
    {
      this.Container.Field = value;
      return this;
    }

    public TaskBoardResourceBuilder<TCard, TColumn> Multiple(bool value)
    {
      this.Container.Multiple = new bool?(value);
      return this;
    }

    public TaskBoardResourceBuilder<TCard, TColumn> Multiple()
    {
      this.Container.Multiple = new bool?(true);
      return this;
    }

    public TaskBoardResourceBuilder<TCard, TColumn> Name(string value)
    {
      this.Container.Name = value;
      return this;
    }

    public TaskBoardResourceBuilder<TCard, TColumn> Title(string value)
    {
      this.Container.Title = value;
      return this;
    }

    public TaskBoardResourceBuilder<TCard, TColumn> ValuePrimitive(
      bool value)
    {
      this.Container.ValuePrimitive = new bool?(value);
      return this;
    }
  }
}
