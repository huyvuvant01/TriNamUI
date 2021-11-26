// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.BottomNavigationTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Rendering;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("kendo-bottomnavigation")]
  [RestrictChildren("bottomnavigation-items", new string[] {})]
  public class BottomNavigationTagHelper : TagHelperBase
  {
    public BottomNavigationTagHelper(
    #nullable disable
    IKendoHtmlGenerator generator)
      : base(generator)
    {
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      BottomNavigationTagHelper navigationTagHelper = this;
      context.Items[(object) navigationTagHelper.GetType()] = (object) navigationTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      // ISSUE: reference to a compiler-generated method
      await navigationTagHelper.\u003C\u003En__0(context, output);
    }

    protected override void WriteHtml(TagHelperOutput output)
    {
      this.GenerateId(output);
      TagBuilder tag = this.Generator.GenerateTag("nav", this.ViewContext, this.Id, this.Name, (IDictionary<string, object>) new Dictionary<string, object>());
      output.TagName = "nav";
      output.MergeAttributes(tag);
    }

    protected override string GetInitializationScript() => this.Initializer.Initialize(this.Selector, "BottomNavigation", (IDictionary<string, object>) this.SerializeSettings());

    public string OnSelect { get; set; }

    protected override Dictionary<string, object> SerializeEvents()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string onSelect = this.OnSelect;
      if ((onSelect != null ? (onSelect.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["select"] = (object) this.CreateHandler(this.OnSelect);
      return dictionary;
    }

    public bool? Border { get; set; }

    public bool? Shadow { get; set; }

    [HtmlAttributeNotBound]
    public BottomNavigationItemsTagHelper Items { get; set; }

    public string Template { get; set; }

    public string TemplateId { get; set; }

    public BottomNavigationFill? Fill { get; set; }

    public BottomNavigationPositionMode? PositionMode { get; set; }

    public BottomNavigationItemFlow? ItemFlow { get; set; }

    public BottomNavigationThemeColor? ThemeColor { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = base.SerializeSettings();
      if (this.Border.HasValue)
        dictionary1["border"] = (object) this.Border;
      if (this.Shadow.HasValue)
        dictionary1["shadow"] = (object) this.Shadow;
      if (this.Items != null)
      {
        IEnumerable<Dictionary<string, object>> source = this.Items.Select<BottomNavigationItemTagHelper, Dictionary<string, object>>((Func<BottomNavigationItemTagHelper, Dictionary<string, object>>) (i => i.Serialize()));
        if (source.Any<Dictionary<string, object>>())
          dictionary1["items"] = (object) source;
      }
      if (this.TemplateId.HasValue())
        dictionary1["template"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.TemplateId)
        };
      else if (this.Template.HasValue())
        dictionary1["template"] = (object) this.Template;
      if (this.Fill.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        BottomNavigationFill? fill = this.Fill;
        ref BottomNavigationFill? local = ref fill;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["fill"] = (object) str;
      }
      if (this.PositionMode.HasValue)
      {
        Dictionary<string, object> dictionary3 = dictionary1;
        BottomNavigationPositionMode? positionMode = this.PositionMode;
        ref BottomNavigationPositionMode? local = ref positionMode;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary3["positionMode"] = (object) str;
      }
      if (this.ItemFlow.HasValue)
      {
        Dictionary<string, object> dictionary4 = dictionary1;
        BottomNavigationItemFlow? itemFlow = this.ItemFlow;
        ref BottomNavigationItemFlow? local = ref itemFlow;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary4["itemFlow"] = (object) str;
      }
      if (this.ThemeColor.HasValue)
      {
        Dictionary<string, object> dictionary5 = dictionary1;
        BottomNavigationThemeColor? themeColor = this.ThemeColor;
        ref BottomNavigationThemeColor? local = ref themeColor;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary5["themeColor"] = (object) str;
      }
      return dictionary1;
    }
  }
}
