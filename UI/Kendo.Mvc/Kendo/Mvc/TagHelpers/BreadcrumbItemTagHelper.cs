// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.BreadcrumbItemTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("kendo-breadcrumb-item", ParentTag = "kendo-breadcrumb-items", TagStructure = TagStructure.NormalOrSelfClosing)]
  [SuppressTagRendering]
  public class BreadcrumbItemTagHelper : TagHelperCollectionItemBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      System.Type type = typeof (BreadcrumbItemsTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as BreadcrumbItemsTagHelper).Add(this);
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Href { get; set; }

    public string Text { get; set; }

    public string Icon { get; set; }

    public string ItemClass { get; set; }

    public string LinkClass { get; set; }

    public string IconClass { get; set; }

    public bool? ShowIcon { get; set; }

    public bool? ShowText { get; set; }

    public BreadcrumbItemType? Type { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = new Dictionary<string, object>();
      string href = this.Href;
      if ((href != null ? (href.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["href"] = (object) this.Href;
      string text = this.Text;
      if ((text != null ? (text.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["text"] = (object) this.Text;
      string icon = this.Icon;
      if ((icon != null ? (icon.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["icon"] = (object) this.Icon;
      string itemClass = this.ItemClass;
      if ((itemClass != null ? (itemClass.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["itemClass"] = (object) this.ItemClass;
      string linkClass = this.LinkClass;
      if ((linkClass != null ? (linkClass.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["linkClass"] = (object) this.LinkClass;
      string iconClass = this.IconClass;
      if ((iconClass != null ? (iconClass.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["iconClass"] = (object) this.IconClass;
      bool? nullable = this.ShowIcon;
      if (nullable.HasValue)
        dictionary1["showIcon"] = (object) this.ShowIcon;
      nullable = this.ShowText;
      if (nullable.HasValue)
        dictionary1["showText"] = (object) this.ShowText;
      BreadcrumbItemType? type = this.Type;
      if (type.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        type = this.Type;
        ref BreadcrumbItemType? local = ref type;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["type"] = (object) str;
      }
      return dictionary1;
    }
  }
}
