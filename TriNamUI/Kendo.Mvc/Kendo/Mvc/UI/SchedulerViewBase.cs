// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.SchedulerViewBase
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public abstract class SchedulerViewBase : JsonObject, ISchedulerView
  {
    protected SchedulerViewBase(SchedulerViewType type, IScheduler scheduler)
    {
      this.Type = type;
      this.Group = new SchedulerGroupSettings();
      this.Scheduler = scheduler;
    }

    public IScheduler Scheduler { get; protected set; }

    public string Title { get; set; }

    public SchedulerViewType Type { get; set; }

    public SchedulerViewEditableSettings Editable { get; set; }

    public SchedulerGroupSettings Group { get; set; }

    public string EventTemplate { get; set; }

    public string EventTemplateId { get; set; }

    public string SelectedDateFormat { get; set; }

    public string SelectedShortDateFormat { get; set; }

    public bool Selected { get; set; }

    protected override void Serialize(IDictionary<string, object> json)
    {
      string str1 = "#";
      if (!string.IsNullOrEmpty(this.Title))
        json["title"] = (object) this.Title;
      string str2 = this.Type.ToString();
      json["type"] = (object) (char.ToLowerInvariant(str2[0]).ToString() + str2.Substring(1));
      if (this.Editable != null)
      {
        if (!this.Editable.Enabled)
          json["editable"] = (object) false;
        else if (this.Editable.ToJson().Count > 0)
          json["editable"] = (object) this.Editable.ToJson();
      }
      if (!string.IsNullOrEmpty(this.EventTemplate))
        json["eventTemplate"] = (object) this.EventTemplate;
      if (!string.IsNullOrEmpty(this.EventTemplateId))
        json["eventTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("kendo.template(jQuery('{0}{1}').html())", (object) str1, (object) this.EventTemplateId)
        };
      if (!string.IsNullOrEmpty(this.SelectedDateFormat))
        json["selectedDateFormat"] = (object) this.SelectedDateFormat;
      if (!string.IsNullOrEmpty(this.SelectedShortDateFormat))
        json["selectedShortDateFormat"] = (object) this.SelectedShortDateFormat;
      if (this.Selected)
        json["selected"] = (object) this.Selected;
      IDictionary<string, object> json1 = this.Group.ToJson();
      if (json1.Count <= 0)
        return;
      json["group"] = (object) json1;
    }
  }
}
