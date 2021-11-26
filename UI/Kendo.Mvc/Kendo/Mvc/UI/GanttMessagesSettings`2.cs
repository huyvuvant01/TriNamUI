// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.GanttMessagesSettings`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class GanttMessagesSettings<TTaskModel, TDependenciesModel>
    where TTaskModel : class, IGanttTask
    where TDependenciesModel : class, IGanttDependency
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public GanttMessagesActionsSettings<TTaskModel, TDependenciesModel> Actions { get; } = new GanttMessagesActionsSettings<TTaskModel, TDependenciesModel>();

    public string Cancel { get; set; }

    public string DeleteDependencyConfirmation { get; set; }

    public string DeleteDependencyWindowTitle { get; set; }

    public string DeleteTaskConfirmation { get; set; }

    public string DeleteTaskWindowTitle { get; set; }

    public string Destroy { get; set; }

    public GanttMessagesEditorSettings<TTaskModel, TDependenciesModel> Editor { get; } = new GanttMessagesEditorSettings<TTaskModel, TDependenciesModel>();

    public GanttMessagesPlannedTasksSettings<TTaskModel, TDependenciesModel> PlannedTasks { get; } = new GanttMessagesPlannedTasksSettings<TTaskModel, TDependenciesModel>();

    public string Save { get; set; }

    public GanttMessagesViewsSettings<TTaskModel, TDependenciesModel> Views { get; } = new GanttMessagesViewsSettings<TTaskModel, TDependenciesModel>();

    public Kendo.Mvc.UI.Gantt<TTaskModel, TDependenciesModel> Gantt { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      Dictionary<string, object> source1 = this.Actions.Serialize();
      if (source1.Any<KeyValuePair<string, object>>())
        dictionary["actions"] = (object) source1;
      string cancel = this.Cancel;
      if ((cancel != null ? (cancel.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["cancel"] = (object) this.Cancel;
      string dependencyConfirmation = this.DeleteDependencyConfirmation;
      if ((dependencyConfirmation != null ? (dependencyConfirmation.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["deleteDependencyConfirmation"] = (object) this.DeleteDependencyConfirmation;
      string dependencyWindowTitle = this.DeleteDependencyWindowTitle;
      if ((dependencyWindowTitle != null ? (dependencyWindowTitle.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["deleteDependencyWindowTitle"] = (object) this.DeleteDependencyWindowTitle;
      string taskConfirmation = this.DeleteTaskConfirmation;
      if ((taskConfirmation != null ? (taskConfirmation.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["deleteTaskConfirmation"] = (object) this.DeleteTaskConfirmation;
      string deleteTaskWindowTitle = this.DeleteTaskWindowTitle;
      if ((deleteTaskWindowTitle != null ? (deleteTaskWindowTitle.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["deleteTaskWindowTitle"] = (object) this.DeleteTaskWindowTitle;
      string destroy = this.Destroy;
      if ((destroy != null ? (destroy.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["destroy"] = (object) this.Destroy;
      Dictionary<string, object> source2 = this.Editor.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
        dictionary["editor"] = (object) source2;
      Dictionary<string, object> source3 = this.PlannedTasks.Serialize();
      if (source3.Any<KeyValuePair<string, object>>())
        dictionary["plannedTasks"] = (object) source3;
      string save = this.Save;
      if ((save != null ? (save.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["save"] = (object) this.Save;
      Dictionary<string, object> source4 = this.Views.Serialize();
      if (source4.Any<KeyValuePair<string, object>>())
        dictionary["views"] = (object) source4;
      return dictionary;
    }
  }
}
