// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.ChatToolbarSettingsTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("toolbar", ParentTag = "kendo-chat", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("buttons", new string[] {"animation"})]
  [SuppressTagRendering]
  public class ChatToolbarSettingsTagHelper : TagHelperChildBase
  {
    [HtmlAttributeNotBound]
    public 
    #nullable disable
    ChatToolbarAnimationSettingsTagHelper Animation { get; set; }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (ChatTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as ChatTagHelper).Toolbar = this;
    }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      if (this.Animation != null)
      {
        Dictionary<string, object> source = this.Animation.Serialize();
        if (source.Any<KeyValuePair<string, object>>() && (!this.Animation.Enabled.HasValue || this.Animation.Enabled.Value))
          dictionary["animation"] = (object) source;
        else if (this.Animation.Enabled.HasValue && !this.Animation.Enabled.Value)
          dictionary["animation"] = (object) this.Animation.Enabled;
      }
      return dictionary;
    }

    [HtmlAttributeNotBound]
    public ChatToolbarSettingsButtonsTagHelper Buttons { get; set; }

    public bool? Scrollable { get; set; }

    public bool? Toggleable { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.Buttons != null)
      {
        IEnumerable<Dictionary<string, object>> source = this.Buttons.Select<ChatToolbarSettingsButtonTagHelper, Dictionary<string, object>>((Func<ChatToolbarSettingsButtonTagHelper, Dictionary<string, object>>) (i => i.Serialize()));
        if (source.Any<Dictionary<string, object>>())
          dictionary["buttons"] = (object) source;
      }
      if (this.Scrollable.HasValue)
        dictionary["scrollable"] = (object) this.Scrollable;
      if (this.Toggleable.HasValue)
        dictionary["toggleable"] = (object) this.Toggleable;
      return dictionary;
    }
  }
}
