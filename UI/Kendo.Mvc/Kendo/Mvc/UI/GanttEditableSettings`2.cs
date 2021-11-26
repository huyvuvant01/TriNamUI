// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.GanttEditableSettings`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class GanttEditableSettings<TTaskModel, TDependenciesModel>
    where TTaskModel : class, IGanttTask
    where TDependenciesModel : class, IGanttDependency
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public bool? Confirmation { get; set; }

    public bool? Create { get; set; }

    public bool? DependencyCreate { get; set; }

    public bool? DependencyDestroy { get; set; }

    public bool? DragPercentComplete { get; set; }

    public bool? Destroy { get; set; }

    public bool? Move { get; set; }

    public bool? PlannedTasks { get; set; }

    public bool? Reorder { get; set; }

    public bool? Resize { get; set; }

    public string Template { get; set; }

    public string TemplateId { get; set; }

    public bool? Update { get; set; }

    public bool? Enabled { get; set; }

    public Kendo.Mvc.UI.Gantt<TTaskModel, TDependenciesModel> Gantt { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.Confirmation.HasValue)
        dictionary["confirmation"] = (object) this.Confirmation;
      if (this.Create.HasValue)
        dictionary["create"] = (object) this.Create;
      if (this.DependencyCreate.HasValue)
        dictionary["dependencyCreate"] = (object) this.DependencyCreate;
      if (this.DependencyDestroy.HasValue)
        dictionary["dependencyDestroy"] = (object) this.DependencyDestroy;
      if (this.DragPercentComplete.HasValue)
        dictionary["dragPercentComplete"] = (object) this.DragPercentComplete;
      if (this.Destroy.HasValue)
        dictionary["destroy"] = (object) this.Destroy;
      if (this.Move.HasValue)
        dictionary["move"] = (object) this.Move;
      if (this.PlannedTasks.HasValue)
        dictionary["plannedTasks"] = (object) this.PlannedTasks;
      if (this.Reorder.HasValue)
        dictionary["reorder"] = (object) this.Reorder;
      if (this.Resize.HasValue)
        dictionary["resize"] = (object) this.Resize;
      if (this.TemplateId.HasValue())
        dictionary["template"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.Gantt.IdPrefix, (object) this.TemplateId)
        };
      else if (this.Template.HasValue())
        dictionary["template"] = (object) this.Template;
      if (this.Update.HasValue)
        dictionary["update"] = (object) this.Update;
      return dictionary;
    }
  }
}
