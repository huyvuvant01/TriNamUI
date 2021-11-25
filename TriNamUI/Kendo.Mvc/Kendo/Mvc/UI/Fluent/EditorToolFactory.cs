// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.EditorToolFactory
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Kendo.Mvc.UI.Fluent
{
  public class EditorToolFactory
  {
    public EditorToolFactory(List<EditorTool> container) => this.Container = container;

    protected List<EditorTool> Container { get; private set; }

    [Obsolete("The FontColor tool is deprecated. Please use the ForeColor tool instead.")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public EditorToolFactory FontColor()
    {
      this.AddTool("foreColor");
      return this;
    }

    [Obsolete("The FontColor tool is deprecated. Please use the ForeColor tool instead.")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public EditorToolFactory FontColor(Action<EditorToolBuilder> configurator)
    {
      this.AddTool("foreColor", configurator);
      return this;
    }

    public EditorToolFactory CustomButton(Action<EditorToolBuilder> configurator)
    {
      this.AddTool((string) null, configurator);
      return this;
    }

    public EditorToolFactory CustomTemplate(Action<EditorToolBuilder> configurator)
    {
      this.AddTool((string) null, configurator);
      return this;
    }

    public EditorToolFactory FormatPainter()
    {
      this.AddTool("copyFormat");
      this.AddTool("applyFormat");
      return this;
    }

    public EditorToolFactory Import()
    {
      this.AddTool("import");
      return this;
    }

    public EditorToolFactory ExportAs()
    {
      this.AddDropDownTool("exportAs", new List<EditorToolItem>());
      return this;
    }

    public EditorToolFactory ExportAs(
      Action<EditorDropDownItemBuilder> configurator)
    {
      List<EditorToolItem> items = new List<EditorToolItem>();
      EditorDropDownItemBuilder dropDownItemBuilder = new EditorDropDownItemBuilder((IList<EditorToolItem>) items);
      configurator(dropDownItemBuilder);
      this.AddDropDownTool("exportAs", items);
      return this;
    }

    public Editor Editor { get; set; }

    public virtual EditorToolFactory Bold()
    {
      this.AddTool("bold");
      return this;
    }

    public virtual EditorToolFactory CleanFormatting()
    {
      this.AddTool("cleanFormatting");
      return this;
    }

    public virtual EditorToolFactory CreateLink()
    {
      this.AddTool("createLink");
      return this;
    }

    public virtual EditorToolFactory Indent()
    {
      this.AddTool("indent");
      return this;
    }

    public virtual EditorToolFactory InsertFile()
    {
      this.AddTool("insertFile");
      return this;
    }

    public virtual EditorToolFactory InsertImage()
    {
      this.AddTool("insertImage");
      return this;
    }

    public virtual EditorToolFactory InsertOrderedList()
    {
      this.AddTool("insertOrderedList");
      return this;
    }

    public virtual EditorToolFactory InsertUnorderedList()
    {
      this.AddTool("insertUnorderedList");
      return this;
    }

    public virtual EditorToolFactory InsertUpperRomanList()
    {
      this.AddTool("insertUpperRomanList");
      return this;
    }

    public virtual EditorToolFactory InsertLowerRomanList()
    {
      this.AddTool("insertLowerRomanList");
      return this;
    }

    public virtual EditorToolFactory Italic()
    {
      this.AddTool("italic");
      return this;
    }

    public virtual EditorToolFactory JustifyCenter()
    {
      this.AddTool("justifyCenter");
      return this;
    }

    public virtual EditorToolFactory JustifyFull()
    {
      this.AddTool("justifyFull");
      return this;
    }

    public virtual EditorToolFactory JustifyLeft()
    {
      this.AddTool("justifyLeft");
      return this;
    }

    public virtual EditorToolFactory JustifyRight()
    {
      this.AddTool("justifyRight");
      return this;
    }

    public virtual EditorToolFactory Outdent()
    {
      this.AddTool("outdent");
      return this;
    }

    public virtual EditorToolFactory Pdf()
    {
      this.AddTool("pdf");
      return this;
    }

    public virtual EditorToolFactory Print()
    {
      this.AddTool("print");
      return this;
    }

    public virtual EditorToolFactory Separator()
    {
      this.AddTool("separator");
      return this;
    }

    public virtual EditorToolFactory Strikethrough()
    {
      this.AddTool("strikethrough");
      return this;
    }

    public virtual EditorToolFactory SubScript()
    {
      this.AddTool("subscript");
      return this;
    }

    public virtual EditorToolFactory SuperScript()
    {
      this.AddTool("superscript");
      return this;
    }

    public virtual EditorToolFactory Underline()
    {
      this.AddTool("underline");
      return this;
    }

    public virtual EditorToolFactory Unlink()
    {
      this.AddTool("unlink");
      return this;
    }

    public virtual EditorToolFactory ViewHtml()
    {
      this.AddTool("viewHtml");
      return this;
    }

    public virtual EditorToolFactory BackColor()
    {
      this.AddTool("backColor");
      return this;
    }

    public EditorToolFactory BackColor(Action<EditorToolBuilder> configurator)
    {
      this.AddTool("backColor", configurator);
      return this;
    }

    public virtual EditorToolFactory ForeColor()
    {
      this.AddTool("foreColor");
      return this;
    }

    public EditorToolFactory ForeColor(Action<EditorToolBuilder> configurator)
    {
      this.AddTool("foreColor", configurator);
      return this;
    }

    public virtual EditorToolFactory FontName()
    {
      this.AddDropDownTool("fontName", new List<EditorToolItem>());
      return this;
    }

    public virtual EditorToolFactory FontName(
      Action<EditorToolItemFactory> configurator)
    {
      this.AddDropDownTool("fontName", this.CreateDropDownToolItems(configurator));
      return this;
    }

    public virtual EditorToolFactory FontSize()
    {
      this.AddDropDownTool("fontSize", new List<EditorToolItem>());
      return this;
    }

    public virtual EditorToolFactory FontSize(
      Action<EditorToolItemFactory> configurator)
    {
      this.AddDropDownTool("fontSize", this.CreateDropDownToolItems(configurator));
      return this;
    }

    public virtual EditorToolFactory Formatting()
    {
      this.AddDropDownTool("formatting", new List<EditorToolItem>());
      return this;
    }

    public virtual EditorToolFactory Formatting(
      Action<EditorToolItemFactory> configurator)
    {
      this.AddDropDownTool("formatting", this.CreateDropDownToolItems(configurator));
      return this;
    }

    public virtual EditorToolFactory Snippets()
    {
      this.AddDropDownTool("insertHtml", new List<EditorToolItem>());
      return this;
    }

    public virtual EditorToolFactory Snippets(
      Action<EditorToolItemFactory> configurator)
    {
      this.AddDropDownTool("insertHtml", this.CreateDropDownToolItems(configurator));
      return this;
    }

    public EditorToolFactory TableEditing()
    {
      this.AddTool("tableWizard");
      this.AddTool("createTable");
      this.AddTool("addColumnLeft");
      this.AddTool("addColumnRight");
      this.AddTool("addRowAbove");
      this.AddTool("addRowBelow");
      this.AddTool("deleteColumn");
      this.AddTool("deleteRow");
      this.AddTool("mergeCellsHorizontally");
      this.AddTool("mergeCellsVertically");
      this.AddTool("splitCellHorizontally");
      this.AddTool("splitCellVertically");
      this.AddTool("tableAlignLeft");
      this.AddTool("tableAlignCenter");
      this.AddTool("tableAlignRight");
      return this;
    }

    private void AddTool(string name) => this.Container.Add(new EditorTool()
    {
      Editor = this.Editor,
      Name = name
    });

    private void AddTool(string name, Action<EditorToolBuilder> configurator)
    {
      EditorTool container = new EditorTool()
      {
        Editor = this.Editor,
        Name = name
      };
      configurator(new EditorToolBuilder(container));
      this.Container.Add(container);
    }

    private void AddDropDownTool(string name, List<EditorToolItem> items) => this.Container.Add(new EditorTool()
    {
      Editor = this.Editor,
      Name = name,
      Items = items
    });

    private List<EditorToolItem> CreateDropDownToolItems(
      Action<EditorToolItemFactory> configurator)
    {
      List<EditorToolItem> container = new List<EditorToolItem>();
      configurator(new EditorToolItemFactory(container)
      {
        Editor = this.Editor
      });
      return container;
    }

    public virtual EditorToolFactory Clear()
    {
      this.Container.Clear();
      return this;
    }
  }
}
