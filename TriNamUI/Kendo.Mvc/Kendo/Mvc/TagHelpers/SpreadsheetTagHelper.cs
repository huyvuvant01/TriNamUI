// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.SpreadsheetTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("kendo-spreadsheet")]
  [RestrictChildren("default-cell-style", new string[] {"excel", "pdf", "sheets", "toolbar"})]
  [OutputElementHint("div")]
  public class SpreadsheetTagHelper : TagHelperBase
  {
    public SpreadsheetTagHelper(
    #nullable disable
    IKendoHtmlGenerator generator)
      : base(generator)
    {
    }

    public object Images { get; set; }

    [HtmlAttributeNotBound]
    public SpreadsheetToolbarTagHelper Toolbar { get; set; }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      SpreadsheetTagHelper spreadsheetTagHelper = this;
      context.Items[(object) spreadsheetTagHelper.GetType()] = (object) spreadsheetTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      // ISSUE: reference to a compiler-generated method
      await spreadsheetTagHelper.\u003C\u003En__0(context, output);
    }

    protected override void WriteHtml(TagHelperOutput output)
    {
      this.GenerateId(output);
      TagBuilder tag = this.Generator.GenerateTag("div", this.ViewContext, this.Id, this.Name, (IDictionary<string, object>) new Dictionary<string, object>());
      output.TagName = "div";
      output.MergeAttributes(tag);
    }

    protected override string GetInitializationScript()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      if (this.Images != null)
        dictionary["images"] = this.Images;
      if (this.Toolbar != null)
      {
        Dictionary<string, object> source = this.Toolbar.Serialize();
        if (source.Any<KeyValuePair<string, object>>() && (!this.Toolbar.Enabled.HasValue || this.Toolbar.Enabled.Value))
          dictionary["toolbar"] = (object) source;
        else if (this.Toolbar.Enabled.HasValue && !this.Toolbar.Enabled.Value)
          dictionary["toolbar"] = (object) this.Toolbar.Enabled;
      }
      return this.Initializer.Initialize(this.Selector, "Spreadsheet", (IDictionary<string, object>) dictionary);
    }

    public string OnInsertSheet { get; set; }

    public string OnRemoveSheet { get; set; }

    public string OnRenameSheet { get; set; }

    public string OnSelectSheet { get; set; }

    public string OnUnhideColumn { get; set; }

    public string OnUnhideRow { get; set; }

    public string OnHideColumn { get; set; }

    public string OnHideRow { get; set; }

    public string OnDeleteColumn { get; set; }

    public string OnDeleteRow { get; set; }

    public string OnInsertColumn { get; set; }

    public string OnInsertRow { get; set; }

    public string OnSelect { get; set; }

    public string OnChangeFormat { get; set; }

    public string OnChanging { get; set; }

    public string OnChange { get; set; }

    public string OnRender { get; set; }

    public string OnExcelExport { get; set; }

    public string OnExcelImport { get; set; }

    public string OnPdfExport { get; set; }

    public string OnCopy { get; set; }

    public string OnCut { get; set; }

    public string OnPaste { get; set; }

    public string OnDataBinding { get; set; }

    public string OnDataBound { get; set; }

    protected override Dictionary<string, object> SerializeEvents()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string onInsertSheet = this.OnInsertSheet;
      if ((onInsertSheet != null ? (onInsertSheet.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["insertSheet"] = (object) this.CreateHandler(this.OnInsertSheet);
      string onRemoveSheet = this.OnRemoveSheet;
      if ((onRemoveSheet != null ? (onRemoveSheet.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["removeSheet"] = (object) this.CreateHandler(this.OnRemoveSheet);
      string onRenameSheet = this.OnRenameSheet;
      if ((onRenameSheet != null ? (onRenameSheet.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["renameSheet"] = (object) this.CreateHandler(this.OnRenameSheet);
      string onSelectSheet = this.OnSelectSheet;
      if ((onSelectSheet != null ? (onSelectSheet.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["selectSheet"] = (object) this.CreateHandler(this.OnSelectSheet);
      string onUnhideColumn = this.OnUnhideColumn;
      if ((onUnhideColumn != null ? (onUnhideColumn.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["unhideColumn"] = (object) this.CreateHandler(this.OnUnhideColumn);
      string onUnhideRow = this.OnUnhideRow;
      if ((onUnhideRow != null ? (onUnhideRow.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["unhideRow"] = (object) this.CreateHandler(this.OnUnhideRow);
      string onHideColumn = this.OnHideColumn;
      if ((onHideColumn != null ? (onHideColumn.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["hideColumn"] = (object) this.CreateHandler(this.OnHideColumn);
      string onHideRow = this.OnHideRow;
      if ((onHideRow != null ? (onHideRow.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["hideRow"] = (object) this.CreateHandler(this.OnHideRow);
      string onDeleteColumn = this.OnDeleteColumn;
      if ((onDeleteColumn != null ? (onDeleteColumn.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["deleteColumn"] = (object) this.CreateHandler(this.OnDeleteColumn);
      string onDeleteRow = this.OnDeleteRow;
      if ((onDeleteRow != null ? (onDeleteRow.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["deleteRow"] = (object) this.CreateHandler(this.OnDeleteRow);
      string onInsertColumn = this.OnInsertColumn;
      if ((onInsertColumn != null ? (onInsertColumn.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["insertColumn"] = (object) this.CreateHandler(this.OnInsertColumn);
      string onInsertRow = this.OnInsertRow;
      if ((onInsertRow != null ? (onInsertRow.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["insertRow"] = (object) this.CreateHandler(this.OnInsertRow);
      string onSelect = this.OnSelect;
      if ((onSelect != null ? (onSelect.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["select"] = (object) this.CreateHandler(this.OnSelect);
      string onChangeFormat = this.OnChangeFormat;
      if ((onChangeFormat != null ? (onChangeFormat.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["changeFormat"] = (object) this.CreateHandler(this.OnChangeFormat);
      string onChanging = this.OnChanging;
      if ((onChanging != null ? (onChanging.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["changing"] = (object) this.CreateHandler(this.OnChanging);
      string onChange = this.OnChange;
      if ((onChange != null ? (onChange.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["change"] = (object) this.CreateHandler(this.OnChange);
      string onRender = this.OnRender;
      if ((onRender != null ? (onRender.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["render"] = (object) this.CreateHandler(this.OnRender);
      string onExcelExport = this.OnExcelExport;
      if ((onExcelExport != null ? (onExcelExport.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["excelExport"] = (object) this.CreateHandler(this.OnExcelExport);
      string onExcelImport = this.OnExcelImport;
      if ((onExcelImport != null ? (onExcelImport.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["excelImport"] = (object) this.CreateHandler(this.OnExcelImport);
      string onPdfExport = this.OnPdfExport;
      if ((onPdfExport != null ? (onPdfExport.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["pdfExport"] = (object) this.CreateHandler(this.OnPdfExport);
      string onCopy = this.OnCopy;
      if ((onCopy != null ? (onCopy.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["copy"] = (object) this.CreateHandler(this.OnCopy);
      string onCut = this.OnCut;
      if ((onCut != null ? (onCut.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["cut"] = (object) this.CreateHandler(this.OnCut);
      string onPaste = this.OnPaste;
      if ((onPaste != null ? (onPaste.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["paste"] = (object) this.CreateHandler(this.OnPaste);
      string onDataBinding = this.OnDataBinding;
      if ((onDataBinding != null ? (onDataBinding.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataBinding"] = (object) this.CreateHandler(this.OnDataBinding);
      string onDataBound = this.OnDataBound;
      if ((onDataBound != null ? (onDataBound.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataBound"] = (object) this.CreateHandler(this.OnDataBound);
      return dictionary;
    }

    public string ActiveSheet { get; set; }

    public double? ColumnWidth { get; set; }

    public double? Columns { get; set; }

    [HtmlAttributeNotBound]
    public SpreadsheetDefaultCellStyleSettingsTagHelper DefaultCellStyle { get; set; }

    public double? HeaderHeight { get; set; }

    public double? HeaderWidth { get; set; }

    [HtmlAttributeNotBound]
    public SpreadsheetExcelSettingsTagHelper Excel { get; set; }

    [HtmlAttributeNotBound]
    public SpreadsheetPdfSettingsTagHelper Pdf { get; set; }

    public double? RowHeight { get; set; }

    public double? Rows { get; set; }

    [HtmlAttributeNotBound]
    public SpreadsheetSheetsTagHelper Sheets { get; set; }

    public bool? Sheetsbar { get; set; }

    public bool? UseCultureDecimals { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = base.SerializeSettings();
      string activeSheet = this.ActiveSheet;
      if ((activeSheet != null ? (activeSheet.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["activeSheet"] = (object) this.ActiveSheet;
      double? nullable1 = this.ColumnWidth;
      if (nullable1.HasValue)
        dictionary["columnWidth"] = (object) this.ColumnWidth;
      nullable1 = this.Columns;
      if (nullable1.HasValue)
        dictionary["columns"] = (object) this.Columns;
      if (this.DefaultCellStyle != null)
      {
        Dictionary<string, object> source = this.DefaultCellStyle.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["defaultCellStyle"] = (object) source;
      }
      nullable1 = this.HeaderHeight;
      if (nullable1.HasValue)
        dictionary["headerHeight"] = (object) this.HeaderHeight;
      nullable1 = this.HeaderWidth;
      if (nullable1.HasValue)
        dictionary["headerWidth"] = (object) this.HeaderWidth;
      if (this.Excel != null)
      {
        Dictionary<string, object> source = this.Excel.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["excel"] = (object) source;
      }
      if (this.Pdf != null)
      {
        Dictionary<string, object> source = this.Pdf.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["pdf"] = (object) source;
      }
      nullable1 = this.RowHeight;
      if (nullable1.HasValue)
        dictionary["rowHeight"] = (object) this.RowHeight;
      nullable1 = this.Rows;
      if (nullable1.HasValue)
        dictionary["rows"] = (object) this.Rows;
      if (this.Sheets != null)
      {
        IEnumerable<Dictionary<string, object>> source = this.Sheets.Select<SpreadsheetSheetTagHelper, Dictionary<string, object>>((Func<SpreadsheetSheetTagHelper, Dictionary<string, object>>) (i => i.Serialize()));
        if (source.Any<Dictionary<string, object>>())
          dictionary["sheets"] = (object) source;
      }
      bool? nullable2 = this.Sheetsbar;
      if (nullable2.HasValue)
        dictionary["sheetsbar"] = (object) this.Sheetsbar;
      nullable2 = this.UseCultureDecimals;
      if (nullable2.HasValue)
        dictionary["useCultureDecimals"] = (object) this.UseCultureDecimals;
      return dictionary;
    }
  }
}
