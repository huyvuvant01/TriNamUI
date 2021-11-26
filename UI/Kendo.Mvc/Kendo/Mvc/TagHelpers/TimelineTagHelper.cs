// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.TimelineTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Rendering;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("kendo-timeline")]
  [RestrictChildren("datasource", new string[] {})]
  public class TimelineTagHelper : TagHelperBase, IDataBoundWidget<
  #nullable disable
  DataSourceTagHelper>
  {
    public string DatasourceId { get; set; }

    public DataSourceTagHelper Datasource { get; set; }

    [HtmlAttributeName("dataactionsfield")]
    public string DataActionsField { get; set; }

    [HtmlAttributeName("datadescriptionfield")]
    public string DataDescriptionField { get; set; }

    [HtmlAttributeName("datadatefield")]
    public string DataDateField { get; set; }

    [HtmlAttributeName("dataimagesfield")]
    public string DataImagesField { get; set; }

    [HtmlAttributeName("datasubtitlefield")]
    public string DataSubTitleField { get; set; }

    [HtmlAttributeName("datatitlefield")]
    public string DataTitleField { get; set; }

    [HtmlAttributeName("dataimagesaltfield")]
    public string DataImagesAltField { get; set; }

    public TimelineTagHelper(IKendoHtmlGenerator generator)
      : base(generator)
    {
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      TimelineTagHelper timelineTagHelper = this;
      context.Items[(object) timelineTagHelper.GetType()] = (object) timelineTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      // ISSUE: reference to a compiler-generated method
      await timelineTagHelper.\u003C\u003En__0(context, output);
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
      string dataActionsField = this.DataActionsField;
      if ((dataActionsField != null ? (dataActionsField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataActionsField"] = (object) this.DataActionsField;
      string descriptionField = this.DataDescriptionField;
      if ((descriptionField != null ? (descriptionField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataDescriptionField"] = (object) this.DataDescriptionField;
      string dataDateField = this.DataDateField;
      if ((dataDateField != null ? (dataDateField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataDateField"] = (object) this.DataDateField;
      string dataImagesField = this.DataImagesField;
      if ((dataImagesField != null ? (dataImagesField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataImagesField"] = (object) this.DataImagesField;
      string dataSubTitleField = this.DataSubTitleField;
      if ((dataSubTitleField != null ? (dataSubTitleField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataSubtitleField"] = (object) this.DataSubTitleField;
      string dataTitleField = this.DataTitleField;
      if ((dataTitleField != null ? (dataTitleField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataTitleField"] = (object) this.DataTitleField;
      string dataImagesAltField = this.DataImagesAltField;
      if ((dataImagesAltField != null ? (dataImagesAltField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataImagesAltField"] = (object) this.DataImagesAltField;
      if (this.DatasourceId.HasValue())
        dictionary["dataSourceId"] = (object) this.DatasourceId;
      else if (this.Datasource != null)
        dictionary["dataSource"] = (object) this.Datasource.Serialize();
      return this.Initializer.Initialize(this.Selector, "Timeline", (IDictionary<string, object>) dictionary);
    }

    public string OnChange { get; set; }

    public string OnDataBound { get; set; }

    public string OnExpand { get; set; }

    public string OnCollapse { get; set; }

    public string OnActionClick { get; set; }

    public string OnNavigate { get; set; }

    protected override Dictionary<string, object> SerializeEvents()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string onChange = this.OnChange;
      if ((onChange != null ? (onChange.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["change"] = (object) this.CreateHandler(this.OnChange);
      string onDataBound = this.OnDataBound;
      if ((onDataBound != null ? (onDataBound.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataBound"] = (object) this.CreateHandler(this.OnDataBound);
      string onExpand = this.OnExpand;
      if ((onExpand != null ? (onExpand.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["expand"] = (object) this.CreateHandler(this.OnExpand);
      string onCollapse = this.OnCollapse;
      if ((onCollapse != null ? (onCollapse.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["collapse"] = (object) this.CreateHandler(this.OnCollapse);
      string onActionClick = this.OnActionClick;
      if ((onActionClick != null ? (onActionClick.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["actionClick"] = (object) this.CreateHandler(this.OnActionClick);
      string onNavigate = this.OnNavigate;
      if ((onNavigate != null ? (onNavigate.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["navigate"] = (object) this.CreateHandler(this.OnNavigate);
      return dictionary;
    }

    public bool? AutoBind { get; set; }

    public bool? AlternatingMode { get; set; }

    public bool? CollapsibleEvents { get; set; }

    public string EventTemplate { get; set; }

    public string EventTemplateId { get; set; }

    public string DateFormat { get; set; }

    public double? EventHeight { get; set; }

    public double? EventWidth { get; set; }

    public bool? Navigatable { get; set; }

    public bool? ShowDateLabels { get; set; }

    public TimelineOrientation? Orientation { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = base.SerializeSettings();
      if (this.AutoBind.HasValue)
        dictionary1["autoBind"] = (object) this.AutoBind;
      if (this.AlternatingMode.HasValue)
        dictionary1["alternatingMode"] = (object) this.AlternatingMode;
      if (this.CollapsibleEvents.HasValue)
        dictionary1["collapsibleEvents"] = (object) this.CollapsibleEvents;
      if (this.EventTemplateId.HasValue())
        dictionary1["eventTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.EventTemplateId)
        };
      else if (this.EventTemplate.HasValue())
        dictionary1["eventTemplate"] = (object) this.EventTemplate;
      string dateFormat = this.DateFormat;
      if ((dateFormat != null ? (dateFormat.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["dateFormat"] = (object) this.DateFormat;
      if (this.EventHeight.HasValue)
        dictionary1["eventHeight"] = (object) this.EventHeight;
      if (this.EventWidth.HasValue)
        dictionary1["eventWidth"] = (object) this.EventWidth;
      if (this.Navigatable.HasValue)
        dictionary1["navigatable"] = (object) this.Navigatable;
      if (this.ShowDateLabels.HasValue)
        dictionary1["showDateLabels"] = (object) this.ShowDateLabels;
      if (this.Orientation.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        TimelineOrientation? orientation = this.Orientation;
        ref TimelineOrientation? local = ref orientation;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["orientation"] = (object) str;
      }
      return dictionary1;
    }
  }
}
