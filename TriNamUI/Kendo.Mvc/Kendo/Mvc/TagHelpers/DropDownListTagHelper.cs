// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.DropDownListTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Rendering;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("kendo-dropdownlist")]
  [HtmlTargetElement("dropdownlist-editor", ParentTag = "form-item")]
  [RestrictChildren("popup-animation", new string[] {"popup", "virtual", "datasource", "messages"})]
  [OutputElementHint("div")]
  public class DropDownListTagHelper : DropDownBaseTagHelper, IKendoFormEditor
  {
    private static readonly 
    #nullable disable
    Regex EscapeRegex = new Regex("([;&,\\.\\+\\*~'\\:\\\"\\!\\^\\$\\[\\]\\(\\)\\|\\/])", RegexOptions.Compiled);

    [HtmlAttributeName("datatextfield")]
    public string DataTextField { get; set; }

    [HtmlAttributeName("datavaluefield")]
    public string DataValueField { get; set; }

    public ModelExpression For { get; set; }

    [HtmlAttributeNotBound]
    public bool IsNested { get; set; }

    public DropDownListTagHelper(IKendoHtmlGenerator generator)
      : base(generator)
    {
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      DropDownListTagHelper downListTagHelper = this;
      if (downListTagHelper.BindTo != null && downListTagHelper.BindTo is IEnumerable<SelectListItem>)
      {
        if (string.IsNullOrEmpty(downListTagHelper.DataValueField) && string.IsNullOrEmpty(downListTagHelper.DataTextField))
        {
          downListTagHelper.DataValueField = "Value";
          downListTagHelper.DataTextField = "Text";
        }
        downListTagHelper.Data = (IEnumerable) ((IEnumerable<SelectListItem>) downListTagHelper.BindTo).Select(item => new
        {
          Text = item.Text,
          Value = item.Value ?? item.Text,
          Selected = item.Selected
        });
        if (downListTagHelper.Value == null)
          downListTagHelper.Value = ((IEnumerable<SelectListItem>) downListTagHelper.BindTo).SelectedValue();
      }
      context.Items[(object) downListTagHelper.GetType()] = (object) downListTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      // ISSUE: explicit non-virtual call
      if (__nonvirtual (downListTagHelper.TryAddToForm(context)))
        output.SuppressOutput();
      // ISSUE: reference to a compiler-generated method
      await downListTagHelper.\u003C\u003En__0(context, output);
    }

    protected override void WriteHtml(TagHelperOutput output)
    {
      ModelExplorer modelExplorer = (ModelExplorer) null;
      if (this.For != null)
      {
        this.Name = this.For.Name;
        modelExplorer = this.For.ModelExplorer;
        if (this.Value == null && this.For.Model != null)
        {
          if (this.For.Model.GetType().IsPredefinedType())
            this.Value = Convert.ToString(this.For.Model);
          else if (this.For.Model.GetType().IsEnumType())
            this.Value = Convert.ToString(Convert.ToInt32(this.For.Model));
        }
      }
      if (this.IsNested && string.IsNullOrEmpty(this.Name))
        this.Name = Guid.NewGuid().ToString();
      this.GenerateId(output);
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      TagBuilder textInput = this.Generator.GenerateTextInput(this.ViewContext, modelExplorer, this.Id, this.Name, (object) this.Value, string.Empty, (IDictionary<string, object>) dictionary);
      output.TagName = "input";
      output.TagMode = TagMode.SelfClosing;
      output.MergeAttributes(textInput);
    }

    protected override string GetInitializationScript()
    {
      if (!this.DatasourceId.HasValue() && this.Datasource != null)
      {
        bool? serverFiltering = this.Datasource.ServerFiltering;
        bool flag = true;
        if (serverFiltering.GetValueOrDefault() == flag & serverFiltering.HasValue && this.Datasource.Transport != null && this.Datasource.Transport.Read != null && !this.Datasource.Transport.Read.Data.HasValue())
          this.Datasource.Transport.Read.Data = "function() { return kendo.ui.DropDownList.requestData(jQuery(\"" + DropDownListTagHelper.EscapeRegex.Replace(this.Selector, "\\\\$1") + "\")); }";
      }
      return this.Initializer.Initialize(this.Selector, "DropDownList", (IDictionary<string, object>) this.Serialize());
    }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      string dataTextField = this.DataTextField;
      if ((dataTextField != null ? (dataTextField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataTextField"] = (object) this.DataTextField;
      string dataValueField = this.DataValueField;
      if ((dataValueField != null ? (dataValueField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataValueField"] = (object) this.DataValueField;
      return dictionary;
    }

    public bool TryAddToForm(TagHelperContext context)
    {
      foreach (KeyValuePair<object, object> keyValuePair in context.Items.Reverse<KeyValuePair<object, object>>())
      {
        if (keyValuePair.Value is FormItemTagHelper formItemTagHelper1)
        {
          this.IsNested = true;
          formItemTagHelper1.EditorOptions = this.Serialize();
          formItemTagHelper1.Editor = "DropDownList";
          return true;
        }
      }
      return false;
    }

    public string OnChange { get; set; }

    public string OnClose { get; set; }

    public string OnDataBound { get; set; }

    public string OnFiltering { get; set; }

    public string OnOpen { get; set; }

    public string OnSelect { get; set; }

    public string OnCascade { get; set; }

    protected override Dictionary<string, object> SerializeEvents()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string onChange = this.OnChange;
      if ((onChange != null ? (onChange.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["change"] = (object) this.CreateHandler(this.OnChange);
      string onClose = this.OnClose;
      if ((onClose != null ? (onClose.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["close"] = (object) this.CreateHandler(this.OnClose);
      string onDataBound = this.OnDataBound;
      if ((onDataBound != null ? (onDataBound.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataBound"] = (object) this.CreateHandler(this.OnDataBound);
      string onFiltering = this.OnFiltering;
      if ((onFiltering != null ? (onFiltering.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["filtering"] = (object) this.CreateHandler(this.OnFiltering);
      string onOpen = this.OnOpen;
      if ((onOpen != null ? (onOpen.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["open"] = (object) this.CreateHandler(this.OnOpen);
      string onSelect = this.OnSelect;
      if ((onSelect != null ? (onSelect.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["select"] = (object) this.CreateHandler(this.OnSelect);
      string onCascade = this.OnCascade;
      if ((onCascade != null ? (onCascade.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["cascade"] = (object) this.CreateHandler(this.OnCascade);
      return dictionary;
    }

    public bool? AutoBind { get; set; }

    public bool? AutoWidth { get; set; }

    public string CascadeFrom { get; set; }

    public string CascadeFromField { get; set; }

    public string CascadeFromParentField { get; set; }

    public double? Delay { get; set; }

    public bool? Enable { get; set; }

    public bool? EnforceMinLength { get; set; }

    public string FilterTitle { get; set; }

    public string FixedGroupTemplate { get; set; }

    public string FixedGroupTemplateId { get; set; }

    public string FooterTemplate { get; set; }

    public string FooterTemplateId { get; set; }

    public string GroupTemplate { get; set; }

    public string GroupTemplateId { get; set; }

    public double? Height { get; set; }

    public bool? IgnoreCase { get; set; }

    public double? Index { get; set; }

    [HtmlAttributeNotBound]
    public DropDownListMessagesSettingsTagHelper Messages { get; set; }

    public double? MinLength { get; set; }

    public string NoDataTemplate { get; set; }

    public string NoDataTemplateId { get; set; }

    public string OptionLabel { get; set; }

    public string OptionLabelTemplate { get; set; }

    public string OptionLabelTemplateId { get; set; }

    public string HeaderTemplate { get; set; }

    public string HeaderTemplateId { get; set; }

    public string Template { get; set; }

    public string TemplateId { get; set; }

    public string ValueTemplate { get; set; }

    public string ValueTemplateId { get; set; }

    public string Text { get; set; }

    public string Value { get; set; }

    public bool? ValuePrimitive { get; set; }

    public FilterType? Filter { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = base.SerializeSettings();
      if (this.AutoBind.HasValue)
        dictionary1["autoBind"] = (object) this.AutoBind;
      if (this.AutoWidth.HasValue)
        dictionary1["autoWidth"] = (object) this.AutoWidth;
      string cascadeFrom = this.CascadeFrom;
      if ((cascadeFrom != null ? (cascadeFrom.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["cascadeFrom"] = (object) this.CascadeFrom;
      string cascadeFromField = this.CascadeFromField;
      if ((cascadeFromField != null ? (cascadeFromField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["cascadeFromField"] = (object) this.CascadeFromField;
      string cascadeFromParentField = this.CascadeFromParentField;
      if ((cascadeFromParentField != null ? (cascadeFromParentField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["cascadeFromParentField"] = (object) this.CascadeFromParentField;
      if (this.Delay.HasValue)
        dictionary1["delay"] = (object) this.Delay;
      if (this.Enable.HasValue)
        dictionary1["enable"] = (object) this.Enable;
      if (this.EnforceMinLength.HasValue)
        dictionary1["enforceMinLength"] = (object) this.EnforceMinLength;
      string filterTitle = this.FilterTitle;
      if ((filterTitle != null ? (filterTitle.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["filterTitle"] = (object) this.FilterTitle;
      if (this.FixedGroupTemplateId.HasValue())
        dictionary1["fixedGroupTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.FixedGroupTemplateId)
        };
      else if (this.FixedGroupTemplate.HasValue())
        dictionary1["fixedGroupTemplate"] = (object) this.FixedGroupTemplate;
      if (this.FooterTemplateId.HasValue())
        dictionary1["footerTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.FooterTemplateId)
        };
      else if (this.FooterTemplate.HasValue())
        dictionary1["footerTemplate"] = (object) this.FooterTemplate;
      if (this.GroupTemplateId.HasValue())
        dictionary1["groupTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.GroupTemplateId)
        };
      else if (this.GroupTemplate.HasValue())
        dictionary1["groupTemplate"] = (object) this.GroupTemplate;
      if (this.Height.HasValue)
        dictionary1["height"] = (object) this.Height;
      if (this.IgnoreCase.HasValue)
        dictionary1["ignoreCase"] = (object) this.IgnoreCase;
      if (this.Index.HasValue)
        dictionary1["index"] = (object) this.Index;
      if (this.Messages != null)
      {
        Dictionary<string, object> source = this.Messages.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["messages"] = (object) source;
      }
      if (this.MinLength.HasValue)
        dictionary1["minLength"] = (object) this.MinLength;
      if (this.NoDataTemplateId.HasValue())
        dictionary1["noDataTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.NoDataTemplateId)
        };
      else if (this.NoDataTemplate.HasValue())
        dictionary1["noDataTemplate"] = (object) this.NoDataTemplate;
      string optionLabel = this.OptionLabel;
      if ((optionLabel != null ? (optionLabel.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["optionLabel"] = (object) this.OptionLabel;
      if (this.OptionLabelTemplateId.HasValue())
        dictionary1["optionLabelTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.OptionLabelTemplateId)
        };
      else if (this.OptionLabelTemplate.HasValue())
        dictionary1["optionLabelTemplate"] = (object) this.OptionLabelTemplate;
      if (this.HeaderTemplateId.HasValue())
        dictionary1["headerTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.HeaderTemplateId)
        };
      else if (this.HeaderTemplate.HasValue())
        dictionary1["headerTemplate"] = (object) this.HeaderTemplate;
      if (this.TemplateId.HasValue())
        dictionary1["template"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.TemplateId)
        };
      else if (this.Template.HasValue())
        dictionary1["template"] = (object) this.Template;
      if (this.ValueTemplateId.HasValue())
        dictionary1["valueTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.ValueTemplateId)
        };
      else if (this.ValueTemplate.HasValue())
        dictionary1["valueTemplate"] = (object) this.ValueTemplate;
      string text = this.Text;
      if ((text != null ? (text.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["text"] = (object) this.Text;
      string str1 = this.Value;
      if ((str1 != null ? (str1.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["value"] = (object) this.Value;
      if (this.ValuePrimitive.HasValue)
        dictionary1["valuePrimitive"] = (object) this.ValuePrimitive;
      if (this.Filter.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        FilterType? filter = this.Filter;
        ref FilterType? local = ref filter;
        string str2 = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["filter"] = (object) str2;
      }
      return dictionary1;
    }
  }
}
