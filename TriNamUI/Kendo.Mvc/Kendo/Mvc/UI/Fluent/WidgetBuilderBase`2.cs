// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.WidgetBuilderBase`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Resources;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Encodings.Web;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.UI.Fluent
{
  public class WidgetBuilderBase<TViewComponent, TBuilder> : HelperResult
    where TViewComponent : 
    #nullable disable
    WidgetBase
    where TBuilder : WidgetBuilderBase<TViewComponent, TBuilder>
  {
    public WidgetBuilderBase(TViewComponent component)
      : base((Func<TextWriter, Task>) (async writer => await Task.Yield()))
    {
      this.Component = component;
    }

    protected internal TViewComponent Component { get; set; }

    protected internal TViewComponent Container => this.Component;

    private bool HasModelExpression { get; set; }

    public static implicit operator TViewComponent(
      WidgetBuilderBase<TViewComponent, TBuilder> builder)
    {
      return builder.ToComponent();
    }

    public TViewComponent ToComponent() => this.Component;

    public virtual TBuilder Expression(string modelExpression)
    {
      this.Component.Name = modelExpression;
      this.HasModelExpression = true;
      return this as TBuilder;
    }

    public virtual TBuilder Explorer(ModelExplorer modelExplorer)
    {
      this.Component.Explorer = modelExplorer;
      return this as TBuilder;
    }

    public virtual TBuilder Name(string componentName)
    {
      if (this.HasModelExpression)
        throw new InvalidOperationException(Exceptions.YouCannotOverrideModelExpressionName);
      this.Component.Name = componentName;
      return this as TBuilder;
    }

    public virtual DeferredWidgetBuilder<TViewComponent> Deferred(bool deferred = true)
    {
      this.Component.HasDeferredInitialization = deferred;
      if (this.Component.HasDeferredInitialization)
      {
        this.Component.ToHtmlString();
        this.Component.WriteDeferredScriptInitialization();
      }
      return new DeferredWidgetBuilder<TViewComponent>(this.Component);
    }

    public virtual TBuilder HtmlAttributes(object attributes)
    {
      dictionary = (IDictionary<string, object>) null;
      switch (attributes)
      {
        case null:
        case IDictionary<string, object> dictionary:
          this.Component.HtmlAttributes = dictionary;
          return this as TBuilder;
        default:
          dictionary = HtmlHelper.AnonymousObjectToHtmlAttributes(attributes);
          goto case null;
      }
    }

    public virtual TBuilder HtmlAttributes(IDictionary<string, object> attributes)
    {
      this.Component.HtmlAttributes = attributes;
      return this as TBuilder;
    }

    public virtual void Render() => this.Component.Render();

    public virtual string ToHtmlString() => this.ToComponent().ToHtmlString();

    public override void WriteTo(TextWriter writer, HtmlEncoder encoder) => writer.Write(this.ToHtmlString());

    public virtual HtmlString ToClientTemplate() => this.ToComponent().ToClientTemplate();
  }
}
