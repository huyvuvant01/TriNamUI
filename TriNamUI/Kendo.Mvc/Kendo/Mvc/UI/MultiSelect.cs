// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.MultiSelect
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Kendo.Mvc.UI
{
  public class MultiSelect : WidgetBase, IFormEditor
  {
    private static readonly Regex EscapeRegex = new Regex("([;&,\\.\\+\\*~'\\:\\\"\\!\\^\\$\\[\\]\\(\\)\\|\\/])", RegexOptions.Compiled);

    public DataSource DataSource { get; private set; }

    public string DataSourceId { get; set; }

    public PopupAnimation Animation { get; private set; }

    public IEnumerable Value { get; set; }

    public MultiSelect(ViewContext viewContext)
      : base(viewContext)
    {
      this.DataSource = new DataSource(this.ModelMetadataProvider);
      this.Animation = new PopupAnimation();
    }

    protected override void WriteHtml(TextWriter writer)
    {
      bool? enable = this.Enable;
      bool flag = false;
      if (enable.GetValueOrDefault() == flag & enable.HasValue)
        this.HtmlAttributes.Merge("disabled", (object) "disabled", true);
      this.Generator.GenerateMultiSelect(this.ViewContext, this.Explorer, this.Id, this.Name, this.HtmlAttributes).WriteTo(writer, this.HtmlEncoder);
      base.WriteHtml(writer);
    }

    public IDictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      IDictionary<string, object> json = this.Animation.ToJson();
      if (json.Keys.Any<string>())
        dictionary["animation"] = json["animation"];
      if (this.DataSourceId.HasValue())
      {
        dictionary["dataSourceId"] = (object) this.DataSourceId;
      }
      else
      {
        if (this.DataSource.ServerFiltering && !this.DataSource.Transport.Read.Data.HasValue())
          this.DataSource.Transport.Read.Data = new ClientHandlerDescriptor()
          {
            HandlerName = "function() { return kendo.ui.MultiSelect.requestData(jQuery(\"" + MultiSelect.EscapeRegex.Replace(this.Selector, "\\\\$1") + "\")); }"
          };
        if (string.IsNullOrEmpty(this.DataSource.Transport.Read.Url) && string.IsNullOrEmpty(this.DataSource.Transport.Read.ActionName))
        {
          DataSourceType? type = this.DataSource.Type;
          DataSourceType dataSourceType = DataSourceType.Custom;
          if (!(type.GetValueOrDefault() == dataSourceType & type.HasValue))
          {
            if (this.DataSource.Data != null)
            {
              dictionary["dataSource"] = (object) this.DataSource.Data;
              goto label_11;
            }
            else
              goto label_11;
          }
        }
        dictionary["dataSource"] = (object) this.DataSource.ToJson();
      }
label_11:
      IEnumerable enumerable = this.GetValue();
      if (enumerable != null)
        dictionary["value"] = (object) enumerable;
      return (IDictionary<string, object>) dictionary;
    }

    public override void WriteInitializationScript(TextWriter writer) => writer.Write(this.Initializer.Initialize(this.Selector, nameof (MultiSelect), this.Serialize()));

    private IEnumerable GetValue()
    {
      ModelStateEntry modelStateEntry;
      if (!string.IsNullOrEmpty(this.Name) && this.Value == null && this.ViewContext.ViewData.ModelState.TryGetValue(this.Name, out modelStateEntry) && modelStateEntry.RawValue != null)
        return modelStateEntry.RawValue as IEnumerable;
      return !string.IsNullOrEmpty(this.Name) && this.Value == null ? this.ViewContext.ViewData.Eval(this.Name) as IEnumerable : this.Value;
    }

    public bool? AutoBind { get; set; }

    public bool? AutoClose { get; set; }

    public bool? AutoWidth { get; set; }

    public bool? ClearButton { get; set; }

    public string DataTextField { get; set; }

    public string DataValueField { get; set; }

    public double? Delay { get; set; }

    public bool? DownArrow { get; set; }

    public bool? Enable { get; set; }

    public bool? EnforceMinLength { get; set; }

    public string FixedGroupTemplate { get; set; }

    public string FixedGroupTemplateId { get; set; }

    public string FooterTemplate { get; set; }

    public string FooterTemplateId { get; set; }

    public string GroupTemplate { get; set; }

    public string GroupTemplateId { get; set; }

    public double? Height { get; set; }

    public bool? HighlightFirst { get; set; }

    public bool? IgnoreCase { get; set; }

    public MultiSelectMessagesSettings Messages { get; } = new MultiSelectMessagesSettings();

    public double? MinLength { get; set; }

    public double? MaxSelectedItems { get; set; }

    public string NoDataTemplate { get; set; }

    public string NoDataTemplateId { get; set; }

    public string Placeholder { get; set; }

    public MultiSelectPopupSettings Popup { get; } = new MultiSelectPopupSettings();

    public string HeaderTemplate { get; set; }

    public string HeaderTemplateId { get; set; }

    public string ItemTemplate { get; set; }

    public string ItemTemplateId { get; set; }

    public string TagTemplate { get; set; }

    public string TagTemplateId { get; set; }

    public MultiSelectTagMode? TagMode { get; set; }

    public bool? ValuePrimitive { get; set; }

    public MultiSelectVirtualSettings Virtual { get; } = new MultiSelectVirtualSettings();

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
      if (this.ClearButton.HasValue)
        dictionary1["clearButton"] = (object) this.ClearButton;
      string dataTextField = this.DataTextField;
      if ((dataTextField != null ? (dataTextField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["dataTextField"] = (object) this.DataTextField;
      string dataValueField = this.DataValueField;
      if ((dataValueField != null ? (dataValueField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["dataValueField"] = (object) this.DataValueField;
      if (this.Delay.HasValue)
        dictionary1["delay"] = (object) this.Delay;
      if (this.DownArrow.HasValue)
        dictionary1["downArrow"] = (object) this.DownArrow;
      if (this.Enable.HasValue)
        dictionary1["enable"] = (object) this.Enable;
      if (this.EnforceMinLength.HasValue)
        dictionary1["enforceMinLength"] = (object) this.EnforceMinLength;
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
      if (this.HighlightFirst.HasValue)
        dictionary1["highlightFirst"] = (object) this.HighlightFirst;
      if (this.IgnoreCase.HasValue)
        dictionary1["ignoreCase"] = (object) this.IgnoreCase;
      Dictionary<string, object> source1 = this.Messages.Serialize();
      if (source1.Any<KeyValuePair<string, object>>())
        dictionary1["messages"] = (object) source1;
      if (this.MinLength.HasValue)
        dictionary1["minLength"] = (object) this.MinLength;
      if (this.MaxSelectedItems.HasValue)
        dictionary1["maxSelectedItems"] = (object) this.MaxSelectedItems;
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
      Dictionary<string, object> source2 = this.Popup.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
        dictionary1["popup"] = (object) source2;
      if (this.HeaderTemplateId.HasValue())
        dictionary1["headerTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.HeaderTemplateId)
        };
      else if (this.HeaderTemplate.HasValue())
        dictionary1["headerTemplate"] = (object) this.HeaderTemplate;
      if (this.ItemTemplateId.HasValue())
        dictionary1["itemTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.ItemTemplateId)
        };
      else if (this.ItemTemplate.HasValue())
        dictionary1["itemTemplate"] = (object) this.ItemTemplate;
      if (this.TagTemplateId.HasValue())
        dictionary1["tagTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.TagTemplateId)
        };
      else if (this.TagTemplate.HasValue())
        dictionary1["tagTemplate"] = (object) this.TagTemplate;
      if (this.TagMode.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        MultiSelectTagMode? tagMode = this.TagMode;
        ref MultiSelectTagMode? local = ref tagMode;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["tagMode"] = (object) str;
      }
      if (this.ValuePrimitive.HasValue)
        dictionary1["valuePrimitive"] = (object) this.ValuePrimitive;
      Dictionary<string, object> source3 = this.Virtual.Serialize();
      if (source3.Any<KeyValuePair<string, object>>())
        dictionary1["virtual"] = (object) source3;
      else if (this.Virtual.Enabled.HasValue)
        dictionary1["virtual"] = (object) this.Virtual.Enabled;
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
