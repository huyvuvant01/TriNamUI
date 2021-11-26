// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.PivotDataSourceMeasureBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI.Fluent
{
  public class PivotDataSourceMeasureBuilder : IHideObjectMembers
  {
    private readonly PivotDataSourceMeasure measure;

    public PivotDataSourceMeasureBuilder(PivotDataSourceMeasure measure) => this.measure = measure;

    public PivotDataSourceMeasureBuilder Values(params string[] values)
    {
      this.measure.Values = ((IEnumerable<string>) values).Select<string, PivotDataSourceMeasureDescriptor>((Func<string, PivotDataSourceMeasureDescriptor>) (value => new PivotDataSourceMeasureDescriptor()
      {
        Name = value
      }));
      return this;
    }

    public PivotDataSourceMeasureBuilder Values(
      Action<PivotDataSourceMeasureDescriptorFactory> addAction)
    {
      List<PivotDataSourceMeasureDescriptor> measureDescriptorList = new List<PivotDataSourceMeasureDescriptor>();
      addAction(new PivotDataSourceMeasureDescriptorFactory((IList<PivotDataSourceMeasureDescriptor>) measureDescriptorList));
      this.measure.Values = (IEnumerable<PivotDataSourceMeasureDescriptor>) measureDescriptorList;
      return this;
    }

    public PivotDataSourceMeasureBuilder Axis(
      PivotDataSourceMeasureAxis axis)
    {
      this.measure.Axis = axis;
      return this;
    }

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
