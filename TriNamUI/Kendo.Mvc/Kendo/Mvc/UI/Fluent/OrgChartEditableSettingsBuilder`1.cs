// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.OrgChartEditableSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class OrgChartEditableSettingsBuilder<T> where T : class
  {
    public OrgChartEditableSettingsBuilder(OrgChartEditableSettings<T> container) => this.Container = container;

    protected OrgChartEditableSettings<T> Container { get; private set; }

    public OrgChartEditableSettingsBuilder<T> Form(
      Action<FormBuilder<T>> configurator)
    {
      this.Container.Form = new Kendo.Mvc.UI.Form<T>(this.Container.OrgChart.ViewContext);
      configurator(new FormBuilder<T>(this.Container.Form));
      return this;
    }

    public OrgChartEditableSettingsBuilder<T> Create(bool value)
    {
      this.Container.Create = new bool?(value);
      return this;
    }

    public OrgChartEditableSettingsBuilder<T> Destroy(bool value)
    {
      this.Container.Destroy = new bool?(value);
      return this;
    }

    public OrgChartEditableSettingsBuilder<T> Fields(bool value)
    {
      this.Container.Fields = new bool?(value);
      return this;
    }

    public OrgChartEditableSettingsBuilder<T> Parent(bool value)
    {
      this.Container.Parent = new bool?(value);
      return this;
    }
  }
}
