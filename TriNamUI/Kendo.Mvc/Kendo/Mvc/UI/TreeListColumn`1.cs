// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.TreeListColumn`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class TreeListColumn<T> where T : class
  {
    public object Editor { get; set; }

    public TreeListColumnFilterableSettings<T> Filterable { get; } = new TreeListColumnFilterableSettings<T>();

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      if (this.Editor != null)
        dictionary.Add("editor", this.Editor);
      Dictionary<string, object> source = this.Filterable.Serialize();
      if (source.Any<KeyValuePair<string, object>>())
        dictionary["filterable"] = (object) source;
      else if (this.Filterable.Enabled.HasValue)
        dictionary["filterable"] = (object) this.Filterable.Enabled;
      return dictionary;
    }

    public IDictionary<string, object> HtmlAttributes { get; set; }

    public List<TreeListColumnCommand<T>> Command { get; set; } = new List<TreeListColumnCommand<T>>();

    public ClientHandlerDescriptor Editable { get; set; }

    public bool? Encoded { get; set; }

    public bool? Expandable { get; set; }

    public string Field { get; set; }

    public string FooterTemplate { get; set; }

    public string FooterTemplateId { get; set; }

    public string Format { get; set; }

    public IDictionary<string, object> HeaderAttributes { get; set; }

    public string HeaderTemplate { get; set; }

    public string HeaderTemplateId { get; set; }

    public double? MinScreenWidth { get; set; }

    public bool? Selectable { get; set; }

    public TreeListColumnSortableSettings<T> Sortable { get; } = new TreeListColumnSortableSettings<T>();

    public string Template { get; set; }

    public string TemplateId { get; set; }

    public string Title { get; set; }

    public string Width { get; set; }

    public bool? Hidden { get; set; }

    public bool? IncludeChildren { get; set; }

    public bool? Menu { get; set; }

    public bool? Locked { get; set; }

    public bool? Lockable { get; set; }

    public Kendo.Mvc.UI.TreeList<T> TreeList { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      IDictionary<string, object> htmlAttributes = this.HtmlAttributes;
      if ((htmlAttributes != null ? (htmlAttributes.Any<KeyValuePair<string, object>>() ? 1 : 0) : 0) != 0)
        dictionary["attributes"] = (object) this.HtmlAttributes;
      IEnumerable<Dictionary<string, object>> source1 = this.Command.Select<TreeListColumnCommand<T>, Dictionary<string, object>>((Func<TreeListColumnCommand<T>, Dictionary<string, object>>) (i => i.Serialize()));
      if (source1.Any<Dictionary<string, object>>())
        dictionary["command"] = (object) source1;
      ClientHandlerDescriptor editable = this.Editable;
      if ((editable != null ? (editable.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["editable"] = (object) this.Editable;
      bool? nullable = this.Encoded;
      if (nullable.HasValue)
        dictionary["encoded"] = (object) this.Encoded;
      nullable = this.Expandable;
      if (nullable.HasValue)
        dictionary["expandable"] = (object) this.Expandable;
      string field = this.Field;
      if ((field != null ? (field.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["field"] = (object) this.Field;
      if (this.FooterTemplateId.HasValue())
        dictionary["footerTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.TreeList.IdPrefix, (object) this.FooterTemplateId)
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
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.TreeList.IdPrefix, (object) this.HeaderTemplateId)
        };
      else if (this.HeaderTemplate.HasValue())
        dictionary["headerTemplate"] = (object) this.HeaderTemplate;
      if (this.MinScreenWidth.HasValue)
        dictionary["minScreenWidth"] = (object) this.MinScreenWidth;
      nullable = this.Selectable;
      if (nullable.HasValue)
        dictionary["selectable"] = (object) this.Selectable;
      Dictionary<string, object> source2 = this.Sortable.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
      {
        dictionary["sortable"] = (object) source2;
      }
      else
      {
        nullable = this.Sortable.Enabled;
        if (nullable.HasValue)
          dictionary["sortable"] = (object) this.Sortable.Enabled;
      }
      if (this.TemplateId.HasValue())
        dictionary["template"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.TreeList.IdPrefix, (object) this.TemplateId)
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
