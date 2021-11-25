// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.TaskBoardEditableSettingsTagHelper
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
  [HtmlTargetElement("editable", ParentTag = "kendo-taskboard", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("buttons", new string[] {"kendo-form"})]
  [SuppressTagRendering]
  public class TaskBoardEditableSettingsTagHelper : TagHelperChildBase
  {
    [HtmlAttributeNotBound]
    public 
    #nullable disable
    Dictionary<string, object> Form { get; set; }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (TaskBoardTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as TaskBoardTagHelper).Editable = this;
    }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      if (this.Form != null)
        dictionary["form"] = (object) this.Form;
      return dictionary;
    }

    public bool? Enabled { get; set; }

    [HtmlAttributeNotBound]
    public TaskBoardEditableSettingsButtonsTagHelper Buttons { get; set; }

    public string HeaderTemplate { get; set; }

    public string HeaderTemplateId { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.Buttons != null)
      {
        IEnumerable<Dictionary<string, object>> source = this.Buttons.Select<TaskBoardEditableSettingsButtonTagHelper, Dictionary<string, object>>((Func<TaskBoardEditableSettingsButtonTagHelper, Dictionary<string, object>>) (i => i.Serialize()));
        if (source.Any<Dictionary<string, object>>())
          dictionary["buttons"] = (object) source;
      }
      if (this.HeaderTemplateId.HasValue())
        dictionary["headerTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.HeaderTemplateId)
        };
      else if (this.HeaderTemplate.HasValue())
        dictionary["headerTemplate"] = (object) this.HeaderTemplate;
      return dictionary;
    }
  }
}
