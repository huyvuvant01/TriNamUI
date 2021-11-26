// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.EditorImportSettingsTagHelper
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
  [HtmlTargetElement("import", ParentTag = "kendo-editor", TagStructure = TagStructure.NormalOrSelfClosing)]
  [HtmlTargetElement("import", ParentTag = "richtexteditor-editor", TagStructure = TagStructure.NormalOrSelfClosing)]
  [SuppressTagRendering]
  public class EditorImportSettingsTagHelper : TagHelperChildBase
  {
    public 
    #nullable disable
    string OnComplete { get; set; }

    public string OnError { get; set; }

    public string OnProgress { get; set; }

    public string OnSelect { get; set; }

    public string OnSuccess { get; set; }

    public string Proxy { get; set; }

    public string[] AllowedExtensions { get; set; }

    public double? MaxFileSize { get; set; }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (EditorTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as EditorTagHelper).Import = this;
    }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.Proxy != null)
        dictionary["proxyURL"] = (object) this.Proxy;
      if (this.AllowedExtensions != null)
        dictionary["allowedExtensions"] = (object) this.AllowedExtensions;
      if (this.MaxFileSize.HasValue)
        dictionary["maxFileSize"] = (object) this.MaxFileSize;
      string onComplete = this.OnComplete;
      if ((onComplete != null ? (onComplete.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["complete"] = (object) this.CreateHandler(this.OnComplete);
      string onError = this.OnError;
      if ((onError != null ? (onError.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["error"] = (object) this.CreateHandler(this.OnError);
      string onProgress = this.OnProgress;
      if ((onProgress != null ? (onProgress.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["progress"] = (object) this.CreateHandler(this.OnProgress);
      string onSelect = this.OnSelect;
      if ((onSelect != null ? (onSelect.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["select"] = (object) this.CreateHandler(this.OnSelect);
      string onSuccess = this.OnSuccess;
      if ((onSuccess != null ? (onSuccess.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["success"] = (object) this.CreateHandler(this.OnSuccess);
      return dictionary;
    }
  }
}
