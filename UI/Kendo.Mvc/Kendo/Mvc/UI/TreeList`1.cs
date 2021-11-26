// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.TreeList`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


#nullable enable
namespace Kendo.Mvc.UI
{
  public class TreeList<T> : WidgetBase where T : 
  #nullable disable
  class
  {
    public TreeList(ViewContext viewContext)
      : base(viewContext)
    {
      this.DataSource = new DataSource(this.ModelMetadataProvider)
      {
        Type = new DataSourceType?(DataSourceType.Ajax),
        ServerAggregates = true,
        ServerFiltering = true,
        ServerPaging = true,
        ServerSorting = true
      };
      this.DataSource.Schema.Model = (ModelDescriptor) new TreeListModelDescriptor(typeof (T), this.ModelMetadataProvider);
    }

    public DataSource DataSource { get; private set; }

    public string DataSourceId { get; set; }

    public override void ProcessSettings()
    {
      DataSourceType? type = this.DataSource.Type;
      DataSourceType dataSourceType = DataSourceType.Custom;
      if (!(type.GetValueOrDefault() == dataSourceType & type.HasValue) || this.DataSource.CustomType == "aspnetmvc-ajax")
        this.ProcessDataSource();
      bool? enabled = this.Editable.Enabled;
      bool flag = true;
      if (enabled.GetValueOrDefault() == flag & enabled.HasValue)
        this.InitializeEditors();
      base.ProcessSettings();
    }

    protected override void WriteHtml(TextWriter writer)
    {
      this.Generator.GenerateTag("div", this.ViewContext, this.Id, this.Name, this.HtmlAttributes).WriteTo(writer, this.HtmlEncoder);
      base.WriteHtml(writer);
    }

    public override void WriteInitializationScript(TextWriter writer)
    {
      Dictionary<string, object> instance = this.SerializeSettings();
      if (this.DataSourceId.HasValue())
        instance["dataSourceId"] = (object) this.DataSourceId;
      else
        instance["dataSource"] = (object) this.DataSource.ToJson();
      Dictionary<string, object> source = this.Selectable.Serialize();
      if (source.Any<KeyValuePair<string, object>>())
        instance.AddRange<KeyValuePair<string, object>>((IEnumerable<KeyValuePair<string, object>>) source);
      writer.Write(this.Initializer.Initialize(this.Selector, nameof (TreeList<T>), (IDictionary<string, object>) instance));
    }

    private string EditorForModel(
      IHtmlHelper htmlHelper,
      string templateName,
      IEnumerable<Action<IDictionary<string, object>, object>> foreignKeyData,
      object additionalViewData)
    {
      StringBuilder sb = new StringBuilder();
      ViewContext viewContext = this.ViewContext.ViewContextForType<T>(this.ModelMetadataProvider);
      ((IViewContextAware) htmlHelper).Contextualize(viewContext);
      if (foreignKeyData != null)
      {
        T dataItem = this.Editable.DefaultDataItem();
        foreignKeyData.Each<Action<IDictionary<string, object>, object>>((Action<Action<IDictionary<string, object>, object>>) (action => action((IDictionary<string, object>) viewContext.ViewData, (object) dataItem)));
      }
      using (StringWriter stringWriter = new StringWriter(sb))
        (!templateName.HasValue() ? htmlHelper.EditorForModel(additionalViewData) : htmlHelper.EditorForModel(templateName, additionalViewData)).WriteTo((TextWriter) stringWriter, this.HtmlEncoder);
      return sb.ToString();
    }

    private string EditorForColumn(TreeListColumn<T> column, IHtmlHelper helper)
    {
      ((IViewContextAware) helper).Contextualize(this.ViewContext.ViewContextForType<T>(this.ModelMetadataProvider));
      StringBuilder sb = new StringBuilder();
      using (StringWriter stringWriter = new StringWriter(sb))
      {
        HtmlHelperEditorExtensions.Editor(helper, column.Field, string.Empty, (string) null).WriteTo((TextWriter) stringWriter, this.HtmlEncoder);
        helper.ValidationMessage(column.Field).WriteTo((TextWriter) stringWriter, this.HtmlEncoder);
      }
      return sb.ToString();
    }

