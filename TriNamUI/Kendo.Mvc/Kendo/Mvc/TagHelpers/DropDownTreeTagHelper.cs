// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.DropDownTreeTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Rendering;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Mvc.ModelBinding;
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
  [HtmlTargetElement("kendo-dropdowntree")]
  [HtmlTargetElement("dropdowntree-editor", ParentTag = "form-item")]
  [RestrictChildren("items", new string[] {"popup-animation", "popup", "checkboxes", "messages", "hierarchical-datasource"})]
  public class DropDownTreeTagHelper : 
    TagHelperBase,
    IDataBoundWidget<
    #nullable disable
    HierarchicalDataSourceTagHelper>,
    IKendoFormEditor
  {
    private static readonly Regex EscapeRegex = new Regex("([;&,\\.\\+\\*~'\\:\\\"\\!\\^\\$\\[\\]\\(\\)\\|\\/])", RegexOptions.Compiled);

    public DropDownTreeTagHelper(IKendoHtmlGenerator generator)
      : base(generator)
    {
    }

    [HtmlAttributeName("datasource-id")]
    public string DataSourceId { get; set; }

    [HtmlAttributeNotBound]
    public HierarchicalDataSourceTagHelper Datasource { get; set; }

    [HtmlAttributeName("bind-to")]
    public IEnumerable<DropDownTreeItemBase> BindTo { get; set; }

    [HtmlAttributeName("datatextfield")]
    public string DataTextField { get; set; }

    [HtmlAttributeName("datavaluefield")]
    public string DataValueField { get; set; }

    [HtmlAttributeName("dataurlfield")]
    public string DataUrlField { get; set; }

    [HtmlAttributeName("dataimageurlfield")]
    public string DataImageUrlField { get; set; }

    [HtmlAttributeNotBound]
    public DropDownTreeItemsTagHelper Items { get; set; }

    [HtmlAttributeNotBound]
    public DropDownTreeCheckboxesSettingsTagHelper Checkboxes { get; set; }

    [HtmlAttributeNotBound]
    public DropDownPopupSettingsTagHelper Popup { get; set; }

    [HtmlAttributeNotBound]
    public DropDownPopupAnimationSettingsTagHelper Animation { get; set; }

    public object Value { get; set; }

    [HtmlAttributeName("dataspritecssclassfield")]
    public string DataSpriteCssClassField { get; set; }

    public ModelExpression For { get; set; }

    [HtmlAttributeNotBound]
    public bool IsNested { get; set; }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      DropDownTreeTagHelper downTreeTagHelper = this;
      context.Items[(object) downTreeTagHelper.GetType()] = (object) downTreeTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      // ISSUE: explicit non-virtual call
      if (__nonvirtual (downTreeTagHelper.TryAddToForm(context)))
        output.SuppressOutput();
      // ISSUE: reference to a compiler-generated method
      await downTreeTagHelper.\u003C\u003En__0(context, output);
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
          if (this.For.Model is IEnumerable)
            this.Value = (object) (this.For.Model as IEnumerable);
          else if (this.For.Model.GetType().IsPredefinedType())
            this.Value = (object) Convert.ToString(this.For.Model);
          else if (this.For.Model.GetType().IsEnumType())
            this.Value = (object) Convert.ToString(Convert.ToInt32(this.For.Model));
        }
      }
      this.GenerateId(output);
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      TagBuilder textInput = this.Generator.GenerateTextInput(this.ViewContext, modelExplorer, this.Id, this.Name, this.Value, string.Empty, (IDictionary<string, object>) dictionary);
      output.TagName = "input";
      output.TagMode = Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing;
      output.MergeAttributes(textInput);
    }

    protected override string GetInitializationScript() => this.Initializer.Initialize(this.Selector, "DropDownList", (IDictionary<string, object>) this.Serialize());

    private object GetValue()
    {
      ModelStateEntry modelStateEntry;
      if (this.ViewContext.ViewData.ModelState.TryGetValue(this.Name, out modelStateEntry) && modelStateEntry.RawValue != null)
        return (object) (modelStateEntry.RawValue as IEnumerable);
      return this.Value == null ? (object) (this.ViewContext.ViewData.Eval(this.Name) as IEnumerable) : this.Value;
    }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      bool? nullable;
      if (this.DataSourceId.HasValue())
        dictionary["dataSourceId"] = (object) this.DataSourceId;
      else if (this.Datasource != null)
      {
        nullable = this.Datasource.ServerFiltering;
        bool flag = true;
        if (nullable.GetValueOrDefault() == flag & nullable.HasValue && this.Datasource.Transport != null && this.Datasource.Transport.Read != null && !this.Datasource.Transport.Read.Data.HasValue())
          this.Datasource.Transport.Read.Data = "function() { return kendo.ui.DropDownTree.requestData(jQuery(\"" + DropDownTreeTagHelper.EscapeRegex.Replace(this.Selector, "\\\\$1") + "\")); }";
        dictionary["dataSource"] = (object) this.Datasource.Serialize();
      }
      if (this.BindTo != null)
      {
        List<object> source = new List<object>();
        foreach (DropDownTreeItemBase downTreeItemBase in this.BindTo)
        {
          DropDownTreeItemTagHelper tagHelper = downTreeItemBase.ConvertToTagHelper();
          source.Add((object) tagHelper.Serialize());
        }
        if (source.Any<object>())
          dictionary["dataSource"] = (object) source;
      }
      if (this.Items != null)
      {
        IEnumerable<Dictionary<string, object>> source = this.Items.Select<DropDownTreeItemTagHelper, Dictionary<string, object>>((Func<DropDownTreeItemTagHelper, Dictionary<string, object>>) (i => i.Serialize()));
        if (source.Any<Dictionary<string, object>>())
          dictionary["dataSource"] = (object) source;
      }
      if (this.Checkboxes != null)
      {
        Dictionary<string, object> source = this.Checkboxes.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
        {
          nullable = this.Checkboxes.Enabled;
          if (nullable.HasValue)
          {
            nullable = this.Checkboxes.Enabled;
            if (!nullable.Value)
              goto label_24;
          }
          dictionary["checkboxes"] = (object) source;
          goto label_27;
        }
label_24:
        nullable = this.Checkboxes.Enabled;
        if (nullable.HasValue)
        {
          nullable = this.Checkboxes.Enabled;
          if (nullable.Value)
            dictionary["checkboxes"] = (object) this.Checkboxes.Enabled;
        }
      }
