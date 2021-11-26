// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.ActionSheetItemTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("item", ParentTag = "items", TagStructure = TagStructure.NormalOrSelfClosing)]
  [SuppressTagRendering]
  public class ActionSheetItemTagHelper : TagHelperCollectionItemBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (ActionSheetItemsTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as ActionSheetItemsTagHelper).Add(this);
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Click { get; set; }

    public string Description { get; set; }

    public bool? Disabled { get; set; }

    public string Group { get; set; }

    public string IconClass { get; set; }

    public string IconColor { get; set; }

    public double? IconSize { get; set; }

    public string Text { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string click = this.Click;
      if ((click != null ? (click.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["click"] = (object) this.CreateHandler(this.Click);
      string description = this.Description;
      if ((description != null ? (description.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["description"] = (object) this.Description;
      if (this.Disabled.HasValue)
        dictionary["disabled"] = (object) this.Disabled;
      string group = this.Group;
      if ((group != null ? (group.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["group"] = (object) this.Group;
      string iconClass = this.IconClass;
      if ((iconClass != null ? (iconClass.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["iconClass"] = (object) this.IconClass;
      string iconColor = this.IconColor;
      if ((iconColor != null ? (iconColor.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["iconColor"] = (object) this.IconColor;
      if (this.IconSize.HasValue)
        dictionary["iconSize"] = (object) this.IconSize;
      string text = this.Text;
      if ((text != null ? (text.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["text"] = (object) this.Text;
      return dictionary;
    }
  }
}
