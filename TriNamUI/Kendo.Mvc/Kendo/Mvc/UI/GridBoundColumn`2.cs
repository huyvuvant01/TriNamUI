// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.GridBoundColumn`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Resources;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.RegularExpressions;
using System.Threading;


#nullable enable
namespace Kendo.Mvc.UI
{
  public class GridBoundColumn<TModel, TValue> : 
    GridColumnBase<
    #nullable disable
    TModel>,
    IGridBoundColumn,
    IGridColumn
    where TModel : class
  {
    private static readonly IDictionary<string, Func<TModel, TValue>> expressionCache = (IDictionary<string, Func<TModel, TValue>>) new Dictionary<string, Func<TModel, TValue>>();
    private static readonly ReaderWriterLockSlim syncLock = new ReaderWriterLockSlim();

    public GridBoundColumn(Grid<TModel> grid, System.Linq.Expressions.Expression<Func<TModel, TValue>> expression)
      : base(grid)
    {
      this.Expression = !typeof (TModel).IsPlainType() || expression.IsBindable() ? expression : throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
      this.Member = expression.MemberWithoutInstance();
      this.MemberType = expression.ToMemberExpression().Type();
      string key = expression.ToString();
      Func<TModel, TValue> func;
      using (GridBoundColumn<TModel, TValue>.syncLock.ReadAndWrite())
      {
        if (!GridBoundColumn<TModel, TValue>.expressionCache.TryGetValue(key, out func))
        {
          using (GridBoundColumn<TModel, TValue>.syncLock.Write())
          {
            if (!GridBoundColumn<TModel, TValue>.expressionCache.TryGetValue(key, out func))
              GridBoundColumn<TModel, TValue>.expressionCache[key] = func = expression.Compile();
          }
        }
      }
      this.Value = func;
      if (typeof (TModel).IsPlainType())
      {
        ViewDataDictionary<TModel> viewData = new ViewDataDictionary<TModel>(this.Grid.ModelMetadataProvider, new ModelStateDictionary());
        this.Metadata = ExpressionMetadataProvider.FromLambdaExpression<TModel, TValue>(expression, viewData, this.Grid.ModelMetadataProvider).Metadata;
        this.MemberType = this.Metadata.ModelType;
        this.Title = this.Metadata.DisplayName;
        this.Format = this.Metadata.DisplayFormatString;
        this.Visible = this.Metadata.ShowForDisplay;
      }
      if (string.IsNullOrEmpty(this.Title))
        this.Title = this.Member.AsTitle();
      this.GroupableSettings = new GridBoundColumnGroupableSettings();
      this.FilterableSettings = new GridBoundColumnFilterableSettings(this.Grid.ModelMetadataProvider);
      this.FilterableSettings.Operators = this.Grid.Filterable.Operators.Clone();
      this.SortableSettings = new GridBoundColumnSortableSettings();
      this.Editable = new ClientHandlerDescriptor();
    }

    public Type MemberType { get; set; }

    public bool Groupable
    {
      get => this.Settings.Groupable;
      set => this.Settings.Groupable = value;
    }

    public GridBoundColumnGroupableSettings GroupableSettings { get; set; }

    public object AdditionalViewData { get; set; }

    public ModelMetadata Metadata { get; }

    public string EditorTemplateName { get; set; }

    public ClientHandlerDescriptor Editable { get; set; }

    public string ClientGroupHeaderTemplate
    {
      get => this.Settings.ClientGroupHeaderTemplate;
      set => this.Settings.ClientGroupHeaderTemplate = value;
    }

    public string ClientGroupHeaderColumnTemplate
    {
      get => this.Settings.ClientGroupHeaderColumnTemplate;
      set => this.Settings.ClientGroupHeaderColumnTemplate = value;
    }

    public Func<TModel, TValue> Value { get; }

    public System.Linq.Expressions.Expression<Func<TModel, TValue>> Expression { get; }

    public bool Sortable
    {
      get => this.Settings.Sortable;
      set => this.Settings.Sortable = value;
    }

    public bool Filterable
    {
      get => this.Settings.Filterable && this.FilterableSettings.Enabled;
      set
      {
        this.Settings.Filterable = value;
        this.FilterableSettings.Enabled = value;
      }
    }

    public GridBoundColumnFilterableSettings FilterableSettings { get; set; }

    public GridBoundColumnSortableSettings SortableSettings { get; set; }

    protected override void Serialize(IDictionary<string, object> json)
    {
      base.Serialize(json);
      IEnumerable<string> source = this.Grid.DataSource.Aggregates.Where<AggregateDescriptor>((Func<AggregateDescriptor, bool>) (agg => agg.Member == this.Member)).SelectMany<AggregateDescriptor, AggregateFunction>((Func<AggregateDescriptor, IEnumerable<AggregateFunction>>) (agg => (IEnumerable<AggregateFunction>) agg.Aggregates)).Select<AggregateFunction, string>((Func<AggregateFunction, string>) (agg => agg.AggregateMethodName.ToLowerInvariant()));
      json["field"] = (object) this.Member;
      if (this.Format.HasValue())
        json["format"] = (object) this.Format;
      IDictionary<string, object> json1 = this.GroupableSettings.ToJson();
      if (!this.Groupable)
        json["groupable"] = (object) false;
      else if (json1.Any<KeyValuePair<string, object>>())
        json["groupable"] = (object) json1;
      IDictionary<string, object> json2 = this.SortableSettings.ToJson();
      if (!this.Sortable)
        json["sortable"] = (object) false;
      else if (json2.Any<KeyValuePair<string, object>>())
        json["sortable"] = (object) json2;
      json["filterable"] = this.Filterable ? (object) this.FilterableSettings.ToJson() : (object) false;
      if (this.Encoded)
        json["encoded"] = (object) true;
      if (source.Any<string>())
        json["aggregates"] = (object) source;
      string str = this.EditorHtml;
      if (this.Grid.IsInClientTemplate && str != null)
        str = Regex.Replace(WebUtility.HtmlDecode(str).Trim(), "(&amp;)#([0-9]+;)", "$1\\#$2").Replace("\r\n", string.Empty).Replace("</script>", "<\\/script>").Replace("jQuery(\"#", "jQuery(\"\\#");
      if (!this.Grid.DataSource.IsReadOnly(this.Member) && this.Grid.Editable.Enabled)
        json["editor"] = (object) str;
      if (this.ClientGroupHeaderTemplate.HasValue())
        json["groupHeaderTemplate"] = (object) this.ClientGroupHeaderTemplate;
      if (this.ClientGroupHeaderColumnTemplate.HasValue())
        json["groupHeaderColumnTemplate"] = (object) this.ClientGroupHeaderColumnTemplate;
      if (this.Editable.HasValue())
        json["editable"] = (object) this.Editable;
      this.SerializeValues(json);
    }

    private void SerializeValues(IDictionary<string, object> result)
    {
      if (!(this.MemberType != (Type) null) || !this.MemberType.IsEnumType())
        return;
      Type nonNullableType = this.MemberType.GetNonNullableType();
      List<IDictionary<string, object>> dictionaryList = new List<IDictionary<string, object>>();
      Type underlyingType = Enum.GetUnderlyingType(nonNullableType);
      foreach (object obj in Enum.GetValues(nonNullableType))
      {
        Dictionary<string, object> dictionary = new Dictionary<string, object>();
        string name = Enum.GetName(nonNullableType, obj);
        MemberInfo propertyOrField = nonNullableType.FindPropertyOrField(name);
        if (propertyOrField != (MemberInfo) null)
        {
          DisplayAttribute displayAttribute = propertyOrField.GetCustomAttributes(typeof (DisplayAttribute), true).OfType<DisplayAttribute>().FirstOrDefault<DisplayAttribute>();
          if (displayAttribute != null)
            name = displayAttribute.GetName();
        }
        dictionary["value"] = Convert.ChangeType(obj, underlyingType);
        dictionary["text"] = (object) name;
        dictionaryList.Add((IDictionary<string, object>) dictionary);
      }
      result["values"] = (object) dictionaryList;
    }

    protected virtual void AppendAdditionalViewData(
      IDictionary<string, object> viewData,
      object dataItem)
    {
    }

    public string GetEditor(IHtmlHelper helper, HtmlEncoder encoder)
    {
      ViewContext viewContext = this.Grid.ViewContext.ViewContextForType<TModel>(this.Grid.ModelMetadataProvider);
      viewContext.ViewData.TemplateInfo.HtmlFieldPrefix = string.Empty;
      ((IViewContextAware) helper).Contextualize(viewContext);
      this.AppendAdditionalViewData((IDictionary<string, object>) viewContext.ViewData, (object) this.Grid.Editable.DefaultDataItem());
      StringBuilder sb = new StringBuilder();
      using (StringWriter stringWriter = new StringWriter(sb))
      {
        helper.Editor(this.Member, this.EditorTemplateName, this.AdditionalViewData).WriteTo((TextWriter) stringWriter, encoder);
        helper.ValidationMessage(this.Member).WriteTo((TextWriter) stringWriter, encoder);
      }
      return sb.ToString();
    }
  }
}
