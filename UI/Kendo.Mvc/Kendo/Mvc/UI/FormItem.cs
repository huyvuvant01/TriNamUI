// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.FormItem
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class FormItem
  {
    public FormItem()
    {
      this.Label = new FormItemLabelSettings();
      this.Items = new List<FormItem>();
      this.Grid = new FormGridSettings();
      this.EditorTemplateHandler = new ClientHandlerDescriptor();
    }

    public string Type { get; set; }

    public string Field { get; set; }

    public string Editor { get; set; }

    public IFormEditor EditorComponent { get; set; }

    public FormItemLabelSettings Label { get; set; }

    public string Id { get; set; }

    public string Title { get; set; }

    public string Name { get; set; }

    public string Hint { get; set; }

    public List<FormItem> Items { get; set; }

    public string EditorTemplate { get; set; }

    public string EditorTemplateId { get; set; }

    public ClientHandlerDescriptor EditorTemplateHandler { get; set; }

    public string Layout { get; set; }

    public FormGridSettings Grid { get; set; }

    public double? ColSpan { get; set; }

    public IDictionary<string, object> InputHtmlAttributes { get; set; }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.Type.HasValue())
        dictionary["type"] = (object) this.Type;
      if (this.Field.HasValue())
        dictionary["field"] = (object) this.Field;
      if (this.Editor.HasValue())
      {
        dictionary["editor"] = (object) this.Editor;
        if (this.EditorComponent != null)
          dictionary["editorOptions"] = (object) this.EditorComponent.Serialize();
      }
      Dictionary<string, object> source1 = this.Label.Serialize();
      if (source1.Any<KeyValuePair<string, object>>())
        dictionary["label"] = (object) source1;
      if (this.Id.HasValue())
        dictionary["id"] = (object) this.Id;
      if (this.Title.HasValue())
        dictionary["title"] = (object) this.Title;
      if (!string.IsNullOrEmpty(this.EditorTemplateId))
        dictionary["editor"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('#{0}').html()", (object) this.EditorTemplateId)
        };
      else if (!string.IsNullOrEmpty(this.EditorTemplate))
        dictionary["editor"] = (object) this.EditorTemplate;
      else if (this.EditorTemplateHandler.HasValue())
        dictionary["editor"] = (object) this.EditorTemplateHandler;
      if (this.Name.HasValue())
        dictionary["name"] = (object) this.Name;
      if (this.Hint.HasValue())
        dictionary["hint"] = (object) this.Hint;
      if (this.Layout.HasValue())
        dictionary["layout"] = (object) this.Layout;
      Dictionary<string, object> source2 = this.Grid.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
        dictionary["grid"] = (object) source2;
      if (this.ColSpan.HasValue)
        dictionary["colSpan"] = (object) this.ColSpan;
      IDictionary<string, object> inputHtmlAttributes = this.InputHtmlAttributes;
      if ((inputHtmlAttributes != null ? (inputHtmlAttributes.Any<KeyValuePair<string, object>>() ? 1 : 0) : 0) != 0)
        dictionary["attributes"] = (object) this.InputHtmlAttributes;
      return dictionary;
    }
  }
}
