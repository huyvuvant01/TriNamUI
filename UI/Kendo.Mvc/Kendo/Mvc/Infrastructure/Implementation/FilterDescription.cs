// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.Infrastructure.Implementation.FilterDescription
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Infrastructure.Implementation.Expressions;
using System.Linq.Expressions;

namespace Kendo.Mvc.Infrastructure.Implementation
{
  public abstract class FilterDescription : FilterDescriptorBase
  {
    public abstract bool SatisfiesFilter(object dataItem);

    public virtual bool IsActive => true;

    protected override Expression CreateFilterExpression(
      ParameterExpression parameterExpression)
    {
      return new FilterDescriptionExpressionBuilder(parameterExpression, this).CreateBodyExpression();
    }
  }
}
