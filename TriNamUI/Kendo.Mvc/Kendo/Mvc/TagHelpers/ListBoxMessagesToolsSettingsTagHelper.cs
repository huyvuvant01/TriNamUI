// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.ListBoxMessagesToolsSettingsTagHelper
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
  [HtmlTargetElement("tools", ParentTag = "messages", TagStructure = TagStructure.WithoutEndTag)]
  [SuppressTagRendering]
  public class ListBoxMessagesToolsSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (ListBoxMessagesSettingsTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as ListBoxMessagesSettingsTagHelper).Tools = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string MoveDown { get; set; }

    public string MoveUp { get; set; }

    public string Remove { get; set; }

    public string TransferAllFrom { get; set; }

    public string TransferAllTo { get; set; }

    public string TransferFrom { get; set; }

    public string TransferTo { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string moveDown = this.MoveDown;
      if ((moveDown != null ? (moveDown.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["moveDown"] = (object) this.MoveDown;
      string moveUp = this.MoveUp;
      if ((moveUp != null ? (moveUp.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["moveUp"] = (object) this.MoveUp;
      string remove = this.Remove;
      if ((remove != null ? (remove.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["remove"] = (object) this.Remove;
      string transferAllFrom = this.TransferAllFrom;
      if ((transferAllFrom != null ? (transferAllFrom.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["transferAllFrom"] = (object) this.TransferAllFrom;
      string transferAllTo = this.TransferAllTo;
      if ((transferAllTo != null ? (transferAllTo.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["transferAllTo"] = (object) this.TransferAllTo;
      string transferFrom = this.TransferFrom;
      if ((transferFrom != null ? (transferFrom.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["transferFrom"] = (object) this.TransferFrom;
      string transferTo = this.TransferTo;
      if ((transferTo != null ? (transferTo.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["transferTo"] = (object) this.TransferTo;
      return dictionary;
    }
  }
}
