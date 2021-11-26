// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Upload
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;

namespace Kendo.Mvc.UI
{
  public class Upload : WidgetBase
  {
    public bool? Enabled { get; set; }

    public UploadMessagesSettings Messages { get; } = new UploadMessagesSettings();

    public Upload(ViewContext viewContext)
      : base(viewContext)
    {
      this.Async.ViewContext = this.ViewContext;
      this.Async.UrlGenerator = this.UrlGenerator;
      this.Async.UrlDecoder = (Func<string, string>) (url => !this.IsSelfInitialized ? url : WebUtility.UrlDecode(url));
    }

    protected override void WriteHtml(TextWriter writer)
    {
      TagBuilder tag = this.Generator.GenerateTag("input", this.ViewContext, this.Id, this.Name, this.HtmlAttributes);
      tag.MergeAttribute("type", "file");
      tag.TagRenderMode = TagRenderMode.SelfClosing;
      tag.WriteTo(writer, this.HtmlEncoder);
      base.WriteHtml(writer);
    }

    public override void WriteInitializationScript(TextWriter writer)
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      Dictionary<string, object> source = this.Messages.Serialize();
      if (source.Any<KeyValuePair<string, object>>())
        dictionary["localization"] = (object) source;
      if (this.Enabled.HasValue)
        dictionary["enabled"] = (object) this.Enabled;
      writer.Write(this.Initializer.Initialize(this.Selector, nameof (Upload), (IDictionary<string, object>) dictionary));
    }

    public UploadAsyncSettings Async { get; } = new UploadAsyncSettings();

    public bool? Directory { get; set; }

    public bool? DirectoryDrop { get; set; }

    public string DropZone { get; set; }

    public List<UploadFile> Files { get; set; } = new List<UploadFile>();

    public bool? Multiple { get; set; }

    public bool? ShowFileList { get; set; }

    public string Template { get; set; }

    public string TemplateId { get; set; }

    public UploadValidationSettings Validation { get; } = new UploadValidationSettings();

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = base.SerializeSettings();
      Dictionary<string, object> source1 = this.Async.Serialize();
      if (source1.Any<KeyValuePair<string, object>>())
        dictionary["async"] = (object) source1;
      bool? nullable = this.Directory;
      if (nullable.HasValue)
        dictionary["directory"] = (object) this.Directory;
      nullable = this.DirectoryDrop;
      if (nullable.HasValue)
        dictionary["directoryDrop"] = (object) this.DirectoryDrop;
      string dropZone = this.DropZone;
      if ((dropZone != null ? (dropZone.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dropZone"] = (object) this.DropZone;
      IEnumerable<Dictionary<string, object>> source2 = this.Files.Select<UploadFile, Dictionary<string, object>>((Func<UploadFile, Dictionary<string, object>>) (i => i.Serialize()));
      if (source2.Any<Dictionary<string, object>>())
        dictionary["files"] = (object) source2;
      nullable = this.Multiple;
      if (nullable.HasValue)
        dictionary["multiple"] = (object) this.Multiple;
      nullable = this.ShowFileList;
      if (nullable.HasValue)
        dictionary["showFileList"] = (object) this.ShowFileList;
      if (this.TemplateId.HasValue())
        dictionary["template"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.TemplateId)
        };
      else if (this.Template.HasValue())
        dictionary["template"] = (object) this.Template;
      Dictionary<string, object> source3 = this.Validation.Serialize();
      if (source3.Any<KeyValuePair<string, object>>())
        dictionary["validation"] = (object) source3;
      return dictionary;
    }
  }
}
