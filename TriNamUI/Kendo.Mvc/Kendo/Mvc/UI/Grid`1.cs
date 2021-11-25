// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Grid`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;


#nullable enable
namespace Kendo.Mvc.UI
{
  public class Grid<T> : WidgetBase, IGridColumnContainer<
  #nullable disable
  T> where T : class
  {
    private string clientRowTemplate;
    private string clientAltRowTemplate;

    public Grid(ViewContext viewContext)
      : base(viewContext)
    {
      this.Editable = new GridEditableSettings<T>(this)
      {
        PopUp = new Window(viewContext)
        {
          Modal = true,
          Draggable = true
        }
      };
      this.DataSource = new DataSource(this.ModelMetadataProvider)
      {
        Type = new DataSourceType?(DataSourceType.Ajax)
      };
      this.DataSource.ModelType(typeof (T));
      this.ToolBar = new GridToolBarSettings((WidgetBase) this);
    }

    public DataSource DataSource { get; private set; }

    public string DataSourceId { get; set; }

    public string ClientRowTemplate
    {
      get => this.clientRowTemplate;
      set => this.clientRowTemplate = WebUtility.HtmlDecode(value);
    }

    public string ClientAltRowTemplate
    {
      get => this.clientAltRowTemplate;
      set => this.clientAltRowTemplate = WebUtility.HtmlDecode(value);
    }

    public string ClientDetailTemplateId { get; set; }

    public string Width { get; set; }

    public string Height { get; set; }

    public bool AutoGenerateColumns { get; set; } = true;

    public GridEditableSettings<T> Editable { get; }

    public GridToolBarSettings ToolBar { get; }

    public GridSelectableSettings Selectable { get; } = new GridSelectableSettings();

    public GridFilterableSettings Filterable { get; } = new GridFilterableSettings();

    public GridScrollableSettings Scrollable { get; } = new GridScrollableSettings();

    public GridPageableSettings Pageable { get; } = new GridPageableSettings();

    public GridSettings Resizable { get; } = new GridSettings();

    public GridSettings Reorderable { get; } = new GridSettings();

    public GridMessages Messages { get; } = new GridMessages();

    public IList<GridColumnBase<T>> Columns { get; } = (IList<GridColumnBase<T>>) new List<GridColumnBase<T>>();

    public IList<GridColumnBase<T>> VisibleColumns => (IList<GridColumnBase<T>>) this.Columns.Where<GridColumnBase<T>>((Func<GridColumnBase<T>, bool>) (c => c.Visible)).ToList<GridColumnBase<T>>();

    public bool EnableCustomBinding { get; set; }

    public MobileMode Mobile { get; set; }

    public override void ProcessSettings()
    {
      if (!this.Columns.Any<GridColumnBase<T>>() && this.AutoGenerateColumns)
      {
        foreach (GridColumnBase<T> column in new GridColumnGenerator<T>(this).GetColumns())
          this.Columns.Add(column);
      }
      if (!this.HtmlAttributes.ContainsKey("id"))
        this.HtmlAttributes["id"] = (object) this.Id;
      DataSourceType? type = this.DataSource.Type;
      DataSourceType dataSourceType = DataSourceType.Custom;
      if (!(type.GetValueOrDefault() == dataSourceType & type.HasValue) || this.DataSource.CustomType == "aspnetmvc-ajax")
        this.ProcessDataSource();
      if (this.Editable.Enabled)
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
      Dictionary<string, object> dictionary1 = this.SerializeSettings();
      DataSourceType? type = this.DataSource.Type;
      DataSourceType dataSourceType = DataSourceType.Server;
      bool flag = !(type.GetValueOrDefault() == dataSourceType & type.HasValue) && this.AutoBind.GetValueOrDefault(true);
      string str = "#";
      if (this.IsInClientTemplate)
        str = "\\" + str;
      IEnumerable<IDictionary<string, object>> source = this.VisibleColumns.Select<GridColumnBase<T>, IDictionary<string, object>>((Func<GridColumnBase<T>, IDictionary<string, object>>) (c => c.ToJson()));
      if (source.Any<IDictionary<string, object>>())
        dictionary1["columns"] = (object) source;
      if (this.Pageable.Enabled)
      {
        this.Pageable.AutoBind = flag;
        dictionary1["pageable"] = (object) this.Pageable.ToJson();
      }
      if (this.Selectable.Enabled)
      {
        if (this.Selectable.IgnoreOverlapped)
        {
          dictionary1["selectable"] = (object) this.Selectable.Serialize();
        }
        else
        {
          Dictionary<string, object> dictionary2 = dictionary1;
          DefaultInterpolatedStringHandler interpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 2);
          interpolatedStringHandler.AppendFormatted<GridSelectionMode>(this.Selectable.Mode);
          interpolatedStringHandler.AppendLiteral(", ");
          interpolatedStringHandler.AppendFormatted<GridSelectionType>(this.Selectable.Type);
          string stringAndClear = interpolatedStringHandler.ToStringAndClear();
          dictionary2["selectable"] = (object) stringAndClear;
        }
      }
      if (this.Filterable.Enabled)
      {
        IDictionary<string, object> json = this.Filterable.ToJson();
        dictionary1["filterable"] = json.Any<KeyValuePair<string, object>>() ? (object) json : (object) true;
      }
      IDictionary<string, object> json1 = this.Messages.ToJson();
      if (json1.Any<KeyValuePair<string, object>>())
        dictionary1["messages"] = (object) json1;
      if (this.Resizable.Enabled)
        dictionary1["resizable"] = (object) true;
      if (this.Reorderable.Enabled)
        dictionary1["reorderable"] = (object) true;
      if (!this.Scrollable.Enabled)
      {
        dictionary1["scrollable"] = (object) false;
      }
      else
      {
        IDictionary<string, object> json2 = this.Scrollable.ToJson();
        if (json2.Any<KeyValuePair<string, object>>())
          dictionary1["scrollable"] = (object) json2;
      }
      if (this.Editable.Enabled)
        dictionary1["editable"] = (object) this.Editable.ToJson();
      if (this.ToolBar.Enabled)
        dictionary1["toolbar"] = this.ToolBar.ToJson().First<KeyValuePair<string, object>>().Value;
      if (this.DataSourceId.HasValue())
        dictionary1["dataSourceId"] = (object) this.DataSourceId;
      else
        dictionary1["dataSource"] = (object) this.DataSource.ToJson();
      if (!string.IsNullOrEmpty(this.ClientDetailTemplateId))
        dictionary1["detailTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("kendo.template(jQuery('{0}{1}').html())", (object) str, (object) this.ClientDetailTemplateId)
        };
      if (!string.IsNullOrEmpty(this.ClientRowTemplate))
        dictionary1["rowTemplate"] = (object) this.ClientRowTemplate;
      if (!string.IsNullOrEmpty(this.ClientAltRowTemplate))
        dictionary1["altRowTemplate"] = (object) this.ClientAltRowTemplate;
      if (!string.IsNullOrEmpty(this.Width))
        dictionary1["width"] = (object) this.Width;
      if (!string.IsNullOrEmpty(this.Height))
        dictionary1["height"] = (object) this.Height;
      if (this.Mobile != MobileMode.Disabled)
        dictionary1["mobile"] = this.Mobile != MobileMode.Auto ? (object) this.Mobile.ToString().ToLowerInvariant() : (object) true;
      writer.Write(this.Initializer.Initialize(this.Selector, nameof (Grid<T>), (IDictionary<string, object>) dictionary1));
    }

