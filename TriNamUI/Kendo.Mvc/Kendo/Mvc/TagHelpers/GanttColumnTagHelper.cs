// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.GanttColumnTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("gantt-column", ParentTag = "columns", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("filterable", new string[] {"sortable", "columns"})]
  [SuppressTagRendering]
  public class GanttColumnTagHelper : TagHelperCollectionItemBase
  {
    private 
    #nullable disable
    GanttColumnTagHelper PreviousInstance { get; set; }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      GanttColumnTagHelper ganttColumnTagHelper = this;
      Type type = ganttColumnTagHelper.GetType();
      if (context.Items.ContainsKey((object) type))
        ganttColumnTagHelper.PreviousInstance = context.Items[(object) type] as GanttColumnTagHelper;
      context.Items[(object) type] = (object) ganttColumnTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      ganttColumnTagHelper.AddSelfToParent(context);
      context.Items[(object) type] = (object) ganttColumnTagHelper.PreviousInstance;
      type = (Type) null;
    }

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (GanttNestedColumnsTagHelper);
      if (!context.Items.ContainsKey((object) type))
        type = typeof (GanttColumnsTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as GanttColumnsTagHelper).Add(this);
    }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      if (this.Columns != null)
      {
        IEnumerable<Dictionary<string, object>> source = this.Columns.Select<GanttColumnTagHelper, Dictionary<string, object>>((Func<GanttColumnTagHelper, Dictionary<string, object>>) (i => i.Serialize()));
        if (source.Any<Dictionary<string, object>>())
          dictionary["columns"] = (object) source;
      }
      if (this.Sortable != null)
      {
        Dictionary<string, object> source = this.Sortable.Serialize();
        if (source.Any<KeyValuePair<string, object>>() && (!this.Sortable.Enabled.HasValue || this.Sortable.Enabled.Value))
          dictionary["sortable"] = (object) source;
        else if (this.Sortable.Enabled.HasValue && !this.Sortable.Enabled.Value)
          dictionary["sortable"] = (object) this.Sortable.Enabled;
      }
      return dictionary;
    }

    [HtmlAttributeNotBound]
    public GanttNestedColumnsTagHelper Columns { get; set; }

    [HtmlAttributeNotBound]
    public GanttColumnSortableSettingsTagHelper Sortable { get; set; }

    public IDictionary<string, object> HtmlAttributes { get; set; }

    public bool? Editable { get; set; }

    public string Editor { get; set; }

    public bool? Expandable { get; set; }

    public string Field { get; set; }

    [HtmlAttributeNotBound]
    public GanttColumnFilterableSettingsTagHelper Filterable { get; set; }

    public string Format { get; set; }

    public IDictionary<string, object> HeaderAttributes { get; set; }

    public string HeaderTemplate { get; set; }

    public string HeaderTemplateId { get; set; }

    public bool? Hidden { get; set; }

    public bool? Menu { get; set; }

    public double? MinScreenWidth { get; set; }

    public string Template { get; set; }

    public string TemplateId { get; set; }

    public string Title { get; set; }

    public string Width { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      IDictionary<string, object> htmlAttributes = this.HtmlAttributes;
      if ((htmlAttributes != null ? (htmlAttributes.Any<KeyValuePair<string, object>>() ? 1 : 0) : 0) != 0)
        dictionary["attributes"] = (object) this.HtmlAttributes;
      bool? nullable = this.Editable;
      if (nullable.HasValue)
        dictionary["editable"] = (object) this.Editable;
      string editor = this.Editor;
      if ((editor != null ? (editor.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["editor"] = (object) this.CreateHandler(this.Editor);
      nullable = this.Expandable;
      if (nullable.HasValue)
        dictionary["expandable"] = (object) this.Expandable;
      string field = this.Field;
      if ((field != null ? (field.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["field"] = (object) this.Field;
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
              goto label_15;
          }
          dictionary["filterable"] = (object) source;
          goto label_18;
        }
label_15:
        nullable = this.Filterable.Enabled;
        if (nullable.HasValue)
        {
          nullable = this.Filterable.Enabled;
          if (!nullable.Value)
            dictionary["filterable"] = (object) this.Filterable.Enabled;
        }
      }
label_18:
      string format = this.Format;
      if ((format != null ? (format.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["format"] = (object) this.Format;
      IDictionary<string, object> headerAttributes = this.HeaderAttributes;
      if ((headerAttributes != null ? (headerAttributes.Any<KeyValuePair<string, object>>() ? 1 : 0) : 0) != 0)
        dictionary["headerAttributes"] = (object) this.HeaderAttributes;
      if (this.HeaderTemplateId.HasValue())
        dictionary["headerTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.HeaderTemplateId)
        };
      else if (this.HeaderTemplate.HasValue())
        dictionary["headerTemplate"] = (object) this.HeaderTemplate;
      nullable = this.Hidden;
      if (nullable.HasValue)
        dictionary["hidden"] = (object) this.Hidden;
      nullable = this.Menu;
      if (nullable.HasValue)
        dictionary["menu"] = (object) this.Menu;
      if (this.MinScreenWidth.HasValue)
        dictionary["minScreenWidth"] = (object) this.MinScreenWidth;
      if (this.TemplateId.HasValue())
        dictionary["template"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.TemplateId)
        };
      else if (this.Template.HasValue())
        dictionary["template"] = (object) this.Template;
      string title = this.Title;
      if ((title != null ? (title.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["title"] = (object) this.Title;
      string width = this.Width;
      if ((width != null ? (width.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["width"] = (object) this.Width;
      return dictionary;
    }
  }
}
