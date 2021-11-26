// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.TreeListTagHelper
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
  [HtmlTargetElement("kendo-treelist")]
  [RestrictChildren("columns", new string[] {"column-menu", "editable", "excel", "filterable", "messages", "pdf", "sortable", "toolbar", "treelist-datasource", "pageable", "search"})]
  public class TreeListTagHelper : TagHelperBase, IDataBoundWidget<
  #nullable disable
  TreeListDataSourceTagHelper>
  {
    public string DatasourceId { get; set; }

    public TreeListDataSourceTagHelper Datasource { get; set; }

    public TreeListTagHelper(IKendoHtmlGenerator generator)
      : base(generator)
    {
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      TreeListTagHelper treeListTagHelper = this;
      context.Items[(object) treeListTagHelper.GetType()] = (object) treeListTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      // ISSUE: reference to a compiler-generated method
      await treeListTagHelper.\u003C\u003En__0(context, output);
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
      if (this.DatasourceId.HasValue())
        dictionary["dataSourceId"] = (object) this.DatasourceId;
      else if (this.Datasource != null)
        dictionary["dataSource"] = (object) this.Datasource.Serialize();
      string selectable = this.Selectable;
      if ((selectable != null ? (selectable.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["selectable"] = (object) this.Selectable;
      return this.Initializer.Initialize(this.Selector, "TreeList", (IDictionary<string, object>) dictionary);
    }

    public string OnBeforeEdit { get; set; }

    public string OnCancel { get; set; }

    public string OnCellClose { get; set; }

    public string OnChange { get; set; }

    public string OnCollapse { get; set; }

    public string OnDataBinding { get; set; }

    public string OnDataBound { get; set; }

    public string OnDragstart { get; set; }

    public string OnDrag { get; set; }

    public string OnDragend { get; set; }

    public string OnDrop { get; set; }

    public string OnEdit { get; set; }

    public string OnExcelExport { get; set; }

    public string OnExpand { get; set; }

    public string OnFilterMenuInit { get; set; }

    public string OnFilterMenuOpen { get; set; }

    public string OnPdfExport { get; set; }

    public string OnRemove { get; set; }

    public string OnSave { get; set; }

    public string OnSaveChanges { get; set; }

    public string OnColumnShow { get; set; }

    public string OnColumnHide { get; set; }

    public string OnColumnReorder { get; set; }

    public string OnColumnResize { get; set; }

    public string OnColumnMenuInit { get; set; }

    public string OnColumnMenuOpen { get; set; }

    public string OnColumnLock { get; set; }

    public string OnColumnUnlock { get; set; }

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
      string onCollapse = this.OnCollapse;
      if ((onCollapse != null ? (onCollapse.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["collapse"] = (object) this.CreateHandler(this.OnCollapse);
      string onDataBinding = this.OnDataBinding;
      if ((onDataBinding != null ? (onDataBinding.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataBinding"] = (object) this.CreateHandler(this.OnDataBinding);
      string onDataBound = this.OnDataBound;
      if ((onDataBound != null ? (onDataBound.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataBound"] = (object) this.CreateHandler(this.OnDataBound);
      string onDragstart = this.OnDragstart;
      if ((onDragstart != null ? (onDragstart.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dragstart"] = (object) this.CreateHandler(this.OnDragstart);
      string onDrag = this.OnDrag;
      if ((onDrag != null ? (onDrag.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["drag"] = (object) this.CreateHandler(this.OnDrag);
      string onDragend = this.OnDragend;
      if ((onDragend != null ? (onDragend.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dragend"] = (object) this.CreateHandler(this.OnDragend);
      string onDrop = this.OnDrop;
      if ((onDrop != null ? (onDrop.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["drop"] = (object) this.CreateHandler(this.OnDrop);
      string onEdit = this.OnEdit;
      if ((onEdit != null ? (onEdit.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["edit"] = (object) this.CreateHandler(this.OnEdit);
      string onExcelExport = this.OnExcelExport;
      if ((onExcelExport != null ? (onExcelExport.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["excelExport"] = (object) this.CreateHandler(this.OnExcelExport);
      string onExpand = this.OnExpand;
      if ((onExpand != null ? (onExpand.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["expand"] = (object) this.CreateHandler(this.OnExpand);
      string onFilterMenuInit = this.OnFilterMenuInit;
      if ((onFilterMenuInit != null ? (onFilterMenuInit.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["filterMenuInit"] = (object) this.CreateHandler(this.OnFilterMenuInit);
      string onFilterMenuOpen = this.OnFilterMenuOpen;
      if ((onFilterMenuOpen != null ? (onFilterMenuOpen.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["filterMenuOpen"] = (object) this.CreateHandler(this.OnFilterMenuOpen);
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
      string onColumnShow = this.OnColumnShow;
      if ((onColumnShow != null ? (onColumnShow.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["columnShow"] = (object) this.CreateHandler(this.OnColumnShow);
      string onColumnHide = this.OnColumnHide;
      if ((onColumnHide != null ? (onColumnHide.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["columnHide"] = (object) this.CreateHandler(this.OnColumnHide);
      string onColumnReorder = this.OnColumnReorder;
      if ((onColumnReorder != null ? (onColumnReorder.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["columnReorder"] = (object) this.CreateHandler(this.OnColumnReorder);
      string onColumnResize = this.OnColumnResize;
      if ((onColumnResize != null ? (onColumnResize.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["columnResize"] = (object) this.CreateHandler(this.OnColumnResize);
      string onColumnMenuInit = this.OnColumnMenuInit;
      if ((onColumnMenuInit != null ? (onColumnMenuInit.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["columnMenuInit"] = (object) this.CreateHandler(this.OnColumnMenuInit);
      string onColumnMenuOpen = this.OnColumnMenuOpen;
      if ((onColumnMenuOpen != null ? (onColumnMenuOpen.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["columnMenuOpen"] = (object) this.CreateHandler(this.OnColumnMenuOpen);
      string onColumnLock = this.OnColumnLock;
      if ((onColumnLock != null ? (onColumnLock.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["columnLock"] = (object) this.CreateHandler(this.OnColumnLock);
      string onColumnUnlock = this.OnColumnUnlock;
      if ((onColumnUnlock != null ? (onColumnUnlock.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["columnUnlock"] = (object) this.CreateHandler(this.OnColumnUnlock);
      return dictionary;
    }

    public string AltRowTemplate { get; set; }

    public string AltRowTemplateId { get; set; }

    public bool? AutoBind { get; set; }

    [HtmlAttributeNotBound]
    public TreeListColumnsTagHelper Columns { get; set; }

    public bool? Resizable { get; set; }

    public bool? Reorderable { get; set; }

    [HtmlAttributeNotBound]
    public TreeListColumnMenuSettingsTagHelper ColumnMenu { get; set; }

    [HtmlAttributeNotBound]
    public TreeListEditableSettingsTagHelper Editable { get; set; }

    [HtmlAttributeNotBound]
    public TreeListExcelSettingsTagHelper Excel { get; set; }

    [HtmlAttributeNotBound]
    public TreeListFilterableSettingsTagHelper Filterable { get; set; }

    public double? Height { get; set; }

    [HtmlAttributeNotBound]
    public TreeListMessagesSettingsTagHelper Messages { get; set; }

    public bool? Navigatable { get; set; }

    [HtmlAttributeNotBound]
    public TreeListPageableSettingsTagHelper Pageable { get; set; }

    [HtmlAttributeNotBound]
    public TreeListPdfSettingsTagHelper Pdf { get; set; }

    public string RowTemplate { get; set; }

    public string RowTemplateId { get; set; }

    public bool? Scrollable { get; set; }

    [HtmlAttributeNotBound]
    public TreeListSearchSettingsTagHelper Search { get; set; }

    [HtmlAttributeNotBound]
    public TreeListSortableSettingsTagHelper Sortable { get; set; }

    [HtmlAttributeNotBound]
    public TreeListToolbarsTagHelper Toolbar { get; set; }

    public string Selectable { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = base.SerializeSettings();
      if (this.AltRowTemplateId.HasValue())
        dictionary["altRowTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.AltRowTemplateId)
        };
      else if (this.AltRowTemplate.HasValue())
        dictionary["altRowTemplate"] = (object) this.AltRowTemplate;
      bool? nullable = this.AutoBind;
      if (nullable.HasValue)
        dictionary["autoBind"] = (object) this.AutoBind;
      if (this.Columns != null)
      {
        IEnumerable<Dictionary<string, object>> source = this.Columns.Select<TreeListColumnTagHelper, Dictionary<string, object>>((Func<TreeListColumnTagHelper, Dictionary<string, object>>) (i => i.Serialize()));
        if (source.Any<Dictionary<string, object>>())
          dictionary["columns"] = (object) source;
      }
      nullable = this.Resizable;
      if (nullable.HasValue)
        dictionary["resizable"] = (object) this.Resizable;
      nullable = this.Reorderable;
      if (nullable.HasValue)
        dictionary["reorderable"] = (object) this.Reorderable;
      if (this.ColumnMenu != null)
      {
        Dictionary<string, object> source = this.ColumnMenu.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
        {
          nullable = this.ColumnMenu.Enabled;
          if (nullable.HasValue)
          {
            nullable = this.ColumnMenu.Enabled;
            if (!nullable.Value)
              goto label_18;
          }
          dictionary["columnMenu"] = (object) source;
          goto label_21;
        }
label_18:
        nullable = this.ColumnMenu.Enabled;
        if (nullable.HasValue)
        {
          nullable = this.ColumnMenu.Enabled;
          if (nullable.Value)
            dictionary["columnMenu"] = (object) this.ColumnMenu.Enabled;
        }
      }
label_21:
      if (this.Editable != null)
      {
        Dictionary<string, object> source = this.Editable.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
        {
          nullable = this.Editable.Enabled;
          if (nullable.HasValue)
          {
            nullable = this.Editable.Enabled;
            if (!nullable.Value)
              goto label_26;
          }
          dictionary["editable"] = (object) source;
          goto label_29;
        }
label_26:
        nullable = this.Editable.Enabled;
        if (nullable.HasValue)
        {
          nullable = this.Editable.Enabled;
          if (nullable.Value)
            dictionary["editable"] = (object) this.Editable.Enabled;
        }
      }
label_29:
      if (this.Excel != null)
      {
        Dictionary<string, object> source = this.Excel.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["excel"] = (object) source;
      }
      if (this.Filterable != null)
      {
        Dictionary<string, object> source = this.Filterable.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
        {
          nullable = this.Filterable.Enabled;
          if (nullable.HasValue)
          {
            nullable = this.Filterable.Enabled;
            if (!nullable.Value)
              goto label_37;
          }
          dictionary["filterable"] = (object) source;
          goto label_40;
        }
label_37:
        nullable = this.Filterable.Enabled;
        if (nullable.HasValue)
        {
          nullable = this.Filterable.Enabled;
          if (nullable.Value)
            dictionary["filterable"] = (object) this.Filterable.Enabled;
        }
      }
label_40:
      if (this.Height.HasValue)
        dictionary["height"] = (object) this.Height;
      if (this.Messages != null)
      {
        Dictionary<string, object> source = this.Messages.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["messages"] = (object) source;
      }
      nullable = this.Navigatable;
      if (nullable.HasValue)
        dictionary["navigatable"] = (object) this.Navigatable;
      if (this.Pageable != null)
      {
        Dictionary<string, object> source = this.Pageable.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
        {
          nullable = this.Pageable.Enabled;
          if (nullable.HasValue)
          {
            nullable = this.Pageable.Enabled;
            if (!nullable.Value)
              goto label_52;
          }
          dictionary["pageable"] = (object) source;
          goto label_55;
        }
label_52:
        nullable = this.Pageable.Enabled;
        if (nullable.HasValue)
        {
          nullable = this.Pageable.Enabled;
          if (nullable.Value)
            dictionary["pageable"] = (object) this.Pageable.Enabled;
        }
      }
label_55:
      if (this.Pdf != null)
      {
        Dictionary<string, object> source = this.Pdf.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["pdf"] = (object) source;
      }
      if (this.RowTemplateId.HasValue())
        dictionary["rowTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.RowTemplateId)
        };
      else if (this.RowTemplate.HasValue())
        dictionary["rowTemplate"] = (object) this.RowTemplate;
      nullable = this.Scrollable;
      if (nullable.HasValue)
        dictionary["scrollable"] = (object) this.Scrollable;
      if (this.Search != null)
      {
        Dictionary<string, object> source = this.Search.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["search"] = (object) source;
      }
      if (this.Sortable != null)
      {
        Dictionary<string, object> source = this.Sortable.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
        {
          nullable = this.Sortable.Enabled;
          if (nullable.HasValue)
          {
            nullable = this.Sortable.Enabled;
            if (!nullable.Value)
              goto label_72;
          }
          dictionary["sortable"] = (object) source;
          goto label_75;
        }
label_72:
        nullable = this.Sortable.Enabled;
        if (nullable.HasValue)
        {
          nullable = this.Sortable.Enabled;
          if (nullable.Value)
            dictionary["sortable"] = (object) this.Sortable.Enabled;
        }
      }
label_75:
      if (this.Toolbar != null)
      {
        IEnumerable<Dictionary<string, object>> source = this.Toolbar.Select<TreeListToolbarTagHelper, Dictionary<string, object>>((Func<TreeListToolbarTagHelper, Dictionary<string, object>>) (i => i.Serialize()));
        if (source.Any<Dictionary<string, object>>())
          dictionary["toolbar"] = (object) source;
      }
      return dictionary;
    }
  }
}
