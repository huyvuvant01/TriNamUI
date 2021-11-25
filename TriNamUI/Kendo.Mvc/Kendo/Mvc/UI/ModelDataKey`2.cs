// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.ModelDataKey`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace Kendo.Mvc.UI
{
  public class ModelDataKey<TModel, TValue> : IDataKey<TModel>, IDataKey where TModel : class
  {
    public ModelDataKey(System.Linq.Expressions.Expression<Func<TModel, TValue>> expression)
    {
      this.RouteKey = "id";
      this.Expression = expression;
      this.Name = expression.MemberWithoutInstance();
      this.Value = expression.Compile();
    }

    public string Name { get; }

    public string RouteKey { get; set; }

    public Func<TModel, TValue> Value { get; }

    public System.Linq.Expressions.Expression<Func<TModel, TValue>> Expression { get; }

    public object GetValue(object dataItem) => (object) this.Value((TModel) dataItem);

    public string HiddenFieldHtml(IHtmlHelper<TModel> htmlHelper) => htmlHelper.HiddenFor<TValue>(this.Expression, (object) new
    {
      id = ""
    }).ToString();
  }
}
