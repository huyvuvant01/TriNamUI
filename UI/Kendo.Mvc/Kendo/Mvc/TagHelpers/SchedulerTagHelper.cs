// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.SchedulerTagHelper
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
  [HtmlTargetElement("kendo-scheduler")]
  [RestrictChildren("current-time-marker", new string[] {"editable", "scheduler-footer", "group", "messages", "pdf", "resources", "toolbar", "views", "scheduler-datasource"})]
  [OutputElementHint("div")]
  public class SchedulerTagHelper : TagHelperBase, IDataBoundWidget<
  #nullable disable
  SchedulerDataSourceTagHelper>
  {
    [HtmlAttributeNotBound]
    public SchedulerDataSourceTagHelper Datasource { get; set; }

    [HtmlAttributeName("datasource-id")]
    public string DataSourceId { get; set; }

    public int[] WorkDays { get; set; }

    public SchedulerTagHelper(IKendoHtmlGenerator generator)
      : base(generator)
    {
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      SchedulerTagHelper schedulerTagHelper = this;
      context.Items[(object) schedulerTagHelper.GetType()] = (object) schedulerTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      // ISSUE: reference to a compiler-generated method
      await schedulerTagHelper.\u003C\u003En__0(context, output);
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
      if (this.Datasource != null)
        dictionary["dataSource"] = (object) this.Datasource.Serialize();
      if (this.DataSourceId.HasValue())
        dictionary["dataSourceId"] = (object) this.DataSourceId;
      if (this.Editable != null)
      {
        bool? enabled = this.Editable.Enabled;
        bool flag = false;
        dictionary["editable"] = !(enabled.GetValueOrDefault() == flag & enabled.HasValue) ? (object) this.Editable.Serialize() : (object) false;
      }
      if (this.Mobile.HasValue)
      {
        MobileMode? mobile = this.Mobile;
        if (mobile.HasValue)
        {
          switch (mobile.GetValueOrDefault())
          {
            case MobileMode.Disabled:
              dictionary["mobile"] = (object) false;
              break;
            case MobileMode.Auto:
              dictionary["mobile"] = (object) true;
              break;
            case MobileMode.Phone:
              dictionary["mobile"] = (object) "phone";
              break;
            case MobileMode.Tablet:
              dictionary["mobile"] = (object) "tablet";
              break;
          }
        }
      }
      if (this.WorkDays != null)
        dictionary["workDays"] = (object) this.WorkDays;
      return this.Initializer.Initialize(this.Selector, "Scheduler", (IDictionary<string, object>) dictionary);
    }

    public string OnAdd { get; set; }

    public string OnCancel { get; set; }

    public string OnChange { get; set; }

    public string OnDataBinding { get; set; }

    public string OnDataBound { get; set; }

    public string OnEdit { get; set; }

    public string OnMoveStart { get; set; }

    public string OnMove { get; set; }

    public string OnMoveEnd { get; set; }

    public string OnNavigate { get; set; }

    public string OnPdfExport { get; set; }

    public string OnRemove { get; set; }

    public string OnResizeStart { get; set; }

    public string OnResize { get; set; }

    public string OnResizeEnd { get; set; }

    public string OnSave { get; set; }

    protected override Dictionary<string, object> SerializeEvents()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string onAdd = this.OnAdd;
      if ((onAdd != null ? (onAdd.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["add"] = (object) this.CreateHandler(this.OnAdd);
      string onCancel = this.OnCancel;
      if ((onCancel != null ? (onCancel.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["cancel"] = (object) this.CreateHandler(this.OnCancel);
      string onChange = this.OnChange;
      if ((onChange != null ? (onChange.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["change"] = (object) this.CreateHandler(this.OnChange);
      string onDataBinding = this.OnDataBinding;
      if ((onDataBinding != null ? (onDataBinding.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataBinding"] = (object) this.CreateHandler(this.OnDataBinding);
      string onDataBound = this.OnDataBound;
      if ((onDataBound != null ? (onDataBound.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataBound"] = (object) this.CreateHandler(this.OnDataBound);
      string onEdit = this.OnEdit;
      if ((onEdit != null ? (onEdit.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["edit"] = (object) this.CreateHandler(this.OnEdit);
      string onMoveStart = this.OnMoveStart;
      if ((onMoveStart != null ? (onMoveStart.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["moveStart"] = (object) this.CreateHandler(this.OnMoveStart);
      string onMove = this.OnMove;
      if ((onMove != null ? (onMove.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["move"] = (object) this.CreateHandler(this.OnMove);
      string onMoveEnd = this.OnMoveEnd;
      if ((onMoveEnd != null ? (onMoveEnd.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["moveEnd"] = (object) this.CreateHandler(this.OnMoveEnd);
      string onNavigate = this.OnNavigate;
      if ((onNavigate != null ? (onNavigate.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["navigate"] = (object) this.CreateHandler(this.OnNavigate);
      string onPdfExport = this.OnPdfExport;
      if ((onPdfExport != null ? (onPdfExport.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["pdfExport"] = (object) this.CreateHandler(this.OnPdfExport);
      string onRemove = this.OnRemove;
      if ((onRemove != null ? (onRemove.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["remove"] = (object) this.CreateHandler(this.OnRemove);
      string onResizeStart = this.OnResizeStart;
      if ((onResizeStart != null ? (onResizeStart.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["resizeStart"] = (object) this.CreateHandler(this.OnResizeStart);
      string onResize = this.OnResize;
      if ((onResize != null ? (onResize.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["resize"] = (object) this.CreateHandler(this.OnResize);
      string onResizeEnd = this.OnResizeEnd;
      if ((onResizeEnd != null ? (onResizeEnd.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["resizeEnd"] = (object) this.CreateHandler(this.OnResizeEnd);
      string onSave = this.OnSave;
      if ((onSave != null ? (onSave.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["save"] = (object) this.CreateHandler(this.OnSave);
      return dictionary;
    }

    public string AllDayEventTemplate { get; set; }

    public string AllDayEventTemplateId { get; set; }

    public bool? AllDaySlot { get; set; }

    public bool? AutoBind { get; set; }

    [HtmlAttributeNotBound]
    public SchedulerCurrentTimeMarkerSettingsTagHelper CurrentTimeMarker { get; set; }

    public DateTime? Date { get; set; }

    public string DateHeaderTemplate { get; set; }

    public string DateHeaderTemplateId { get; set; }

    [HtmlAttributeNotBound]
    public SchedulerEditableSettingsTagHelper Editable { get; set; }

    public DateTime? EndTime { get; set; }

    public string EventTemplate { get; set; }

    public string EventTemplateId { get; set; }

    [HtmlAttributeNotBound]
    public SchedulerFooterSettingsTagHelper Footer { get; set; }

    [HtmlAttributeNotBound]
    public SchedulerGroupSettingsTagHelper Group { get; set; }

    public string GroupHeaderTemplate { get; set; }

    public string GroupHeaderTemplateId { get; set; }

    public double? Height { get; set; }

    public int? MajorTick { get; set; }

    public string MajorTimeHeaderTemplate { get; set; }

    public string MajorTimeHeaderTemplateId { get; set; }

    public DateTime? Max { get; set; }

    [HtmlAttributeNotBound]
    public SchedulerMessagesSettingsTagHelper Messages { get; set; }

    public DateTime? Min { get; set; }

    public int? MinorTickCount { get; set; }

    public string MinorTimeHeaderTemplate { get; set; }

    public string MinorTimeHeaderTemplateId { get; set; }

    [HtmlAttributeNotBound]
    public SchedulerPdfSettingsTagHelper Pdf { get; set; }

    [HtmlAttributeNotBound]
    public SchedulerResourcesTagHelper Resources { get; set; }

    public bool? Selectable { get; set; }

    public bool? ShowWorkHours { get; set; }

    public bool? Snap { get; set; }

    public DateTime? StartTime { get; set; }

    public string Timezone { get; set; }

    [HtmlAttributeNotBound]
    public SchedulerToolbarsTagHelper Toolbar { get; set; }

    [HtmlAttributeNotBound]
    public SchedulerViewsTagHelper Views { get; set; }

    public double? Width { get; set; }

    public DateTime? WorkDayStart { get; set; }

    public DateTime? WorkDayEnd { get; set; }

    public int? WorkWeekStart { get; set; }

    public int? WorkWeekEnd { get; set; }

    public MobileMode? Mobile { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = base.SerializeSettings();
      if (this.AllDayEventTemplateId.HasValue())
        dictionary["allDayEventTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.AllDayEventTemplateId)
        };
      else if (this.AllDayEventTemplate.HasValue())
        dictionary["allDayEventTemplate"] = (object) this.AllDayEventTemplate;
      bool? nullable1 = this.AllDaySlot;
      if (nullable1.HasValue)
        dictionary["allDaySlot"] = (object) this.AllDaySlot;
      nullable1 = this.AutoBind;
      if (nullable1.HasValue)
        dictionary["autoBind"] = (object) this.AutoBind;
      if (this.CurrentTimeMarker != null)
      {
        Dictionary<string, object> source = this.CurrentTimeMarker.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
        {
          nullable1 = this.CurrentTimeMarker.Enabled;
          if (nullable1.HasValue)
          {
            nullable1 = this.CurrentTimeMarker.Enabled;
            if (!nullable1.Value)
              goto label_13;
          }
          dictionary["currentTimeMarker"] = (object) source;
          goto label_16;
        }
label_13:
        nullable1 = this.CurrentTimeMarker.Enabled;
        if (nullable1.HasValue)
        {
          nullable1 = this.CurrentTimeMarker.Enabled;
          if (!nullable1.Value)
            dictionary["currentTimeMarker"] = (object) this.CurrentTimeMarker.Enabled;
        }
      }
label_16:
      DateTime? nullable2 = this.Date;
      if (nullable2.HasValue)
        dictionary["date"] = (object) this.Date;
      if (this.DateHeaderTemplateId.HasValue())
        dictionary["dateHeaderTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.DateHeaderTemplateId)
        };
      else if (this.DateHeaderTemplate.HasValue())
        dictionary["dateHeaderTemplate"] = (object) this.DateHeaderTemplate;
      nullable2 = this.EndTime;
      if (nullable2.HasValue)
        dictionary["endTime"] = (object) this.EndTime;
      if (this.EventTemplateId.HasValue())
        dictionary["eventTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.EventTemplateId)
        };
      else if (this.EventTemplate.HasValue())
        dictionary["eventTemplate"] = (object) this.EventTemplate;
      if (this.Footer != null)
      {
        Dictionary<string, object> source = this.Footer.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
        {
          nullable1 = this.Footer.Enabled;
          if (nullable1.HasValue)
          {
            nullable1 = this.Footer.Enabled;
            if (!nullable1.Value)
              goto label_33;
          }
          dictionary["footer"] = (object) source;
          goto label_36;
        }
label_33:
        nullable1 = this.Footer.Enabled;
        if (nullable1.HasValue)
        {
          nullable1 = this.Footer.Enabled;
          if (!nullable1.Value)
            dictionary["footer"] = (object) this.Footer.Enabled;
        }
      }
label_36:
      if (this.Group != null)
      {
        Dictionary<string, object> source = this.Group.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["group"] = (object) source;
      }
      if (this.GroupHeaderTemplateId.HasValue())
        dictionary["groupHeaderTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.GroupHeaderTemplateId)
        };
      else if (this.GroupHeaderTemplate.HasValue())
        dictionary["groupHeaderTemplate"] = (object) this.GroupHeaderTemplate;
      double? nullable3 = this.Height;
      if (nullable3.HasValue)
        dictionary["height"] = (object) this.Height;
      int? nullable4 = this.MajorTick;
      if (nullable4.HasValue)
        dictionary["majorTick"] = (object) this.MajorTick;
      if (this.MajorTimeHeaderTemplateId.HasValue())
        dictionary["majorTimeHeaderTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.MajorTimeHeaderTemplateId)
        };
      else if (this.MajorTimeHeaderTemplate.HasValue())
        dictionary["majorTimeHeaderTemplate"] = (object) this.MajorTimeHeaderTemplate;
      nullable2 = this.Max;
      if (nullable2.HasValue)
        dictionary["max"] = (object) this.Max;
      if (this.Messages != null)
      {
        Dictionary<string, object> source = this.Messages.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["messages"] = (object) source;
      }
      nullable2 = this.Min;
      if (nullable2.HasValue)
        dictionary["min"] = (object) this.Min;
      nullable4 = this.MinorTickCount;
      if (nullable4.HasValue)
        dictionary["minorTickCount"] = (object) this.MinorTickCount;
      if (this.MinorTimeHeaderTemplateId.HasValue())
        dictionary["minorTimeHeaderTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.MinorTimeHeaderTemplateId)
        };
      else if (this.MinorTimeHeaderTemplate.HasValue())
        dictionary["minorTimeHeaderTemplate"] = (object) this.MinorTimeHeaderTemplate;
      if (this.Pdf != null)
      {
        Dictionary<string, object> source = this.Pdf.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["pdf"] = (object) source;
      }
      if (this.Resources != null)
      {
        IEnumerable<Dictionary<string, object>> source = this.Resources.Select<SchedulerResourceTagHelper, Dictionary<string, object>>((Func<SchedulerResourceTagHelper, Dictionary<string, object>>) (i => i.Serialize()));
        if (source.Any<Dictionary<string, object>>())
          dictionary["resources"] = (object) source;
      }
      nullable1 = this.Selectable;
      if (nullable1.HasValue)
        dictionary["selectable"] = (object) this.Selectable;
      nullable1 = this.ShowWorkHours;
      if (nullable1.HasValue)
        dictionary["showWorkHours"] = (object) this.ShowWorkHours;
      nullable1 = this.Snap;
      if (nullable1.HasValue)
        dictionary["snap"] = (object) this.Snap;
      nullable2 = this.StartTime;
      if (nullable2.HasValue)
        dictionary["startTime"] = (object) this.StartTime;
      string timezone = this.Timezone;
      if ((timezone != null ? (timezone.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["timezone"] = (object) this.Timezone;
      if (this.Toolbar != null)
      {
        IEnumerable<Dictionary<string, object>> source = this.Toolbar.Select<SchedulerToolbarTagHelper, Dictionary<string, object>>((Func<SchedulerToolbarTagHelper, Dictionary<string, object>>) (i => i.Serialize()));
        if (source.Any<Dictionary<string, object>>())
          dictionary["toolbar"] = (object) source;
      }
      if (this.Views != null)
      {
        IEnumerable<Dictionary<string, object>> source = this.Views.Select<SchedulerViewTagHelper, Dictionary<string, object>>((Func<SchedulerViewTagHelper, Dictionary<string, object>>) (i => i.Serialize()));
        if (source.Any<Dictionary<string, object>>())
          dictionary["views"] = (object) source;
      }
      nullable3 = this.Width;
      if (nullable3.HasValue)
        dictionary["width"] = (object) this.Width;
      nullable2 = this.WorkDayStart;
      if (nullable2.HasValue)
        dictionary["workDayStart"] = (object) this.WorkDayStart;
      nullable2 = this.WorkDayEnd;
      if (nullable2.HasValue)
        dictionary["workDayEnd"] = (object) this.WorkDayEnd;
      nullable4 = this.WorkWeekStart;
      if (nullable4.HasValue)
        dictionary["workWeekStart"] = (object) this.WorkWeekStart;
      nullable4 = this.WorkWeekEnd;
      if (nullable4.HasValue)
        dictionary["workWeekEnd"] = (object) this.WorkWeekEnd;
      return dictionary;
    }
  }
}
