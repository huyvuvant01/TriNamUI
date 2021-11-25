// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Form.Fluent.FormItemsContainerBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Form.Fluent
{
  public class FormItemsContainerBuilder<T>
  {
    private readonly ViewContext ViewContext;

    public FormItemsContainerBuilder(FormItem container, ViewContext viewContext)
    {
      this.Container = container;
      this.ViewContext = viewContext;
      container.Items = new List<FormItem>();
      container.Grid = new FormGridSettings();
    }

    protected FormItem Container { get; private set; }

    public FormItemsContainerBuilder<T> Label(string value)
    {
      this.Container.Label = new FormItemLabelSettings()
      {
        Text = value
      };
      return this;
    }

    public FormItemsContainerBuilder<T> Items(
      Action<FormItemFactory<T>> configurator)
    {
      configurator(new FormItemFactory<T>(this.Container.Items, this.ViewContext));
      return this;
    }

    public FormItemsContainerBuilder<T> Layout(string value)
    {
      this.Container.Layout = value;
      return this;
    }

    public FormItemsContainerBuilder<T> Grid(
      Action<FormGridSettingsBuilder<T>> configurator)
    {
      configurator(new FormGridSettingsBuilder<T>(this.Container.Grid));
      return this;
    }

    public FormItemsContainerBuilder<T> ColSpan(double value)
    {
      this.Container.ColSpan = new double?(value);
      return this;
    }
  }
}
