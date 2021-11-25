// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.SpreadsheetGroupedToolFactory
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class SpreadsheetGroupedToolFactory : IHideObjectMembers
  {
    private readonly SpreadsheetTool group;

    public SpreadsheetGroupedToolFactory(SpreadsheetTool group) => this.group = group;

    public SpreadsheetGroupedToolFactory Open() => this.Tool("open");

    public SpreadsheetGroupedToolFactory ExportAs() => this.Tool("exportAs");

    public SpreadsheetGroupedToolFactory Cut() => this.Tool("cut");

    public SpreadsheetGroupedToolFactory Copy() => this.Tool("copy");

    public SpreadsheetGroupedToolFactory Paste() => this.Tool("paste");

    public SpreadsheetGroupedToolFactory Bold() => this.Tool("bold");

    public SpreadsheetGroupedToolFactory Italic() => this.Tool("italic");

    public SpreadsheetGroupedToolFactory Underline() => this.Tool("underline");

    public SpreadsheetGroupedToolFactory BackgroundColor() => this.Tool("backgroundColor");

    public SpreadsheetGroupedToolFactory TextColor() => this.Tool("textColor");

    public SpreadsheetGroupedToolFactory Borders() => this.Tool("borders");

    public SpreadsheetGroupedToolFactory FontSize() => this.Tool("fontSize");

    public SpreadsheetGroupedToolFactory FontFamily() => this.Tool("fontFamily");

    public SpreadsheetGroupedToolFactory Alignment() => this.Tool("alignment");

    public SpreadsheetGroupedToolFactory TextWrap() => this.Tool("textWrap");

    public SpreadsheetGroupedToolFactory FormatDecreaseDecimal() => this.Tool("formatDecreaseDecimal");

    public SpreadsheetGroupedToolFactory FormatIncreaseDecimal() => this.Tool("formatIncreaseDecimal");

    public SpreadsheetGroupedToolFactory Format() => this.Tool("format");

    public SpreadsheetGroupedToolFactory Merge() => this.Tool("merge");

    public SpreadsheetGroupedToolFactory Freeze() => this.Tool("freeze");

    public SpreadsheetGroupedToolFactory Filter() => this.Tool("filter");

    public SpreadsheetGroupedToolFactory Hyperlink() => this.Tool("hyperlink");

    public SpreadsheetGroupedToolFactory InsertComment() => this.Tool("insertComment");

    public SpreadsheetGroupedToolFactory InsertImage() => this.Tool("insertImage");

    public SpreadsheetGroupedToolFactory ToggleGridLines() => this.Tool("toggleGridlines");

    public SpreadsheetGroupedToolFactory AddColumnLeft() => this.Tool("addColumnLeft");

    public SpreadsheetGroupedToolFactory AddColumnRight() => this.Tool("addColumnRight");

    public SpreadsheetGroupedToolFactory AddRowBelow() => this.Tool("addRowBelow");

    public SpreadsheetGroupedToolFactory AddRowAbove() => this.Tool("addRowAbove");

    public SpreadsheetGroupedToolFactory DeleteColumn() => this.Tool("deleteColumn");

    public SpreadsheetGroupedToolFactory DeleteRow() => this.Tool("deleteRow");

    public SpreadsheetGroupedToolFactory Sort() => this.Tool("sort");

    public SpreadsheetGroupedToolFactory Validation() => this.Tool("validation");

    private SpreadsheetGroupedToolFactory Tool(string text)
    {
      this.group.Tools.Add(new SpreadsheetTool(text));
      return this;
    }

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
