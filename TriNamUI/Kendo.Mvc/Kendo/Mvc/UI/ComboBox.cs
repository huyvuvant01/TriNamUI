// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.ComboBox
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Kendo.Mvc.UI
{
  public class ComboBox : WidgetBase, IFormEditor
  {
    private static readonly Regex EscapeRegex = new Regex("([;&,\\.\\+\\*~'\\:\\\"\\!\\^\\$\\[\\]\\(\\)\\|\\/])", RegexOptions.Compiled);

    public DataSource DataSource { get; private set; }

    public int? SelectedIndex { get; set; }

    public PopupAnimation Animation { get; private set; }

    public ComboBox(ViewContext viewContext)
      : base(viewContext)
    {
      this.DataSource = new DataSource(this.ModelMetadataProvider);
      this.Animation = new PopupAnimation();
    }

    public string DataSourceId { get; set; }

    protected override void WriteHtml(TextWriter writer)
    {
      bool? enable = this.Enable;
      bool flag = false;
      if (enable.GetValueOrDefault() == flag & enable.HasValue)
        this.HtmlAttributes.Merge("disabled", (object) "disabled", true);
      this.Generator.GenerateTextInput(this.ViewContext, this.Explorer, this.Id, this.Name, (object) this.Value, string.Empty, this.HtmlAttributes).WriteTo(writer, this.HtmlEncoder);
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
        if (string.IsNullOrEmpty(this.DataSource.Transport.Read.Url) && string.IsNullOrEmpty(this.DataSource.Transport.Read.ActionName))
        {
          DataSourceType? type = this.DataSource.Type;
          DataSourceType dataSourceType = DataSourceType.Custom;
          if (!(type.GetValueOrDefault() == dataSourceType & type.HasValue))
          {
            if (this.DataSource.Data != null)
            {
              dictionary["dataSource"] = (object) this.DataSource.Data;
              goto label_9;
            }
            else
              goto label_9;
          }
        }
        dictionary["dataSource"] = (object) this.DataSource.ToJson();
      }
label_9:
      int? selectedIndex = this.SelectedIndex;
      if (selectedIndex.HasValue)
      {
        selectedIndex = this.SelectedIndex;
        int num = -1;
        if (selectedIndex.GetValueOrDefault() > num & selectedIndex.HasValue)
          dictionary["index"] = (object) this.SelectedIndex;
      }
      return (IDictionary<string, object>) dictionary;
    }

    public override void WriteInitializationScript(TextWriter writer)
    {
      if (this.DataSource.ServerFiltering && !this.DataSource.Transport.Read.Data.HasValue())
      {
        DataSourceType? type = this.DataSource.Type;
        DataSourceType dataSourceType1 = DataSourceType.Custom;
        if (!(type.GetValueOrDefault() == dataSourceType1 & type.HasValue))
        {
          type = this.DataSource.Type;
          DataSourceType dataSourceType2 = DataSourceType.Ajax;
          if (!(type.GetValueOrDefault() == dataSourceType2 & type.HasValue))
            this.DataSource.Transport.Read.Data = new ClientHandlerDescriptor()
            {
              HandlerName = "function() { return kendo.ui.ComboBox.requestData(jQuery(\"" + ComboBox.EscapeRegex.Replace(this.Selector, "\\\\$1") + "\")); }"
            };
        }
      }
      writer.Write(this.Initializer.Initialize(this.Selector, nameof (ComboBox), this.Serialize()));
    }

    public bool? AutoBind { get; set; }

    public bool? AutoWidth { get; set; }

    public string CascadeFrom { get; set; }

    public string CascadeFromField { get; set; }

    public string CascadeFromParentField { get; set; }

    public bool? ClearButton { get; set; }

    public string DataTextField { get; set; }

    public string DataValueField { get; set; }

    public double? Delay { get; set; }

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

    public ComboBoxMessagesSettings Messages { get; } = new ComboBoxMessagesSettings();

    public double? MinLength { get; set; }

    public string NoDataTemplate { get; set; }

    public string NoDataTemplateId { get; set; }

    public string Placeholder { get; set; }

    public ComboBoxPopupSettings Popup { get; } = new ComboBoxPopupSettings();

    public bool? Suggest { get; set; }

    public bool? SyncValueAndText { get; set; }

    public string HeaderTemplate { get; set; }

    public string HeaderTemplateId { get; set; }

    public string Template { get; set; }

    public string TemplateId { get; set; }

    public string Text { get; set; }

    public string Value { get; set; }

    public bool? ValuePrimitive { get; set; }

    public ComboBoxVirtualSettings Virtual { get; } = new ComboBoxVirtualSettings();

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
      if (this.Suggest.HasValue)
        dictionary1["suggest"] = (object) this.Suggest;
      if (this.SyncValueAndText.HasValue)
        dictionary1["syncValueAndText"] = (object) this.SyncValueAndText;
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
      string text = this.Text;
      if ((text != null ? (text.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["text"] = (object) this.Text;
      string str1 = this.Value;
      if ((str1 != null ? (str1.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["value"] = (object) this.Value;
      if (this.ValuePrimitive.HasValue)
        dictionary1["valuePrimitive"] = (object) this.ValuePrimitive;
      Dictionary<string, object> source3 = this.Virtual.Serialize();
      if (source3.Any<KeyValuePair<string, object>>())
        dictionary1["virtual"] = (object) source3;
      else if (this.Virtual.Enabled.HasValue)
        dictionary1["virtual"] = (object) this.Virtual.Enabled;
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
