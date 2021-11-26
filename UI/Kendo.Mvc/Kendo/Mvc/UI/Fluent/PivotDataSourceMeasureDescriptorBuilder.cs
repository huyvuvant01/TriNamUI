// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.PivotDataSourceMeasureDescriptorBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class PivotDataSourceMeasureDescriptorBuilder : IHideObjectMembers
  {
    private readonly PivotDataSourceMeasureDescriptor measure;

    public PivotDataSourceMeasureDescriptorBuilder(PivotDataSourceMeasureDescriptor measure) => this.measure = measure;

    public PivotDataSourceMeasureDescriptorBuilder Name(
      string name)
    {
      this.measure.Name = name;
      return this;
    }

    public PivotDataSourceMeasureDescriptorBuilder Type(
      string type)
    {
      this.measure.Type = type;
      return this;
    }

    System.Type IHideObjectMembers.GetType() => this.GetType();
  }
}
