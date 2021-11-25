// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.SpreadsheetToolFactory
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class SpreadsheetToolFactory : IHideObjectMembers
  {
    private readonly SpreadsheetToolTab tab;

    public SpreadsheetToolFactory(SpreadsheetToolTab tab) => this.tab = tab;

    public SpreadsheetToolFactory Clear()
    {
      this.tab.Tools.Clear();
      return this;
    }

    public SpreadsheetToolFactory Group(
      Action<SpreadsheetGroupedToolFactory> configurator)
    {
      SpreadsheetTool group = new SpreadsheetTool();
      this.tab.Tools.Add(group);
      configurator(new SpreadsheetGroupedToolFactory(group));
      return this;
    }

    public SpreadsheetToolFactory Open() => this.Tool("open");

    public SpreadsheetToolFactory ExportAs() => this.Tool("exportAs");

    public SpreadsheetToolFactory Cut() => this.Tool("cut");

    public SpreadsheetToolFactory Copy() => this.Tool("copy");

    public SpreadsheetToolFactory Paste() => this.Tool("paste");

    public SpreadsheetToolFactory Bold() => this.Tool("bold");

    public SpreadsheetToolFactory Italic() => this.Tool("italic");

    public SpreadsheetToolFactory Underline() => this.Tool("underline");

    public SpreadsheetToolFactory BackgroundColor() => this.Tool("backgroundColor");

    public SpreadsheetToolFactory TextColor() => this.Tool("textColor");

    public SpreadsheetToolFactory Borders() => this.Tool("borders");

    public SpreadsheetToolFactory FontSize() => this.Tool("fontSize");

    public SpreadsheetToolFactory FontFamily() => this.Tool("fontFamily");

    public SpreadsheetToolFactory Alignment() => this.Tool("alignment");

    public SpreadsheetToolFactory TextWrap() => this.Tool("textWrap");

    public SpreadsheetToolFactory FormatDecreaseDecimal() => this.Tool("formatDecreaseDecimal");

    public SpreadsheetToolFactory FormatIncreaseDecimal() => this.Tool("formatIncreaseDecimal");

    public SpreadsheetToolFactory Format() => this.Tool("format");

    public SpreadsheetToolFactory Merge() => this.Tool("merge");

    public SpreadsheetToolFactory Freeze() => this.Tool("freeze");

    public SpreadsheetToolFactory Filter() => this.Tool("filter");

    public SpreadsheetToolFactory Hyperlink() => this.Tool("hyperlink");

    public SpreadsheetToolFactory InsertComment() => this.Tool("insertComment");

    public SpreadsheetToolFactory InsertImage() => this.Tool("insertImage");

    public SpreadsheetToolFactory ToggleGridLines() => this.Tool("toggleGridlines");

    public SpreadsheetToolFactory AddColumnLeft() => this.Tool("addColumnLeft");

    public SpreadsheetToolFactory AddColumnRight() => this.Tool("addColumnRight");

    public SpreadsheetToolFactory AddRowBelow() => this.Tool("addRowBelow");

    public SpreadsheetToolFactory AddRowAbove() => this.Tool("addRowAbove");

    public SpreadsheetToolFactory DeleteColumn() => this.Tool("deleteColumn");

    public SpreadsheetToolFactory DeleteRow() => this.Tool("deleteRow");

    public SpreadsheetToolFactory Sort() => this.Tool("sort");

    public SpreadsheetToolFactory Validation() => this.Tool("validation");

    private SpreadsheetToolFactory Tool(string text)
    {
      this.tab.Tools.Add(new SpreadsheetTool(text));
      return this;
    }

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
