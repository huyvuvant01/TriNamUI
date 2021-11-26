// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.GridColumnMenuColumnsSettingsGroupBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class GridColumnMenuColumnsSettingsGroupBuilder<T> where T : class
  {
    public GridColumnMenuColumnsSettingsGroupBuilder(GridColumnMenuColumnsSettingsGroup<T> item) => this.Container = item;

    public GridColumnMenuColumnsSettingsGroup<T> Container { get; set; }

    public GridColumnMenuColumnsSettingsGroupBuilder<T> Title(
      string value)
    {
      this.Container.Title = value;
      return this;
    }

    public GridColumnMenuColumnsSettingsGroupBuilder<T> Columns(
      IEnumerable<string> value)
    {
      this.Container.Columns = value;
      return this;
    }
  }
}