    private string EditorForModel(
      IHtmlHelper htmlHelper,
      string templateName,
      IEnumerable<Action<IDictionary<string, object>, object>> foreignKeyData,
      object additionalViewData)
    {
      ViewContext viewContext = this.ViewContext.ViewContextForType<T>(this.ModelMetadataProvider);
      ((IViewContextAware) htmlHelper).Contextualize(viewContext);
      if (foreignKeyData != null)
      {
        T dataItem = this.Editable.DefaultDataItem();
        foreignKeyData.Each<Action<IDictionary<string, object>, object>>((Action<Action<IDictionary<string, object>, object>>) (action => action((IDictionary<string, object>) viewContext.ViewData, (object) dataItem)));
      }
      IHtmlContent htmlContent = !templateName.HasValue() ? htmlHelper.EditorForModel(additionalViewData) : htmlHelper.EditorForModel(templateName, additionalViewData);
      StringBuilder sb = new StringBuilder();
      using (StringWriter stringWriter = new StringWriter(sb))
        htmlContent.WriteTo((TextWriter) stringWriter, this.HtmlEncoder);
      return sb.ToString().Replace("editor-field", "k-edit-field").Replace("editor-label", "k-edit-label");
    }

    private void InitializeEditors()
    {
      Regex popupSlashes = new Regex("(?<=data-val-regex-pattern=\")([^\"]*)", RegexOptions.Multiline);
      T obj = this.Editable.DefaultDataItem();
      HtmlHelper<T> htmlHelper = this.ViewContext.CreateHtmlHelper<T>();
      if (this.Editable.Mode != GridEditMode.InLine && this.Editable.Mode != GridEditMode.InCell)
      {
        string input = this.EditorForModel((IHtmlHelper) htmlHelper, this.Editable.TemplateName, this.Columns.OfType<IGridForeignKeyColumn>().Select<IGridForeignKeyColumn, Action<IDictionary<string, object>, object>>((Func<IGridForeignKeyColumn, Action<IDictionary<string, object>, object>>) (c => c.SerializeSelectList)), this.Editable.AdditionalViewData);
        if (this.IsInClientTemplate)
          input = WebUtility.HtmlDecode(input);
        this.EditorHtml = popupSlashes.Replace(input, (MatchEvaluator) (match => match.Groups[0].Value.Replace("\\", this.IsInClientTemplate ? "\\\\\\\\" : "\\\\")));
      }
      else
      {
        IList<ModelFieldDescriptor> fields = this.DataSource.Schema.Model.Fields;
        bool isDynamic = obj.GetType().IsDynamicObject();
        ((IEnumerable<IGridColumn>) this.VisibleColumns).LeafColumns().OfType<IGridBoundColumn>().Each<IGridBoundColumn>((Action<IGridBoundColumn>) (column =>
        {
          ModelFieldDescriptor modelFieldDescriptor = fields.FirstOrDefault<ModelFieldDescriptor>((Func<ModelFieldDescriptor, bool>) (f => f.Member == column.Member));
          IGridForeignKeyColumn foreignKeyColumn = column as IGridForeignKeyColumn;
          if (isDynamic && modelFieldDescriptor != null && !modelFieldDescriptor.IsEditable || foreignKeyColumn != null && foreignKeyColumn.DataSource != null && !foreignKeyColumn.UseServerEditor)
            return;
          string input = column.GetEditor((IHtmlHelper) htmlHelper, this.HtmlEncoder);
          if (this.IsInClientTemplate)
            input = popupSlashes.Replace(input, (MatchEvaluator) (match => match.Groups[0].Value.Replace("\\", "\\\\")));
          column.EditorHtml = input;
        }));
      }
    }

