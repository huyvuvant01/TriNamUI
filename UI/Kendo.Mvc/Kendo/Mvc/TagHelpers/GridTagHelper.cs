// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.GridTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Rendering;
using Kendo.Mvc.UI;
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
  [HtmlTargetElement("kendo-grid")]
  [RestrictChildren("allow-copy", new string[] {"column-menu", "editable", "excel", "filterable", "groupable", "messages", "no-records", "pageable", "pdf", "scrollable", "sortable", "columns", "datasource", "toolbar", "search", "selectable"})]
  public class GridTagHelper : TagHelperBase, IDataBoundWidget<
  #nullable disable
  DataSourceTagHelper>
  {
    public GridTagHelper(IKendoHtmlGenerator generator)
      : base(generator)
    {
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      GridTagHelper gridTagHelper = this;
      context.Items[(object) gridTagHelper.GetType()] = (object) gridTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      // ISSUE: reference to a compiler-generated method
      await gridTagHelper.\u003C\u003En__0(context, output);
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
      Dictionary<string, object> dictionary1 = this.SerializeSettings();
      if (this.Filterable != null)
      {
        Dictionary<string, object> source = this.Filterable.Serialize();
        if (source.Any<KeyValuePair<string, object>>() && (!this.Filterable.Enabled.HasValue || this.Filterable.Enabled.Value))
          dictionary1["filterable"] = (object) source;
        else if (this.Filterable.Enabled.HasValue && this.Filterable.Enabled.Value)
          dictionary1["filterable"] = (object) this.Filterable.Enabled;
      }
      if (this.Columns != null)
      {
        IEnumerable<Dictionary<string, object>> source = this.Columns.Select<GridColumnTagHelper, Dictionary<string, object>>((Func<GridColumnTagHelper, Dictionary<string, object>>) (i => i.Serialize()));
        if (source.Any<Dictionary<string, object>>())
          dictionary1["columns"] = (object) source;
      }
      if (this.Toolbar != null)
      {
        IEnumerable<Dictionary<string, object>> source = this.Toolbar.Select<GridToolbarButtonTagHelper, Dictionary<string, object>>((Func<GridToolbarButtonTagHelper, Dictionary<string, object>>) (i => i.Serialize()));
        if (source.Any<Dictionary<string, object>>())
          dictionary1["toolbar"] = (object) source;
      }
      if (this.DatasourceId.HasValue())
        dictionary1["dataSourceId"] = (object) this.DatasourceId;
      else if (this.Datasource != null)
        dictionary1["dataSource"] = (object) this.Datasource.Serialize();
      string mobile = this.Mobile;
      if ((mobile != null ? (mobile.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["mobile"] = (object) this.Mobile;
      else if (this.MobileEnabled.HasValue)
        dictionary1["mobile"] = (object) this.MobileEnabled;
      if (this.Width.HasValue())
        dictionary1["width"] = (object) this.Width;
      if (this.SelectableSettings != null)
      {
        Dictionary<string, object> dictionary2 = this.SelectableSettings.SerializeSettings();
        dictionary1["selectable"] = (object) dictionary2;
      }
      else
      {
        string selectable = this.Selectable;
        if ((selectable != null ? (selectable.HasValue() ? 1 : 0) : 0) != 0)
          dictionary1["selectable"] = (object) this.Selectable;
      }
      return this.Initializer.Initialize(this.Selector, "Grid", (IDictionary<string, object>) dictionary1);
    }

    public GridFilterableSettingsTagHelper Filterable { get; set; }

    public GridColumnsTagHelper Columns { get; set; }

    public GridToolbarTagHelper Toolbar { get; set; }

    public string DatasourceId { get; set; }

    public DataSourceTagHelper Datasource { get; set; }

    public string Mobile { get; set; }

    public bool? MobileEnabled { get; set; }

    public string Width { get; set; }

    public string Selectable { get; set; }

    public GridSelectableSettings SelectableSettings { get; set; }

    public string OnBeforeEdit { get; set; }

    public string OnCancel { get; set; }

    public string OnCellClose { get; set; }

    public string OnChange { get; set; }

    public string OnColumnHide { get; set; }

    public string OnColumnLock { get; set; }

    public string OnColumnMenuInit { get; set; }

    public string OnColumnMenuOpen { get; set; }

    public string OnColumnReorder { get; set; }

    public string OnColumnResize { get; set; }

    public string OnColumnShow { get; set; }

    public string OnColumnStick { get; set; }

    public string OnColumnUnlock { get; set; }

    public string OnColumnUnstick { get; set; }

    public string OnDataBinding { get; set; }

    public string OnDataBound { get; set; }

    public string OnDetailCollapse { get; set; }

    public string OnDetailExpand { get; set; }

    public string OnDetailInit { get; set; }

    public string OnEdit { get; set; }

    public string OnExcelExport { get; set; }

    public string OnFilter { get; set; }

    public string OnFilterMenuInit { get; set; }

    public string OnFilterMenuOpen { get; set; }

    public string OnGroup { get; set; }

    public string OnGroupCollapse { get; set; }

    public string OnGroupExpand { get; set; }

    public string OnNavigate { get; set; }

    public string OnPage { get; set; }

    public string OnPdfExport { get; set; }

    public string OnRemove { get; set; }

    public string OnSave { get; set; }

    public string OnSaveChanges { get; set; }

    public string OnSort { get; set; }

    protected override Dictionary<string, object> SerializeEvents()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string onBeforeEdit = this.OnBeforeEdit;
      if ((onBeforeEdit != null ? (onBeforeEdit.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["beforeEdit"] = (object) this.CreateHandler(this.OnBeforeEdit);
      string onCancel = this.OnCancel;
      if ((onCancel != null ? (onCancel.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["cancel"] = (object) this.CreateHandler(this.OnCancel);
      string onCellClose = this.OnCellClose;
      if ((onCellClose != null ? (onCellClose.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["cellClose"] = (object) this.CreateHandler(this.OnCellClose);
      string onChange = this.OnChange;
      if ((onChange != null ? (onChange.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["change"] = (object) this.CreateHandler(this.OnChange);
      string onColumnHide = this.OnColumnHide;
      if ((onColumnHide != null ? (onColumnHide.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["columnHide"] = (object) this.CreateHandler(this.OnColumnHide);
      string onColumnLock = this.OnColumnLock;
      if ((onColumnLock != null ? (onColumnLock.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["columnLock"] = (object) this.CreateHandler(this.OnColumnLock);
      string onColumnMenuInit = this.OnColumnMenuInit;
      if ((onColumnMenuInit != null ? (onColumnMenuInit.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["columnMenuInit"] = (object) this.CreateHandler(this.OnColumnMenuInit);
      string onColumnMenuOpen = this.OnColumnMenuOpen;
      if ((onColumnMenuOpen != null ? (onColumnMenuOpen.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["columnMenuOpen"] = (object) this.CreateHandler(this.OnColumnMenuOpen);
      string onColumnReorder = this.OnColumnReorder;
      if ((onColumnReorder != null ? (onColumnReorder.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["columnReorder"] = (object) this.CreateHandler(this.OnColumnReorder);
      string onColumnResize = this.OnColumnResize;
      if ((onColumnResize != null ? (onColumnResize.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["columnResize"] = (object) this.CreateHandler(this.OnColumnResize);
      string onColumnShow = this.OnColumnShow;
      if ((onColumnShow != null ? (onColumnShow.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["columnShow"] = (object) this.CreateHandler(this.OnColumnShow);
      string onColumnStick = this.OnColumnStick;
      if ((onColumnStick != null ? (onColumnStick.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["columnStick"] = (object) this.CreateHandler(this.OnColumnStick);
      string onColumnUnlock = this.OnColumnUnlock;
      if ((onColumnUnlock != null ? (onColumnUnlock.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["columnUnlock"] = (object) this.CreateHandler(this.OnColumnUnlock);
      string onColumnUnstick = this.OnColumnUnstick;
      if ((onColumnUnstick != null ? (onColumnUnstick.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["columnUnstick"] = (object) this.CreateHandler(this.OnColumnUnstick);
      string onDataBinding = this.OnDataBinding;
      if ((onDataBinding != null ? (onDataBinding.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataBinding"] = (object) this.CreateHandler(this.OnDataBinding);
      string onDataBound = this.OnDataBound;
      if ((onDataBound != null ? (onDataBound.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataBound"] = (object) this.CreateHandler(this.OnDataBound);
      string onDetailCollapse = this.OnDetailCollapse;
      if ((onDetailCollapse != null ? (onDetailCollapse.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["detailCollapse"] = (object) this.CreateHandler(this.OnDetailCollapse);
      string onDetailExpand = this.OnDetailExpand;
      if ((onDetailExpand != null ? (onDetailExpand.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["detailExpand"] = (object) this.CreateHandler(this.OnDetailExpand);
      string onDetailInit = this.OnDetailInit;
      if ((onDetailInit != null ? (onDetailInit.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["detailInit"] = (object) this.CreateHandler(this.OnDetailInit);
      string onEdit = this.OnEdit;
      if ((onEdit != null ? (onEdit.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["edit"] = (object) this.CreateHandler(this.OnEdit);
      string onExcelExport = this.OnExcelExport;
      if ((onExcelExport != null ? (onExcelExport.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["excelExport"] = (object) this.CreateHandler(this.OnExcelExport);
      string onFilter = this.OnFilter;
      if ((onFilter != null ? (onFilter.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["filter"] = (object) this.CreateHandler(this.OnFilter);
      string onFilterMenuInit = this.OnFilterMenuInit;
      if ((onFilterMenuInit != null ? (onFilterMenuInit.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["filterMenuInit"] = (object) this.CreateHandler(this.OnFilterMenuInit);
      string onFilterMenuOpen = this.OnFilterMenuOpen;
      if ((onFilterMenuOpen != null ? (onFilterMenuOpen.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["filterMenuOpen"] = (object) this.CreateHandler(this.OnFilterMenuOpen);
      string onGroup = this.OnGroup;
      if ((onGroup != null ? (onGroup.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["group"] = (object) this.CreateHandler(this.OnGroup);
      string onGroupCollapse = this.OnGroupCollapse;
      if ((onGroupCollapse != null ? (onGroupCollapse.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["groupCollapse"] = (object) this.CreateHandler(this.OnGroupCollapse);
      string onGroupExpand = this.OnGroupExpand;
      if ((onGroupExpand != null ? (onGroupExpand.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["groupExpand"] = (object) this.CreateHandler(this.OnGroupExpand);
      string onNavigate = this.OnNavigate;
      if ((onNavigate != null ? (onNavigate.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["navigate"] = (object) this.CreateHandler(this.OnNavigate);
      string onPage = this.OnPage;
      if ((onPage != null ? (onPage.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["page"] = (object) this.CreateHandler(this.OnPage);
      string onPdfExport = this.OnPdfExport;
      if ((onPdfExport != null ? (onPdfExport.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["pdfExport"] = (object) this.CreateHandler(this.OnPdfExport);
      string onRemove = this.OnRemove;
      if ((onRemove != null ? (onRemove.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["remove"] = (object) this.CreateHandler(this.OnRemove);
      string onSave = this.OnSave;
      if ((onSave != null ? (onSave.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["save"] = (object) this.CreateHandler(this.OnSave);
      string onSaveChanges = this.OnSaveChanges;
      if ((onSaveChanges != null ? (onSaveChanges.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["saveChanges"] = (object) this.CreateHandler(this.OnSaveChanges);
      string onSort = this.OnSort;
      if ((onSort != null ? (onSort.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["sort"] = (object) this.CreateHandler(this.OnSort);
      return dictionary;
    }

    [HtmlAttributeNotBound]
    public GridAllowCopySettingsTagHelper AllowCopy { get; set; }

    public bool? AutoBind { get; set; }

    public double? ColumnResizeHandleWidth { get; set; }

    [HtmlAttributeNotBound]
    public GridColumnMenuSettingsTagHelper ColumnMenu { get; set; }

    [HtmlAttributeNotBound]
    public GridEditableSettingsTagHelper Editable { get; set; }

    public bool? EncodeTitles { get; set; }

    [HtmlAttributeNotBound]
    public GridExcelSettingsTagHelper Excel { get; set; }

    [HtmlAttributeNotBound]
    public GridGroupableSettingsTagHelper Groupable { get; set; }

    public double? Height { get; set; }

    public GridLoaderType? LoaderType { get; set; }

    [HtmlAttributeNotBound]
    public GridMessagesSettingsTagHelper Messages { get; set; }

    public bool? Navigatable { get; set; }

    [HtmlAttributeNotBound]
    public GridNoRecordsSettingsTagHelper NoRecords { get; set; }

    [HtmlAttributeNotBound]
    public GridPageableSettingsTagHelper Pageable { get; set; }

    [HtmlAttributeNotBound]
    public GridPdfSettingsTagHelper Pdf { get; set; }

    public bool? PersistSelection { get; set; }

    public bool? Reorderable { get; set; }

    public bool? Resizable { get; set; }

    [HtmlAttributeNotBound]
    public GridScrollableSettingsTagHelper Scrollable { get; set; }

    [HtmlAttributeNotBound]
    public GridSearchSettingsTagHelper Search { get; set; }

    [HtmlAttributeNotBound]
    public GridSortableSettingsTagHelper Sortable { get; set; }

    public string DetailTemplate { get; set; }

    public string DetailTemplateId { get; set; }

    public string RowTemplate { get; set; }

    public string RowTemplateId { get; set; }

    public string AltRowTemplate { get; set; }

    public string AltRowTemplateId { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = base.SerializeSettings();
      if (this.AllowCopy != null)
      {
        Dictionary<string, object> source = this.AllowCopy.Serialize();
        if (source.Any<KeyValuePair<string, object>>() && (!this.AllowCopy.Enabled.HasValue || this.AllowCopy.Enabled.Value))
          dictionary1["allowCopy"] = (object) source;
        else if (this.AllowCopy.Enabled.HasValue && this.AllowCopy.Enabled.Value)
          dictionary1["allowCopy"] = (object) this.AllowCopy.Enabled;
      }
      if (this.AutoBind.HasValue)
        dictionary1["autoBind"] = (object) this.AutoBind;
      if (this.ColumnResizeHandleWidth.HasValue)
        dictionary1["columnResizeHandleWidth"] = (object) this.ColumnResizeHandleWidth;
      if (this.ColumnMenu != null)
      {
        Dictionary<string, object> source = this.ColumnMenu.Serialize();
        if (source.Any<KeyValuePair<string, object>>() && (!this.ColumnMenu.Enabled.HasValue || this.ColumnMenu.Enabled.Value))
          dictionary1["columnMenu"] = (object) source;
        else if (this.ColumnMenu.Enabled.HasValue && this.ColumnMenu.Enabled.Value)
          dictionary1["columnMenu"] = (object) this.ColumnMenu.Enabled;
      }
      if (this.Editable != null)
      {
        Dictionary<string, object> source = this.Editable.Serialize();
        if (source.Any<KeyValuePair<string, object>>() && (!this.Editable.Enabled.HasValue || this.Editable.Enabled.Value))
          dictionary1["editable"] = (object) source;
        else if (this.Editable.Enabled.HasValue && this.Editable.Enabled.Value)
          dictionary1["editable"] = (object) this.Editable.Enabled;
      }
      if (this.EncodeTitles.HasValue)
        dictionary1["encodeTitles"] = (object) this.EncodeTitles;
      if (this.Excel != null)
      {
        Dictionary<string, object> source = this.Excel.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["excel"] = (object) source;
      }
      if (this.Groupable != null)
      {
        Dictionary<string, object> source = this.Groupable.Serialize();
        if (source.Any<KeyValuePair<string, object>>() && (!this.Groupable.Enabled.HasValue || this.Groupable.Enabled.Value))
          dictionary1["groupable"] = (object) source;
        else if (this.Groupable.Enabled.HasValue && this.Groupable.Enabled.Value)
          dictionary1["groupable"] = (object) this.Groupable.Enabled;
      }
      if (this.Height.HasValue)
        dictionary1["height"] = (object) this.Height;
      if (this.LoaderType.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        GridLoaderType? loaderType = this.LoaderType;
        ref GridLoaderType? local = ref loaderType;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["loaderType"] = (object) str;
      }
      if (this.Messages != null)
      {
        Dictionary<string, object> source = this.Messages.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["messages"] = (object) source;
      }
      if (this.Navigatable.HasValue)
        dictionary1["navigatable"] = (object) this.Navigatable;
      if (this.NoRecords != null)
      {
        Dictionary<string, object> source = this.NoRecords.Serialize();
        if (source.Any<KeyValuePair<string, object>>() && (!this.NoRecords.Enabled.HasValue || this.NoRecords.Enabled.Value))
          dictionary1["noRecords"] = (object) source;
        else if (this.NoRecords.Enabled.HasValue && this.NoRecords.Enabled.Value)
          dictionary1["noRecords"] = (object) this.NoRecords.Enabled;
      }
      if (this.Pageable != null)
      {
        Dictionary<string, object> source = this.Pageable.Serialize();
        if (source.Any<KeyValuePair<string, object>>() && (!this.Pageable.Enabled.HasValue || this.Pageable.Enabled.Value))
          dictionary1["pageable"] = (object) source;
        else if (this.Pageable.Enabled.HasValue && this.Pageable.Enabled.Value)
          dictionary1["pageable"] = (object) this.Pageable.Enabled;
      }
      if (this.Pdf != null)
      {
        Dictionary<string, object> source = this.Pdf.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["pdf"] = (object) source;
      }
      if (this.PersistSelection.HasValue)
        dictionary1["persistSelection"] = (object) this.PersistSelection;
      if (this.Reorderable.HasValue)
        dictionary1["reorderable"] = (object) this.Reorderable;
      if (this.Resizable.HasValue)
        dictionary1["resizable"] = (object) this.Resizable;
      if (this.Scrollable != null)
      {
        Dictionary<string, object> source = this.Scrollable.Serialize();
        if (source.Any<KeyValuePair<string, object>>() && (!this.Scrollable.Enabled.HasValue || this.Scrollable.Enabled.Value))
          dictionary1["scrollable"] = (object) source;
        else if (this.Scrollable.Enabled.HasValue && !this.Scrollable.Enabled.Value)
          dictionary1["scrollable"] = (object) this.Scrollable.Enabled;
      }
      if (this.Search != null)
      {
        Dictionary<string, object> source = this.Search.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["search"] = (object) source;
      }
      if (this.Sortable != null)
      {
        Dictionary<string, object> source = this.Sortable.Serialize();
        if (source.Any<KeyValuePair<string, object>>() && (!this.Sortable.Enabled.HasValue || this.Sortable.Enabled.Value))
          dictionary1["sortable"] = (object) source;
        else if (this.Sortable.Enabled.HasValue && this.Sortable.Enabled.Value)
          dictionary1["sortable"] = (object) this.Sortable.Enabled;
      }
      if (this.DetailTemplateId.HasValue())
        dictionary1["detailTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.DetailTemplateId)
        };
      else if (this.DetailTemplate.HasValue())
        dictionary1["detailTemplate"] = (object) this.DetailTemplate;
      if (this.RowTemplateId.HasValue())
        dictionary1["rowTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.RowTemplateId)
        };
      else if (this.RowTemplate.HasValue())
        dictionary1["rowTemplate"] = (object) this.RowTemplate;
      if (this.AltRowTemplateId.HasValue())
        dictionary1["altRowTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.AltRowTemplateId)
        };
      else if (this.AltRowTemplate.HasValue())
        dictionary1["altRowTemplate"] = (object) this.AltRowTemplate;
      return dictionary1;
    }
  }
}
