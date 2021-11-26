// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.InputGroupHtmlBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class InputGroupHtmlBuilder
  {
    public InputGroupHtmlBuilder(WidgetBase component, IKendoHtmlGenerator generator)
    {
      this.Component = component;
      this.Generator = generator;
    }

    private WidgetBase Component { get; set; }

    private IKendoHtmlGenerator Generator { get; set; }

    public HtmlElement BuildGroup()
    {
      HtmlElement htmlElement = this.BuildListTag();
      IDictionary<string, string> attributes1 = this.BuildUnobtrusiveValidationAttributes();
      IDictionary<string, string> attributes2 = this.BuildServerValidationAttributes();
      htmlElement.Attributes<string, string>(attributes1);
      htmlElement.Attributes<string, string>(attributes2);
      return htmlElement;
    }

    protected virtual HtmlElement BuildListTag()
    {
      HtmlElement htmlElement = new HtmlElement("ul");
      htmlElement.Attribute("id", this.Component.Id).Attributes<string, object>(this.Component.HtmlAttributes);
      if (!string.IsNullOrEmpty(this.Component.Name))
        htmlElement.Attribute("name", this.Component.Name);
      return htmlElement;
    }

    private ModelExplorer GetModelExplorer() => ExpressionMetadataProvider.FromStringExpression(this.Component.Name, this.Component.ViewContext.ViewData, this.Component.ModelMetadataProvider);

    private IDictionary<string, string> BuildServerValidationAttributes()
    {
      ModelStateDictionary modelState = this.Component.ViewContext.ViewData.ModelState;
      Dictionary<string, string> dictionary = new Dictionary<string, string>();
      if (modelState.Any<KeyValuePair<string, ModelStateEntry>>() && modelState[this.Component.Name] != null && modelState[this.Component.Name].Errors.Any<ModelError>())
      {
        IEnumerable<string> values = modelState[this.Component.Name].Errors.Select<ModelError, string>((Func<ModelError, string>) (er => er.ErrorMessage));
        dictionary["data-val-server"] = string.Join(Environment.NewLine, values);
      }
      return (IDictionary<string, string>) dictionary;
    }

    private IDictionary<string, string> BuildUnobtrusiveValidationAttributes() => (IDictionary<string, string>) this.Generator.GeneratePseudoBuilder(this.Component.ViewContext, this.GetModelExplorer(), this.Component.Name).Attributes;
  }
}
