// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.FileManagerUploadSettingsTagHelper
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
  [HtmlTargetElement("upload", ParentTag = "kendo-filemanager", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("async", new string[] {"localization", "validation"})]
  [SuppressTagRendering]
  public class FileManagerUploadSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (FileManagerTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as FileManagerTagHelper).Upload = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Cancel { get; set; }

    public string Clear { get; set; }

    public string Complete { get; set; }

    public string Error { get; set; }

    public string Pause { get; set; }

    public string Progress { get; set; }

    public string Resume { get; set; }

    public string Remove { get; set; }

    public string Select { get; set; }

    public string Success { get; set; }

    public string Upload { get; set; }

    [HtmlAttributeNotBound]
    public FileManagerUploadAsyncSettingsTagHelper Async { get; set; }

    public bool? Directory { get; set; }

    [HtmlAttributeNotBound]
    public FileManagerUploadLocalizationSettingsTagHelper Localization { get; set; }

    public bool? Multiple { get; set; }

    public bool? ShowFileList { get; set; }

    [HtmlAttributeNotBound]
    public FileManagerUploadValidationSettingsTagHelper Validation { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string cancel = this.Cancel;
      if ((cancel != null ? (cancel.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["cancel"] = (object) this.CreateHandler(this.Cancel);
      string clear = this.Clear;
      if ((clear != null ? (clear.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["clear"] = (object) this.CreateHandler(this.Clear);
      string complete = this.Complete;
      if ((complete != null ? (complete.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["complete"] = (object) this.CreateHandler(this.Complete);
      string error = this.Error;
      if ((error != null ? (error.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["error"] = (object) this.CreateHandler(this.Error);
      string pause = this.Pause;
      if ((pause != null ? (pause.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["pause"] = (object) this.CreateHandler(this.Pause);
      string progress = this.Progress;
      if ((progress != null ? (progress.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["progress"] = (object) this.CreateHandler(this.Progress);
      string resume = this.Resume;
      if ((resume != null ? (resume.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["resume"] = (object) this.CreateHandler(this.Resume);
      string remove = this.Remove;
      if ((remove != null ? (remove.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["remove"] = (object) this.CreateHandler(this.Remove);
      string select = this.Select;
      if ((select != null ? (select.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["select"] = (object) this.CreateHandler(this.Select);
      string success = this.Success;
      if ((success != null ? (success.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["success"] = (object) this.CreateHandler(this.Success);
      string upload = this.Upload;
      if ((upload != null ? (upload.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["upload"] = (object) this.CreateHandler(this.Upload);
      if (this.Async != null)
      {
        Dictionary<string, object> source = this.Async.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["async"] = (object) source;
      }
      bool? nullable = this.Directory;
      if (nullable.HasValue)
        dictionary["directory"] = (object) this.Directory;
      if (this.Localization != null)
      {
        Dictionary<string, object> source = this.Localization.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["localization"] = (object) source;
      }
      nullable = this.Multiple;
      if (nullable.HasValue)
        dictionary["multiple"] = (object) this.Multiple;
      nullable = this.ShowFileList;
      if (nullable.HasValue)
        dictionary["showFileList"] = (object) this.ShowFileList;
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
