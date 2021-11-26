// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.BottomNavigation
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class BottomNavigation : WidgetBase
  {
    public BottomNavigation(ViewContext viewContext)
      : base(viewContext)
    {
    }

    protected override void WriteHtml(TextWriter writer)
    {
      this.Generator.GenerateTag("nav", this.ViewContext, this.Id, this.Name, this.HtmlAttributes).WriteTo(writer, this.HtmlEncoder);
      base.WriteHtml(writer);
    }

    public override void WriteInitializationScript(TextWriter writer)
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      writer.Write(this.Initializer.Initialize(this.Selector, nameof (BottomNavigation), (IDictionary<string, object>) dictionary));
    }

    public bool? Border { get; set; }

    public bool? Shadow { get; set; }

    public List<BottomNavigationItem> Items { get; set; } = new List<BottomNavigationItem>();

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
      IEnumerable<Dictionary<string, object>> source = this.Items.Select<BottomNavigationItem, Dictionary<string, object>>((Func<BottomNavigationItem, Dictionary<string, object>>) (i => i.Serialize()));
      if (source.Any<Dictionary<string, object>>())
        dictionary1["items"] = (object) source;
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
