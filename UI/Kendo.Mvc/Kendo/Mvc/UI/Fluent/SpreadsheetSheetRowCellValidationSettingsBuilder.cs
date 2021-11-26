// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.SpreadsheetSheetRowCellValidationSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class SpreadsheetSheetRowCellValidationSettingsBuilder
  {
    public SpreadsheetSheetRowCellValidationSettingsBuilder(
      SpreadsheetSheetRowCellValidationSettings container)
    {
      this.Container = container;
    }

    protected SpreadsheetSheetRowCellValidationSettings Container { get; private set; }

    public SpreadsheetSheetRowCellValidationSettingsBuilder Type(
      string value)
    {
      this.Container.Type = value;
      return this;
    }

    public SpreadsheetSheetRowCellValidationSettingsBuilder ComparerType(
      string value)
    {
      this.Container.ComparerType = value;
      return this;
    }

    public SpreadsheetSheetRowCellValidationSettingsBuilder DataType(
      string value)
    {
      this.Container.DataType = value;
      return this;
    }

    public SpreadsheetSheetRowCellValidationSettingsBuilder From(
      string value)
    {
      this.Container.From = value;
      return this;
    }

    public SpreadsheetSheetRowCellValidationSettingsBuilder ShowButton(
      bool value)
    {
      this.Container.ShowButton = new bool?(value);
      return this;
    }

    public SpreadsheetSheetRowCellValidationSettingsBuilder ShowButton()
    {
      this.Container.ShowButton = new bool?(true);
      return this;
    }

    public SpreadsheetSheetRowCellValidationSettingsBuilder To(
      string value)
    {
      this.Container.To = value;
      return this;
    }

    public SpreadsheetSheetRowCellValidationSettingsBuilder AllowNulls(
      bool value)
    {
      this.Container.AllowNulls = new bool?(value);
      return this;
    }

    public SpreadsheetSheetRowCellValidationSettingsBuilder MessageTemplate(
      string value)
    {
      this.Container.MessageTemplate = value;
      return this;
    }

    public SpreadsheetSheetRowCellValidationSettingsBuilder MessageTemplateId(
      string templateId)
    {
      this.Container.MessageTemplateId = templateId;
      return this;
    }

    public SpreadsheetSheetRowCellValidationSettingsBuilder TitleTemplate(
      string value)
    {
      this.Container.TitleTemplate = value;
      return this;
    }

    public SpreadsheetSheetRowCellValidationSettingsBuilder TitleTemplateId(
      string templateId)
    {
      this.Container.TitleTemplateId = templateId;
      return this;
    }
  }
}
