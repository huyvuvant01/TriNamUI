// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.TagHelperChildBase
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  public abstract class TagHelperChildBase : TagHelper
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      this.AddSelfToContext(context);
      this.AddSelfToParent(context);
      if (this.SuppressTagRendering())
        output.SuppressOutput();
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
    }

    protected virtual void AddSelfToContext(TagHelperContext context) => context.Items[(object) this.GetType()] = (object) this;

    protected abstract void AddSelfToParent(TagHelperContext context);

    private bool SuppressTagRendering() => ((IEnumerable<object>) this.GetType().GetTypeInfo().GetCustomAttributes(true)).Any<object>((Func<object, bool>) (p => p.GetType() == typeof (SuppressTagRenderingAttribute)));

    protected ClientHandlerDescriptor CreateHandler(string handler) => new ClientHandlerDescriptor()
    {
      HandlerName = handler
    };

    public string IdPrefix => "#";
  }
}
