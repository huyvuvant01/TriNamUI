// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.TaskBoardPreviewPaneSettings`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class TaskBoardPreviewPaneSettings<TCard, TColumn>
    where TCard : class
    where TColumn : class
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public List<TaskBoardPreviewPaneSettingsButton<TCard, TColumn>> Buttons { get; set; } = new List<TaskBoardPreviewPaneSettingsButton<TCard, TColumn>>();

    public string Template { get; set; }

    public string TemplateId { get; set; }

    public string HeaderTemplate { get; set; }

    public string HeaderTemplateId { get; set; }

    public bool? Enabled { get; set; }

    public Kendo.Mvc.UI.TaskBoard<TCard, TColumn> TaskBoard { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      IEnumerable<Dictionary<string, object>> source = this.Buttons.Select<TaskBoardPreviewPaneSettingsButton<TCard, TColumn>, Dictionary<string, object>>((Func<TaskBoardPreviewPaneSettingsButton<TCard, TColumn>, Dictionary<string, object>>) (i => i.Serialize()));
      if (source.Any<Dictionary<string, object>>())
        dictionary["buttons"] = (object) source;
      if (this.TemplateId.HasValue())
        dictionary["template"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.TaskBoard.IdPrefix, (object) this.TemplateId)
        };
      else if (this.Template.HasValue())
        dictionary["template"] = (object) this.Template;
      if (this.HeaderTemplateId.HasValue())
        dictionary["headerTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.TaskBoard.IdPrefix, (object) this.HeaderTemplateId)
        };
      else if (this.HeaderTemplate.HasValue())
        dictionary["headerTemplate"] = (object) this.HeaderTemplate;
      return dictionary;
    }
  }
}