    private void InitializeEditors()
    {
      Regex popupSlashes = new Regex("(?<=data-val-regex-pattern=\")([^\"]*)", RegexOptions.Multiline);
      T obj = this.Editable.DefaultDataItem();
      HtmlHelper<T> htmlHelper = this.ViewContext.CreateHtmlHelper<T>();
      TreeListEditMode? mode = this.Editable.Mode;
      TreeListEditMode treeListEditMode = TreeListEditMode.PopUp;
      if (mode.GetValueOrDefault() == treeListEditMode & mode.HasValue)
      {
        string input = this.EditorForModel((IHtmlHelper) htmlHelper, this.Editable.TemplateName, (IEnumerable<Action<IDictionary<string, object>, object>>) null, (object) null);
        if (!this.Editable.TemplateName.HasValue())
          input = input.Replace("editor-field", "k-edit-field").Replace("editor-label", "k-edit-label");
        this.Editable.EditorHtml = popupSlashes.Replace(input, (MatchEvaluator) (match => match.Groups[0].Value.Replace("\\", this.IsInClientTemplate ? "\\\\\\\\" : "\\\\")));
      }
      else
      {
        IList<ModelFieldDescriptor> fields = this.DataSource.Schema.Model.Fields;
        bool isDynamic = obj.GetType().IsDynamicObject();
        this.Columns.Each<TreeListColumn<T>>((Action<TreeListColumn<T>>) (column =>
        {
          if (!column.Field.HasValue())
            return;
          if (column.Editor != null)
          {
            column.Editor = (object) new ClientHandlerDescriptor()
            {
              HandlerName = column.Editor.ToString()
            };
          }
          else
          {
            ModelFieldDescriptor modelFieldDescriptor = fields.FirstOrDefault<ModelFieldDescriptor>((Func<ModelFieldDescriptor, bool>) (f => f.Member == column.Field));
            if (isDynamic && modelFieldDescriptor != null && !modelFieldDescriptor.IsEditable)
              return;
            string input = this.EditorForColumn(column, (IHtmlHelper) htmlHelper);
            if (this.IsInClientTemplate)
              input = popupSlashes.Replace(input, (MatchEvaluator) (match => match.Groups[0].Value.Replace("\\", "\\\\")));
            column.Editor = (object) input;
          }
        }));
      }
    }

    private void ProcessDataSource() => this.DataSource.Process(DataSourceRequestModelBinder.CreateDataSourceRequest(this.ModelMetadataProvider.GetMetadataForType(typeof (T)), this.ValueProvider, string.Empty), true);

    public string AltRowTemplate { get; set; }

    public string AltRowTemplateId { get; set; }

    public bool? AutoBind { get; set; }

    public List<TreeListColumn<T>> Columns { get; set; } = new List<TreeListColumn<T>>();

    public bool? Resizable { get; set; }

    public bool? Reorderable { get; set; }

    public TreeListColumnMenuSettings<T> ColumnMenu { get; } = new TreeListColumnMenuSettings<T>();

    public TreeListEditableSettings<T> Editable { get; } = new TreeListEditableSettings<T>();

    public TreeListExcelSettings<T> Excel { get; } = new TreeListExcelSettings<T>();

    public TreeListFilterableSettings<T> Filterable { get; } = new TreeListFilterableSettings<T>();

    public double? Height { get; set; }

    public TreeListMessagesSettings<T> Messages { get; } = new TreeListMessagesSettings<T>();

    public bool? Navigatable { get; set; }

    public TreeListPageableSettings<T> Pageable { get; } = new TreeListPageableSettings<T>();

    public TreeListPdfSettings<T> Pdf { get; } = new TreeListPdfSettings<T>();

    public string RowTemplate { get; set; }

    public string RowTemplateId { get; set; }

    public bool? Scrollable { get; set; }

    public TreeListSearchSettings<T> Search { get; } = new TreeListSearchSettings<T>();

