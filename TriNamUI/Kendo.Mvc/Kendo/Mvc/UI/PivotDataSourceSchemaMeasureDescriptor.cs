// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.PivotDataSourceSchemaMeasureDescriptor
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI
{
  public class PivotDataSourceSchemaMeasureDescriptor
  {
    public PivotDataSourceSchemaMeasureDescriptor()
    {
      this.Aggregate = new ClientHandlerDescriptor();
      this.Result = new ClientHandlerDescriptor();
    }

    public string Caption { get; set; }

    public string Measure { get; set; }

    public string Field { get; set; }

    public string Format { get; set; }

    public string AggregateName { get; set; }

    public ClientHandlerDescriptor Aggregate { get; set; }

    public ClientHandlerDescriptor Result { get; set; }
  }
}
