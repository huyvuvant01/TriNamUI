// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.TaskBoardColumnSettingsSettings`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class TaskBoardColumnSettingsSettings<TCard, TColumn>
    where TCard : class
    where TColumn : class
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public List<TaskBoardColumnSettingsSettingsButton<TCard, TColumn>> Buttons { get; set; } = new List<TaskBoardColumnSettingsSettingsButton<TCard, TColumn>>();

    public string DataStatusField { get; set; }

    public string DataTextField { get; set; }

    public string DataOrderField { get; set; }

    public string Width { get; set; }

    public string Template { get; set; }

    public string TemplateId { get; set; }

    public Kendo.Mvc.UI.TaskBoard<TCard, TColumn> TaskBoard { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      IEnumerable<Dictionary<string, object>> source = this.Buttons.Select<TaskBoardColumnSettingsSettingsButton<TCard, TColumn>, Dictionary<string, object>>((Func<TaskBoardColumnSettingsSettingsButton<TCard, TColumn>, Dictionary<string, object>>) (i => i.Serialize()));
      if (source.Any<Dictionary<string, object>>())
        dictionary["buttons"] = (object) source;
      string dataStatusField = this.DataStatusField;
      if ((dataStatusField != null ? (dataStatusField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataStatusField"] = (object) this.DataStatusField;
      string dataTextField = this.DataTextField;
      if ((dataTextField != null ? (dataTextField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataTextField"] = (object) this.DataTextField;
      string dataOrderField = this.DataOrderField;
      if ((dataOrderField != null ? (dataOrderField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataOrderField"] = (object) this.DataOrderField;
      string width = this.Width;
      if ((width != null ? (width.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["width"] = (object) this.Width;
      if (this.TemplateId.HasValue())
        dictionary["template"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.TaskBoard.IdPrefix, (object) this.TemplateId)
        };
      else if (this.Template.HasValue())
        dictionary["template"] = (object) this.Template;
      return dictionary;
    }
  }
}
