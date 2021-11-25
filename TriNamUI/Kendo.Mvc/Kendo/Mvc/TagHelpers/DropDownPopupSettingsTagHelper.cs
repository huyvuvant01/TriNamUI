// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.DropDownPopupSettingsTagHelper
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
  [SuppressTagRendering]
  public class DropDownPopupSettingsTagHelper : TagHelperChildBase
  {
    public 
    #nullable disable
    string Anchor { get; set; }

    public string AppendTo { get; set; }

    public string Collision { get; set; }

    public string Origin { get; set; }

    public string Position { get; set; }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (DropDownBaseTagHelper);
      foreach (object obj in (IEnumerable<object>) context.Items.Values)
      {
        if (type.IsAssignableFrom(obj.GetType()))
          (context.Items[(object) obj.GetType()] as DropDownBaseTagHelper).Popup = this;
      }
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    protected Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = this.SerializeEvents();
      string anchor = this.Anchor;
      if ((anchor != null ? (anchor.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["anchor"] = (object) this.Anchor;
      string appendTo = this.AppendTo;
      if ((appendTo != null ? (appendTo.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["appendTo"] = (object) this.AppendTo;
      string collision = this.Collision;
      if ((collision != null ? (collision.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["collision"] = (object) this.Collision;
      string origin = this.Origin;
      if ((origin != null ? (origin.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["origin"] = (object) this.Origin;
      string position = this.Position;
      if ((position != null ? (position.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["position"] = (object) this.Position;
      return dictionary;
    }

    public string OnActivate { get; set; }

    public string OnClose { get; set; }

    public string OnDeactivate { get; set; }

    public string OnOpen { get; set; }

    protected Dictionary<string, object> SerializeEvents()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string onActivate = this.OnActivate;
      if ((onActivate != null ? (onActivate.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["activate"] = (object) this.CreateHandler(this.OnActivate);
      string onClose = this.OnClose;
      if ((onClose != null ? (onClose.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["close"] = (object) this.CreateHandler(this.OnClose);
      string onDeactivate = this.OnDeactivate;
      if ((onDeactivate != null ? (onDeactivate.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["deactivate"] = (object) this.CreateHandler(this.OnDeactivate);
      string onOpen = this.OnOpen;
      if ((onOpen != null ? (onOpen.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["open"] = (object) this.CreateHandler(this.OnOpen);
      return dictionary;
    }
  }
}