label_27:
      if (this.Animation != null)
      {
        Dictionary<string, object> source = this.Animation.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
        {
          nullable = this.Animation.Enabled;
          if (nullable.HasValue)
          {
            nullable = this.Animation.Enabled;
            if (!nullable.Value)
              goto label_32;
          }
          dictionary["animation"] = (object) source;
          goto label_35;
        }
label_32:
        nullable = this.Animation.Enabled;
        if (nullable.HasValue)
        {
          nullable = this.Animation.Enabled;
          if (nullable.Value)
            dictionary["animation"] = (object) this.Animation.Enabled;
        }
      }
label_35:
      if (this.Popup != null)
      {
        Dictionary<string, object> source = this.Popup.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["popup"] = (object) source;
      }
      if (this.GetValue() != null)
        dictionary["value"] = !(this.Value is IEnumerable) ? (object) this.Value.ToString() : this.Value;
      string dataTextField = this.DataTextField;
      if ((dataTextField != null ? (dataTextField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataTextField"] = (object) this.DataTextField;
      string dataValueField = this.DataValueField;
      if ((dataValueField != null ? (dataValueField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataValueField"] = (object) this.DataValueField;
      string spriteCssClassField = this.DataSpriteCssClassField;
      if ((spriteCssClassField != null ? (spriteCssClassField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataSpriteCssClassField"] = (object) this.DataSpriteCssClassField;
      string dataImageUrlField = this.DataImageUrlField;
      if ((dataImageUrlField != null ? (dataImageUrlField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataImageUrlField"] = (object) this.DataImageUrlField;
      string dataUrlField = this.DataUrlField;
      if ((dataUrlField != null ? (dataUrlField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataUrlField"] = (object) this.DataUrlField;
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
          formItemTagHelper1.Editor = "DropDownTree";
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
      return dictionary;
    }

    public bool? AutoBind { get; set; }

    public bool? AutoClose { get; set; }

    public bool? AutoWidth { get; set; }

    public bool? CheckAll { get; set; }

    public string CheckAllTemplate { get; set; }

    public string CheckAllTemplateId { get; set; }

    public bool? ClearButton { get; set; }

    public double? Delay { get; set; }

    public bool? Enable { get; set; }

    public bool? EnforceMinLength { get; set; }

    public string FooterTemplate { get; set; }

    public string FooterTemplateId { get; set; }

    public string Height { get; set; }

    public bool? IgnoreCase { get; set; }

    public bool? LoadOnDemand { get; set; }

    [HtmlAttributeNotBound]
    public DropDownTreeMessagesSettingsTagHelper Messages { get; set; }

    public double? MinLength { get; set; }

    public string NoDataTemplate { get; set; }

    public string NoDataTemplateId { get; set; }

    public string Placeholder { get; set; }

    public string HeaderTemplate { get; set; }

    public string HeaderTemplateId { get; set; }

    public string ValueTemplate { get; set; }

    public string ValueTemplateId { get; set; }

    public DropDownTreeTagMode? TagMode { get; set; }

    public string Template { get; set; }

    public string TemplateId { get; set; }

    public string Text { get; set; }

    public bool? ValuePrimitive { get; set; }

    public FilterType? Filter { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = base.SerializeSettings();
      if (this.AutoBind.HasValue)
        dictionary1["autoBind"] = (object) this.AutoBind;
      if (this.AutoClose.HasValue)
        dictionary1["autoClose"] = (object) this.AutoClose;
      if (this.AutoWidth.HasValue)
        dictionary1["autoWidth"] = (object) this.AutoWidth;
      if (this.CheckAll.HasValue)
        dictionary1["checkAll"] = (object) this.CheckAll;
      if (this.CheckAllTemplateId.HasValue())
        dictionary1["checkAllTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.CheckAllTemplateId)
        };
      else if (this.CheckAllTemplate.HasValue())
        dictionary1["checkAllTemplate"] = (object) this.CheckAllTemplate;
      if (this.ClearButton.HasValue)
        dictionary1["clearButton"] = (object) this.ClearButton;
      if (this.Delay.HasValue)
        dictionary1["delay"] = (object) this.Delay;
      if (this.Enable.HasValue)
        dictionary1["enable"] = (object) this.Enable;
      if (this.EnforceMinLength.HasValue)
        dictionary1["enforceMinLength"] = (object) this.EnforceMinLength;
      if (this.FooterTemplateId.HasValue())
        dictionary1["footerTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.FooterTemplateId)
        };
      else if (this.FooterTemplate.HasValue())
        dictionary1["footerTemplate"] = (object) this.FooterTemplate;
      string height = this.Height;
      if ((height != null ? (height.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["height"] = (object) this.Height;
      if (this.IgnoreCase.HasValue)
        dictionary1["ignoreCase"] = (object) this.IgnoreCase;
      if (this.LoadOnDemand.HasValue)
        dictionary1["loadOnDemand"] = (object) this.LoadOnDemand;
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
      string placeholder = this.Placeholder;
      if ((placeholder != null ? (placeholder.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["placeholder"] = (object) this.Placeholder;
      if (this.HeaderTemplateId.HasValue())
        dictionary1["headerTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.HeaderTemplateId)
        };
      else if (this.HeaderTemplate.HasValue())
        dictionary1["headerTemplate"] = (object) this.HeaderTemplate;
      if (this.ValueTemplateId.HasValue())
        dictionary1["valueTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.ValueTemplateId)
        };
      else if (this.ValueTemplate.HasValue())
        dictionary1["valueTemplate"] = (object) this.ValueTemplate;
      if (this.TagMode.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        DropDownTreeTagMode? tagMode = this.TagMode;
        ref DropDownTreeTagMode? local = ref tagMode;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["tagMode"] = (object) str;
      }
      if (this.TemplateId.HasValue())
        dictionary1["template"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.TemplateId)
        };
      else if (this.Template.HasValue())
        dictionary1["template"] = (object) this.Template;
      string text = this.Text;
      if ((text != null ? (text.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["text"] = (object) this.Text;
      if (this.ValuePrimitive.HasValue)
        dictionary1["valuePrimitive"] = (object) this.ValuePrimitive;
      if (this.Filter.HasValue)
      {
        Dictionary<string, object> dictionary3 = dictionary1;
        FilterType? filter = this.Filter;
        ref FilterType? local = ref filter;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary3["filter"] = (object) str;
      }
      return dictionary1;
    }
  }
}
