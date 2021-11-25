// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.GanttColumn`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class GanttColumn<TTaskModel, TDependenciesModel>
    where TTaskModel : class, IGanttTask
    where TDependenciesModel : class, IGanttDependency
  {
    public virtual Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      if (!string.IsNullOrEmpty(this.HeaderTemplateId))
        dictionary["headerTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('#{0}').html()", (object) this.HeaderTemplateId)
        };
      else if (!string.IsNullOrEmpty(this.HeaderTemplate))
        dictionary["headerTemplate"] = (object) this.HeaderTemplate;
      if (!string.IsNullOrEmpty(this.TemplateId))
        dictionary["template"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('#{0}').html()", (object) this.TemplateId)
        };
      else if (!string.IsNullOrEmpty(this.Template))
        dictionary["template"] = (object) this.Template;
      if (this.Editor != null && this.Editor.HasValue())
        dictionary["editor"] = (object) this.Editor;
      if (this.Sortable != null)
      {
        Dictionary<string, object> source = this.Sortable.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["sortable"] = (object) source;
        else if (this.Sortable.Enabled.HasValue)
          dictionary["sortable"] = (object) this.Sortable.Enabled;
      }
      return dictionary;
    }

    public ClientHandlerDescriptor Editor { get; set; }

    public string HeaderTemplate { get; set; }

    public string HeaderTemplateId { get; set; }

    public GanttColumnSortableSettings Sortable { get; set; }

    public string Template { get; set; }

    public string TemplateId { get; set; }

    public IDictionary<string, object> HtmlAttributes { get; set; }

    public bool? Editable { get; set; }

    public bool? Expandable { get; set; }

    public string Field { get; set; }

    public GanttColumnFilterableSettings<TTaskModel, TDependenciesModel> Filterable { get; } = new GanttColumnFilterableSettings<TTaskModel, TDependenciesModel>();

    public string Format { get; set; }

    public IDictionary<string, object> HeaderAttributes { get; set; }

    public bool? Hidden { get; set; }

    public bool? Menu { get; set; }

    public double? MinScreenWidth { get; set; }

    public string Title { get; set; }

    public string Width { get; set; }

    public Kendo.Mvc.UI.Gantt<TTaskModel, TDependenciesModel> Gantt { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      IDictionary<string, object> htmlAttributes = this.HtmlAttributes;
      if ((htmlAttributes != null ? (htmlAttributes.Any<KeyValuePair<string, object>>() ? 1 : 0) : 0) != 0)
        dictionary["attributes"] = (object) this.HtmlAttributes;
      bool? nullable = this.Editable;
      if (nullable.HasValue)
        dictionary["editable"] = (object) this.Editable;
      nullable = this.Expandable;
      if (nullable.HasValue)
        dictionary["expandable"] = (object) this.Expandable;
      string field = this.Field;
      if ((field != null ? (field.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["field"] = (object) this.Field;
      Dictionary<string, object> source = this.Filterable.Serialize();
      if (source.Any<KeyValuePair<string, object>>())
      {
        dictionary["filterable"] = (object) source;
      }
      else
      {
        nullable = this.Filterable.Enabled;
        if (nullable.HasValue)
          dictionary["filterable"] = (object) this.Filterable.Enabled;
      }
      string format = this.Format;
      if ((format != null ? (format.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["format"] = (object) this.Format;
      IDictionary<string, object> headerAttributes = this.HeaderAttributes;
      if ((headerAttributes != null ? (headerAttributes.Any<KeyValuePair<string, object>>() ? 1 : 0) : 0) != 0)
        dictionary["headerAttributes"] = (object) this.HeaderAttributes;
      nullable = this.Hidden;
      if (nullable.HasValue)
        dictionary["hidden"] = (object) this.Hidden;
      nullable = this.Menu;
      if (nullable.HasValue)
        dictionary["menu"] = (object) this.Menu;
      if (this.MinScreenWidth.HasValue)
        dictionary["minScreenWidth"] = (object) this.MinScreenWidth;
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
