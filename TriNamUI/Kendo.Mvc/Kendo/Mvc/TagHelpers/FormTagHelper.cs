// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.FormTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("kendo-form")]
  [HtmlTargetElement("kendo-form", ParentTag = "editable")]
  [HtmlTargetElement("wizard-step-form", ParentTag = "wizard-step")]
  [RestrictChildren("form-items", new string[] {"messages", "validatable", "grid"})]
  [OutputElementHint("form")]
  public class FormTagHelper : TagHelperBase
  {
    public 
    #nullable disable
    object FormData { get; set; }

    [HtmlAttributeNotBound]
    public bool IsNested { get; private set; }

    public FormTagHelper(IKendoHtmlGenerator generator)
      : base(generator)
    {
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      FormTagHelper formTagHelper = this;
      context.Items[(object) formTagHelper.GetType()] = (object) formTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      if (formTagHelper.TryAddToParent(context))
        output.SuppressOutput();
      // ISSUE: reference to a compiler-generated method
      await formTagHelper.\u003C\u003En__0(context, output);
    }

    private bool TryAddToParent(TagHelperContext context)
    {
      foreach (KeyValuePair<object, object> keyValuePair in context.Items.Reverse<KeyValuePair<object, object>>())
      {
        object obj = keyValuePair.Value;
        string name = obj.GetType().Name;
        if (!(name == "WizardStepTagHelper"))
        {
          if (!(name == "TaskBoardEditableSettingsTagHelper"))
          {
            if (name == "OrgChartEditableSettingsTagHelper")
            {
              OrgChartEditableSettingsTagHelper settingsTagHelper = obj as OrgChartEditableSettingsTagHelper;
              this.IsNested = true;
              Dictionary<string, object> dictionary = this.Serialize();
              settingsTagHelper.Form = dictionary;
              return true;
            }
          }
          else
          {
            TaskBoardEditableSettingsTagHelper settingsTagHelper = obj as TaskBoardEditableSettingsTagHelper;
            this.IsNested = true;
            Dictionary<string, object> dictionary = this.Serialize();
            settingsTagHelper.Form = dictionary;
            return true;
          }
        }
        else
        {
          WizardStepTagHelper wizardStepTagHelper = obj as WizardStepTagHelper;
          this.IsNested = true;
          Dictionary<string, object> dictionary = this.Serialize();
          wizardStepTagHelper.Form = dictionary;
          return true;
        }
      }
      return false;
    }

    protected override void WriteHtml(TagHelperOutput output)
    {
      if (this.IsNested && string.IsNullOrEmpty(this.Name))
        this.Name = Guid.NewGuid().ToString();
      this.GenerateId(output);
      TagBuilder tag = this.Generator.GenerateTag("form", this.ViewContext, this.Id, this.Name, (IDictionary<string, object>) new Dictionary<string, object>());
      output.TagName = "form";
      output.MergeAttributes(tag);
    }

    protected override string GetInitializationScript() => this.Initializer.Initialize(this.Selector, "Form", (IDictionary<string, object>) this.Serialize());

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      if (this.FormData != null)
        dictionary["formData"] = this.FormData;
      dictionary["serverErrors"] = (object) this.GetModelStateErrors();
      dictionary["items"] = (object) this.BuildItems((IList<FormItemTagHelper>) this.Items);
      return dictionary;
    }

    private IList<IDictionary<string, object>> BuildItems(
      IList<FormItemTagHelper> items)
    {
      List<IDictionary<string, object>> dictionaryList1 = new List<IDictionary<string, object>>();
      foreach (FormItemTagHelper formItemTagHelper1 in (IEnumerable<FormItemTagHelper>) items)
      {
        Dictionary<string, object> dictionary1 = formItemTagHelper1.Serialize();
        if (formItemTagHelper1.Items != null)
        {
          List<IDictionary<string, object>> dictionaryList2 = new List<IDictionary<string, object>>();
          foreach (FormItemTagHelper formItemTagHelper2 in (TagHelperCollectionBase<FormItemTagHelper>) formItemTagHelper1.Items)
          {
            Dictionary<string, object> dictionary2 = formItemTagHelper2.Serialize();
            dictionary2["validation"] = (object) this.BuildValidationAttributes(formItemTagHelper2);
            dictionary2["shouldRenderHidden"] = (object) this.ShouldRenderHidden(formItemTagHelper2);
            dictionaryList2.Add((IDictionary<string, object>) dictionary2);
          }
          dictionary1[nameof (items)] = (object) dictionaryList2;
        }
        else
        {
          dictionary1["validation"] = (object) this.BuildValidationAttributes(formItemTagHelper1);
          dictionary1["shouldRenderHidden"] = (object) this.ShouldRenderHidden(formItemTagHelper1);
        }
        dictionaryList1.Add((IDictionary<string, object>) dictionary1);
      }
      return (IList<IDictionary<string, object>>) dictionaryList1;
    }

    private IDictionary<string, string> BuildValidationAttributes(FormItemTagHelper item)
    {
      ModelStateDictionary modelState = this.ViewContext.ViewData.ModelState;
      AttributeDictionary attributes = this.Generator.GeneratePseudoBuilder(this.ViewContext, this.ViewContext.ViewData.ModelExplorer.GetExplorerForModel(this.FormData).GetExplorerForProperty(item.Field), item.Field).Attributes;
      if (modelState.Any<KeyValuePair<string, ModelStateEntry>>() && modelState[item.Field] != null && modelState[item.Field].Errors.Any<ModelError>())
      {
        IEnumerable<string> values = modelState[item.Field].Errors.Select<ModelError, string>((Func<ModelError, string>) (er => er.ErrorMessage));
        attributes["data-val-server"] = string.Join(Environment.NewLine, values);
      }
      return (IDictionary<string, string>) attributes;
    }

    private bool ShouldRenderHidden(FormItemTagHelper item) => this.FormData.ToDictionary().Select<KeyValuePair<string, object>, bool>((Func<KeyValuePair<string, object>, bool>) (i => i.Key == item.Field)).FirstOrDefault<bool>().GetType().Name == "Boolean" && (!item.Editor.HasValue() || item.Editor.Equals("Switch") || item.Editor.Equals("CheckBox"));

    private IDictionary<string, IList<string>> GetModelStateErrors()
    {
      Dictionary<string, IList<string>> dictionary = new Dictionary<string, IList<string>>();
      foreach (KeyValuePair<string, ModelStateEntry> keyValuePair in this.ViewContext.ViewData.ModelState)
      {
        string key = keyValuePair.Key;
        ModelStateEntry modelStateEntry = keyValuePair.Value;
        dictionary.Add(key, (IList<string>) new List<string>());
        foreach (ModelError error in (Collection<ModelError>) modelStateEntry.Errors)
          dictionary[key].Add(error.ErrorMessage);
      }
      return (IDictionary<string, IList<string>>) dictionary;
    }

    public string OnValidate { get; set; }

    public string OnValidateField { get; set; }

    public string OnChange { get; set; }

    public string OnSubmit { get; set; }

    public string OnClear { get; set; }

    protected override Dictionary<string, object> SerializeEvents()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string onValidate = this.OnValidate;
      if ((onValidate != null ? (onValidate.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["validate"] = (object) this.CreateHandler(this.OnValidate);
      string onValidateField = this.OnValidateField;
      if ((onValidateField != null ? (onValidateField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["validateField"] = (object) this.CreateHandler(this.OnValidateField);
      string onChange = this.OnChange;
      if ((onChange != null ? (onChange.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["change"] = (object) this.CreateHandler(this.OnChange);
      string onSubmit = this.OnSubmit;
      if ((onSubmit != null ? (onSubmit.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["submit"] = (object) this.CreateHandler(this.OnSubmit);
      string onClear = this.OnClear;
      if ((onClear != null ? (onClear.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["clear"] = (object) this.CreateHandler(this.OnClear);
      return dictionary;
    }

    public string ButtonsTemplate { get; set; }

    public string ButtonsTemplateId { get; set; }

    public bool? FocusFirst { get; set; }

    public string FormatLabel { get; set; }

    [HtmlAttributeNotBound]
    public FormItemsTagHelper Items { get; set; }

    public string Orientation { get; set; }

    [HtmlAttributeNotBound]
    public FormMessagesSettingsTagHelper Messages { get; set; }

    [HtmlAttributeNotBound]
    public FormValidatableSettingsTagHelper Validatable { get; set; }

    public string Layout { get; set; }

    [HtmlAttributeNotBound]
    public FormGridSettingsTagHelper Grid { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = base.SerializeSettings();
      if (this.ButtonsTemplateId.HasValue())
        dictionary["buttonsTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.ButtonsTemplateId)
        };
      else if (this.ButtonsTemplate.HasValue())
        dictionary["buttonsTemplate"] = (object) this.ButtonsTemplate;
      if (this.FocusFirst.HasValue)
        dictionary["focusFirst"] = (object) this.FocusFirst;
      string formatLabel = this.FormatLabel;
      if ((formatLabel != null ? (formatLabel.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["formatLabel"] = (object) this.CreateHandler(this.FormatLabel);
      if (this.Items != null)
      {
        IEnumerable<Dictionary<string, object>> source = this.Items.Select<FormItemTagHelper, Dictionary<string, object>>((Func<FormItemTagHelper, Dictionary<string, object>>) (i => i.Serialize()));
        if (source.Any<Dictionary<string, object>>())
          dictionary["items"] = (object) source;
      }
      string orientation = this.Orientation;
      if ((orientation != null ? (orientation.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["orientation"] = (object) this.Orientation;
      if (this.Messages != null)
      {
        Dictionary<string, object> source = this.Messages.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["messages"] = (object) source;
      }
      if (this.Validatable != null)
      {
        Dictionary<string, object> source = this.Validatable.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["validatable"] = (object) source;
      }
      string layout = this.Layout;
      if ((layout != null ? (layout.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["layout"] = (object) this.Layout;
      if (this.Grid != null)
      {
        Dictionary<string, object> source = this.Grid.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["grid"] = (object) source;
      }
      return dictionary;
    }
  }
}
