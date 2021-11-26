// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.GanttTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Rendering;
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
  [HtmlTargetElement("kendo-gantt")]
  [RestrictChildren("assignments", new string[] {"columns", "current-time-marker", "editable", "messages", "pdf", "range", "toolbars", "tooltip", "views", "resources", "gantt-datasource", "dependency-datasource"})]
  public class GanttTagHelper : TagHelperBase, IDataBoundWidget<
  #nullable disable
  GanttDataSourceTagHelper>
  {
    [HtmlAttributeNotBound]
    public GanttDataSourceTagHelper Datasource { get; set; }

    public string DatasourceId { get; set; }

    [HtmlAttributeNotBound]
    public GanttDependencyDataSourceTagHelper DependancyDatasource { get; set; }

    public string DependancyDatasourceId { get; set; }

    public GanttTagHelper(IKendoHtmlGenerator generator)
      : base(generator)
    {
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      GanttTagHelper ganttTagHelper = this;
      context.Items[(object) ganttTagHelper.GetType()] = (object) ganttTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      // ISSUE: reference to a compiler-generated method
      await ganttTagHelper.\u003C\u003En__0(context, output);
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
      if (this.DatasourceId.HasValue())
        dictionary["dataSourceId"] = (object) this.DatasourceId;
      else if (this.Datasource != null)
        dictionary["dataSource"] = (object) this.Datasource.Serialize();
      if (this.DependancyDatasourceId.HasValue())
        dictionary["dependenciesId"] = (object) this.DependancyDatasourceId;
      else if (this.DependancyDatasource != null)
        dictionary["dependencies"] = (object) this.DependancyDatasource.Serialize();
      return this.Initializer.Initialize(this.Selector, "Gantt", (IDictionary<string, object>) dictionary);
    }

    public string OnDataBinding { get; set; }

    public string OnDataBound { get; set; }

    public string OnAdd { get; set; }

    public string OnEdit { get; set; }

    public string OnRemove { get; set; }

    public string OnCancel { get; set; }

    public string OnSave { get; set; }

    public string OnChange { get; set; }

    public string OnColumnHide { get; set; }

    public string OnColumnReorder { get; set; }

    public string OnColumnResize { get; set; }

    public string OnColumnShow { get; set; }

    public string OnNavigate { get; set; }

    public string OnMoveStart { get; set; }

    public string OnMove { get; set; }

    public string OnMoveEnd { get; set; }

    public string OnPdfExport { get; set; }

    public string OnResizeStart { get; set; }

    public string OnResize { get; set; }

    public string OnResizeEnd { get; set; }

    public string OnTogglePlannedTasks { get; set; }

    protected override Dictionary<string, object> SerializeEvents()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string onDataBinding = this.OnDataBinding;
      if ((onDataBinding != null ? (onDataBinding.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataBinding"] = (object) this.CreateHandler(this.OnDataBinding);
      string onDataBound = this.OnDataBound;
      if ((onDataBound != null ? (onDataBound.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataBound"] = (object) this.CreateHandler(this.OnDataBound);
      string onAdd = this.OnAdd;
      if ((onAdd != null ? (onAdd.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["add"] = (object) this.CreateHandler(this.OnAdd);
      string onEdit = this.OnEdit;
      if ((onEdit != null ? (onEdit.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["edit"] = (object) this.CreateHandler(this.OnEdit);
      string onRemove = this.OnRemove;
      if ((onRemove != null ? (onRemove.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["remove"] = (object) this.CreateHandler(this.OnRemove);
      string onCancel = this.OnCancel;
      if ((onCancel != null ? (onCancel.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["cancel"] = (object) this.CreateHandler(this.OnCancel);
      string onSave = this.OnSave;
      if ((onSave != null ? (onSave.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["save"] = (object) this.CreateHandler(this.OnSave);
      string onChange = this.OnChange;
      if ((onChange != null ? (onChange.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["change"] = (object) this.CreateHandler(this.OnChange);
      string onColumnHide = this.OnColumnHide;
      if ((onColumnHide != null ? (onColumnHide.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["columnHide"] = (object) this.CreateHandler(this.OnColumnHide);
      string onColumnReorder = this.OnColumnReorder;
      if ((onColumnReorder != null ? (onColumnReorder.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["columnReorder"] = (object) this.CreateHandler(this.OnColumnReorder);
      string onColumnResize = this.OnColumnResize;
      if ((onColumnResize != null ? (onColumnResize.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["columnResize"] = (object) this.CreateHandler(this.OnColumnResize);
      string onColumnShow = this.OnColumnShow;
      if ((onColumnShow != null ? (onColumnShow.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["columnShow"] = (object) this.CreateHandler(this.OnColumnShow);
      string onNavigate = this.OnNavigate;
      if ((onNavigate != null ? (onNavigate.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["navigate"] = (object) this.CreateHandler(this.OnNavigate);
      string onMoveStart = this.OnMoveStart;
      if ((onMoveStart != null ? (onMoveStart.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["moveStart"] = (object) this.CreateHandler(this.OnMoveStart);
      string onMove = this.OnMove;
      if ((onMove != null ? (onMove.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["move"] = (object) this.CreateHandler(this.OnMove);
      string onMoveEnd = this.OnMoveEnd;
      if ((onMoveEnd != null ? (onMoveEnd.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["moveEnd"] = (object) this.CreateHandler(this.OnMoveEnd);
      string onPdfExport = this.OnPdfExport;
      if ((onPdfExport != null ? (onPdfExport.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["pdfExport"] = (object) this.CreateHandler(this.OnPdfExport);
      string onResizeStart = this.OnResizeStart;
      if ((onResizeStart != null ? (onResizeStart.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["resizeStart"] = (object) this.CreateHandler(this.OnResizeStart);
      string onResize = this.OnResize;
      if ((onResize != null ? (onResize.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["resize"] = (object) this.CreateHandler(this.OnResize);
      string onResizeEnd = this.OnResizeEnd;
      if ((onResizeEnd != null ? (onResizeEnd.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["resizeEnd"] = (object) this.CreateHandler(this.OnResizeEnd);
      string togglePlannedTasks = this.OnTogglePlannedTasks;
      if ((togglePlannedTasks != null ? (togglePlannedTasks.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["togglePlannedTasks"] = (object) this.CreateHandler(this.OnTogglePlannedTasks);
      return dictionary;
    }

    [HtmlAttributeNotBound]
    public GanttAssignmentsSettingsTagHelper Assignments { get; set; }

    public bool? AutoBind { get; set; }

    public double? ColumnResizeHandleWidth { get; set; }

    public bool? ColumnMenu { get; set; }

    [HtmlAttributeNotBound]
    public GanttColumnsTagHelper Columns { get; set; }

    [HtmlAttributeNotBound]
    public GanttCurrentTimeMarkerSettingsTagHelper CurrentTimeMarker { get; set; }

    public DateTime? Date { get; set; }

    [HtmlAttributeNotBound]
    public GanttEditableSettingsTagHelper Editable { get; set; }

    public bool? Filterable { get; set; }

    public bool? Reorderable { get; set; }

    public bool? Navigatable { get; set; }

    public DateTime? WorkDayStart { get; set; }

    public DateTime? WorkDayEnd { get; set; }

    public double? WorkWeekStart { get; set; }

    public double? WorkWeekEnd { get; set; }

    public double? HourSpan { get; set; }

    public bool? Snap { get; set; }

    public double? Height { get; set; }

    public string ListWidth { get; set; }

    [HtmlAttributeNotBound]
    public GanttMessagesSettingsTagHelper Messages { get; set; }

    [HtmlAttributeNotBound]
    public GanttPdfSettingsTagHelper Pdf { get; set; }

    [HtmlAttributeNotBound]
    public GanttRangeSettingsTagHelper Range { get; set; }

    public bool? Resizable { get; set; }

    public bool? Selectable { get; set; }

    public bool? ShowPlannedTasks { get; set; }

    public bool? ShowWorkDays { get; set; }

    public bool? ShowWorkHours { get; set; }

    public string TaskTemplate { get; set; }

    public string TaskTemplateId { get; set; }

    [HtmlAttributeNotBound]
    public GanttToolbarsTagHelper Toolbar { get; set; }

    [HtmlAttributeNotBound]
    public GanttTooltipSettingsTagHelper Tooltip { get; set; }

    [HtmlAttributeNotBound]
    public GanttViewsTagHelper Views { get; set; }

    [HtmlAttributeNotBound]
    public GanttResourcesSettingsTagHelper Resources { get; set; }

    public double? RowHeight { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = base.SerializeSettings();
      if (this.Assignments != null)
      {
        Dictionary<string, object> source = this.Assignments.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["assignments"] = (object) source;
      }
      if (this.AutoBind.HasValue)
        dictionary["autoBind"] = (object) this.AutoBind;
      if (this.ColumnResizeHandleWidth.HasValue)
        dictionary["columnResizeHandleWidth"] = (object) this.ColumnResizeHandleWidth;
      if (this.ColumnMenu.HasValue)
        dictionary["columnMenu"] = (object) this.ColumnMenu;
      if (this.Columns != null)
      {
        IEnumerable<Dictionary<string, object>> source = this.Columns.Select<GanttColumnTagHelper, Dictionary<string, object>>((Func<GanttColumnTagHelper, Dictionary<string, object>>) (i => i.Serialize()));
        if (source.Any<Dictionary<string, object>>())
          dictionary["columns"] = (object) source;
      }
      if (this.CurrentTimeMarker != null)
      {
        Dictionary<string, object> source = this.CurrentTimeMarker.Serialize();
        if (source.Any<KeyValuePair<string, object>>() && (!this.CurrentTimeMarker.Enabled.HasValue || this.CurrentTimeMarker.Enabled.Value))
          dictionary["currentTimeMarker"] = (object) source;
        else if (this.CurrentTimeMarker.Enabled.HasValue && !this.CurrentTimeMarker.Enabled.Value)
          dictionary["currentTimeMarker"] = (object) this.CurrentTimeMarker.Enabled;
      }
      if (this.Date.HasValue)
        dictionary["date"] = (object) this.Date;
      if (this.Filterable.HasValue)
        dictionary["filterable"] = (object) this.Filterable;
      if (this.Reorderable.HasValue)
        dictionary["reorderable"] = (object) this.Reorderable;
      if (this.Navigatable.HasValue)
        dictionary["navigatable"] = (object) this.Navigatable;
      if (this.WorkDayStart.HasValue)
        dictionary["workDayStart"] = (object) this.WorkDayStart;
      if (this.WorkDayEnd.HasValue)
        dictionary["workDayEnd"] = (object) this.WorkDayEnd;
      if (this.WorkWeekStart.HasValue)
        dictionary["workWeekStart"] = (object) this.WorkWeekStart;
      if (this.WorkWeekEnd.HasValue)
        dictionary["workWeekEnd"] = (object) this.WorkWeekEnd;
      if (this.HourSpan.HasValue)
        dictionary["hourSpan"] = (object) this.HourSpan;
      if (this.Snap.HasValue)
        dictionary["snap"] = (object) this.Snap;
      if (this.Height.HasValue)
        dictionary["height"] = (object) this.Height;
      string listWidth = this.ListWidth;
      if ((listWidth != null ? (listWidth.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["listWidth"] = (object) this.ListWidth;
      if (this.Messages != null)
      {
        Dictionary<string, object> source = this.Messages.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["messages"] = (object) source;
      }
      if (this.Pdf != null)
      {
        Dictionary<string, object> source = this.Pdf.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["pdf"] = (object) source;
      }
      if (this.Range != null)
      {
        Dictionary<string, object> source = this.Range.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["range"] = (object) source;
      }
      if (this.Resizable.HasValue)
        dictionary["resizable"] = (object) this.Resizable;
      if (this.Selectable.HasValue)
        dictionary["selectable"] = (object) this.Selectable;
      if (this.ShowPlannedTasks.HasValue)
        dictionary["showPlannedTasks"] = (object) this.ShowPlannedTasks;
      if (this.ShowWorkDays.HasValue)
        dictionary["showWorkDays"] = (object) this.ShowWorkDays;
      if (this.ShowWorkHours.HasValue)
        dictionary["showWorkHours"] = (object) this.ShowWorkHours;
      if (this.TaskTemplateId.HasValue())
        dictionary["taskTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.TaskTemplateId)
        };
      else if (this.TaskTemplate.HasValue())
        dictionary["taskTemplate"] = (object) this.TaskTemplate;
      if (this.Toolbar != null)
      {
        IEnumerable<Dictionary<string, object>> source = this.Toolbar.Select<GanttToolbarTagHelper, Dictionary<string, object>>((Func<GanttToolbarTagHelper, Dictionary<string, object>>) (i => i.Serialize()));
        if (source.Any<Dictionary<string, object>>())
          dictionary["toolbar"] = (object) source;
      }
      if (this.Tooltip != null)
      {
        Dictionary<string, object> source = this.Tooltip.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["tooltip"] = (object) source;
      }
      if (this.Views != null)
      {
        IEnumerable<Dictionary<string, object>> source = this.Views.Select<GanttViewTagHelper, Dictionary<string, object>>((Func<GanttViewTagHelper, Dictionary<string, object>>) (i => i.Serialize()));
        if (source.Any<Dictionary<string, object>>())
          dictionary["views"] = (object) source;
      }
      if (this.Resources != null)
      {
        Dictionary<string, object> source = this.Resources.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["resources"] = (object) source;
      }
      if (this.RowHeight.HasValue)
        dictionary["rowHeight"] = (object) this.RowHeight;
      return dictionary;
    }
  }
}
