// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.UploadValidationSettingsTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("validation", ParentTag = "kendo-upload", TagStructure = TagStructure.WithoutEndTag)]
  [SuppressTagRendering]
  public class UploadValidationSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (UploadTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as UploadTagHelper).Validation = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string[] AllowedExtensions { get; set; }

    public double? MaxFileSize { get; set; }

    public double? MinFileSize { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string[] allowedExtensions = this.AllowedExtensions;
      if ((allowedExtensions != null ? (((IEnumerable<string>) allowedExtensions).Any<string>() ? 1 : 0) : 0) != 0)
        dictionary["allowedExtensions"] = (object) this.AllowedExtensions;
      double? nullable = this.MaxFileSize;
      if (nullable.HasValue)
        dictionary["maxFileSize"] = (object) this.MaxFileSize;
      nullable = this.MinFileSize;
      if (nullable.HasValue)
        dictionary["minFileSize"] = (object) this.MinFileSize;
      return dictionary;
    }
  }
}
