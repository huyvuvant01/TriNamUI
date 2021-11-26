// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.FileManagerViewsListSettingsTagHelper
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
  [HtmlTargetElement("list", ParentTag = "views", TagStructure = TagStructure.WithoutEndTag)]
  [SuppressTagRendering]
  public class FileManagerViewsListSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (FileManagerViewsSettingsTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as FileManagerViewsSettingsTagHelper).List = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string EditTemplate { get; set; }

    public string EditTemplateId { get; set; }

    public string Template { get; set; }

    public string TemplateId { get; set; }

    public string AltTemplate { get; set; }

    public string AltTemplateId { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.EditTemplateId.HasValue())
        dictionary["editTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.EditTemplateId)
        };
      else if (this.EditTemplate.HasValue())
        dictionary["editTemplate"] = (object) this.EditTemplate;
      if (this.TemplateId.HasValue())
        dictionary["template"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.TemplateId)
        };
      else if (this.Template.HasValue())
        dictionary["template"] = (object) this.Template;
      if (this.AltTemplateId.HasValue())
        dictionary["altTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.AltTemplateId)
        };
      else if (this.AltTemplate.HasValue())
        dictionary["altTemplate"] = (object) this.AltTemplate;
      return dictionary;
    }
  }
}
