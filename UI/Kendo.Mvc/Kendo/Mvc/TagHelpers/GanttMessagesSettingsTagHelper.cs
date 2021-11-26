// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.GanttMessagesSettingsTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("messages", ParentTag = "kendo-gantt", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("actions", new string[] {"editor", "views"})]
  [SuppressTagRendering]
  public class GanttMessagesSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (GanttTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as GanttTagHelper).Messages = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    [HtmlAttributeNotBound]
    public GanttMessagesActionsSettingsTagHelper Actions { get; set; }

    public string Cancel { get; set; }

    public string DeleteDependencyConfirmation { get; set; }

    public string DeleteDependencyWindowTitle { get; set; }

    public string DeleteTaskConfirmation { get; set; }

    public string DeleteTaskWindowTitle { get; set; }

    public string Destroy { get; set; }

    [HtmlAttributeNotBound]
    public GanttMessagesEditorSettingsTagHelper Editor { get; set; }

    [HtmlAttributeNotBound]
    public GanttMessagesPlannedTasksSettingsTagHelper PlannedTasks { get; set; }

    public string Save { get; set; }

    [HtmlAttributeNotBound]
    public GanttMessagesViewsSettingsTagHelper Views { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.Actions != null)
      {
        Dictionary<string, object> source = this.Actions.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["actions"] = (object) source;
      }
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
      if (this.Editor != null)
      {
        Dictionary<string, object> source = this.Editor.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["editor"] = (object) source;
      }
      if (this.PlannedTasks != null)
      {
        Dictionary<string, object> source = this.PlannedTasks.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["plannedTasks"] = (object) source;
      }
      string save = this.Save;
      if ((save != null ? (save.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["save"] = (object) this.Save;
      if (this.Views != null)
      {
        Dictionary<string, object> source = this.Views.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["views"] = (object) source;
      }
      return dictionary;
    }
  }
}
