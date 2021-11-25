// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.TreeListEditableSettings`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class TreeListEditableSettings<T> where T : class
  {
    public TreeListEditableSettings() => this.DefaultDataItem = new Func<T>(this.CreateDefaultItem);

    public Func<T> DefaultDataItem { get; set; }

    public string EditorHtml { get; set; }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      this.SerializeEditTemplate((IDictionary<string, object>) dictionary);
      return dictionary;
    }

    private T CreateDefaultItem() => Activator.CreateInstance<T>();

    private void SerializeEditTemplate(IDictionary<string, object> options)
    {
      bool? enabled = this.Enabled;
      bool flag = true;
      if (!(enabled.GetValueOrDefault() == flag & enabled.HasValue) || !this.EditorHtml.HasValue())
        return;
      string str = this.EditorHtml.Trim().EscapeHtmlEntities().Replace("\r\n", string.Empty).Replace("jQuery(\"#", "jQuery(\"\\#");
      options["template"] = (object) str;
    }

    public TreeListEditableMoveSettings<T> Move { get; } = new TreeListEditableMoveSettings<T>();

    public string Template { get; set; }

    public string TemplateId { get; set; }

    public string TemplateName { get; set; }

    public TreeListEditMode? Mode { get; set; }

    public bool? Enabled { get; set; }

    public Kendo.Mvc.UI.TreeList<T> TreeList { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = new Dictionary<string, object>();
      Dictionary<string, object> source = this.Move.Serialize();
      if (source.Any<KeyValuePair<string, object>>())
        dictionary1["move"] = (object) source;
      else if (this.Move.Enabled.HasValue)
        dictionary1["move"] = (object) this.Move.Enabled;
      if (this.TemplateId.HasValue())
        dictionary1["template"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.TreeList.IdPrefix, (object) this.TemplateId)
        };
      else if (this.Template.HasValue())
        dictionary1["template"] = (object) this.Template;
      if (this.Mode.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        TreeListEditMode? mode = this.Mode;
        ref TreeListEditMode? local = ref mode;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["mode"] = (object) str;
      }
      return dictionary1;
    }
  }
}
