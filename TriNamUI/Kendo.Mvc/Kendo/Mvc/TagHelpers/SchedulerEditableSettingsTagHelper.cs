// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.SchedulerEditableSettingsTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("editable", ParentTag = "kendo-scheduler", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("editable-window", new string[] {})]
  [SuppressTagRendering]
  public class SchedulerEditableSettingsTagHelper : TagHelperChildBase
  {
    public 
    #nullable disable
    SchedulerEditableWindowTagHelper Window { get; set; }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (SchedulerTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as SchedulerTagHelper).Editable = this;
    }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary1 = this.SerializeSettings();
      if (this.Window != null)
      {
        Dictionary<string, object> dictionary2 = this.Window.Serialize();
        dictionary1["window"] = (object) dictionary2;
      }
      return dictionary1;
    }

    public bool? Enabled { get; set; }

    public bool? Confirmation { get; set; }

    public bool? Create { get; set; }

    public bool? Destroy { get; set; }

    public string EditRecurringMode { get; set; }

    public bool? Move { get; set; }

    public bool? Resize { get; set; }

    public string Template { get; set; }

    public string TemplateId { get; set; }

    public bool? Update { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.Confirmation.HasValue)
        dictionary["confirmation"] = (object) this.Confirmation;
      if (this.Create.HasValue)
        dictionary["create"] = (object) this.Create;
      if (this.Destroy.HasValue)
        dictionary["destroy"] = (object) this.Destroy;
      string editRecurringMode = this.EditRecurringMode;
      if ((editRecurringMode != null ? (editRecurringMode.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["editRecurringMode"] = (object) this.EditRecurringMode;
      if (this.Move.HasValue)
        dictionary["move"] = (object) this.Move;
      if (this.Resize.HasValue)
        dictionary["resize"] = (object) this.Resize;
      if (this.TemplateId.HasValue())
        dictionary["template"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.TemplateId)
        };
      else if (this.Template.HasValue())
        dictionary["template"] = (object) this.Template;
      if (this.Update.HasValue)
        dictionary["update"] = (object) this.Update;
      return dictionary;
    }
  }
}
