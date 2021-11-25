// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.FileManagerViewsGridSettingsColumn
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class FileManagerViewsGridSettingsColumn
  {
    public string Field { get; set; }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      if (!string.IsNullOrEmpty(this.Field))
        dictionary["field"] = (object) this.Field;
      return dictionary;
    }

    public bool? Encoded { get; set; }

    public string HeaderTemplate { get; set; }

    public string HeaderTemplateId { get; set; }

    public bool? Sortable { get; set; }

    public string Template { get; set; }

    public string TemplateId { get; set; }

    public string Title { get; set; }

    public double? Width { get; set; }

    public FileManager FileManager { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.Encoded.HasValue)
        dictionary["encoded"] = (object) this.Encoded;
      if (this.HeaderTemplateId.HasValue())
        dictionary["headerTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.FileManager.IdPrefix, (object) this.HeaderTemplateId)
        };
      else if (this.HeaderTemplate.HasValue())
        dictionary["headerTemplate"] = (object) this.HeaderTemplate;
      if (this.Sortable.HasValue)
        dictionary["sortable"] = (object) this.Sortable;
      if (this.TemplateId.HasValue())
        dictionary["template"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.FileManager.IdPrefix, (object) this.TemplateId)
        };
      else if (this.Template.HasValue())
        dictionary["template"] = (object) this.Template;
      string title = this.Title;
      if ((title != null ? (title.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["title"] = (object) this.Title;
      if (this.Width.HasValue)
        dictionary["width"] = (object) this.Width;
      return dictionary;
    }
  }
}
