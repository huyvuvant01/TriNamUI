// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.GridNoRecordsSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class GridNoRecordsSettingsBuilder<T> where T : class
  {
    public GridNoRecordsSettingsBuilder(GridNoRecordsSettings<T> container) => this.Container = container;

    protected GridNoRecordsSettings<T> Container { get; private set; }

    public GridNoRecordsSettingsBuilder<T> Template(string value)
    {
      this.Container.Template = value;
      return this;
    }

    public GridNoRecordsSettingsBuilder<T> TemplateId(string templateId)
    {
      this.Container.TemplateId = templateId;
      return this;
    }
  }
}
