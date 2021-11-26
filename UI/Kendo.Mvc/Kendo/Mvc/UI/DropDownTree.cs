// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.DropDownTree
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Kendo.Mvc.UI
{
  public class DropDownTree : 
    WidgetBase,
    INavigationItemComponent<DropDownTreeItem>,
    INavigationItemContainer<DropDownTreeItem>,
    IFormEditor
  {
    private static readonly Regex EscapeRegex = new Regex("([;&,\\.\\+\\*~'\\:\\\"\\!\\^\\$\\[\\]\\(\\)\\|\\/])", RegexOptions.Compiled);

    public DropDownTree(ViewContext viewContext)
      : base(viewContext)
    {
      this.Items = (IList<DropDownTreeItem>) new LinkedObjectCollection<DropDownTreeItem>((DropDownTreeItem) null);
      this.DataSource = new DataSource(this.ModelMetadataProvider);
      this.DataSource.Schema.Model = new ModelDescriptor(typeof (object), this.ModelMetadataProvider);
      this.Animation = new PopupAnimation();
      this.DataTextFieldArray = new List<string>();
    }

    public PopupAnimation Animation { get; private set; }

    public IList<DropDownTreeItem> Items { get; private set; }

    public List<string> DataTextFieldArray { get; set; }

    public DataSource DataSource { get; private set; }

    public string DataSourceId { get; set; }

    public Action<DropDownTreeItem> ItemAction { get; set; }

    public IEnumerable ValueArray { get; set; }

    protected override void WriteHtml(TextWriter writer)
    {
      bool? enable = this.Enable;
      bool flag1 = false;
      if (enable.GetValueOrDefault() == flag1 & enable.HasValue)
        this.HtmlAttributes.Merge("disabled", (object) "disabled", true);
      TagBuilder tagBuilder;
      if (!this.Checkboxes.Serialize().Any<KeyValuePair<string, object>>())
      {
        bool? enabled = this.Checkboxes.Enabled;
        bool flag2 = true;
        if (!(enabled.GetValueOrDefault() == flag2 & enabled.HasValue))
        {
          tagBuilder = this.Generator.GenerateTextInput(this.ViewContext, this.Explorer, this.Id, this.Name, (object) this.Value, string.Empty, this.HtmlAttributes);
          goto label_6;
        }
      }
      tagBuilder = this.Generator.GenerateMultiSelect(this.ViewContext, this.Explorer, this.Id, this.Name, this.HtmlAttributes);
label_6:
      tagBuilder.WriteTo(writer, this.HtmlEncoder);
      base.WriteHtml(writer);
    }

    public IDictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      if (this.DataTextFieldArray.Count<string>() > 0)
        dictionary["dataTextField"] = (object) this.DataTextFieldArray;
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
        {
          DataSourceType? type1 = this.DataSource.Type;
          DataSourceType dataSourceType1 = DataSourceType.Custom;
          if (!(type1.GetValueOrDefault() == dataSourceType1 & type1.HasValue))
          {
            DataSourceType? type2 = this.DataSource.Type;
            DataSourceType dataSourceType2 = DataSourceType.Ajax;
            if (!(type2.GetValueOrDefault() == dataSourceType2 & type2.HasValue))
              this.DataSource.Transport.Read.Data = new ClientHandlerDescriptor()
              {
                HandlerName = "function() { return kendo.ui.DropDownTree.requestData(jQuery(\"" + DropDownTree.EscapeRegex.Replace(this.Selector, "\\\\$1") + "\")); }"
              };
          }
        }
        if (this.Items.Any<DropDownTreeItem>())
          this.DataSource.Data = this.SerializeItems(this.Items);
        if (string.IsNullOrEmpty(this.DataSource.Transport.Read.Url))
        {
          DataSourceType? type = this.DataSource.Type;
          DataSourceType dataSourceType = DataSourceType.Custom;
          if (!(type.GetValueOrDefault() == dataSourceType & type.HasValue))
          {
            if (this.DataSource.Data != null)
            {
              dictionary["dataSource"] = (object) this.DataSource.Data;
              goto label_17;
            }
            else
              goto label_17;
          }
        }
        dictionary["dataSource"] = (object) this.DataSource.ToJson();
      }
label_17:
      IEnumerable enumerable = this.GetValue();
      if (enumerable != null)
        dictionary["value"] = (object) enumerable;
      return (IDictionary<string, object>) dictionary;
    }

    public override void WriteInitializationScript(TextWriter writer) => writer.Write(this.Initializer.Initialize(this.Selector, nameof (DropDownTree), this.Serialize()));

    private IEnumerable SerializeItems(IList<DropDownTreeItem> items)
    {
      IUrlHelper urlHelper = this.ViewContext.HttpContext.RequestServices.GetRequiredService<IUrlHelperFactory>().GetUrlHelper((ActionContext) this.ViewContext);
      return (IEnumerable) items.Select<DropDownTreeItem, IDictionary<string, object>>((Func<DropDownTreeItem, IDictionary<string, object>>) (item => item.Serialize(urlHelper)));
    }

    private IEnumerable GetValue()
    {
      ModelStateEntry modelStateEntry;
      if (this.ViewContext.ViewData.ModelState.TryGetValue(this.Name, out modelStateEntry) && modelStateEntry.RawValue != null)
        return modelStateEntry.RawValue as IEnumerable;
      return this.ValueArray == null ? this.ViewContext.ViewData.Eval(this.Name) as IEnumerable : this.ValueArray;
    }

    public bool? AutoBind { get; set; }

    public bool? AutoClose { get; set; }

    public bool? AutoWidth { get; set; }

    public bool? CheckAll { get; set; }

    public string CheckAllTemplate { get; set; }

    public string CheckAllTemplateId { get; set; }

    public DropDownTreeCheckboxesSettings Checkboxes { get; } = new DropDownTreeCheckboxesSettings();

    public bool? ClearButton { get; set; }

    public string DataImageUrlField { get; set; }

    public string DataSpriteCssClassField { get; set; }

    public string DataTextField { get; set; }

    public string DataUrlField { get; set; }

    public string DataValueField { get; set; }

    public double? Delay { get; set; }

    public bool? Enable { get; set; }

    public bool? EnforceMinLength { get; set; }

    public string FooterTemplate { get; set; }

    public string FooterTemplateId { get; set; }

    public string Height { get; set; }

    public bool? IgnoreCase { get; set; }

    public bool? LoadOnDemand { get; set; }

    public DropDownTreeMessagesSettings Messages { get; } = new DropDownTreeMessagesSettings();

    public double? MinLength { get; set; }

    public string NoDataTemplate { get; set; }

    public string NoDataTemplateId { get; set; }

    public string Placeholder { get; set; }

    public DropDownTreePopupSettings Popup { get; } = new DropDownTreePopupSettings();

    public string HeaderTemplate { get; set; }

    public string HeaderTemplateId { get; set; }

    public string ValueTemplate { get; set; }

    public string ValueTemplateId { get; set; }

    public DropDownTreeTagMode? TagMode { get; set; }

    public string Template { get; set; }

    public string TemplateId { get; set; }

    public string Text { get; set; }

    public string Value { get; set; }

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
      Dictionary<string, object> source1 = this.Checkboxes.Serialize();
      if (source1.Any<KeyValuePair<string, object>>())
        dictionary1["checkboxes"] = (object) source1;
      else if (this.Checkboxes.Enabled.HasValue)
        dictionary1["checkboxes"] = (object) this.Checkboxes.Enabled;
      if (this.ClearButton.HasValue)
        dictionary1["clearButton"] = (object) this.ClearButton;
      string dataImageUrlField = this.DataImageUrlField;
      if ((dataImageUrlField != null ? (dataImageUrlField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["dataImageUrlField"] = (object) this.DataImageUrlField;
      string spriteCssClassField = this.DataSpriteCssClassField;
      if ((spriteCssClassField != null ? (spriteCssClassField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["dataSpriteCssClassField"] = (object) this.DataSpriteCssClassField;
      string dataTextField = this.DataTextField;
      if ((dataTextField != null ? (dataTextField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["dataTextField"] = (object) this.DataTextField;
      string dataUrlField = this.DataUrlField;
      if ((dataUrlField != null ? (dataUrlField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["dataUrlField"] = (object) this.DataUrlField;
      string dataValueField = this.DataValueField;
      if ((dataValueField != null ? (dataValueField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["dataValueField"] = (object) this.DataValueField;
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
      Dictionary<string, object> source2 = this.Messages.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
        dictionary1["messages"] = (object) source2;
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
      Dictionary<string, object> source3 = this.Popup.Serialize();
      if (source3.Any<KeyValuePair<string, object>>())
        dictionary1["popup"] = (object) source3;
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
      string str1 = this.Value;
      if ((str1 != null ? (str1.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["value"] = (object) this.Value;
      if (this.ValuePrimitive.HasValue)
        dictionary1["valuePrimitive"] = (object) this.ValuePrimitive;
      if (this.Filter.HasValue)
      {
        Dictionary<string, object> dictionary3 = dictionary1;
        FilterType? filter = this.Filter;
        ref FilterType? local = ref filter;
        string str2 = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary3["filter"] = (object) str2;
      }
      return dictionary1;
    }
  }
}
