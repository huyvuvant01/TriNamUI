// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.TreeListColumnBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Resources;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Kendo.Mvc.UI.Fluent
{
  public class TreeListColumnBuilder<T> where T : class
  {
    public TreeListColumnBuilder(TreeListColumn<T> container) => this.Container = container;

    protected TreeListColumn<T> Container { get; private set; }

    public TreeListColumnBuilder<T> Editor(string value)
    {
      this.Container.Editor = (object) value;
      return this;
    }

    public TreeListColumnBuilder<T> Field<TValue>(
      Expression<Func<T, TValue>> expression)
    {
      this.Container.Field = !typeof (T).IsPlainType() || expression.IsBindable() ? expression.MemberWithoutInstance() : throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
      if (typeof (T).IsPlainType())
      {
        ViewDataDictionary<T> viewData = new ViewDataDictionary<T>(this.Container.TreeList.ModelMetadataProvider, new ModelStateDictionary());
        ModelExplorer modelExplorer = ExpressionMetadataProvider.FromLambdaExpression<T, TValue>(expression, viewData, this.Container.TreeList.ModelMetadataProvider);
        this.Container.Title = modelExplorer.Metadata.DisplayName;
        this.Container.Format = modelExplorer.Metadata.DisplayFormatString;
      }
      if (string.IsNullOrEmpty(this.Container.Title))
      {
        string str = this.Container.Field.AsTitle();
        if (str != this.Container.Field)
          this.Container.Title = str;
      }
      return this;
    }

    public TreeListColumnBuilder<T> Width(int value)
    {
      this.Container.Width = value.ToString() + "px";
      return this;
    }

    public TreeListColumnBuilder<T> Filterable(
      Action<TreeListColumnFilterableSettingsBuilder<T>> configurator)
    {
      this.Container.Filterable.Enabled = new bool?(true);
      this.Container.Filterable.TreeList = this.Container.TreeList;
      configurator(new TreeListColumnFilterableSettingsBuilder<T>(this.Container.Filterable, this.Container.TreeList.ViewContext, this.Container.TreeList.UrlGenerator));
      return this;
    }

    public TreeListColumnBuilder<T> Filterable(bool enabled)
    {
      this.Container.Filterable.Enabled = new bool?(enabled);
      return this;
    }

    public TreeListColumnBuilder<T> HtmlAttributes(
      IDictionary<string, object> value)
    {
      this.Container.HtmlAttributes = value;
      return this;
    }

    public TreeListColumnBuilder<T> HtmlAttributes(object value)
    {
      this.Container.HtmlAttributes = value.ToDictionary();
      return this;
    }

    public TreeListColumnBuilder<T> Command(
      Action<TreeListColumnCommandFactory<T>> configurator)
    {
      configurator(new TreeListColumnCommandFactory<T>(this.Container.Command)
      {
        TreeList = this.Container.TreeList
      });
      return this;
    }

    public TreeListColumnBuilder<T> Editable(string handler)
    {
      this.Container.Editable = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public TreeListColumnBuilder<T> Editable(Func<object, object> handler)
    {
      this.Container.Editable = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public TreeListColumnBuilder<T> Encoded(bool value)
    {
      this.Container.Encoded = new bool?(value);
      return this;
    }

    public TreeListColumnBuilder<T> Expandable(bool value)
    {
      this.Container.Expandable = new bool?(value);
      return this;
    }

    public TreeListColumnBuilder<T> Expandable()
    {
      this.Container.Expandable = new bool?(true);
      return this;
    }

    public TreeListColumnBuilder<T> Field(string value)
    {
      this.Container.Field = value;
      return this;
    }

    public TreeListColumnBuilder<T> FooterTemplate(string value)
    {
      this.Container.FooterTemplate = value;
      return this;
    }

    public TreeListColumnBuilder<T> FooterTemplateId(string templateId)
    {
      this.Container.FooterTemplateId = templateId;
      return this;
    }

    public TreeListColumnBuilder<T> Format(string value)
    {
      this.Container.Format = value;
      return this;
    }

    public TreeListColumnBuilder<T> HeaderAttributes(
      IDictionary<string, object> value)
    {
      this.Container.HeaderAttributes = value;
      return this;
    }

    public TreeListColumnBuilder<T> HeaderAttributes(object value)
    {
      this.Container.HeaderAttributes = value.ToDictionary();
      return this;
    }

    public TreeListColumnBuilder<T> HeaderTemplate(string value)
    {
      this.Container.HeaderTemplate = value;
      return this;
    }

    public TreeListColumnBuilder<T> HeaderTemplateId(string templateId)
    {
      this.Container.HeaderTemplateId = templateId;
      return this;
    }

    public TreeListColumnBuilder<T> MinScreenWidth(double value)
    {
      this.Container.MinScreenWidth = new double?(value);
      return this;
    }

    public TreeListColumnBuilder<T> Selectable(bool value)
    {
      this.Container.Selectable = new bool?(value);
      return this;
    }

    public TreeListColumnBuilder<T> Selectable()
    {
      this.Container.Selectable = new bool?(true);
      return this;
    }

    public TreeListColumnBuilder<T> Sortable(
      Action<TreeListColumnSortableSettingsBuilder<T>> configurator)
    {
      this.Container.Sortable.Enabled = new bool?(true);
      this.Container.Sortable.TreeList = this.Container.TreeList;
      configurator(new TreeListColumnSortableSettingsBuilder<T>(this.Container.Sortable));
      return this;
    }

    public TreeListColumnBuilder<T> Sortable(bool enabled)
    {
      this.Container.Sortable.Enabled = new bool?(enabled);
      return this;
    }

    public TreeListColumnBuilder<T> Template(string value)
    {
      this.Container.Template = value;
      return this;
    }

    public TreeListColumnBuilder<T> TemplateId(string templateId)
    {
      this.Container.TemplateId = templateId;
      return this;
    }

    public TreeListColumnBuilder<T> Title(string value)
    {
      this.Container.Title = value;
      return this;
    }

    public TreeListColumnBuilder<T> Width(string value)
    {
      this.Container.Width = value;
      return this;
    }

    public TreeListColumnBuilder<T> Hidden(bool value)
    {
      this.Container.Hidden = new bool?(value);
      return this;
    }

    public TreeListColumnBuilder<T> Hidden()
    {
      this.Container.Hidden = new bool?(true);
      return this;
    }

    public TreeListColumnBuilder<T> IncludeChildren(bool value)
    {
      this.Container.IncludeChildren = new bool?(value);
      return this;
    }

    public TreeListColumnBuilder<T> IncludeChildren()
    {
      this.Container.IncludeChildren = new bool?(true);
      return this;
    }

    public TreeListColumnBuilder<T> Menu(bool value)
    {
      this.Container.Menu = new bool?(value);
      return this;
    }

    public TreeListColumnBuilder<T> Locked(bool value)
    {
      this.Container.Locked = new bool?(value);
      return this;
    }

    public TreeListColumnBuilder<T> Locked()
    {
      this.Container.Locked = new bool?(true);
      return this;
    }

    public TreeListColumnBuilder<T> Lockable(bool value)
    {
      this.Container.Lockable = new bool?(value);
      return this;
    }
  }
}
