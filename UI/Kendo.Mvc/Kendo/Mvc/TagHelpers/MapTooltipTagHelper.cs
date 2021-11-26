// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.MapTooltipTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("tooltip", ParentTag = "layer", TagStructure = TagStructure.NormalOrSelfClosing)]
  [HtmlTargetElement("tooltip", ParentTag = "layer-defaults", TagStructure = TagStructure.NormalOrSelfClosing)]
  [HtmlTargetElement("tooltip", ParentTag = "marker-defaults", TagStructure = TagStructure.NormalOrSelfClosing)]
  [HtmlTargetElement("tooltip", ParentTag = "map-marker", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("popup-animation", new string[] {})]
  [SuppressTagRendering]
  public class MapTooltipTagHelper : TagHelperChildBase
  {
    public 
    #nullable disable
    string Template { get; set; }

    public MapTooltipPopupAnimationSettingsTagHelper Animation { get; set; }

    public string ContentUrl { get; set; }

    public string ContentHandler { get; set; }

    public string ContentTemplateId { get; set; }

    public bool? AutoHide { get; set; }

    public bool? Callout { get; set; }

    public string Filter { get; set; }

    public bool? Iframe { get; set; }

    public double? Height { get; set; }

    public double? Width { get; set; }

    public string Position { get; set; }

    public double? ShowAfter { get; set; }

    public string ShowOn { get; set; }

    public string Content { get; set; }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      bool? nullable;
      if (this.Animation != null)
      {
        Dictionary<string, object> source = this.Animation.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
        {
          nullable = this.Animation.Enabled;
          if (nullable.HasValue)
          {
            nullable = this.Animation.Enabled;
            if (!nullable.Value)
              goto label_5;
          }
          dictionary["animation"] = (object) source;
          goto label_8;
        }
label_5:
        nullable = this.Animation.Enabled;
        if (nullable.HasValue)
        {
          nullable = this.Animation.Enabled;
          if (nullable.Value)
            dictionary["animation"] = (object) this.Animation.Enabled;
        }
      }
label_8:
      if (this.Filter.HasValue())
        dictionary["filter"] = (object) this.Filter;
      if (this.ContentUrl.HasValue())
        dictionary["content"] = (object) new Dictionary<string, object>()
        {
          {
            "url",
            (object) this.Encode(this.ContentUrl)
          }
        };
      else if (this.ContentHandler.HasValue())
        dictionary["content"] = (object) this.CreateHandler(this.ContentHandler);
      else if (!string.IsNullOrEmpty(this.ContentTemplateId))
      {
        string str = "#";
        dictionary["content"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("kendo.template(jQuery('{0}{1}').html())", (object) str, (object) this.ContentTemplateId)
        };
      }
      if (this.Template.HasValue())
        dictionary["template"] = (object) this.Template;
      nullable = this.AutoHide;
      if (nullable.HasValue)
        dictionary["autoHide"] = (object) this.AutoHide;
      nullable = this.Callout;
      if (nullable.HasValue)
        dictionary["callout"] = (object) this.Callout;
      nullable = this.Iframe;
      if (nullable.HasValue)
        dictionary["iframe"] = (object) this.Iframe;
      if (this.Height.HasValue)
        dictionary["height"] = (object) this.Height;
      if (this.Width.HasValue)
        dictionary["width"] = (object) this.Width;
      string position = this.Position;
      if ((position != null ? (position.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["position"] = (object) this.Position;
      if (this.ShowAfter.HasValue)
        dictionary["showAfter"] = (object) this.ShowAfter;
      string showOn = this.ShowOn;
      if ((showOn != null ? (showOn.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["showOn"] = (object) this.ShowOn;
      string content = this.Content;
      if ((content != null ? (content.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["content"] = (object) this.Content;
      return dictionary;
    }

    protected override void AddSelfToParent(TagHelperContext context)
    {
      foreach (KeyValuePair<object, object> keyValuePair in (IEnumerable<KeyValuePair<object, object>>) context.Items)
        this.SetTooltip(keyValuePair.Value);
    }

    private void SetTooltip(object item)
    {
      if (!(item is IMapToolTipParent<MapTooltipTagHelper>))
        return;
      (item as IMapToolTipParent<MapTooltipTagHelper>).Tooltip = this;
    }

    private string Encode(string value)
    {
      value = Regex.Replace(value, "(%20)*%23%3D(%20)*", "#=", RegexOptions.IgnoreCase);
      value = Regex.Replace(value, "(%20)*%23(%20)*", "#", RegexOptions.IgnoreCase);
      value = Regex.Replace(value, "(%20)*%24%7B(%20)*", "${", RegexOptions.IgnoreCase);
      value = Regex.Replace(value, "(%20)*%7D(%20)*", "}", RegexOptions.IgnoreCase);
      return value;
    }
  }
}
