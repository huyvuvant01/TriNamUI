// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.FilterFieldBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class FilterFieldBuilder<T> where T : class
  {
    public FilterFieldBuilder(FilterField<T> container) => this.Container = container;

    protected FilterField<T> Container { get; private set; }

    public FilterFieldBuilder<T> EditorTemplateHandler(string value)
    {
      this.Container.EditorTemplateHandler.HandlerName = value;
      return this;
    }

    public FilterFieldBuilder<T> EditorTemplateHandler(Func<object, object> value)
    {
      this.Container.EditorTemplateHandler.TemplateDelegate = value;
      return this;
    }

    public FilterFieldBuilder<T> Operators(
      Action<FilterOperatorsSettingsBuilder<T>> configurator)
    {
      configurator(new FilterOperatorsSettingsBuilder<T>(this.Container.Operators));
      return this;
    }

    public FilterFieldBuilder<T> DefaultValue(object value)
    {
      this.Container.DefaultValue = value;
      return this;
    }

    public FilterFieldBuilder<T> EditorTemplate(string value)
    {
      this.Container.EditorTemplate = value;
      return this;
    }

    public FilterFieldBuilder<T> EditorTemplateId(string templateId)
    {
      this.Container.EditorTemplateId = templateId;
      return this;
    }

    public FilterFieldBuilder<T> PreviewFormat(string value)
    {
      this.Container.PreviewFormat = value;
      return this;
    }

    public FilterFieldBuilder<T> Label(string value)
    {
      this.Container.Label = value;
      return this;
    }
  }
}
