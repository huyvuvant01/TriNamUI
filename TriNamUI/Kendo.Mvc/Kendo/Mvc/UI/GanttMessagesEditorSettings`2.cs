// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.GanttMessagesEditorSettings`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class GanttMessagesEditorSettings<TTaskModel, TDependenciesModel>
    where TTaskModel : class, IGanttTask
    where TDependenciesModel : class, IGanttDependency
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string AssignButton { get; set; }

    public string EditorTitle { get; set; }

    public string End { get; set; }

    public string PercentComplete { get; set; }

    public string PlannedEnd { get; set; }

    public string PlannedStart { get; set; }

    public string Resources { get; set; }

    public string ResourcesEditorTitle { get; set; }

    public string ResourcesHeader { get; set; }

    public string Start { get; set; }

    public string Title { get; set; }

    public string UnitsHeader { get; set; }

    public Kendo.Mvc.UI.Gantt<TTaskModel, TDependenciesModel> Gantt { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string assignButton = this.AssignButton;
      if ((assignButton != null ? (assignButton.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["assignButton"] = (object) this.AssignButton;
      string editorTitle = this.EditorTitle;
      if ((editorTitle != null ? (editorTitle.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["editorTitle"] = (object) this.EditorTitle;
      string end = this.End;
      if ((end != null ? (end.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["end"] = (object) this.End;
      string percentComplete = this.PercentComplete;
      if ((percentComplete != null ? (percentComplete.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["percentComplete"] = (object) this.PercentComplete;
      string plannedEnd = this.PlannedEnd;
      if ((plannedEnd != null ? (plannedEnd.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["plannedEnd"] = (object) this.PlannedEnd;
      string plannedStart = this.PlannedStart;
      if ((plannedStart != null ? (plannedStart.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["plannedStart"] = (object) this.PlannedStart;
      string resources = this.Resources;
      if ((resources != null ? (resources.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["resources"] = (object) this.Resources;
      string resourcesEditorTitle = this.ResourcesEditorTitle;
      if ((resourcesEditorTitle != null ? (resourcesEditorTitle.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["resourcesEditorTitle"] = (object) this.ResourcesEditorTitle;
      string resourcesHeader = this.ResourcesHeader;
      if ((resourcesHeader != null ? (resourcesHeader.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["resourcesHeader"] = (object) this.ResourcesHeader;
      string start = this.Start;
      if ((start != null ? (start.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["start"] = (object) this.Start;
      string title = this.Title;
      if ((title != null ? (title.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["title"] = (object) this.Title;
      string unitsHeader = this.UnitsHeader;
      if ((unitsHeader != null ? (unitsHeader.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["unitsHeader"] = (object) this.UnitsHeader;
      return dictionary;
    }
  }
}
