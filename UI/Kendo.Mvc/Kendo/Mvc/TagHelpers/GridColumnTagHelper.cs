// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.GridColumnTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.Encodings.Web;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("column", ParentTag = "columns", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("filterable", new string[] {"commands", "columns", "sortable", "groupable", "exportable"})]
  [SuppressTagRendering]
  public class GridColumnTagHelper : TagHelperCollectionItemBase
  {
    public GridColumnTagHelper()
    {
      this.HeaderHtmlAttributes = (IDictionary<string, object>) new RouteValueDictionary();
      this.HtmlAttributes = (IDictionary<string, object>) new RouteValueDictionary();
      this.FooterHtmlAttributes = (IDictionary<string, object>) new RouteValueDictionary();
    }

    private 
    #nullable disable
    GridColumnTagHelper PreviousInstance { get; set; }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      GridColumnTagHelper gridColumnTagHelper = this;
      Type type = gridColumnTagHelper.GetType();
      if (context.Items.ContainsKey((object) type))
        gridColumnTagHelper.PreviousInstance = context.Items[(object) type] as GridColumnTagHelper;
      context.Items[(object) type] = (object) gridColumnTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      gridColumnTagHelper.AddSelfToParent(context);
      context.Items[(object) type] = (object) gridColumnTagHelper.PreviousInstance;
      type = (Type) null;
    }

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type1 = typeof (GridNestedColumnsTagHelper);
      Type type2 = typeof (GridTagHelper);
      this.Grid = context.Items[(object) type2] as GridTagHelper;
      if (context.Items.ContainsKey((object) type1))
      {
        (context.Items[(object) type1] as GridNestedColumnsTagHelper).Add(this);
      }
      else
      {
        Type type3 = typeof (GridColumnsTagHelper);
        (context.Items[(object) type3] as GridColumnsTagHelper).Add(this);
      }
    }

    public string Format { get; set; }

    public bool? Groupable { get; set; }

    public GridColumnGroupableSettingsTagHelper GroupableSettings { get; set; }

    public GridTagHelper Grid { get; set; }

    public bool? Selectable { get; set; }

    public GridColumnFilterableSettingsTagHelper Filterable { get; set; }

    public GridColumnExportableSettingsTagHelper Exportable { get; set; }

    public GridColumnSortableSettingsTagHelper Sortable { get; set; }

    public bool? Sticky { get; set; }

    public bool? Stickable { get; set; }

    public string Field { get; set; }

    public string Editor { get; set; }

    public string GroupHeaderTemplate { get; set; }

    public string Editable { get; set; }

    public string Template { get; set; }

    public string FooterTemplate { get; set; }

    public string GroupFooterTemplate { get; set; }

    public bool? Encoded { get; set; }

    public string HeaderTemplate { get; set; }

    public IDictionary<string, object> HeaderHtmlAttributes { get; set; }

    public IDictionary<string, object> FooterHtmlAttributes { get; set; }

    public bool? Hidden { get; set; }

    public bool? Locked { get; set; }

    public bool? Lockable { get; set; }

    public bool? Menu { get; set; }

    public IDictionary<string, object> HtmlAttributes { get; set; }

    public string Title { get; set; }

    public bool? Visible { get; set; }

    public string Media { get; set; }

    public int MinScreenWidth { get; set; }

    public int MinResizableWidth { get; set; }

    public int Width { get; set; }

    public GridColumnCommandsTagHelper Commands { get; set; }

    public GridNestedColumnsTagHelper Columns { get; set; }

    internal virtual Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      List<string> source1 = (List<string>) null;
      if (this.Grid.Datasource != null && this.Grid.Datasource.Aggregate != null)
        source1 = this.Grid.Datasource.Aggregate.Where<DataSourceAggregateTagHelper>((Func<DataSourceAggregateTagHelper, bool>) (agg => agg.Field == this.Field)).Select<DataSourceAggregateTagHelper, string>((Func<DataSourceAggregateTagHelper, string>) (agg => agg.Aggregate.ToLowerInvariant())).ToList<string>();
      if (this.Format.HasValue())
        dictionary["format"] = (object) this.Format;
      if (this.Columns != null)
      {
        IEnumerable<Dictionary<string, object>> source2 = this.Columns.Select<GridColumnTagHelper, Dictionary<string, object>>((Func<GridColumnTagHelper, Dictionary<string, object>>) (i => i.Serialize()));
        if (source2.Any<Dictionary<string, object>>())
          dictionary["columns"] = (object) source2;
      }
      if (this.Commands != null)
      {
        IEnumerable<Dictionary<string, object>> source3 = this.Commands.Select<GridColumnCommandTagHelper, Dictionary<string, object>>((Func<GridColumnCommandTagHelper, Dictionary<string, object>>) (i => i.Serialize()));
        if (source3.Any<Dictionary<string, object>>())
          dictionary["command"] = (object) source3;
      }
      if (this.Field.HasValue())
        dictionary["field"] = (object) this.Field;
      bool? nullable = this.Groupable;
      if (nullable.HasValue)
      {
        nullable = this.Groupable;
        bool flag = true;
        if (nullable.GetValueOrDefault() == flag & nullable.HasValue)
        {
          if (this.GroupableSettings == null)
            dictionary["groupable"] = (object) this.Groupable;
          else
            this.SerializeGroupable((IDictionary<string, object>) dictionary);
        }
        else
          dictionary["groupable"] = (object) this.Groupable;
      }
      else
        this.SerializeGroupable((IDictionary<string, object>) dictionary);
      nullable = this.Selectable;
      if (nullable.HasValue)
        dictionary["selectable"] = (object) this.Selectable;
      if (this.Sortable != null)
      {
        Dictionary<string, object> source4 = this.Sortable.SerializeSettings();
        if (source4.Any<KeyValuePair<string, object>>())
        {
          nullable = this.Sortable.Enabled;
          if (nullable.HasValue)
          {
            nullable = this.Sortable.Enabled;
            if (!nullable.Value)
              goto label_26;
          }
          dictionary["sortable"] = (object) source4;
          goto label_29;
        }
label_26:
        nullable = this.Sortable.Enabled;
        if (nullable.HasValue)
        {
          nullable = this.Sortable.Enabled;
          if (!nullable.Value)
            dictionary["sortable"] = (object) this.Sortable.Enabled;
        }
      }
