// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.FormBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.UI.Form.Fluent;
using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class FormBuilder<T> : WidgetBuilderBase<Kendo.Mvc.UI.Form<T>, FormBuilder<T>>
  {
    public FormBuilder(Kendo.Mvc.UI.Form<T> component)
      : base(component)
    {
    }

    public FormBuilder<T> ButtonsTemplate(string value)
    {
      this.Container.ButtonsTemplate = value;
      return this;
    }

    public FormBuilder<T> ButtonsTemplateId(string value)
    {
      this.Container.ButtonsTemplateId = value;
      return this;
    }

    public FormBuilder<T> FocusFirst(bool value)
    {
      this.Container.FocusFirst = new bool?(value);
      return this;
    }

    public FormBuilder<T> Orientation(string value)
    {
      this.Container.Orientation = value;
      return this;
    }

    public FormBuilder<T> Validatable(
      Action<FormValidatableSettingsBuilder<T>> configurator)
    {
      configurator(new FormValidatableSettingsBuilder<T>(this.Container.Validatable));
      return this;
    }

    public FormBuilder<T> Items(Action<FormItemFactory<T>> configurator)
    {
      configurator(new FormItemFactory<T>(this.Container.Items, this.Container.ViewContext));
      return this;
    }

    public FormBuilder<T> FormData(object value)
    {
      this.Container.FormData = value;
      return this;
    }

    public FormBuilder<T> Events(Action<FormEventBuilder> configurator)
    {
      configurator(new FormEventBuilder(this.Component.Events));
      return this;
    }

    public FormBuilder<T> Layout(string value)
    {
      this.Container.Layout = value;
      return this;
    }

    public FormBuilder<T> Grid(Action<FormGridSettingsBuilder<T>> configurator)
    {
      configurator(new FormGridSettingsBuilder<T>(this.Container.Grid));
      return this;
    }

    public FormBuilder<T> FormatLabel(Func<object, object> handler)
    {
      this.Container.FormatLabel.TemplateDelegate = handler;
      return this;
    }

    public FormBuilder<T> FormatLabel(string handler)
    {
      this.Container.FormatLabel.HandlerName = handler;
      return this;
    }

    public FormBuilder<T> Messages(
      Action<FormMessagesSettingsBuilder<T>> configurator)
    {
      configurator(new FormMessagesSettingsBuilder<T>(this.Container.Messages));
      return this;
    }
  }
}