    public string EditorHtml { get; set; }

    private void ProcessDataSource()
    {
      if (this.Pageable.Enabled && this.DataSource.PageSize == 0)
        this.DataSource.PageSize = 10;
      this.DataSource.Process(DataSourceRequestModelBinder.CreateDataSourceRequest(this.ModelMetadataProvider.GetMetadataForType(typeof (T)), this.ValueProvider, string.Empty), !this.EnableCustomBinding);
    }

    public GridAllowCopySettings<T> AllowCopy { get; } = new GridAllowCopySettings<T>();

    public bool? AutoBind { get; set; }

    public double? ColumnResizeHandleWidth { get; set; }

    public GridColumnMenuSettings<T> ColumnMenu { get; } = new GridColumnMenuSettings<T>();

    public bool? EncodeTitles { get; set; }

    public GridExcelSettings<T> Excel { get; } = new GridExcelSettings<T>();

    public GridGroupableSettings<T> Groupable { get; } = new GridGroupableSettings<T>();

    public bool? Navigatable { get; set; }

    public GridNoRecordsSettings<T> NoRecords { get; } = new GridNoRecordsSettings<T>();

    public GridPdfSettings<T> Pdf { get; } = new GridPdfSettings<T>();

    public bool? PersistSelection { get; set; }

