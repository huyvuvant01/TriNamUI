// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.TaskBoardColumnSettingsSettingsTagHelper
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
  [HtmlTargetElement("column-settings", ParentTag = "kendo-taskboard", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("buttons", new string[] {})]
  [SuppressTagRendering]
  public class TaskBoardColumnSettingsSettingsTagHelper : TagHelperChildBase
  {
    [HtmlAttributeName("datastatusfield")]
    public 
    #nullable disable
    string DataStatusField { get; set; }

    [HtmlAttributeName("datatextfield")]
    public string DataTextField { get; set; }

    [HtmlAttributeName("dataorderfield")]
    public string DataOrderField { get; set; }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (TaskBoardTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as TaskBoardTagHelper).ColumnSettings = this;
    }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      string dataStatusField = this.DataStatusField;
      if ((dataStatusField != null ? (dataStatusField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataStatusField"] = (object) this.DataStatusField;
      string dataTextField = this.DataTextField;
      if ((dataTextField != null ? (dataTextField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataTextField"] = (object) this.DataTextField;
      string dataOrderField = this.DataOrderField;
      if ((dataOrderField != null ? (dataOrderField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataOrderField"] = (object) this.DataOrderField;
      return dictionary;
    }

    [HtmlAttributeNotBound]
    public TaskBoardColumnSettingsSettingsButtonsTagHelper Buttons { get; set; }

    public string Width { get; set; }

    public string Template { get; set; }

    public string TemplateId { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.Buttons != null)
      {
        IEnumerable<Dictionary<string, object>> source = this.Buttons.Select<TaskBoardColumnSettingsSettingsButtonTagHelper, Dictionary<string, object>>((Func<TaskBoardColumnSettingsSettingsButtonTagHelper, Dictionary<string, object>>) (i => i.Serialize()));
        if (source.Any<Dictionary<string, object>>())
          dictionary["buttons"] = (object) source;
      }
      string width = this.Width;
      if ((width != null ? (width.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["width"] = (object) this.Width;
      if (this.TemplateId.HasValue())
        dictionary["template"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.TemplateId)
        };
      else if (this.Template.HasValue())
        dictionary["template"] = (object) this.Template;
      return dictionary;
    }
  }
}