    public TreeListSortableSettings<T> Sortable { get; } = new TreeListSortableSettings<T>();

    public List<TreeListToolbar<T>> Toolbar { get; set; } = new List<TreeListToolbar<T>>();

    public TreeListSelectableSettings<T> Selectable { get; } = new TreeListSelectableSettings<T>();

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
      IEnumerable<Dictionary<string, object>> source1 = this.Columns.Select<TreeListColumn<T>, Dictionary<string, object>>((Func<TreeListColumn<T>, Dictionary<string, object>>) (i => i.Serialize()));
      if (source1.Any<Dictionary<string, object>>())
        dictionary["columns"] = (object) source1;
      nullable = this.Resizable;
      if (nullable.HasValue)
        dictionary["resizable"] = (object) this.Resizable;
      nullable = this.Reorderable;
      if (nullable.HasValue)
        dictionary["reorderable"] = (object) this.Reorderable;
      Dictionary<string, object> source2 = this.ColumnMenu.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
      {
        dictionary["columnMenu"] = (object) source2;
      }
      else
      {
        nullable = this.ColumnMenu.Enabled;
        if (nullable.HasValue)
          dictionary["columnMenu"] = (object) this.ColumnMenu.Enabled;
      }
      Dictionary<string, object> source3 = this.Editable.Serialize();
      if (source3.Any<KeyValuePair<string, object>>())
      {
        dictionary["editable"] = (object) source3;
      }
      else
      {
        nullable = this.Editable.Enabled;
        if (nullable.HasValue)
          dictionary["editable"] = (object) this.Editable.Enabled;
      }
      Dictionary<string, object> source4 = this.Excel.Serialize();
      if (source4.Any<KeyValuePair<string, object>>())
        dictionary["excel"] = (object) source4;
      Dictionary<string, object> source5 = this.Filterable.Serialize();
      if (source5.Any<KeyValuePair<string, object>>())
      {
        dictionary["filterable"] = (object) source5;
      }
      else
      {
        nullable = this.Filterable.Enabled;
        if (nullable.HasValue)
          dictionary["filterable"] = (object) this.Filterable.Enabled;
      }
      if (this.Height.HasValue)
        dictionary["height"] = (object) this.Height;
      Dictionary<string, object> source6 = this.Messages.Serialize();
      if (source6.Any<KeyValuePair<string, object>>())
        dictionary["messages"] = (object) source6;
      nullable = this.Navigatable;
      if (nullable.HasValue)
        dictionary["navigatable"] = (object) this.Navigatable;
      Dictionary<string, object> source7 = this.Pageable.Serialize();
      if (source7.Any<KeyValuePair<string, object>>())
      {
        dictionary["pageable"] = (object) source7;
      }
      else
      {
        nullable = this.Pageable.Enabled;
        if (nullable.HasValue)
          dictionary["pageable"] = (object) this.Pageable.Enabled;
      }
      Dictionary<string, object> source8 = this.Pdf.Serialize();
      if (source8.Any<KeyValuePair<string, object>>())
        dictionary["pdf"] = (object) source8;
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
      Dictionary<string, object> source9 = this.Search.Serialize();
      if (source9.Any<KeyValuePair<string, object>>())
        dictionary["search"] = (object) source9;
      Dictionary<string, object> source10 = this.Sortable.Serialize();
      if (source10.Any<KeyValuePair<string, object>>())
      {
        dictionary["sortable"] = (object) source10;
      }
      else
      {
        nullable = this.Sortable.Enabled;
        if (nullable.HasValue)
          dictionary["sortable"] = (object) this.Sortable.Enabled;
      }
      IEnumerable<Dictionary<string, object>> source11 = this.Toolbar.Select<TreeListToolbar<T>, Dictionary<string, object>>((Func<TreeListToolbar<T>, Dictionary<string, object>>) (i => i.Serialize()));
      if (source11.Any<Dictionary<string, object>>())
        dictionary["toolbar"] = (object) source11;
      return dictionary;
    }
  }
}