    public GridSearchSettings<T> Search { get; } = new GridSearchSettings<T>();

    public GridSortableSettings<T> Sortable { get; } = new GridSortableSettings<T>();

    public GridLoaderType? LoaderType { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = base.SerializeSettings();
      Dictionary<string, object> source1 = this.AllowCopy.Serialize();
      if (source1.Any<KeyValuePair<string, object>>())
        dictionary1["allowCopy"] = (object) source1;
      else if (this.AllowCopy.Enabled.HasValue)
        dictionary1["allowCopy"] = (object) this.AllowCopy.Enabled;
      bool? nullable = this.AutoBind;
      if (nullable.HasValue)
        dictionary1["autoBind"] = (object) this.AutoBind;
      if (this.ColumnResizeHandleWidth.HasValue)
        dictionary1["columnResizeHandleWidth"] = (object) this.ColumnResizeHandleWidth;
      Dictionary<string, object> source2 = this.ColumnMenu.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
      {
        dictionary1["columnMenu"] = (object) source2;
      }
      else
      {
        nullable = this.ColumnMenu.Enabled;
        if (nullable.HasValue)
          dictionary1["columnMenu"] = (object) this.ColumnMenu.Enabled;
      }
      nullable = this.EncodeTitles;
      if (nullable.HasValue)
        dictionary1["encodeTitles"] = (object) this.EncodeTitles;
      Dictionary<string, object> source3 = this.Excel.Serialize();
      if (source3.Any<KeyValuePair<string, object>>())
        dictionary1["excel"] = (object) source3;
      Dictionary<string, object> source4 = this.Groupable.Serialize();
      if (source4.Any<KeyValuePair<string, object>>())
      {
        dictionary1["groupable"] = (object) source4;
      }
      else
      {
        nullable = this.Groupable.Enabled;
        if (nullable.HasValue)
          dictionary1["groupable"] = (object) this.Groupable.Enabled;
      }
      nullable = this.Navigatable;
      if (nullable.HasValue)
        dictionary1["navigatable"] = (object) this.Navigatable;
      Dictionary<string, object> source5 = this.NoRecords.Serialize();
      if (source5.Any<KeyValuePair<string, object>>())
      {
        dictionary1["noRecords"] = (object) source5;
      }
      else
      {
        nullable = this.NoRecords.Enabled;
        if (nullable.HasValue)
          dictionary1["noRecords"] = (object) this.NoRecords.Enabled;
      }
      Dictionary<string, object> source6 = this.Pdf.Serialize();
      if (source6.Any<KeyValuePair<string, object>>())
        dictionary1["pdf"] = (object) source6;
      nullable = this.PersistSelection;
      if (nullable.HasValue)
        dictionary1["persistSelection"] = (object) this.PersistSelection;
      Dictionary<string, object> source7 = this.Search.Serialize();
      if (source7.Any<KeyValuePair<string, object>>())
        dictionary1["search"] = (object) source7;
      Dictionary<string, object> source8 = this.Sortable.Serialize();
      if (source8.Any<KeyValuePair<string, object>>())
      {
        dictionary1["sortable"] = (object) source8;
      }
      else
      {
        nullable = this.Sortable.Enabled;
        if (nullable.HasValue)
          dictionary1["sortable"] = (object) this.Sortable.Enabled;
      }
      GridLoaderType? loaderType = this.LoaderType;
      if (loaderType.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        loaderType = this.LoaderType;
        ref GridLoaderType? local = ref loaderType;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["loaderType"] = (object) str;
      }
      return dictionary1;
    }
  }
}
