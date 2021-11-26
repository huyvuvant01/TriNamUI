// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Scheduler`1
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
  public class Scheduler<T> : WidgetBase, IScheduler<T>, IScheduler where T : class, ISchedulerEvent
  {
    public Scheduler(ViewContext viewContext)
      : base(viewContext)
    {
      this.ToolbarCommands = (IList<SchedulerToolbarCommand>) new List<SchedulerToolbarCommand>();
      this.Editable = new SchedulerEditableSettings<T>()
      {
        PopUp = new Window(viewContext)
        {
          Modal = true,
          Draggable = true,
          Title = (object) Kendo.Mvc.Resources.Messages.Scheduler_Editor_EditorTitle
        },
        HtmlEncoder = this.HtmlEncoder
      };
      this.Group = new SchedulerGroupSettings();
      this.Views = (IList<SchedulerViewBase>) new List<SchedulerViewBase>();
      this.Resources = (IList<SchedulerResource<T>>) new List<SchedulerResource<T>>();
      this.DataSource = new DataSource(this.ModelMetadataProvider);
      this.DataSource.Type = new DataSourceType?(DataSourceType.Ajax);
      this.DataSource.Schema.Model = (ModelDescriptor) new SchedulerModelDescriptor(typeof (T), this.ModelMetadataProvider);
    }

    public SchedulerEditableSettings<T> Editable { get; set; }

    public DataSource DataSource { get; private set; }

    public IList<SchedulerToolbarCommand> ToolbarCommands { get; private set; }

    public IList<SchedulerViewBase> Views { get; private set; }

    public IList<SchedulerResource<T>> Resources { get; private set; }

    public SchedulerGroupSettings Group { get; set; }

    public int[] WorkDays { get; set; }

    protected override void WriteHtml(TextWriter writer)
    {
      this.Generator.GenerateTag("div", this.ViewContext, this.Id, this.Name, this.HtmlAttributes).WriteTo(writer, this.HtmlEncoder);
      base.WriteHtml(writer);
    }

    public override void WriteInitializationScript(TextWriter writer)
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      string str1 = "#";
      if (this.IsInClientTemplate)
      {
        string str2 = "\\" + str1;
      }
      if (!this.Editable.Enabled)
      {
        dictionary["editable"] = (object) false;
      }
      else
      {
        this.Editable.InitializeEditor(this.ViewContext, this.ModelMetadataProvider);
        IDictionary<string, object> json = this.Editable.ToJson();
        if (json.Count > 0)
          dictionary["editable"] = (object) json;
      }
      if (this.Views.Count > 0)
        dictionary["views"] = (object) ((IEnumerable<JsonObject>) this.Views).ToJson();
      if (this.Resources.Count > 0)
        dictionary["resources"] = (object) ((IEnumerable<JsonObject>) this.Resources).ToJson();
      IDictionary<string, object> json1 = this.Group.ToJson();
      if (json1.Count > 0)
        dictionary["group"] = (object) json1;
      DataSourceType? type = this.DataSource.Type;
      DataSourceType dataSourceType = DataSourceType.Custom;
      if (!(type.GetValueOrDefault() == dataSourceType & type.HasValue) || this.DataSource.CustomType == "aspnetmvc-ajax")
      {
        this.DataSource.Transport.StringifyDates = true;
        if (this.DataSource.IsClientOperationMode)
          this.ProcessDataSource();
      }
      if (this.ToolbarCommands.Count > 0)
        dictionary["toolbar"] = (object) ((IEnumerable<JsonObject>) this.ToolbarCommands).ToJson();
      MobileMode? mobile1 = this.Mobile;
      MobileMode mobileMode1 = MobileMode.Disabled;
      if (!(mobile1.GetValueOrDefault() == mobileMode1 & mobile1.HasValue))
      {
        MobileMode? mobile2 = this.Mobile;
        MobileMode mobileMode2 = MobileMode.Auto;
        dictionary["mobile"] = !(mobile2.GetValueOrDefault() == mobileMode2 & mobile2.HasValue) ? (object) this.Mobile.ToString().ToLowerInvariant() : (object) true;
      }
      if (this.WorkDays != null)
        dictionary["workDays"] = (object) this.WorkDays;
      Dictionary<string, object> json2 = (Dictionary<string, object>) this.DataSource.ToJson();
      dictionary["dataSource"] = (object) json2;
      writer.Write(this.Initializer.Initialize(this.Selector, nameof (Scheduler<T>), (IDictionary<string, object>) dictionary));
    }

    private void ProcessDataSource() => this.DataSource.Process(new DataSourceRequest(), true);

    public string AllDayEventTemplate { get; set; }

    public string AllDayEventTemplateId { get; set; }

    public bool? AllDaySlot { get; set; }

    public bool? AutoBind { get; set; }

    public SchedulerCurrentTimeMarkerSettings<T> CurrentTimeMarker { get; } = new SchedulerCurrentTimeMarkerSettings<T>();

    public DateTime? Date { get; set; }

    public string DateHeaderTemplate { get; set; }

    public string DateHeaderTemplateId { get; set; }

    public DateTime? EndTime { get; set; }

    public string EventTemplate { get; set; }

    public string EventTemplateId { get; set; }

    public SchedulerFooterSettings<T> Footer { get; } = new SchedulerFooterSettings<T>();

    public string GroupHeaderTemplate { get; set; }

    public string GroupHeaderTemplateId { get; set; }

    public double? Height { get; set; }

    public int? MajorTick { get; set; }

    public string MajorTimeHeaderTemplate { get; set; }

    public string MajorTimeHeaderTemplateId { get; set; }

    public DateTime? Max { get; set; }

    public SchedulerMessagesSettings<T> Messages { get; } = new SchedulerMessagesSettings<T>();

    public DateTime? Min { get; set; }

    public int? MinorTickCount { get; set; }

    public string MinorTimeHeaderTemplate { get; set; }

    public string MinorTimeHeaderTemplateId { get; set; }

    public SchedulerPdfSettings<T> Pdf { get; } = new SchedulerPdfSettings<T>();

    public bool? Selectable { get; set; }

    public bool? ShowWorkHours { get; set; }

    public bool? Snap { get; set; }

    public DateTime? StartTime { get; set; }

    public string Timezone { get; set; }

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
      Dictionary<string, object> source1 = this.CurrentTimeMarker.Serialize();
      if (source1.Any<KeyValuePair<string, object>>())
      {
        dictionary["currentTimeMarker"] = (object) source1;
      }
      else
      {
        nullable1 = this.CurrentTimeMarker.Enabled;
        if (nullable1.HasValue)
          dictionary["currentTimeMarker"] = (object) this.CurrentTimeMarker.Enabled;
      }
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
      Dictionary<string, object> source2 = this.Footer.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
      {
        dictionary["footer"] = (object) source2;
      }
      else
      {
        nullable1 = this.Footer.Enabled;
        if (nullable1.HasValue)
          dictionary["footer"] = (object) this.Footer.Enabled;
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
      Dictionary<string, object> source3 = this.Messages.Serialize();
      if (source3.Any<KeyValuePair<string, object>>())
        dictionary["messages"] = (object) source3;
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
      Dictionary<string, object> source4 = this.Pdf.Serialize();
      if (source4.Any<KeyValuePair<string, object>>())
        dictionary["pdf"] = (object) source4;
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
