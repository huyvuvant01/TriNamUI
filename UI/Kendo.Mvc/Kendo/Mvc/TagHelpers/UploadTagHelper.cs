// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.UploadTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("kendo-upload")]
  [RestrictChildren("async", new string[] {"files", "localization", "validation"})]
  [OutputElementHint("div")]
  public class UploadTagHelper : TagHelperBase
  {
    public UploadTagHelper(
    #nullable disable
    IKendoHtmlGenerator generator)
      : base(generator)
    {
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      UploadTagHelper uploadTagHelper = this;
      context.Items[(object) uploadTagHelper.GetType()] = (object) uploadTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      // ISSUE: reference to a compiler-generated method
      await uploadTagHelper.\u003C\u003En__0(context, output);
    }

    protected override void WriteHtml(TagHelperOutput output)
    {
      this.GenerateId(output);
      TagBuilder tag = this.Generator.GenerateTag("input", this.ViewContext, this.Id, this.Name, (IDictionary<string, object>) new Dictionary<string, object>()
      {
        {
          "type",
          (object) "file"
        }
      });
      output.TagName = "input";
      output.TagMode = TagMode.SelfClosing;
      output.MergeAttributes(tag);
    }

    protected override string GetInitializationScript() => this.Initializer.Initialize(this.Selector, "Upload", (IDictionary<string, object>) this.SerializeSettings());

    public string OnCancel { get; set; }

    public string OnClear { get; set; }

    public string OnComplete { get; set; }

    public string OnError { get; set; }

    public string OnPause { get; set; }

    public string OnProgress { get; set; }

    public string OnResume { get; set; }

    public string OnRemove { get; set; }

    public string OnSelect { get; set; }

    public string OnSuccess { get; set; }

    public string OnUpload { get; set; }

    protected override Dictionary<string, object> SerializeEvents()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string onCancel = this.OnCancel;
      if ((onCancel != null ? (onCancel.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["cancel"] = (object) this.CreateHandler(this.OnCancel);
      string onClear = this.OnClear;
      if ((onClear != null ? (onClear.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["clear"] = (object) this.CreateHandler(this.OnClear);
      string onComplete = this.OnComplete;
      if ((onComplete != null ? (onComplete.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["complete"] = (object) this.CreateHandler(this.OnComplete);
      string onError = this.OnError;
      if ((onError != null ? (onError.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["error"] = (object) this.CreateHandler(this.OnError);
      string onPause = this.OnPause;
      if ((onPause != null ? (onPause.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["pause"] = (object) this.CreateHandler(this.OnPause);
      string onProgress = this.OnProgress;
      if ((onProgress != null ? (onProgress.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["progress"] = (object) this.CreateHandler(this.OnProgress);
      string onResume = this.OnResume;
      if ((onResume != null ? (onResume.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["resume"] = (object) this.CreateHandler(this.OnResume);
      string onRemove = this.OnRemove;
      if ((onRemove != null ? (onRemove.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["remove"] = (object) this.CreateHandler(this.OnRemove);
      string onSelect = this.OnSelect;
      if ((onSelect != null ? (onSelect.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["select"] = (object) this.CreateHandler(this.OnSelect);
      string onSuccess = this.OnSuccess;
      if ((onSuccess != null ? (onSuccess.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["success"] = (object) this.CreateHandler(this.OnSuccess);
      string onUpload = this.OnUpload;
      if ((onUpload != null ? (onUpload.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["upload"] = (object) this.CreateHandler(this.OnUpload);
      return dictionary;
    }

    [HtmlAttributeNotBound]
    public UploadAsyncSettingsTagHelper Async { get; set; }

    public bool? Directory { get; set; }

    public bool? DirectoryDrop { get; set; }

    public string DropZone { get; set; }

    public bool? Enabled { get; set; }

    [HtmlAttributeNotBound]
    public UploadFilesTagHelper Files { get; set; }

    [HtmlAttributeNotBound]
    public UploadLocalizationSettingsTagHelper Localization { get; set; }

    public bool? Multiple { get; set; }

    public bool? ShowFileList { get; set; }

    public string Template { get; set; }

    public string TemplateId { get; set; }

    [HtmlAttributeNotBound]
    public UploadValidationSettingsTagHelper Validation { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = base.SerializeSettings();
      if (this.Async != null)
      {
        Dictionary<string, object> source = this.Async.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["async"] = (object) source;
      }
      if (this.Directory.HasValue)
        dictionary["directory"] = (object) this.Directory;
      if (this.DirectoryDrop.HasValue)
        dictionary["directoryDrop"] = (object) this.DirectoryDrop;
      string dropZone = this.DropZone;
      if ((dropZone != null ? (dropZone.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dropZone"] = (object) this.DropZone;
      if (this.Enabled.HasValue)
        dictionary["enabled"] = (object) this.Enabled;
      if (this.Files != null)
      {
        IEnumerable<Dictionary<string, object>> source = this.Files.Select<UploadFileTagHelper, Dictionary<string, object>>((Func<UploadFileTagHelper, Dictionary<string, object>>) (i => i.Serialize()));
        if (source.Any<Dictionary<string, object>>())
          dictionary["files"] = (object) source;
      }
      if (this.Localization != null)
      {
        Dictionary<string, object> source = this.Localization.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["localization"] = (object) source;
      }
      if (this.Multiple.HasValue)
        dictionary["multiple"] = (object) this.Multiple;
      if (this.ShowFileList.HasValue)
        dictionary["showFileList"] = (object) this.ShowFileList;
      if (this.TemplateId.HasValue())
        dictionary["template"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.TemplateId)
        };
      else if (this.Template.HasValue())
        dictionary["template"] = (object) this.Template;
      if (this.Validation != null)
      {
        Dictionary<string, object> source = this.Validation.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["validation"] = (object) source;
      }
      return dictionary;
    }
  }
}
