// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Form.Fluent.FormItemBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Kendo.Mvc.UI.Form.Fluent
{
  public class FormItemBuilder<T>
  {
    private readonly ViewContext ViewContext;

    public FormItemBuilder(FormItem container, ViewContext viewContext)
    {
      this.Container = container;
      this.ViewContext = viewContext;
    }

    protected FormItem Container { get; private set; }

    public FormItemBuilder<T> Type(string value)
    {
      this.Container.Type = value;
      return this;
    }

    public FormItemBuilder<T> Field(string value)
    {
      this.Container.Field = value;
      return this;
    }

    public FormItemBuilder<T> Editor(string value)
    {
      this.Container.Editor = value;
      return this;
    }

    public FormItemBuilder<T> EditorTemplate(string value)
    {
      this.Container.EditorTemplate = value;
      return this;
    }

    public FormItemBuilder<T> EditorTemplateId(string value)
    {
      this.Container.EditorTemplateId = value;
      return this;
    }

    public FormItemBuilder<T> Label(
      Action<FormItemLabelSettingsBuilder<T>> configurator)
    {
      configurator(new FormItemLabelSettingsBuilder<T>(this.Container.Label));
      return this;
    }

    public FormItemBuilder<T> Label(string value)
    {
      this.Container.Label = new FormItemLabelSettings()
      {
        Text = value
      };
      return this;
    }

    public FormItemBuilder<T> Id(string value)
    {
      this.Container.Id = value;
      return this;
    }

    public FormItemBuilder<T> Title(string value)
    {
      this.Container.Title = value;
      return this;
    }

    public FormItemBuilder<T> Name(string value)
    {
      this.Container.Name = value;
      return this;
    }

    public FormItemBuilder<T> Hint(string value)
    {
      this.Container.Hint = value;
      return this;
    }

    public FormItemBuilder<T> Field<TValue>(Expression<Func<T, TValue>> expression)
    {
      this.Container.Field = expression.MemberWithoutInstance();
      return this;
    }

    public FormItemBuilder<T> Editor(Action<FormItemEditorBuilder<T>> configurator)
    {
      configurator(new FormItemEditorBuilder<T>(this.Container, this.ViewContext));
      return this;
    }

    public FormItemBuilder<T> EditorTemplateHandler(string value)
    {
      this.Container.EditorTemplateHandler.HandlerName = value;
      return this;
    }

    public FormItemBuilder<T> EditorTemplateHandler(Func<object, object> value)
    {
      this.Container.EditorTemplateHandler.TemplateDelegate = value;
      return this;
    }

    public FormItemBuilder<T> ColSpan(double value)
    {
      this.Container.ColSpan = new double?(value);
      return this;
    }

    public virtual FormItemBuilder<T> InputHtmlAttributes(object value)
    {
      this.Container.InputHtmlAttributes = value.ToDictionary();
      return this;
    }

    public virtual FormItemBuilder<T> InputHtmlAttributes(
      IDictionary<string, object> value)
    {
      this.Container.InputHtmlAttributes = value;
      return this;
    }
  }
}
