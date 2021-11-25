// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.TileLayoutContainerTagHelper
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
  [HtmlTargetElement("container", ParentTag = "containers", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("container-header", new string[] {})]
  [SuppressTagRendering]
  public class TileLayoutContainerTagHelper : TagHelperCollectionItemBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (TileLayoutContainersTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as TileLayoutContainersTagHelper).Add(this);
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string BodyTemplate { get; set; }

    public string BodyTemplateId { get; set; }

    public double? ColSpan { get; set; }

    [HtmlAttributeNotBound]
    public TileLayoutContainerHeaderSettingsTagHelper Header { get; set; }

    public double? RowSpan { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.BodyTemplateId.HasValue())
        dictionary["bodyTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.BodyTemplateId)
        };
      else if (this.BodyTemplate.HasValue())
        dictionary["bodyTemplate"] = (object) this.BodyTemplate;
      if (this.ColSpan.HasValue)
        dictionary["colSpan"] = (object) this.ColSpan;
      if (this.Header != null)
      {
        Dictionary<string, object> source = this.Header.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["header"] = (object) source;
      }
      if (this.RowSpan.HasValue)
        dictionary["rowSpan"] = (object) this.RowSpan;
      return dictionary;
    }
  }
}
