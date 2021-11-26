// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.Infrastructure.Implementation.FilterNodeVisitor
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;

namespace Kendo.Mvc.Infrastructure.Implementation
{
  public class FilterNodeVisitor : IFilterNodeVisitor
  {
    private Stack<IFilterDescriptor> context;

    public FilterNodeVisitor() => this.context = new Stack<IFilterDescriptor>();

    public IFilterDescriptor Result => this.context.Pop();

    private IFilterDescriptor CurrentDescriptor => this.context.Count > 0 ? this.context.Peek() : (IFilterDescriptor) null;

    public void StartVisit(IOperatorNode operatorNode)
    {
      FilterDescriptor filterDescriptor = new FilterDescriptor()
      {
        Operator = operatorNode.FilterOperator
      };
      if (this.CurrentDescriptor is CompositeFilterDescriptor currentDescriptor)
        currentDescriptor.FilterDescriptors.Add((IFilterDescriptor) filterDescriptor);
      this.context.Push((IFilterDescriptor) filterDescriptor);
    }

    public void StartVisit(ILogicalNode logicalNode)
    {
      CompositeFilterDescriptor filterDescriptor = new CompositeFilterDescriptor()
      {
        LogicalOperator = logicalNode.LogicalOperator
      };
      if (this.CurrentDescriptor is CompositeFilterDescriptor currentDescriptor)
        currentDescriptor.FilterDescriptors.Add((IFilterDescriptor) filterDescriptor);
      this.context.Push((IFilterDescriptor) filterDescriptor);
    }

    public void Visit(PropertyNode propertyNode) => ((FilterDescriptor) this.CurrentDescriptor).Member = propertyNode.Name;

    public void EndVisit()
    {
      if (this.context.Count <= 1)
        return;
      this.context.Pop();
    }

    public void Visit(IValueNode valueNode) => ((FilterDescriptor) this.CurrentDescriptor).Value = valueNode.Value;
  }
}
