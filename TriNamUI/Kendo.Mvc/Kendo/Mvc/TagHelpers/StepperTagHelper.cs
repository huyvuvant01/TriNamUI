// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.StepperTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Rendering;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("kendo-stepper")]
  [RestrictChildren("steps", new string[] {})]
  public class StepperTagHelper : TagHelperBase
  {
    public StepperTagHelper(
    #nullable disable
    IKendoHtmlGenerator generator)
      : base(generator)
    {
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      StepperTagHelper stepperTagHelper = this;
      context.Items[(object) stepperTagHelper.GetType()] = (object) stepperTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      // ISSUE: reference to a compiler-generated method
      await stepperTagHelper.\u003C\u003En__0(context, output);
    }

    protected override void WriteHtml(TagHelperOutput output)
    {
      this.GenerateId(output);
      TagBuilder tag = this.Generator.GenerateTag("div", this.ViewContext, this.Id, this.Name, (IDictionary<string, object>) new Dictionary<string, object>());
      output.TagName = "div";
      output.MergeAttributes(tag);
    }

    protected override string GetInitializationScript() => this.Initializer.Initialize(this.Selector, "Stepper", (IDictionary<string, object>) this.SerializeSettings());

    public string OnActivate { get; set; }

    public string OnSelect { get; set; }

    protected override Dictionary<string, object> SerializeEvents()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string onActivate = this.OnActivate;
      if ((onActivate != null ? (onActivate.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["activate"] = (object) this.CreateHandler(this.OnActivate);
      string onSelect = this.OnSelect;
      if ((onSelect != null ? (onSelect.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["select"] = (object) this.CreateHandler(this.OnSelect);
      return dictionary;
    }

    public bool? Indicator { get; set; }

    public bool? Label { get; set; }

    public bool? Linear { get; set; }

    public bool? SelectOnFocus { get; set; }

    [HtmlAttributeNotBound]
    public StepperStepsTagHelper Steps { get; set; }

    public StepperOrientationType? Orientation { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = base.SerializeSettings();
      if (this.Indicator.HasValue)
        dictionary1["indicator"] = (object) this.Indicator;
      if (this.Label.HasValue)
        dictionary1["label"] = (object) this.Label;
      if (this.Linear.HasValue)
        dictionary1["linear"] = (object) this.Linear;
      if (this.SelectOnFocus.HasValue)
        dictionary1["selectOnFocus"] = (object) this.SelectOnFocus;
      if (this.Steps != null)
      {
        IEnumerable<Dictionary<string, object>> source = this.Steps.Select<StepperStepTagHelper, Dictionary<string, object>>((Func<StepperStepTagHelper, Dictionary<string, object>>) (i => i.Serialize()));
        if (source.Any<Dictionary<string, object>>())
          dictionary1["steps"] = (object) source;
      }
      if (this.Orientation.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        StepperOrientationType? orientation = this.Orientation;
        ref StepperOrientationType? local = ref orientation;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["orientation"] = (object) str;
      }
      return dictionary1;
    }
  }
}
