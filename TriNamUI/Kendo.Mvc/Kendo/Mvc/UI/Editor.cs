// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Editor
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI.Fluent;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class Editor : WidgetBase, IWidget, IHtmlAttributesContainer, IFormEditor
  {
    public Editor(ViewContext viewContext)
      : base(viewContext)
    {
      this.Tag = "textarea";
      this.ExportAsSettings = new EditorExportAsSettings(this);
      this.ImportSettings = new EditorImportSettings(this);
      new EditorToolFactory(this.Tools).Formatting().Bold().Italic().Underline().JustifyLeft().JustifyCenter().JustifyRight().FormatPainter().InsertUnorderedList().InsertOrderedList().Indent().Outdent().CreateLink().Unlink().InsertImage().TableEditing();
    }

    public List<string> StyleSheets { get; set; } = new List<string>();

    public Func<object, object> ValueHandler { get; set; }

    public Action ValueAction { get; set; }

    public EditorExportAsSettings ExportAsSettings { get; set; }

    public EditorImportSettings ImportSettings { get; set; }

    protected override void WriteHtml(TextWriter writer)
    {
      this.GenerateTag(writer).WriteTo(writer, this.HtmlEncoder);
      base.WriteHtml(writer);
    }

    protected TagBuilder GenerateTag(TextWriter writer)
    {
      bool flag = this.Tag != "textarea";
      TagBuilder tagBuilder;
      if (flag)
      {
        tagBuilder = this.Generator.GenerateTag(this.Tag, this.ViewContext, this.Id, this.Name, this.HtmlAttributes);
        tagBuilder.MergeAttribute("contentEditable", "true");
      }
      else
      {
        tagBuilder = this.Generator.GenerateTextarea(this.ViewContext, (ModelExplorer) null, this.Id, this.Name, this.HtmlAttributes);
        tagBuilder.MergeAttribute("cols", 20.ToString());
        tagBuilder.MergeAttribute("rows", 5.ToString());
      }
      tagBuilder.TagRenderMode = TagRenderMode.StartTag;
      tagBuilder.WriteTo(writer, this.HtmlEncoder);
      string str = this.GetValue<string>(this.Value);
      if (str.HasValue())
      {
        if (flag)
          writer.Write(str);
        else
          writer.Write(this.HtmlEncoder.Encode(str));
      }
      else if (this.ValueAction != null)
        this.ValueAction();
      else if (this.ValueHandler != null)
      {
        if (flag)
          writer.WriteContent<object>(this.ValueHandler, this.HtmlEncoder);
        else
          writer.WriteContent<object>(this.ValueHandler, this.HtmlEncoder, htmlEncode: true);
      }
      tagBuilder.TagRenderMode = TagRenderMode.EndTag;
      return tagBuilder;
    }

    public IDictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      if (this.StyleSheets.Count > 0)
        dictionary["stylesheets"] = (object) this.StyleSheets;
      IDictionary<string, object> json1 = this.ExportAsSettings.ToJson();
      if (json1.Any<KeyValuePair<string, object>>())
        dictionary["exportAs"] = (object) json1;
      IDictionary<string, object> json2 = this.ImportSettings.ToJson();
      if (json2.Any<KeyValuePair<string, object>>())
        dictionary["import"] = (object) json2;
      dictionary["tools"] = (object) this.Tools.Select<EditorTool, Dictionary<string, object>>((Func<EditorTool, Dictionary<string, object>>) (i => i.Serialize()));
      return (IDictionary<string, object>) dictionary;
    }

    public override void WriteInitializationScript(TextWriter writer) => writer.Write(this.Initializer.Initialize(this.Selector, nameof (Editor), this.Serialize()));

    public EditorDeserializationSettings Deserialization { get; } = new EditorDeserializationSettings();

    public string Domain { get; set; }

    public bool? Encoded { get; set; }

    public EditorImmutablesSettings Immutables { get; } = new EditorImmutablesSettings();

    public EditorMessagesSettings Messages { get; } = new EditorMessagesSettings();

    public EditorPasteCleanupSettings PasteCleanup { get; } = new EditorPasteCleanupSettings();

    public EditorPdfSettings Pdf { get; } = new EditorPdfSettings();

    public string Placeholder { get; set; }

    public EditorResizableSettings Resizable { get; } = new EditorResizableSettings();

    public EditorSerializationSettings Serialization { get; } = new EditorSerializationSettings();

    public List<EditorTool> Tools { get; set; } = new List<EditorTool>();

    public EditorImageBrowserSettings ImageBrowser { get; } = new EditorImageBrowserSettings();

    public EditorFileBrowserSettings FileBrowser { get; } = new EditorFileBrowserSettings();

    public string Tag { get; set; }

    public string Value { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = base.SerializeSettings();
      Dictionary<string, object> source1 = this.Deserialization.Serialize();
      if (source1.Any<KeyValuePair<string, object>>())
        dictionary["deserialization"] = (object) source1;
      string domain = this.Domain;
      if ((domain != null ? (domain.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["domain"] = (object) this.Domain;
      bool? nullable = this.Encoded;
      if (nullable.HasValue)
        dictionary["encoded"] = (object) this.Encoded;
      Dictionary<string, object> source2 = this.Immutables.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
      {
        dictionary["immutables"] = (object) source2;
      }
      else
      {
        nullable = this.Immutables.Enabled;
        if (nullable.HasValue)
          dictionary["immutables"] = (object) this.Immutables.Enabled;
      }
      Dictionary<string, object> source3 = this.Messages.Serialize();
      if (source3.Any<KeyValuePair<string, object>>())
        dictionary["messages"] = (object) source3;
      Dictionary<string, object> source4 = this.PasteCleanup.Serialize();
      if (source4.Any<KeyValuePair<string, object>>())
        dictionary["pasteCleanup"] = (object) source4;
      Dictionary<string, object> source5 = this.Pdf.Serialize();
      if (source5.Any<KeyValuePair<string, object>>())
        dictionary["pdf"] = (object) source5;
      string placeholder = this.Placeholder;
      if ((placeholder != null ? (placeholder.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["placeholder"] = (object) this.Placeholder;
      Dictionary<string, object> source6 = this.Resizable.Serialize();
      if (source6.Any<KeyValuePair<string, object>>())
      {
        dictionary["resizable"] = (object) source6;
      }
      else
      {
        nullable = this.Resizable.Enabled;
        if (nullable.HasValue)
          dictionary["resizable"] = (object) this.Resizable.Enabled;
      }
      Dictionary<string, object> source7 = this.Serialization.Serialize();
      if (source7.Any<KeyValuePair<string, object>>())
        dictionary["serialization"] = (object) source7;
      Dictionary<string, object> source8 = this.ImageBrowser.Serialize();
      if (source8.Any<KeyValuePair<string, object>>())
        dictionary["imageBrowser"] = (object) source8;
      Dictionary<string, object> source9 = this.FileBrowser.Serialize();
      if (source9.Any<KeyValuePair<string, object>>())
        dictionary["fileBrowser"] = (object) source9;
      return dictionary;
    }
  }
}
