// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.TreeListColumnTagHelper
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
  [HtmlTargetElement("treelist-column", ParentTag = "columns", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("commands", new string[] {"filterable", "sortable", "columns"})]
  [SuppressTagRendering]
  public class TreeListColumnTagHelper : TagHelperCollectionItemBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      TreeListColumnTagHelper listColumnTagHelper = this;
      Type type = listColumnTagHelper.GetType();
      if (context.Items.ContainsKey((object) type))
        listColumnTagHelper.PreviousInstance = context.Items[(object) type] as TreeListColumnTagHelper;
      context.Items[(object) type] = (object) listColumnTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      listColumnTagHelper.AddSelfToParent(context);
      context.Items[(object) type] = (object) listColumnTagHelper.PreviousInstance;
      type = (Type) null;
    }

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type1 = typeof (TreeListNestedColumnsTagHelper);
      if (context.Items.ContainsKey((object) type1))
      {
        (context.Items[(object) type1] as TreeListNestedColumnsTagHelper).Add(this);
      }
      else
      {
        Type type2 = typeof (TreeListColumnsTagHelper);
        (context.Items[(object) type2] as TreeListColumnsTagHelper).Add(this);
      }
    }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      if (this.Columns != null)
      {
        IEnumerable<Dictionary<string, object>> source = this.Columns.Select<TreeListColumnTagHelper, Dictionary<string, object>>((Func<TreeListColumnTagHelper, Dictionary<string, object>>) (i => i.Serialize()));
        if (source.Any<Dictionary<string, object>>())
          dictionary["columns"] = (object) source;
      }
      return dictionary;
    }

    public TreeListNestedColumnsTagHelper Columns { get; set; }

    private TreeListColumnTagHelper PreviousInstance { get; set; }

    public IDictionary<string, object> HtmlAttributes { get; set; }

    [HtmlAttributeNotBound]
    public TreeListColumnCommandsTagHelper Command { get; set; }

    public string Editable { get; set; }

    public string Editor { get; set; }

    public bool? Encoded { get; set; }

    public bool? Expandable { get; set; }

    public string Field { get; set; }

    [HtmlAttributeNotBound]
    public TreeListColumnFilterableSettingsTagHelper Filterable { get; set; }

    public string FooterTemplate { get; set; }

    public string FooterTemplateId { get; set; }

    public string Format { get; set; }

    public IDictionary<string, object> HeaderAttributes { get; set; }

    public string HeaderTemplate { get; set; }

    public string HeaderTemplateId { get; set; }

    public double? MinScreenWidth { get; set; }

    public bool? Selectable { get; set; }

    [HtmlAttributeNotBound]
    public TreeListColumnSortableSettingsTagHelper Sortable { get; set; }

    public string Template { get; set; }

    public string TemplateId { get; set; }

    public string Title { get; set; }

    public string Width { get; set; }

    public bool? Hidden { get; set; }

    public bool? IncludeChildren { get; set; }

    public bool? Menu { get; set; }

    public bool? Locked { get; set; }

    public bool? Lockable { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      IDictionary<string, object> htmlAttributes = this.HtmlAttributes;
      if ((htmlAttributes != null ? (htmlAttributes.Any<KeyValuePair<string, object>>() ? 1 : 0) : 0) != 0)
        dictionary["attributes"] = (object) this.HtmlAttributes;
      if (this.Command != null)
      {
        IEnumerable<Dictionary<string, object>> source = this.Command.Select<TreeListColumnCommandTagHelper, Dictionary<string, object>>((Func<TreeListColumnCommandTagHelper, Dictionary<string, object>>) (i => i.Serialize()));
        if (source.Any<Dictionary<string, object>>())
          dictionary["command"] = (object) source;
      }
      string editable = this.Editable;
      if ((editable != null ? (editable.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["editable"] = (object) this.CreateHandler(this.Editable);
      string editor = this.Editor;
      if ((editor != null ? (editor.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["editor"] = (object) this.CreateHandler(this.Editor);
      bool? nullable = this.Encoded;
      if (nullable.HasValue)
        dictionary["encoded"] = (object) this.Encoded;
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
              goto label_20;
          }
          dictionary["filterable"] = (object) source;
          goto label_23;
        }
label_20:
        nullable = this.Filterable.Enabled;
        if (nullable.HasValue)
        {
          nullable = this.Filterable.Enabled;
          if (!nullable.Value)
            dictionary["filterable"] = (object) this.Filterable.Enabled;
        }
      }
label_23:
      if (this.FooterTemplateId.HasValue())
        dictionary["footerTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.FooterTemplateId)
        };
      else if (this.FooterTemplate.HasValue())
        dictionary["footerTemplate"] = (object) this.FooterTemplate;
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
      if (this.MinScreenWidth.HasValue)
        dictionary["minScreenWidth"] = (object) this.MinScreenWidth;
      nullable = this.Selectable;
      if (nullable.HasValue)
        dictionary["selectable"] = (object) this.Selectable;
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
              goto label_44;
          }
          dictionary["sortable"] = (object) source;
          goto label_47;
        }
label_44:
        nullable = this.Sortable.Enabled;
        if (nullable.HasValue)
        {
          nullable = this.Sortable.Enabled;
          if (!nullable.Value)
            dictionary["sortable"] = (object) this.Sortable.Enabled;
        }
      }
label_47:
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
      nullable = this.Hidden;
      if (nullable.HasValue)
        dictionary["hidden"] = (object) this.Hidden;
      nullable = this.IncludeChildren;
      if (nullable.HasValue)
        dictionary["includeChildren"] = (object) this.IncludeChildren;
      nullable = this.Menu;
      if (nullable.HasValue)
        dictionary["menu"] = (object) this.Menu;
      nullable = this.Locked;
      if (nullable.HasValue)
        dictionary["locked"] = (object) this.Locked;
      nullable = this.Lockable;
      if (nullable.HasValue)
        dictionary["lockable"] = (object) this.Lockable;
      return dictionary;
    }
  }
}
