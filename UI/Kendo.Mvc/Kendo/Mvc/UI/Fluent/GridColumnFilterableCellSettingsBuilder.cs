// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.GridColumnFilterableCellSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections;

namespace Kendo.Mvc.UI.Fluent
{
  public class GridColumnFilterableCellSettingsBuilder : IHideObjectMembers
  {
    private readonly GridColumnFilterableCellSettings settings;
    private ViewContext viewContext;
    private IUrlGenerator urlGenerator;

    public GridColumnFilterableCellSettingsBuilder(
      GridColumnFilterableCellSettings settings,
      ViewContext viewContext,
      IUrlGenerator urlGenerator)
    {
      this.viewContext = viewContext;
      this.urlGenerator = urlGenerator;
      this.settings = settings;
    }

    public GridColumnFilterableCellSettingsBuilder Enabled(
      bool value)
    {
      this.settings.Enabled = value;
      return this;
    }

    public GridColumnFilterableCellSettingsBuilder Operator(
      string defaultOperator)
    {
      this.settings.Operator = defaultOperator;
      return this;
    }

    public GridColumnFilterableCellSettingsBuilder ShowOperators(
      bool showOperators)
    {
      this.settings.ShowOperators = showOperators;
      return this;
    }

    public GridColumnFilterableCellSettingsBuilder Template(
      Func<object, object> handler)
    {
      this.settings.Template.TemplateDelegate = handler;
      return this;
    }

    public GridColumnFilterableCellSettingsBuilder Template(
      string handler)
    {
      this.settings.Template.HandlerName = handler;
      return this;
    }

    public GridColumnFilterableCellSettingsBuilder Delay(
      double delay)
    {
      this.settings.Delay = delay;
      return this;
    }

    public GridColumnFilterableCellSettingsBuilder MinLength(
      int minLength)
    {
      this.settings.MinLength = minLength;
      return this;
    }

    public GridColumnFilterableCellSettingsBuilder SuggestionOperator(
      FilterType filterType)
    {
      this.settings.SuggestionOperator = filterType;
      return this;
    }

    public GridColumnFilterableCellSettingsBuilder InputWidth(
      int inputWidth)
    {
      this.settings.InputWidth = new int?(inputWidth);
      return this;
    }

    public GridColumnFilterableCellSettingsBuilder DataTextField(
      string dataTextField)
    {
      this.settings.DataTextField = dataTextField;
      return this;
    }

    public GridColumnFilterableCellSettingsBuilder DataSource(
      Action<ReadOnlyDataSourceBuilder> configurator)
    {
      configurator(new ReadOnlyDataSourceBuilder(this.settings.DataSource, this.viewContext, this.urlGenerator));
      return this;
    }

    public GridColumnFilterableCellSettingsBuilder BindTo(
      IEnumerable dataSource)
    {
      this.settings.DataSource.Data = dataSource;
      return this;
    }

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
