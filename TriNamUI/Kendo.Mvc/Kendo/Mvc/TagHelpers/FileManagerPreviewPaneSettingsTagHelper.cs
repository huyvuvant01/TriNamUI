// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.FileManagerPreviewPaneSettingsTagHelper
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
  [HtmlTargetElement("preview-pane", ParentTag = "kendo-filemanager", TagStructure = TagStructure.WithoutEndTag)]
  [SuppressTagRendering]
  public class FileManagerPreviewPaneSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (FileManagerTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as FileManagerTagHelper).PreviewPane = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string[] MetaFields { get; set; }

    public string NoFileTemplate { get; set; }

    public string NoFileTemplateId { get; set; }

    public string SingleFileTemplate { get; set; }

    public string SingleFileTemplateId { get; set; }

    public string MultipleFilesTemplate { get; set; }

    public string MultipleFilesTemplateId { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string[] metaFields = this.MetaFields;
      if ((metaFields != null ? (((IEnumerable<string>) metaFields).Any<string>() ? 1 : 0) : 0) != 0)
        dictionary["metaFields"] = (object) this.MetaFields;
      if (this.NoFileTemplateId.HasValue())
        dictionary["noFileTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.NoFileTemplateId)
        };
      else if (this.NoFileTemplate.HasValue())
        dictionary["noFileTemplate"] = (object) this.NoFileTemplate;
      if (this.SingleFileTemplateId.HasValue())
        dictionary["singleFileTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.SingleFileTemplateId)
        };
      else if (this.SingleFileTemplate.HasValue())
        dictionary["singleFileTemplate"] = (object) this.SingleFileTemplate;
      if (this.MultipleFilesTemplateId.HasValue())
        dictionary["multipleFilesTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.MultipleFilesTemplateId)
        };
      else if (this.MultipleFilesTemplate.HasValue())
        dictionary["multipleFilesTemplate"] = (object) this.MultipleFilesTemplate;
      return dictionary;
    }
  }
}
