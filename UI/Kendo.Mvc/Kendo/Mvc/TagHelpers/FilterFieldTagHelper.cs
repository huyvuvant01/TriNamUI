// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.FilterFieldTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("filter-field", ParentTag = "fields", TagStructure = TagStructure.NormalOrSelfClosing)]
  [SuppressTagRendering]
  public class FilterFieldTagHelper : TagHelperCollectionItemBase
  {
    [HtmlAttributeNotBound]
    public 
    #nullable disable
    FilterOperatorsSettingsTagHelper Operators { get; set; }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      System.Type type = typeof (FilterFieldsTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as FilterFieldsTagHelper).Add(this);
    }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      if (this.Operators != null)
      {
        Dictionary<string, object> source = this.Operators.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["operators"] = (object) source;
      }
      return dictionary;
    }

    public object DefaultValue { get; set; }

    public string EditorTemplate { get; set; }

    public string EditorTemplateId { get; set; }

    public string PreviewFormat { get; set; }

    public string Label { get; set; }

    public string Name { get; set; }

    public string Type { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.DefaultValue != null)
        dictionary["defaultValue"] = this.DefaultValue;
      if (this.EditorTemplateId.HasValue())
        dictionary["editorTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.EditorTemplateId)
        };
      else if (this.EditorTemplate.HasValue())
        dictionary["editorTemplate"] = (object) this.EditorTemplate;
      string previewFormat = this.PreviewFormat;
      if ((previewFormat != null ? (previewFormat.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["previewFormat"] = (object) this.PreviewFormat;
      string label = this.Label;
      if ((label != null ? (label.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["label"] = (object) this.Label;
      string name = this.Name;
      if ((name != null ? (name.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["name"] = (object) this.Name;
      string type = this.Type;
      if ((type != null ? (type.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["type"] = (object) this.Type;
      return dictionary;
    }
  }
}
