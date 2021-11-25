// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.EditorTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("kendo-editor")]
  [HtmlTargetElement("richtexteditor-editor", ParentTag = "form-item")]
  [RestrictChildren("content", new string[] {"deserialization", "immutables", "messages", "paste-cleanup", "pdf", "resizable", "serialization", "tools", "image-browser", "file-browser", "import", "export-as"})]
  public class EditorTagHelper : TagHelperBase, IKendoFormEditor
  {
    public EditorTagHelper(
    #nullable disable
    IKendoHtmlGenerator generator)
      : base(generator)
    {
    }

    public ModelExpression For { get; set; }

    [HtmlAttributeName("stylesheets")]
    public string[] StyleSheets { get; set; }

    [HtmlAttributeNotBound]
    public EditorImportSettingsTagHelper Import { get; set; }

    [HtmlAttributeNotBound]
    public EditorExportAsSettingsTagHelper ExportAs { get; set; }

    [HtmlAttributeNotBound]
    public bool IsNested { get; set; }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      EditorTagHelper editorTagHelper = this;
      context.Items[(object) editorTagHelper.GetType()] = (object) editorTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      // ISSUE: explicit non-virtual call
      if (__nonvirtual (editorTagHelper.TryAddToForm(context)))
        output.SuppressOutput();
      // ISSUE: reference to a compiler-generated method
      await editorTagHelper.\u003C\u003En__0(context, output);
    }

    protected override void WriteHtml(TagHelperOutput output)
    {
      if (this.For != null)
      {
        this.Name = this.For.Name;
        if (this.Value == null && this.For.Model != null)
        {
          if (this.For.Model.GetType().IsPredefinedType())
            this.Value = Convert.ToString(this.For.Model);
          else if (this.For.Model.GetType().IsEnumType())
            this.Value = Convert.ToString(Convert.ToInt32(this.For.Model));
        }
      }
      if (this.IsNested && string.IsNullOrEmpty(this.Name))
        this.Name = Guid.NewGuid().ToString();
      this.GenerateId(output);
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      TagBuilder tagBuilder;
      if (this.Tag == "div")
      {
        tagBuilder = this.Generator.GenerateTag(this.Tag, this.ViewContext, this.Id, this.Name, (IDictionary<string, object>) dictionary);
      }
      else
      {
        this.Tag = "textarea";
        tagBuilder = this.Generator.GenerateTextarea(this.ViewContext, (ModelExplorer) null, this.Id, this.Name, (IDictionary<string, object>) dictionary);
      }
      output.TagName = this.Tag;
      output.MergeAttributes(tagBuilder);
    }

    protected override string GetInitializationScript() => this.Initializer.Initialize(this.Selector, "Editor", (IDictionary<string, object>) this.Serialize());

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      if (this.Value != null)
        dictionary["value"] = (object) this.Value;
      if (this.StyleSheets != null)
        dictionary["stylesheets"] = (object) this.StyleSheets;
      if (this.Import != null)
        dictionary["import"] = (object) this.Import.Serialize();
      if (this.ExportAs != null)
        dictionary["exportAs"] = (object) this.ExportAs.Serialize();
      if (this.Tools != null)
      {
        IEnumerable<Dictionary<string, object>> source = this.Tools.Select<EditorToolTagHelper, Dictionary<string, object>>((Func<EditorToolTagHelper, Dictionary<string, object>>) (i => i.Serialize()));
        if (source.Any<Dictionary<string, object>>())
          dictionary["tools"] = (object) source;
      }
      return dictionary;
    }

    public bool TryAddToForm(TagHelperContext context)
    {
      foreach (KeyValuePair<object, object> keyValuePair in context.Items.Reverse<KeyValuePair<object, object>>())
      {
        if (keyValuePair.Value is FormItemTagHelper formItemTagHelper1)
        {
          this.IsNested = true;
          formItemTagHelper1.EditorOptions = this.Serialize();
          formItemTagHelper1.Editor = "Editor";
          return true;
        }
      }
      return false;
    }

    public string OnChange { get; set; }

    public string OnExecute { get; set; }

    public string OnKeydown { get; set; }

    public string OnKeyup { get; set; }

    public string OnPaste { get; set; }

    public string OnPdfExport { get; set; }

    public string OnSelect { get; set; }

    protected override Dictionary<string, object> SerializeEvents()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string onChange = this.OnChange;
      if ((onChange != null ? (onChange.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["change"] = (object) this.CreateHandler(this.OnChange);
      string onExecute = this.OnExecute;
      if ((onExecute != null ? (onExecute.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["execute"] = (object) this.CreateHandler(this.OnExecute);
      string onKeydown = this.OnKeydown;
      if ((onKeydown != null ? (onKeydown.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["keydown"] = (object) this.CreateHandler(this.OnKeydown);
      string onKeyup = this.OnKeyup;
      if ((onKeyup != null ? (onKeyup.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["keyup"] = (object) this.CreateHandler(this.OnKeyup);
      string onPaste = this.OnPaste;
      if ((onPaste != null ? (onPaste.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["paste"] = (object) this.CreateHandler(this.OnPaste);
      string onPdfExport = this.OnPdfExport;
      if ((onPdfExport != null ? (onPdfExport.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["pdfExport"] = (object) this.CreateHandler(this.OnPdfExport);
      string onSelect = this.OnSelect;
      if ((onSelect != null ? (onSelect.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["select"] = (object) this.CreateHandler(this.OnSelect);
      return dictionary;
    }

    [HtmlAttributeNotBound]
    public EditorDeserializationSettingsTagHelper Deserialization { get; set; }

    public string Domain { get; set; }

    public bool? Encoded { get; set; }

    [HtmlAttributeNotBound]
    public EditorImmutablesSettingsTagHelper Immutables { get; set; }

    [HtmlAttributeNotBound]
    public EditorMessagesSettingsTagHelper Messages { get; set; }

    [HtmlAttributeNotBound]
    public EditorPasteCleanupSettingsTagHelper PasteCleanup { get; set; }

    [HtmlAttributeNotBound]
    public EditorPdfSettingsTagHelper Pdf { get; set; }

    public string Placeholder { get; set; }

    [HtmlAttributeNotBound]
    public EditorResizableSettingsTagHelper Resizable { get; set; }

    [HtmlAttributeNotBound]
    public EditorSerializationSettingsTagHelper Serialization { get; set; }

    [HtmlAttributeNotBound]
    public EditorToolsTagHelper Tools { get; set; }

    [HtmlAttributeNotBound]
    public EditorImageBrowserSettingsTagHelper ImageBrowser { get; set; }

    [HtmlAttributeNotBound]
    public EditorFileBrowserSettingsTagHelper FileBrowser { get; set; }

    public string Tag { get; set; }

    public string Value { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = base.SerializeSettings();
      if (this.Deserialization != null)
      {
        Dictionary<string, object> source = this.Deserialization.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["deserialization"] = (object) source;
      }
      string domain = this.Domain;
      if ((domain != null ? (domain.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["domain"] = (object) this.Domain;
      if (this.Encoded.HasValue)
        dictionary["encoded"] = (object) this.Encoded;
      if (this.Immutables != null)
      {
        Dictionary<string, object> source = this.Immutables.Serialize();
        if (source.Any<KeyValuePair<string, object>>() && (!this.Immutables.Enabled.HasValue || this.Immutables.Enabled.Value))
          dictionary["immutables"] = (object) source;
        else if (this.Immutables.Enabled.HasValue && this.Immutables.Enabled.Value)
          dictionary["immutables"] = (object) this.Immutables.Enabled;
      }
      if (this.Messages != null)
      {
        Dictionary<string, object> source = this.Messages.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["messages"] = (object) source;
      }
      if (this.PasteCleanup != null)
      {
        Dictionary<string, object> source = this.PasteCleanup.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["pasteCleanup"] = (object) source;
      }
      if (this.Pdf != null)
      {
        Dictionary<string, object> source = this.Pdf.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["pdf"] = (object) source;
      }
      string placeholder = this.Placeholder;
      if ((placeholder != null ? (placeholder.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["placeholder"] = (object) this.Placeholder;
      if (this.Resizable != null)
      {
        Dictionary<string, object> source = this.Resizable.Serialize();
        if (source.Any<KeyValuePair<string, object>>() && (!this.Resizable.Enabled.HasValue || this.Resizable.Enabled.Value))
          dictionary["resizable"] = (object) source;
        else if (this.Resizable.Enabled.HasValue && this.Resizable.Enabled.Value)
          dictionary["resizable"] = (object) this.Resizable.Enabled;
      }
      if (this.Serialization != null)
      {
        Dictionary<string, object> source = this.Serialization.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["serialization"] = (object) source;
      }
      if (this.ImageBrowser != null)
      {
        Dictionary<string, object> source = this.ImageBrowser.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["imageBrowser"] = (object) source;
      }
      if (this.FileBrowser != null)
      {
        Dictionary<string, object> source = this.FileBrowser.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["fileBrowser"] = (object) source;
      }
      return dictionary;
    }
  }
}