label_29:
      nullable = this.Sticky;
      if (nullable.HasValue)
        dictionary["sticky"] = (object) this.Sticky;
      nullable = this.Stickable;
      if (nullable.HasValue)
        dictionary["stickable"] = (object) this.Stickable;
      if (this.Filterable != null)
      {
        Dictionary<string, object> source5 = this.Filterable.SerializeSettings();
        if (source5.Any<KeyValuePair<string, object>>())
        {
          nullable = this.Filterable.Enabled;
          if (nullable.HasValue)
          {
            nullable = this.Filterable.Enabled;
            if (!nullable.Value)
              goto label_38;
          }
          dictionary["filterable"] = (object) source5;
          goto label_41;
        }
label_38:
        nullable = this.Filterable.Enabled;
        if (nullable.HasValue)
        {
          nullable = this.Filterable.Enabled;
          if (!nullable.Value)
            dictionary["filterable"] = (object) this.Filterable.Enabled;
        }
      }
label_41:
      if (this.Exportable != null)
      {
        if (!this.Exportable.Enabled)
          dictionary["exportable"] = (object) false;
        else if (!this.Exportable.Pdf || !this.Exportable.Excel)
          dictionary["exportable"] = (object) this.Exportable.SerializeSettings();
      }
      nullable = this.Encoded;
      if (nullable.HasValue)
        dictionary["encoded"] = (object) this.Encoded;
      if (this.Editor.HasValue())
        dictionary["editor"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = this.Editor
        };
      if (this.GroupHeaderTemplate.HasValue())
        dictionary["groupHeaderTemplate"] = (object) this.GroupHeaderTemplate;
      string editable = this.Editable;
      if ((editable != null ? (editable.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["editable"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = this.Editable
        };
      if (this.Title.HasValue())
        dictionary["title"] = (object) this.Title;
      if (this.HtmlAttributes.Any<KeyValuePair<string, object>>())
        dictionary["attributes"] = (object) this.EncodeAttributes(this.HtmlAttributes);
      if (this.HeaderHtmlAttributes.Any<KeyValuePair<string, object>>())
        dictionary["headerAttributes"] = (object) this.EncodeAttributes(this.HeaderHtmlAttributes);
      if (this.FooterHtmlAttributes.Any<KeyValuePair<string, object>>())
        dictionary["footerAttributes"] = (object) this.EncodeAttributes(this.FooterHtmlAttributes);
      nullable = this.Hidden;
      if (nullable.HasValue)
        dictionary["hidden"] = (object) this.Hidden;
      if (this.Width != 0)
        dictionary["width"] = (object) this.Width;
      if (this.Media.HasValue())
        dictionary["media"] = (object) this.Media;
      if (this.MinScreenWidth != 0)
        dictionary["minScreenWidth"] = (object) this.MinScreenWidth;
      if (this.MinResizableWidth != 0)
        dictionary["minResizableWidth"] = (object) this.MinResizableWidth;
      if (this.Template.HasValue())
        dictionary["template"] = (object) WebUtility.UrlDecode(this.Template);
      if (this.FooterTemplate.HasValue())
        dictionary["footerTemplate"] = (object) WebUtility.UrlDecode(this.FooterTemplate);
      if (this.HeaderTemplate.HasValue())
        dictionary["headerTemplate"] = (object) WebUtility.UrlDecode(this.HeaderTemplate);
      if (this.GroupFooterTemplate.HasValue())
        dictionary["groupFooterTemplate"] = (object) this.GroupFooterTemplate;
      nullable = this.Encoded;
      if (nullable.HasValue)
        dictionary["encoded"] = (object) this.Encoded;
      nullable = this.Locked;
      if (nullable.HasValue)
        dictionary["locked"] = (object) this.Locked;
      nullable = this.Lockable;
      if (nullable.HasValue)
        dictionary["lockable"] = (object) this.Lockable;
      nullable = this.Menu;
      if (nullable.HasValue)
        dictionary["menu"] = (object) this.Menu;
      if (source1 != null && source1.Any<string>())
        dictionary["aggregates"] = (object) source1;
      return dictionary;
    }

    private IDictionary<string, object> EncodeAttributes(
      IDictionary<string, object> htmlAttributes)
    {
      Dictionary<string, object> attributes = new Dictionary<string, object>();
      HtmlEncoder encoder = HtmlEncoder.Default;
      htmlAttributes.Each<KeyValuePair<string, object>>((Action<KeyValuePair<string, object>>) (attr =>
      {
        string str = encoder.Encode(attr.Value.ToString());
        attributes[encoder.Encode(attr.Key)] = (object) str;
      }));
      return (IDictionary<string, object>) attributes;
    }

    public void SerializeGroupable(IDictionary<string, object> settings)
    {
      if (this.GroupableSettings == null)
        return;
      Dictionary<string, object> source = this.GroupableSettings.Serialize();
      if (source.Any<KeyValuePair<string, object>>() && (!this.GroupableSettings.Enabled.HasValue || this.GroupableSettings.Enabled.Value))
      {
        settings["groupable"] = (object) source;
      }
      else
      {
        if (!this.GroupableSettings.Enabled.HasValue || this.GroupableSettings.Enabled.Value)
          return;
        settings["groupable"] = (object) this.GroupableSettings.Enabled;
      }
    }
  }
}
