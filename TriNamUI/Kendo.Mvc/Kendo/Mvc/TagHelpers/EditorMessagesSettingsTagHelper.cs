// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.EditorMessagesSettingsTagHelper
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
  [HtmlTargetElement("messages", ParentTag = "kendo-editor", TagStructure = TagStructure.WithoutEndTag)]
  [HtmlTargetElement("messages", ParentTag = "richtexteditor-editor", TagStructure = TagStructure.WithoutEndTag)]
  [SuppressTagRendering]
  public class EditorMessagesSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (EditorTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as EditorTagHelper).Messages = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string AccessibilityTab { get; set; }

    public string AddColumnLeft { get; set; }

    public string AddColumnRight { get; set; }

    public string AddRowAbove { get; set; }

    public string AddRowBelow { get; set; }

    public string AlignCenter { get; set; }

    public string AlignCenterBottom { get; set; }

    public string AlignCenterMiddle { get; set; }

    public string AlignCenterTop { get; set; }

    public string AlignLeft { get; set; }

    public string AlignLeftBottom { get; set; }

    public string AlignLeftMiddle { get; set; }

    public string AlignLeftTop { get; set; }

    public string AlignRemove { get; set; }

    public string AlignRight { get; set; }

    public string AlignRightBottom { get; set; }

    public string AlignRightMiddle { get; set; }

    public string AlignRightTop { get; set; }

    public string TableAlignLeft { get; set; }

    public string TableAlignCenter { get; set; }

    public string TableAlignRight { get; set; }

    public string Alignment { get; set; }

    public string ApplyFormat { get; set; }

    public string AssociateCellsWithHeaders { get; set; }

    public string BackColor { get; set; }

    public string Background { get; set; }

    public string Bold { get; set; }

    public string Border { get; set; }

    public string Style { get; set; }

    public string Caption { get; set; }

    public string CellMargin { get; set; }

    public string CellPadding { get; set; }

    public string CellSpacing { get; set; }

    public string CellTab { get; set; }

    public string CleanFormatting { get; set; }

    public string CollapseBorders { get; set; }

    public string Columns { get; set; }

    public string CopyFormat { get; set; }

    public string CreateLink { get; set; }

    public string CreateTable { get; set; }

    public string CreateTableHint { get; set; }

    public string CssClass { get; set; }

    public string DeleteColumn { get; set; }

    public string DeleteRow { get; set; }

    public string DialogCancel { get; set; }

    public string DialogInsert { get; set; }

    public string DialogOk { get; set; }

    public string DialogUpdate { get; set; }

    public string EditAreaTitle { get; set; }

    public string FileTitle { get; set; }

    public string FileWebAddress { get; set; }

    public string FontName { get; set; }

    public string FontNameInherit { get; set; }

    public string FontSize { get; set; }

    public string FontSizeInherit { get; set; }

    public string ForeColor { get; set; }

    public string FormatBlock { get; set; }

    public string Formatting { get; set; }

    public string Height { get; set; }

    public string Id { get; set; }

    public string ImageAltText { get; set; }

    public string ImageHeight { get; set; }

    public string ImageWebAddress { get; set; }

    public string ImageWidth { get; set; }

    public string Indent { get; set; }

    public string InsertFile { get; set; }

    public string InsertHtml { get; set; }

    public string InsertImage { get; set; }

    public string InsertOrderedList { get; set; }

    public string InsertUnorderedList { get; set; }

    public string InsertUpperRomanList { get; set; }

    public string InsertLowerRomanList { get; set; }

    public string Italic { get; set; }

    public string OverflowAnchor { get; set; }

    public string JustifyCenter { get; set; }

    public string JustifyFull { get; set; }

    public string JustifyLeft { get; set; }

    public string JustifyRight { get; set; }

    public string LinkOpenInNewWindow { get; set; }

    public string LinkText { get; set; }

    public string LinkToolTip { get; set; }

    public string LinkWebAddress { get; set; }

    public string Outdent { get; set; }

    public string Print { get; set; }

    public string Rows { get; set; }

    public string SelectAllCells { get; set; }

    public string Strikethrough { get; set; }

    public string Subscript { get; set; }

    public string Summary { get; set; }

    public string Superscript { get; set; }

    public string TableTab { get; set; }

    public string TableWizard { get; set; }

    public string Underline { get; set; }

    public string Units { get; set; }

    public string Unlink { get; set; }

    public string ViewHtml { get; set; }

    public string Width { get; set; }

    public string WrapText { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string accessibilityTab = this.AccessibilityTab;
      if ((accessibilityTab != null ? (accessibilityTab.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["accessibilityTab"] = (object) this.AccessibilityTab;
      string addColumnLeft = this.AddColumnLeft;
      if ((addColumnLeft != null ? (addColumnLeft.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["addColumnLeft"] = (object) this.AddColumnLeft;
      string addColumnRight = this.AddColumnRight;
      if ((addColumnRight != null ? (addColumnRight.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["addColumnRight"] = (object) this.AddColumnRight;
      string addRowAbove = this.AddRowAbove;
      if ((addRowAbove != null ? (addRowAbove.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["addRowAbove"] = (object) this.AddRowAbove;
      string addRowBelow = this.AddRowBelow;
      if ((addRowBelow != null ? (addRowBelow.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["addRowBelow"] = (object) this.AddRowBelow;
      string alignCenter = this.AlignCenter;
      if ((alignCenter != null ? (alignCenter.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["alignCenter"] = (object) this.AlignCenter;
      string alignCenterBottom = this.AlignCenterBottom;
      if ((alignCenterBottom != null ? (alignCenterBottom.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["alignCenterBottom"] = (object) this.AlignCenterBottom;
      string alignCenterMiddle = this.AlignCenterMiddle;
      if ((alignCenterMiddle != null ? (alignCenterMiddle.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["alignCenterMiddle"] = (object) this.AlignCenterMiddle;
      string alignCenterTop = this.AlignCenterTop;
      if ((alignCenterTop != null ? (alignCenterTop.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["alignCenterTop"] = (object) this.AlignCenterTop;
      string alignLeft = this.AlignLeft;
      if ((alignLeft != null ? (alignLeft.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["alignLeft"] = (object) this.AlignLeft;
      string alignLeftBottom = this.AlignLeftBottom;
      if ((alignLeftBottom != null ? (alignLeftBottom.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["alignLeftBottom"] = (object) this.AlignLeftBottom;
      string alignLeftMiddle = this.AlignLeftMiddle;
      if ((alignLeftMiddle != null ? (alignLeftMiddle.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["alignLeftMiddle"] = (object) this.AlignLeftMiddle;
      string alignLeftTop = this.AlignLeftTop;
      if ((alignLeftTop != null ? (alignLeftTop.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["alignLeftTop"] = (object) this.AlignLeftTop;
      string alignRemove = this.AlignRemove;
      if ((alignRemove != null ? (alignRemove.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["alignRemove"] = (object) this.AlignRemove;
      string alignRight = this.AlignRight;
      if ((alignRight != null ? (alignRight.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["alignRight"] = (object) this.AlignRight;
      string alignRightBottom = this.AlignRightBottom;
      if ((alignRightBottom != null ? (alignRightBottom.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["alignRightBottom"] = (object) this.AlignRightBottom;
      string alignRightMiddle = this.AlignRightMiddle;
      if ((alignRightMiddle != null ? (alignRightMiddle.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["alignRightMiddle"] = (object) this.AlignRightMiddle;
      string alignRightTop = this.AlignRightTop;
      if ((alignRightTop != null ? (alignRightTop.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["alignRightTop"] = (object) this.AlignRightTop;
      string tableAlignLeft = this.TableAlignLeft;
      if ((tableAlignLeft != null ? (tableAlignLeft.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["tableAlignLeft"] = (object) this.TableAlignLeft;
      string tableAlignCenter = this.TableAlignCenter;
      if ((tableAlignCenter != null ? (tableAlignCenter.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["tableAlignCenter"] = (object) this.TableAlignCenter;
      string tableAlignRight = this.TableAlignRight;
      if ((tableAlignRight != null ? (tableAlignRight.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["tableAlignRight"] = (object) this.TableAlignRight;
      string alignment = this.Alignment;
      if ((alignment != null ? (alignment.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["alignment"] = (object) this.Alignment;
      string applyFormat = this.ApplyFormat;
      if ((applyFormat != null ? (applyFormat.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["applyFormat"] = (object) this.ApplyFormat;
      string cellsWithHeaders = this.AssociateCellsWithHeaders;
      if ((cellsWithHeaders != null ? (cellsWithHeaders.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["associateCellsWithHeaders"] = (object) this.AssociateCellsWithHeaders;
      string backColor = this.BackColor;
      if ((backColor != null ? (backColor.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["backColor"] = (object) this.BackColor;
      string background = this.Background;
      if ((background != null ? (background.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["background"] = (object) this.Background;
      string bold = this.Bold;
      if ((bold != null ? (bold.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["bold"] = (object) this.Bold;
      string border = this.Border;
      if ((border != null ? (border.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["border"] = (object) this.Border;
      string style = this.Style;
      if ((style != null ? (style.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["style"] = (object) this.Style;
      string caption = this.Caption;
      if ((caption != null ? (caption.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["caption"] = (object) this.Caption;
      string cellMargin = this.CellMargin;
      if ((cellMargin != null ? (cellMargin.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["cellMargin"] = (object) this.CellMargin;
      string cellPadding = this.CellPadding;
      if ((cellPadding != null ? (cellPadding.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["cellPadding"] = (object) this.CellPadding;
      string cellSpacing = this.CellSpacing;
      if ((cellSpacing != null ? (cellSpacing.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["cellSpacing"] = (object) this.CellSpacing;
      string cellTab = this.CellTab;
      if ((cellTab != null ? (cellTab.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["cellTab"] = (object) this.CellTab;
      string cleanFormatting = this.CleanFormatting;
      if ((cleanFormatting != null ? (cleanFormatting.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["cleanFormatting"] = (object) this.CleanFormatting;
      string collapseBorders = this.CollapseBorders;
      if ((collapseBorders != null ? (collapseBorders.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["collapseBorders"] = (object) this.CollapseBorders;
      string columns = this.Columns;
      if ((columns != null ? (columns.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["columns"] = (object) this.Columns;
      string copyFormat = this.CopyFormat;
      if ((copyFormat != null ? (copyFormat.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["copyFormat"] = (object) this.CopyFormat;
      string createLink = this.CreateLink;
      if ((createLink != null ? (createLink.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["createLink"] = (object) this.CreateLink;
      string createTable = this.CreateTable;
      if ((createTable != null ? (createTable.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["createTable"] = (object) this.CreateTable;
      string createTableHint = this.CreateTableHint;
      if ((createTableHint != null ? (createTableHint.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["createTableHint"] = (object) this.CreateTableHint;
      string cssClass = this.CssClass;
      if ((cssClass != null ? (cssClass.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["cssClass"] = (object) this.CssClass;
      string deleteColumn = this.DeleteColumn;
      if ((deleteColumn != null ? (deleteColumn.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["deleteColumn"] = (object) this.DeleteColumn;
      string deleteRow = this.DeleteRow;
      if ((deleteRow != null ? (deleteRow.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["deleteRow"] = (object) this.DeleteRow;
      string dialogCancel = this.DialogCancel;
      if ((dialogCancel != null ? (dialogCancel.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dialogCancel"] = (object) this.DialogCancel;
      string dialogInsert = this.DialogInsert;
      if ((dialogInsert != null ? (dialogInsert.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dialogInsert"] = (object) this.DialogInsert;
      string dialogOk = this.DialogOk;
      if ((dialogOk != null ? (dialogOk.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dialogOk"] = (object) this.DialogOk;
      string dialogUpdate = this.DialogUpdate;
      if ((dialogUpdate != null ? (dialogUpdate.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dialogUpdate"] = (object) this.DialogUpdate;
      string editAreaTitle = this.EditAreaTitle;
      if ((editAreaTitle != null ? (editAreaTitle.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["editAreaTitle"] = (object) this.EditAreaTitle;
      string fileTitle = this.FileTitle;
      if ((fileTitle != null ? (fileTitle.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["fileTitle"] = (object) this.FileTitle;
      string fileWebAddress = this.FileWebAddress;
      if ((fileWebAddress != null ? (fileWebAddress.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["fileWebAddress"] = (object) this.FileWebAddress;
      string fontName = this.FontName;
      if ((fontName != null ? (fontName.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["fontName"] = (object) this.FontName;
      string fontNameInherit = this.FontNameInherit;
      if ((fontNameInherit != null ? (fontNameInherit.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["fontNameInherit"] = (object) this.FontNameInherit;
      string fontSize = this.FontSize;
      if ((fontSize != null ? (fontSize.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["fontSize"] = (object) this.FontSize;
      string fontSizeInherit = this.FontSizeInherit;
      if ((fontSizeInherit != null ? (fontSizeInherit.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["fontSizeInherit"] = (object) this.FontSizeInherit;
      string foreColor = this.ForeColor;
      if ((foreColor != null ? (foreColor.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["foreColor"] = (object) this.ForeColor;
      string formatBlock = this.FormatBlock;
      if ((formatBlock != null ? (formatBlock.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["formatBlock"] = (object) this.FormatBlock;
      string formatting = this.Formatting;
      if ((formatting != null ? (formatting.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["formatting"] = (object) this.Formatting;
      string height = this.Height;
      if ((height != null ? (height.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["height"] = (object) this.Height;
      string id = this.Id;
      if ((id != null ? (id.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["id"] = (object) this.Id;
      string imageAltText = this.ImageAltText;
      if ((imageAltText != null ? (imageAltText.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["imageAltText"] = (object) this.ImageAltText;
      string imageHeight = this.ImageHeight;
      if ((imageHeight != null ? (imageHeight.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["imageHeight"] = (object) this.ImageHeight;
      string imageWebAddress = this.ImageWebAddress;
      if ((imageWebAddress != null ? (imageWebAddress.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["imageWebAddress"] = (object) this.ImageWebAddress;
      string imageWidth = this.ImageWidth;
      if ((imageWidth != null ? (imageWidth.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["imageWidth"] = (object) this.ImageWidth;
      string indent = this.Indent;
      if ((indent != null ? (indent.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["indent"] = (object) this.Indent;
      string insertFile = this.InsertFile;
      if ((insertFile != null ? (insertFile.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["insertFile"] = (object) this.InsertFile;
      string insertHtml = this.InsertHtml;
      if ((insertHtml != null ? (insertHtml.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["insertHtml"] = (object) this.InsertHtml;
      string insertImage = this.InsertImage;
      if ((insertImage != null ? (insertImage.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["insertImage"] = (object) this.InsertImage;
      string insertOrderedList = this.InsertOrderedList;
      if ((insertOrderedList != null ? (insertOrderedList.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["insertOrderedList"] = (object) this.InsertOrderedList;
      string insertUnorderedList = this.InsertUnorderedList;
      if ((insertUnorderedList != null ? (insertUnorderedList.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["insertUnorderedList"] = (object) this.InsertUnorderedList;
      string insertUpperRomanList = this.InsertUpperRomanList;
      if ((insertUpperRomanList != null ? (insertUpperRomanList.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["insertUpperRomanList"] = (object) this.InsertUpperRomanList;
      string insertLowerRomanList = this.InsertLowerRomanList;
      if ((insertLowerRomanList != null ? (insertLowerRomanList.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["insertLowerRomanList"] = (object) this.InsertLowerRomanList;
      string italic = this.Italic;
      if ((italic != null ? (italic.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["italic"] = (object) this.Italic;
      string overflowAnchor = this.OverflowAnchor;
      if ((overflowAnchor != null ? (overflowAnchor.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["overflowAnchor"] = (object) this.OverflowAnchor;
      string justifyCenter = this.JustifyCenter;
      if ((justifyCenter != null ? (justifyCenter.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["justifyCenter"] = (object) this.JustifyCenter;
      string justifyFull = this.JustifyFull;
      if ((justifyFull != null ? (justifyFull.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["justifyFull"] = (object) this.JustifyFull;
      string justifyLeft = this.JustifyLeft;
      if ((justifyLeft != null ? (justifyLeft.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["justifyLeft"] = (object) this.JustifyLeft;
      string justifyRight = this.JustifyRight;
      if ((justifyRight != null ? (justifyRight.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["justifyRight"] = (object) this.JustifyRight;
      string linkOpenInNewWindow = this.LinkOpenInNewWindow;
      if ((linkOpenInNewWindow != null ? (linkOpenInNewWindow.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["linkOpenInNewWindow"] = (object) this.LinkOpenInNewWindow;
      string linkText = this.LinkText;
      if ((linkText != null ? (linkText.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["linkText"] = (object) this.LinkText;
      string linkToolTip = this.LinkToolTip;
      if ((linkToolTip != null ? (linkToolTip.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["linkToolTip"] = (object) this.LinkToolTip;
      string linkWebAddress = this.LinkWebAddress;
      if ((linkWebAddress != null ? (linkWebAddress.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["linkWebAddress"] = (object) this.LinkWebAddress;
      string outdent = this.Outdent;
      if ((outdent != null ? (outdent.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["outdent"] = (object) this.Outdent;
      string print = this.Print;
      if ((print != null ? (print.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["print"] = (object) this.Print;
      string rows = this.Rows;
      if ((rows != null ? (rows.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["rows"] = (object) this.Rows;
      string selectAllCells = this.SelectAllCells;
      if ((selectAllCells != null ? (selectAllCells.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["selectAllCells"] = (object) this.SelectAllCells;
      string strikethrough = this.Strikethrough;
      if ((strikethrough != null ? (strikethrough.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["strikethrough"] = (object) this.Strikethrough;
      string subscript = this.Subscript;
      if ((subscript != null ? (subscript.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["subscript"] = (object) this.Subscript;
      string summary = this.Summary;
      if ((summary != null ? (summary.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["summary"] = (object) this.Summary;
      string superscript = this.Superscript;
      if ((superscript != null ? (superscript.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["superscript"] = (object) this.Superscript;
      string tableTab = this.TableTab;
      if ((tableTab != null ? (tableTab.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["tableTab"] = (object) this.TableTab;
      string tableWizard = this.TableWizard;
      if ((tableWizard != null ? (tableWizard.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["tableWizard"] = (object) this.TableWizard;
      string underline = this.Underline;
      if ((underline != null ? (underline.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["underline"] = (object) this.Underline;
      string units = this.Units;
      if ((units != null ? (units.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["units"] = (object) this.Units;
      string unlink = this.Unlink;
      if ((unlink != null ? (unlink.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["unlink"] = (object) this.Unlink;
      string viewHtml = this.ViewHtml;
      if ((viewHtml != null ? (viewHtml.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["viewHtml"] = (object) this.ViewHtml;
      string width = this.Width;
      if ((width != null ? (width.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["width"] = (object) this.Width;
      string wrapText = this.WrapText;
      if ((wrapText != null ? (wrapText.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["wrapText"] = (object) this.WrapText;
      return dictionary;
    }
  }
}
