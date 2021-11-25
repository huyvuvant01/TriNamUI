// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.Infrastructure.FilterDescriptorFactory
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Infrastructure.Implementation;
using System.Collections.Generic;

namespace Kendo.Mvc.Infrastructure
{
  public static class FilterDescriptorFactory
  {
    public static IList<IFilterDescriptor> Create(string input)
    {
      IList<IFilterDescriptor> filterDescriptorList = (IList<IFilterDescriptor>) new List<IFilterDescriptor>();
      IFilterNode filterNode = new FilterParser(input).Parse();
      if (filterNode == null)
        return filterDescriptorList;
      FilterNodeVisitor filterNodeVisitor = new FilterNodeVisitor();
      filterNode.Accept((IFilterNodeVisitor) filterNodeVisitor);
      filterDescriptorList.Add(filterNodeVisitor.Result);
      return filterDescriptorList;
    }
  }
}
