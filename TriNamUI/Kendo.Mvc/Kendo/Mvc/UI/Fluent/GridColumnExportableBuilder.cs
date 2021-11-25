// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.GridColumnExportableBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class GridColumnExportableBuilder
  {
    public GridColumnExportableBuilder(GridColumnExportableSettings container) => this.Container = container;

    protected GridColumnExportableSettings Container { get; private set; }

    public GridColumnExportableBuilder Excel(bool value)
    {
      this.Container.Excel = value;
      return this;
    }

    public GridColumnExportableBuilder Pdf(bool value)
    {
      this.Container.Pdf = value;
      return this;
    }
  }
}
