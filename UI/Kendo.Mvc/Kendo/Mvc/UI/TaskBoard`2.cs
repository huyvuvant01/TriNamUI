// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.TaskBoard`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class TaskBoard<TCard, TColumn> : WidgetBase
    where TCard : class
    where TColumn : class
  {
    public DataSource DataSource { get; private set; }

    public string DataSourceId { get; set; }

    public DataSource Columns { get; private set; }

    public string ColumnsId { get; set; }

    public TaskBoard(ViewContext viewContext)
      : base(viewContext)
    {
      this.DataSource = new DataSource(this.ModelMetadataProvider);
      this.DataSource.ModelType(typeof (TCard));
      this.Columns = new DataSource(this.ModelMetadataProvider);
      this.Columns.ModelType(typeof (TColumn));
    }

    protected override void WriteHtml(TextWriter writer)
    {
      this.Generator.GenerateTag("div", this.ViewContext, this.Id, this.Name, this.HtmlAttributes).WriteTo(writer, this.HtmlEncoder);
      base.WriteHtml(writer);
    }

    public override void WriteInitializationScript(TextWriter writer)
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      DataSourceType? type;
      if (this.DataSourceId.HasValue())
      {
        dictionary["dataSourceId"] = (object) this.DataSourceId;
      }
      else
      {
        if (string.IsNullOrEmpty(this.DataSource.Transport.Read.Url) && string.IsNullOrEmpty(this.DataSource.Transport.Read.ActionName))
        {
          type = this.DataSource.Type;
          DataSourceType dataSourceType = DataSourceType.Custom;
          if (!(type.GetValueOrDefault() == dataSourceType & type.HasValue))
          {
            if (this.DataSource.Data != null)
            {
              dictionary["dataSource"] = (object) this.DataSource.Data;
              goto label_7;
            }
            else
              goto label_7;
          }
        }
        dictionary["dataSource"] = (object) this.DataSource.ToJson();
      }
label_7:
      if (this.ColumnsId.HasValue())
      {
        dictionary["columnsId"] = (object) this.ColumnsId;
      }
      else
      {
        if (string.IsNullOrEmpty(this.Columns.Transport.Read.Url) && string.IsNullOrEmpty(this.Columns.Transport.Read.ActionName))
        {
          type = this.Columns.Type;
          DataSourceType dataSourceType = DataSourceType.Custom;
          if (!(type.GetValueOrDefault() == dataSourceType & type.HasValue))
          {
            if (this.Columns.Data != null)
            {
              dictionary["columns"] = (object) this.Columns.Data;
              goto label_14;
            }
            else
              goto label_14;
          }
        }
        dictionary["columns"] = (object) this.Columns.ToJson();
      }
label_14:
      writer.Write(this.Initializer.Initialize(this.Selector, nameof (TaskBoard<TCard, TColumn>), (IDictionary<string, object>) dictionary));
    }

    public bool? AutoBind { get; set; }

    public List<TaskBoardCardMenu<TCard, TColumn>> CardMenu { get; set; } = new List<TaskBoardCardMenu<TCard, TColumn>>();

    public TaskBoardColumnSettingsSettings<TCard, TColumn> ColumnSettings { get; } = new TaskBoardColumnSettingsSettings<TCard, TColumn>();

    public string DataOrderField { get; set; }

    public string DataCategoryField { get; set; }

    public string DataDescriptionField { get; set; }

    public string DataStatusField { get; set; }

    public string DataTitleField { get; set; }

    public TaskBoardEditableSettings<TCard, TColumn> Editable { get; } = new TaskBoardEditableSettings<TCard, TColumn>();

    public string Height { get; set; }

    public TaskBoardPreviewPaneSettings<TCard, TColumn> PreviewPane { get; } = new TaskBoardPreviewPaneSettings<TCard, TColumn>();

    public bool? Reorderable { get; set; }

    public List<TaskBoardResource<TCard, TColumn>> Resources { get; set; } = new List<TaskBoardResource<TCard, TColumn>>();

    public bool? Selectable { get; set; }

    public string Template { get; set; }

    public string TemplateId { get; set; }

    public TaskBoardToolbarSettings<TCard, TColumn> Toolbar { get; } = new TaskBoardToolbarSettings<TCard, TColumn>();

    public string Width { get; set; }

    public TaskBoardMessagesSettings<TCard, TColumn> Messages { get; } = new TaskBoardMessagesSettings<TCard, TColumn>();

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = base.SerializeSettings();
      if (this.AutoBind.HasValue)
        dictionary["autoBind"] = (object) this.AutoBind;
      IEnumerable<Dictionary<string, object>> source1 = this.CardMenu.Select<TaskBoardCardMenu<TCard, TColumn>, Dictionary<string, object>>((Func<TaskBoardCardMenu<TCard, TColumn>, Dictionary<string, object>>) (i => i.Serialize()));
      if (source1.Any<Dictionary<string, object>>())
        dictionary["cardMenu"] = (object) source1;
      Dictionary<string, object> source2 = this.ColumnSettings.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
        dictionary["columnSettings"] = (object) source2;
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
      Dictionary<string, object> source3 = this.Editable.Serialize();
      if (source3.Any<KeyValuePair<string, object>>())
        dictionary["editable"] = (object) source3;
      else if (this.Editable.Enabled.HasValue)
        dictionary["editable"] = (object) this.Editable.Enabled;
      string height = this.Height;
      if ((height != null ? (height.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["height"] = (object) this.Height;
      Dictionary<string, object> source4 = this.PreviewPane.Serialize();
      if (source4.Any<KeyValuePair<string, object>>())
        dictionary["previewPane"] = (object) source4;
      else if (this.PreviewPane.Enabled.HasValue)
        dictionary["previewPane"] = (object) this.PreviewPane.Enabled;
      if (this.Reorderable.HasValue)
        dictionary["reorderable"] = (object) this.Reorderable;
      IEnumerable<Dictionary<string, object>> source5 = this.Resources.Select<TaskBoardResource<TCard, TColumn>, Dictionary<string, object>>((Func<TaskBoardResource<TCard, TColumn>, Dictionary<string, object>>) (i => i.Serialize()));
      if (source5.Any<Dictionary<string, object>>())
        dictionary["resources"] = (object) source5;
      if (this.Selectable.HasValue)
        dictionary["selectable"] = (object) this.Selectable;
      if (this.TemplateId.HasValue())
        dictionary["template"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.TemplateId)
        };
      else if (this.Template.HasValue())
        dictionary["template"] = (object) this.Template;
      Dictionary<string, object> source6 = this.Toolbar.Serialize();
      if (source6.Any<KeyValuePair<string, object>>())
        dictionary["toolbar"] = (object) source6;
      else if (this.Toolbar.Enabled.HasValue)
        dictionary["toolbar"] = (object) this.Toolbar.Enabled;
      string width = this.Width;
      if ((width != null ? (width.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["width"] = (object) this.Width;
      Dictionary<string, object> source7 = this.Messages.Serialize();
      if (source7.Any<KeyValuePair<string, object>>())
        dictionary["messages"] = (object) source7;
      return dictionary;
    }
  }
}
