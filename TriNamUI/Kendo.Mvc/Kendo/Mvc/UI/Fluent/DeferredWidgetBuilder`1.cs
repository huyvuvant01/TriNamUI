// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.DeferredWidgetBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Razor;
using System;
using System.IO;
using System.Text.Encodings.Web;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.UI.Fluent
{
  public class DeferredWidgetBuilder<TViewComponent> : HelperResult where TViewComponent : 
  #nullable disable
  WidgetBase
  {
    protected internal TViewComponent Component { get; set; }

    public DeferredWidgetBuilder(TViewComponent component)
      : base((Func<TextWriter, Task>) (async writer => await Task.Yield()))
    {
      this.Component = component;
    }

    public TViewComponent ToComponent() => this.Component;

    public virtual void Render() => this.Component.Render();

    public virtual string ToHtmlString() => this.ToComponent().ToHtmlString();

    public override void WriteTo(TextWriter writer, HtmlEncoder encoder) => writer.Write(this.ToHtmlString());

    public virtual HtmlString ToClientTemplate() => this.ToComponent().ToClientTemplate();
  }
}
