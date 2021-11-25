// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.ImageEditorTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("kendo-imageeditor")]
  [RestrictChildren("save-as", new string[] {"toolbar", "imageeditor-messages"})]
  public class ImageEditorTagHelper : TagHelperBase
  {
    public ImageEditorTagHelper(
    #nullable disable
    IKendoHtmlGenerator generator)
      : base(generator)
    {
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      ImageEditorTagHelper imageEditorTagHelper = this;
      context.Items[(object) imageEditorTagHelper.GetType()] = (object) imageEditorTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      // ISSUE: reference to a compiler-generated method
      await imageEditorTagHelper.\u003C\u003En__0(context, output);
    }

    protected override void WriteHtml(TagHelperOutput output)
    {
      this.GenerateId(output);
      TagBuilder tag = this.Generator.GenerateTag("div", this.ViewContext, this.Id, this.Name, (IDictionary<string, object>) new Dictionary<string, object>());
      output.TagName = "div";
      output.MergeAttributes(tag);
    }

    protected override string GetInitializationScript() => this.Initializer.Initialize(this.Selector, "ImageEditor", (IDictionary<string, object>) this.SerializeSettings());

    public string OnImageLoaded { get; set; }

    public string OnImageRendered { get; set; }

    public string OnExecute { get; set; }

    public string OnError { get; set; }

    protected override Dictionary<string, object> SerializeEvents()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string onImageLoaded = this.OnImageLoaded;
      if ((onImageLoaded != null ? (onImageLoaded.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["imageLoaded"] = (object) this.CreateHandler(this.OnImageLoaded);
      string onImageRendered = this.OnImageRendered;
      if ((onImageRendered != null ? (onImageRendered.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["imageRendered"] = (object) this.CreateHandler(this.OnImageRendered);
      string onExecute = this.OnExecute;
      if ((onExecute != null ? (onExecute.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["execute"] = (object) this.CreateHandler(this.OnExecute);
      string onError = this.OnError;
      if ((onError != null ? (onError.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["error"] = (object) this.CreateHandler(this.OnError);
      return dictionary;
    }

    public double? Width { get; set; }

    public double? Height { get; set; }

    public string ImageUrl { get; set; }

    [HtmlAttributeNotBound]
    public ImageEditorSaveAsSettingsTagHelper SaveAs { get; set; }

    [HtmlAttributeNotBound]
    public ImageEditorToolbarSettingsTagHelper Toolbar { get; set; }

    [HtmlAttributeNotBound]
    public ImageEditorMessagesSettingsTagHelper Messages { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = base.SerializeSettings();
      if (this.Width.HasValue)
        dictionary["width"] = (object) this.Width;
      if (this.Height.HasValue)
        dictionary["height"] = (object) this.Height;
      string imageUrl = this.ImageUrl;
      if ((imageUrl != null ? (imageUrl.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["imageUrl"] = (object) this.ImageUrl;
      if (this.SaveAs != null)
      {
        Dictionary<string, object> source = this.SaveAs.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["saveAs"] = (object) source;
      }
      if (this.Toolbar != null)
      {
        Dictionary<string, object> source = this.Toolbar.Serialize();
        if (source.Any<KeyValuePair<string, object>>() && (!this.Toolbar.Enabled.HasValue || this.Toolbar.Enabled.Value))
          dictionary["toolbar"] = (object) source;
        else if (this.Toolbar.Enabled.HasValue && !this.Toolbar.Enabled.Value)
          dictionary["toolbar"] = (object) this.Toolbar.Enabled;
      }
      if (this.Messages != null)
      {
        Dictionary<string, object> source = this.Messages.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["messages"] = (object) source;
      }
      return dictionary;
    }
  }
}
