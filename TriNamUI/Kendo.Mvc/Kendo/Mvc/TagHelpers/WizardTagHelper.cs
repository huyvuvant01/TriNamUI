// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.WizardTagHelper
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
  [HtmlTargetElement("kendo-wizard")]
  [RestrictChildren("messages", new string[] {"stepper", "wizard-steps"})]
  public class WizardTagHelper : TagHelperBase
  {
    public WizardTagHelper(
    #nullable disable
    IKendoHtmlGenerator generator)
      : base(generator)
    {
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      WizardTagHelper wizardTagHelper = this;
      context.Items[(object) wizardTagHelper.GetType()] = (object) wizardTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      // ISSUE: reference to a compiler-generated method
      await wizardTagHelper.\u003C\u003En__0(context, output);
    }

    protected override void WriteHtml(TagHelperOutput output)
    {
      this.GenerateId(output);
      TagBuilder tag = this.Generator.GenerateTag("div", this.ViewContext, this.Id, this.Name, (IDictionary<string, object>) new Dictionary<string, object>());
      output.TagName = "div";
      output.MergeAttributes(tag);
    }

    protected override string GetInitializationScript()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      if (this.Steps != null)
      {
        IEnumerable<Dictionary<string, object>> source = this.Steps.Select<WizardStepTagHelper, Dictionary<string, object>>((Func<WizardStepTagHelper, Dictionary<string, object>>) (i => i.Serialize()));
        if (source.Any<Dictionary<string, object>>())
          dictionary["steps"] = (object) source;
      }
      return this.Initializer.Initialize(this.Selector, "Wizard", (IDictionary<string, object>) dictionary);
    }

    public string OnActivate { get; set; }

    public string OnContentLoad { get; set; }

    public string OnDone { get; set; }

    public string OnError { get; set; }

    public string OnReset { get; set; }

    public string OnSelect { get; set; }

    public string OnFormValidateFailed { get; set; }

    protected override Dictionary<string, object> SerializeEvents()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string onActivate = this.OnActivate;
      if ((onActivate != null ? (onActivate.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["activate"] = (object) this.CreateHandler(this.OnActivate);
      string onContentLoad = this.OnContentLoad;
      if ((onContentLoad != null ? (onContentLoad.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["contentLoad"] = (object) this.CreateHandler(this.OnContentLoad);
      string onDone = this.OnDone;
      if ((onDone != null ? (onDone.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["done"] = (object) this.CreateHandler(this.OnDone);
      string onError = this.OnError;
      if ((onError != null ? (onError.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["error"] = (object) this.CreateHandler(this.OnError);
      string onReset = this.OnReset;
      if ((onReset != null ? (onReset.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["reset"] = (object) this.CreateHandler(this.OnReset);
      string onSelect = this.OnSelect;
      if ((onSelect != null ? (onSelect.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["select"] = (object) this.CreateHandler(this.OnSelect);
      string formValidateFailed = this.OnFormValidateFailed;
      if ((formValidateFailed != null ? (formValidateFailed.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["formValidateFailed"] = (object) this.CreateHandler(this.OnFormValidateFailed);
      return dictionary;
    }

    public bool? ActionBar { get; set; }

    public bool? LoadOnDemand { get; set; }

    [HtmlAttributeNotBound]
    public WizardMessagesSettingsTagHelper Messages { get; set; }

    public bool? Pager { get; set; }

    public bool? ReloadOnSelect { get; set; }

    [HtmlAttributeNotBound]
    public WizardStepperSettingsTagHelper Stepper { get; set; }

    [HtmlAttributeNotBound]
    public WizardValidateFormsSettingsTagHelper ValidateForms { get; set; }

    [HtmlAttributeNotBound]
    public WizardStepsTagHelper Steps { get; set; }

    public WizardContentPosition? ContentPosition { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = base.SerializeSettings();
      if (this.ActionBar.HasValue)
        dictionary1["actionBar"] = (object) this.ActionBar;
      if (this.LoadOnDemand.HasValue)
        dictionary1["loadOnDemand"] = (object) this.LoadOnDemand;
      if (this.Messages != null)
      {
        Dictionary<string, object> source = this.Messages.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["messages"] = (object) source;
      }
      if (this.Pager.HasValue)
        dictionary1["pager"] = (object) this.Pager;
      if (this.ReloadOnSelect.HasValue)
        dictionary1["reloadOnSelect"] = (object) this.ReloadOnSelect;
      if (this.Stepper != null)
      {
        Dictionary<string, object> source = this.Stepper.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["stepper"] = (object) source;
      }
      if (this.ValidateForms != null)
      {
        Dictionary<string, object> source = this.ValidateForms.Serialize();
        if (source.Any<KeyValuePair<string, object>>() && (!this.ValidateForms.Enabled.HasValue || this.ValidateForms.Enabled.Value))
          dictionary1["validateForms"] = (object) source;
        else if (this.ValidateForms.Enabled.HasValue && !this.ValidateForms.Enabled.Value)
          dictionary1["validateForms"] = (object) this.ValidateForms.Enabled;
      }
      if (this.Steps != null)
      {
        IEnumerable<Dictionary<string, object>> source = this.Steps.Select<WizardStepTagHelper, Dictionary<string, object>>((Func<WizardStepTagHelper, Dictionary<string, object>>) (i => i.Serialize()));
        if (source.Any<Dictionary<string, object>>())
          dictionary1["steps"] = (object) source;
      }
      if (this.ContentPosition.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        WizardContentPosition? contentPosition = this.ContentPosition;
        ref WizardContentPosition? local = ref contentPosition;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["contentPosition"] = (object) str;
      }
      return dictionary1;
    }
  }
}
