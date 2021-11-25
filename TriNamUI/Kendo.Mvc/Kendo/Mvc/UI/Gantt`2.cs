// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Gantt`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class Gantt<TTaskModel, TDependenciesModel> : WidgetBase
    where TTaskModel : class, IGanttTask
    where TDependenciesModel : class, IGanttDependency
  {
    public DataSource DataSource { get; private set; }

    public string DataSourceId { get; set; }

    public DataSource DependenciesDataSource { get; private set; }

    public string DependenciesDataSourceId { get; set; }

    public GanttAssignmentsSettings Assignments { get; }

    public GanttResourcesSettings Resources { get; }

    public Gantt(ViewContext viewContext)
      : base(viewContext)
    {
      this.DataSource = new DataSource(this.ModelMetadataProvider);
      this.DataSource.Type = new DataSourceType?(DataSourceType.Ajax);
      this.DataSource.Schema.Model = (ModelDescriptor) new GanttTaskModelDescriptor(typeof (TTaskModel), this.ModelMetadataProvider);
      this.DependenciesDataSource = new DataSource(this.ModelMetadataProvider);
      this.DependenciesDataSource.Type = new DataSourceType?(DataSourceType.Ajax);
      this.DependenciesDataSource.Schema.Model = (ModelDescriptor) new GanttDependencyModelDescriptor(typeof (TDependenciesModel), this.ModelMetadataProvider);
      this.Assignments = new GanttAssignmentsSettings(this.ModelMetadataProvider);
      this.Resources = new GanttResourcesSettings(this.ModelMetadataProvider);
    }

    protected override void WriteHtml(TextWriter writer)
    {
      this.Generator.GenerateTag("div", this.ViewContext, this.Id, this.Name, this.HtmlAttributes).WriteTo(writer, this.HtmlEncoder);
      base.WriteHtml(writer);
    }

    public override void WriteInitializationScript(TextWriter writer)
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      if (this.DataSourceId.HasValue())
      {
        dictionary["dataSourceId"] = (object) this.DataSourceId;
      }
      else
      {
        this.ProcessDataSource(this.DataSource);
        dictionary["dataSource"] = (object) (Dictionary<string, object>) this.DataSource.ToJson();
      }
      if (this.DependenciesDataSourceId.HasValue())
      {
        dictionary["dependenciesId"] = (object) this.DependenciesDataSourceId;
      }
      else
      {
        this.ProcessDataSource(this.DependenciesDataSource);
        dictionary["dependencies"] = (object) (Dictionary<string, object>) this.DependenciesDataSource.ToJson();
      }
      Dictionary<string, object> source1 = this.Assignments.Serialize();
      if (source1.Any<KeyValuePair<string, object>>())
        dictionary["assignments"] = (object) source1;
      Dictionary<string, object> source2 = this.Resources.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
        dictionary["resources"] = (object) source2;
      if (this.Editable.Enabled.HasValue)
      {
        bool? enabled = this.Editable.Enabled;
        bool flag = false;
        if (enabled.GetValueOrDefault() == flag & enabled.HasValue)
        {
          dictionary["editable"] = (object) false;
          goto label_15;
        }
      }
      Dictionary<string, object> source3 = this.Editable.Serialize();
      if (source3.Any<KeyValuePair<string, object>>())
        dictionary["editable"] = (object) source3;
label_15:
      writer.Write(this.Initializer.Initialize(this.Selector, nameof (Gantt<TTaskModel, TDependenciesModel>), (IDictionary<string, object>) dictionary));
    }

    private void ProcessDataSource(DataSource dataSource)
    {
      DataSourceType? type = dataSource.Type;
      DataSourceType dataSourceType = DataSourceType.Custom;
      if (type.GetValueOrDefault() == dataSourceType & type.HasValue && !(dataSource.CustomType == "aspnetmvc-ajax") || !dataSource.IsClientOperationMode)
        return;
      DataSourceRequest request = new DataSourceRequest();
      dataSource.Process(request, true);
    }

    public bool? AutoBind { get; set; }

    public double? ColumnResizeHandleWidth { get; set; }

    public bool? ColumnMenu { get; set; }

    public List<GanttColumn<TTaskModel, TDependenciesModel>> Columns { get; set; } = new List<GanttColumn<TTaskModel, TDependenciesModel>>();

    public GanttCurrentTimeMarkerSettings<TTaskModel, TDependenciesModel> CurrentTimeMarker { get; } = new GanttCurrentTimeMarkerSettings<TTaskModel, TDependenciesModel>();

    public DateTime? Date { get; set; }

    public GanttEditableSettings<TTaskModel, TDependenciesModel> Editable { get; } = new GanttEditableSettings<TTaskModel, TDependenciesModel>();

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

    public GanttMessagesSettings<TTaskModel, TDependenciesModel> Messages { get; } = new GanttMessagesSettings<TTaskModel, TDependenciesModel>();

    public GanttPdfSettings<TTaskModel, TDependenciesModel> Pdf { get; } = new GanttPdfSettings<TTaskModel, TDependenciesModel>();

    public GanttRangeSettings<TTaskModel, TDependenciesModel> Range { get; } = new GanttRangeSettings<TTaskModel, TDependenciesModel>();

    public bool? Resizable { get; set; }

    public bool? Selectable { get; set; }

    public bool? ShowPlannedTasks { get; set; }

    public bool? ShowWorkDays { get; set; }

    public bool? ShowWorkHours { get; set; }

    public string TaskTemplate { get; set; }

    public string TaskTemplateId { get; set; }

    public List<GanttToolbar<TTaskModel, TDependenciesModel>> Toolbar { get; set; } = new List<GanttToolbar<TTaskModel, TDependenciesModel>>();

    public GanttTooltipSettings<TTaskModel, TDependenciesModel> Tooltip { get; } = new GanttTooltipSettings<TTaskModel, TDependenciesModel>();

    public List<GanttView<TTaskModel, TDependenciesModel>> Views { get; set; } = new List<GanttView<TTaskModel, TDependenciesModel>>();

    public double? RowHeight { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = base.SerializeSettings();
      if (this.AutoBind.HasValue)
        dictionary["autoBind"] = (object) this.AutoBind;
      if (this.ColumnResizeHandleWidth.HasValue)
        dictionary["columnResizeHandleWidth"] = (object) this.ColumnResizeHandleWidth;
      if (this.ColumnMenu.HasValue)
        dictionary["columnMenu"] = (object) this.ColumnMenu;
      IEnumerable<Dictionary<string, object>> source1 = this.Columns.Select<GanttColumn<TTaskModel, TDependenciesModel>, Dictionary<string, object>>((Func<GanttColumn<TTaskModel, TDependenciesModel>, Dictionary<string, object>>) (i => i.Serialize()));
      if (source1.Any<Dictionary<string, object>>())
        dictionary["columns"] = (object) source1;
      Dictionary<string, object> source2 = this.CurrentTimeMarker.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
        dictionary["currentTimeMarker"] = (object) source2;
      else if (this.CurrentTimeMarker.Enabled.HasValue)
        dictionary["currentTimeMarker"] = (object) this.CurrentTimeMarker.Enabled;
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
      Dictionary<string, object> source3 = this.Messages.Serialize();
      if (source3.Any<KeyValuePair<string, object>>())
        dictionary["messages"] = (object) source3;
      Dictionary<string, object> source4 = this.Pdf.Serialize();
      if (source4.Any<KeyValuePair<string, object>>())
        dictionary["pdf"] = (object) source4;
      Dictionary<string, object> source5 = this.Range.Serialize();
      if (source5.Any<KeyValuePair<string, object>>())
        dictionary["range"] = (object) source5;
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
      IEnumerable<Dictionary<string, object>> source6 = this.Toolbar.Select<GanttToolbar<TTaskModel, TDependenciesModel>, Dictionary<string, object>>((Func<GanttToolbar<TTaskModel, TDependenciesModel>, Dictionary<string, object>>) (i => i.Serialize()));
      if (source6.Any<Dictionary<string, object>>())
        dictionary["toolbar"] = (object) source6;
      Dictionary<string, object> source7 = this.Tooltip.Serialize();
      if (source7.Any<KeyValuePair<string, object>>())
        dictionary["tooltip"] = (object) source7;
      IEnumerable<Dictionary<string, object>> source8 = this.Views.Select<GanttView<TTaskModel, TDependenciesModel>, Dictionary<string, object>>((Func<GanttView<TTaskModel, TDependenciesModel>, Dictionary<string, object>>) (i => i.Serialize()));
      if (source8.Any<Dictionary<string, object>>())
        dictionary["views"] = (object) source8;
      if (this.RowHeight.HasValue)
        dictionary["rowHeight"] = (object) this.RowHeight;
      return dictionary;
    }
  }
}
