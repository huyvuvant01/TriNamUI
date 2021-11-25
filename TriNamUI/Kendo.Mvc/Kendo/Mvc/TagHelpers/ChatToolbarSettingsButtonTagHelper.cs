// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.ChatToolbarSettingsButtonTagHelper
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
  [HtmlTargetElement("button", ParentTag = "buttons", TagStructure = TagStructure.NormalOrSelfClosing)]
  [SuppressTagRendering]
  public class ChatToolbarSettingsButtonTagHelper : TagHelperCollectionItemBase
  {
    private 
    #nullable disable
    Dictionary<string, string> Attr { get; set; }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      this.Attr = output.Attributes.ToDictionary<TagHelperAttribute, string, string>((Func<TagHelperAttribute, string>) (attr => attr.Name), (Func<TagHelperAttribute, string>) (attr => attr.Value.ToString()));
      await base.ProcessAsync(context, output);
    }

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (ChatToolbarSettingsButtonsTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as ChatToolbarSettingsButtonsTagHelper).Add(this);
    }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      if (this.Attr != null)
        dictionary["attr"] = (object) this.Attr;
      return dictionary;
    }

    public string Name { get; set; }

    public string Text { get; set; }

    public string IconClass { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string name = this.Name;
      if ((name != null ? (name.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["name"] = (object) this.Name;
      string text = this.Text;
      if ((text != null ? (text.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["text"] = (object) this.Text;
      string iconClass = this.IconClass;
      if ((iconClass != null ? (iconClass.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["iconClass"] = (object) this.IconClass;
      return dictionary;
    }
  }
}
