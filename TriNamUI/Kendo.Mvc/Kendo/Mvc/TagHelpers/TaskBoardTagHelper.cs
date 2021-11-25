// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.TaskBoardTagHelper
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
  [HtmlTargetElement("kendo-taskboard")]
  [RestrictChildren("card-menu", new string[] {"column-settings", "editable", "preview-pane", "taskboard-resources", "toolbar", "messages", "datasource", "taskboard-columns"})]
  public class TaskBoardTagHelper : TagHelperBase, IDataBoundWidget<
  #nullable disable
  DataSourceTagHelper>
  {
    public IEnumerable<object> BindTo { get; set; }

    [HtmlAttributeName("dataorderfield")]
    public string DataOrderField { get; set; }

    [HtmlAttributeName("datacategoryfield")]
    public string DataCategoryField { get; set; }

    [HtmlAttributeName("datadescriptionfield")]
    public string DataDescriptionField { get; set; }

    [HtmlAttributeName("datastatusfield")]
    public string DataStatusField { get; set; }

    [HtmlAttributeName("datatitlefield")]
    public string DataTitleField { get; set; }

    public string DatasourceId { get; set; }

    [HtmlAttributeNotBound]
    public DataSourceTagHelper Datasource { get; set; }

    public TaskBoardTagHelper(IKendoHtmlGenerator generator)
      : base(generator)
    {
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      TaskBoardTagHelper taskBoardTagHelper = this;
      context.Items[(object) taskBoardTagHelper.GetType()] = (object) taskBoardTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      // ISSUE: reference to a compiler-generated method
      await taskBoardTagHelper.\u003C\u003En__0(context, output);
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
      string dataOrderField = this.DataOrderField;
      if ((dataOrderField != null ? (dataOrderField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataOrderField"] = (object) this.DataOrderField;
      string dataCategoryField = this.DataCategoryField;
      if ((dataCategoryField != null ? (dataCategoryField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataCategoryField"] = (object) this.DataCategoryField;
      string descriptionField = this.DataDescriptionField;
      if ((descriptionField != null ? (descriptionField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataDescriptionField"] = (object) this.DataDescriptionField;
      string dataStatusField = this.DataStatusField;
      if ((dataStatusField != null ? (dataStatusField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataStatusField"] = (object) this.DataStatusField;
      string dataTitleField = this.DataTitleField;
      if ((dataTitleField != null ? (dataTitleField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataTitleField"] = (object) this.DataTitleField;
      if (this.DatasourceId.HasValue())
        dictionary["dataSourceId"] = (object) this.DatasourceId;
      else if (this.Datasource != null)
        dictionary["dataSource"] = (object) this.Datasource.Serialize();
      else if (this.BindTo != null)
        dictionary["dataSource"] = (object) this.BindTo;
      if (this.Columns != null)
      {
        if (this.Columns.DatasourceId.HasValue())
          dictionary["columns"] = (object) this.CreateHandler(this.Columns.DatasourceId);
        else if (this.Columns.Datasource != null)
          dictionary["columns"] = (object) this.Columns.Datasource.Serialize();
        else if (this.Columns.BindTo != null)
          dictionary["columns"] = (object) this.Columns.BindTo;
      }
      return this.Initializer.Initialize(this.Selector, "TaskBoard", (IDictionary<string, object>) dictionary);
    }

    public string OnColumnsDataBinding { get; set; }

    public string OnColumnsDataBound { get; set; }

    public string OnSelect { get; set; }

    public string OnDataBinding { get; set; }

    public string OnDataBound { get; set; }

    public string OnDeleteCard { get; set; }

    public string OnDeleteColumn { get; set; }

    public string OnEditCard { get; set; }

    public string OnEditColumn { get; set; }

    public string OnExecute { get; set; }

    public string OnMove { get; set; }

    public string OnMoveEnd { get; set; }

    public string OnMoveStart { get; set; }

    public string OnChange { get; set; }

    public string OnSaveCard { get; set; }

    public string OnSaveColumn { get; set; }

    protected override Dictionary<string, object> SerializeEvents()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string columnsDataBinding = this.OnColumnsDataBinding;
      if ((columnsDataBinding != null ? (columnsDataBinding.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["columnsDataBinding"] = (object) this.CreateHandler(this.OnColumnsDataBinding);
      string columnsDataBound = this.OnColumnsDataBound;
      if ((columnsDataBound != null ? (columnsDataBound.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["columnsDataBound"] = (object) this.CreateHandler(this.OnColumnsDataBound);
      string onSelect = this.OnSelect;
      if ((onSelect != null ? (onSelect.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["select"] = (object) this.CreateHandler(this.OnSelect);
      string onDataBinding = this.OnDataBinding;
      if ((onDataBinding != null ? (onDataBinding.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataBinding"] = (object) this.CreateHandler(this.OnDataBinding);
      string onDataBound = this.OnDataBound;
      if ((onDataBound != null ? (onDataBound.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataBound"] = (object) this.CreateHandler(this.OnDataBound);
      string onDeleteCard = this.OnDeleteCard;
      if ((onDeleteCard != null ? (onDeleteCard.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["deleteCard"] = (object) this.CreateHandler(this.OnDeleteCard);
      string onDeleteColumn = this.OnDeleteColumn;
      if ((onDeleteColumn != null ? (onDeleteColumn.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["deleteColumn"] = (object) this.CreateHandler(this.OnDeleteColumn);
      string onEditCard = this.OnEditCard;
      if ((onEditCard != null ? (onEditCard.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["editCard"] = (object) this.CreateHandler(this.OnEditCard);
      string onEditColumn = this.OnEditColumn;
      if ((onEditColumn != null ? (onEditColumn.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["editColumn"] = (object) this.CreateHandler(this.OnEditColumn);
      string onExecute = this.OnExecute;
      if ((onExecute != null ? (onExecute.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["execute"] = (object) this.CreateHandler(this.OnExecute);
      string onMove = this.OnMove;
      if ((onMove != null ? (onMove.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["move"] = (object) this.CreateHandler(this.OnMove);
      string onMoveEnd = this.OnMoveEnd;
      if ((onMoveEnd != null ? (onMoveEnd.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["moveEnd"] = (object) this.CreateHandler(this.OnMoveEnd);
      string onMoveStart = this.OnMoveStart;
      if ((onMoveStart != null ? (onMoveStart.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["moveStart"] = (object) this.CreateHandler(this.OnMoveStart);
      string onChange = this.OnChange;
      if ((onChange != null ? (onChange.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["change"] = (object) this.CreateHandler(this.OnChange);
      string onSaveCard = this.OnSaveCard;
      if ((onSaveCard != null ? (onSaveCard.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["saveCard"] = (object) this.CreateHandler(this.OnSaveCard);
      string onSaveColumn = this.OnSaveColumn;
      if ((onSaveColumn != null ? (onSaveColumn.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["saveColumn"] = (object) this.CreateHandler(this.OnSaveColumn);
      return dictionary;
    }

    public bool? AutoBind { get; set; }

    [HtmlAttributeNotBound]
    public TaskBoardCardMenusTagHelper CardMenu { get; set; }

    [HtmlAttributeNotBound]
    public TaskBoardColumnSettingsSettingsTagHelper ColumnSettings { get; set; }

    [HtmlAttributeNotBound]
    public TaskBoardEditableSettingsTagHelper Editable { get; set; }

    public string Height { get; set; }

    [HtmlAttributeNotBound]
    public TaskBoardPreviewPaneSettingsTagHelper PreviewPane { get; set; }

    public bool? Reorderable { get; set; }

    [HtmlAttributeNotBound]
    public TaskBoardResourcesTagHelper Resources { get; set; }

    public bool? Selectable { get; set; }

    public string Template { get; set; }

    public string TemplateId { get; set; }

    [HtmlAttributeNotBound]
    public TaskBoardToolbarSettingsTagHelper Toolbar { get; set; }

    public string Width { get; set; }

    [HtmlAttributeNotBound]
    public TaskBoardMessagesSettingsTagHelper Messages { get; set; }

    [HtmlAttributeNotBound]
    public TaskBoardColumnsTagHelper Columns { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = base.SerializeSettings();
      if (this.AutoBind.HasValue)
        dictionary["autoBind"] = (object) this.AutoBind;
      if (this.CardMenu != null)
      {
        IEnumerable<Dictionary<string, object>> source = this.CardMenu.Select<TaskBoardCardMenuTagHelper, Dictionary<string, object>>((Func<TaskBoardCardMenuTagHelper, Dictionary<string, object>>) (i => i.Serialize()));
        if (source.Any<Dictionary<string, object>>())
          dictionary["cardMenu"] = (object) source;
      }
      if (this.ColumnSettings != null)
      {
        Dictionary<string, object> source = this.ColumnSettings.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["columnSettings"] = (object) source;
      }
      if (this.Editable != null)
      {
        Dictionary<string, object> source = this.Editable.Serialize();
        if (source.Any<KeyValuePair<string, object>>() && (!this.Editable.Enabled.HasValue || this.Editable.Enabled.Value))
          dictionary["editable"] = (object) source;
        else if (this.Editable.Enabled.HasValue && !this.Editable.Enabled.Value)
          dictionary["editable"] = (object) this.Editable.Enabled;
      }
      string height = this.Height;
      if ((height != null ? (height.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["height"] = (object) this.Height;
      if (this.PreviewPane != null)
      {
        Dictionary<string, object> source = this.PreviewPane.Serialize();
        if (source.Any<KeyValuePair<string, object>>() && (!this.PreviewPane.Enabled.HasValue || this.PreviewPane.Enabled.Value))
          dictionary["previewPane"] = (object) source;
        else if (this.PreviewPane.Enabled.HasValue && !this.PreviewPane.Enabled.Value)
          dictionary["previewPane"] = (object) this.PreviewPane.Enabled;
      }
      if (this.Reorderable.HasValue)
        dictionary["reorderable"] = (object) this.Reorderable;
      if (this.Resources != null)
      {
        IEnumerable<Dictionary<string, object>> source = this.Resources.Select<TaskBoardResourceTagHelper, Dictionary<string, object>>((Func<TaskBoardResourceTagHelper, Dictionary<string, object>>) (i => i.Serialize()));
        if (source.Any<Dictionary<string, object>>())
          dictionary["resources"] = (object) source;
      }
      if (this.Selectable.HasValue)
        dictionary["selectable"] = (object) this.Selectable;
      if (this.TemplateId.HasValue())
        dictionary["template"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.TemplateId)
        };
      else if (this.Template.HasValue())
        dictionary["template"] = (object) this.Template;
      if (this.Toolbar != null)
      {
        Dictionary<string, object> source = this.Toolbar.Serialize();
        if (source.Any<KeyValuePair<string, object>>() && (!this.Toolbar.Enabled.HasValue || this.Toolbar.Enabled.Value))
          dictionary["toolbar"] = (object) source;
        else if (this.Toolbar.Enabled.HasValue && !this.Toolbar.Enabled.Value)
          dictionary["toolbar"] = (object) this.Toolbar.Enabled;
      }
      string width = this.Width;
      if ((width != null ? (width.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["width"] = (object) this.Width;
      if (this.Messages != null)
      {
        Dictionary<string, object> source = this.Messages.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["messages"] = (object) source;
      }
      if (this.Columns != null)
      {
        IEnumerable<Dictionary<string, object>> source = this.Columns.Select<TaskBoardColumnTagHelper, Dictionary<string, object>>((Func<TaskBoardColumnTagHelper, Dictionary<string, object>>) (i => i.Serialize()));
        if (source.Any<Dictionary<string, object>>())
          dictionary["columns"] = (object) source;
      }
      return dictionary;
    }
  }
}
