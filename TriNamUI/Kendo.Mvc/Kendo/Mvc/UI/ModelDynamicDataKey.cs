// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.ModelDynamicDataKey
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CSharp.RuntimeBinder;
using System;

namespace Kendo.Mvc.UI
{
  internal class ModelDynamicDataKey : IDataKey<object>, IDataKey
  {
    public ModelDynamicDataKey(string memberName, System.Linq.Expressions.Expression<Func<object, object>> expression)
    {
      this.RouteKey = "id";
      this.Name = memberName;
      this.Expression = expression;
      this.Value = expression.Compile();
    }

    public string Name { get; }

    public string RouteKey { get; set; }

    public Func<object, object> Value { get; }

    public System.Linq.Expressions.Expression<Func<object, object>> Expression { get; }

    public object GetValue(object dataItem)
    {
      try
      {
        return this.Value(dataItem);
      }
      catch (RuntimeBinderException ex)
      {
        return (object) null;
      }
    }

    public string HiddenFieldHtml(IHtmlHelper<object> htmlHelper) => htmlHelper.Hidden(this.Name, (object) null, (object) new
    {
      id = ""
    }).ToString();
  }
}
