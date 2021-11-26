// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.SpreadsheetSheetDrawingBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class SpreadsheetSheetDrawingBuilder
  {
    public SpreadsheetSheetDrawingBuilder(SpreadsheetSheetDrawing container) => this.Container = container;

    protected SpreadsheetSheetDrawing Container { get; private set; }

    public SpreadsheetSheetDrawingBuilder TopLeftCell(string value)
    {
      this.Container.TopLeftCell = value;
      return this;
    }

    public SpreadsheetSheetDrawingBuilder OffsetX(double value)
    {
      this.Container.OffsetX = new double?(value);
      return this;
    }

    public SpreadsheetSheetDrawingBuilder OffsetY(double value)
    {
      this.Container.OffsetY = new double?(value);
      return this;
    }

    public SpreadsheetSheetDrawingBuilder Width(double value)
    {
      this.Container.Width = new double?(value);
      return this;
    }

    public SpreadsheetSheetDrawingBuilder Height(double value)
    {
      this.Container.Height = new double?(value);
      return this;
    }

    public SpreadsheetSheetDrawingBuilder Image(string value)
    {
      this.Container.Image = value;
      return this;
    }
  }
}
