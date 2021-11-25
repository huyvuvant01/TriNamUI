// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Notification
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
  public class Notification : WidgetBase
  {
    public Notification(ViewContext viewContext)
      : base(viewContext)
    {
    }

    public IList<NotificationTemplateSettings> Templates { get; } = (IList<NotificationTemplateSettings>) new List<NotificationTemplateSettings>();

    public PopupAnimation Animation { get; } = new PopupAnimation();

    public string Tag { get; set; } = "span";

    protected override void WriteHtml(TextWriter writer)
    {
      this.Generator.GenerateTag(this.Tag, this.ViewContext, this.Id, this.Name, this.HtmlAttributes).WriteTo(writer, this.HtmlEncoder);
      base.WriteHtml(writer);
    }

    public override void WriteInitializationScript(TextWriter writer)
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      IDictionary<string, object> json = this.Animation.ToJson();
      if (json.Any<KeyValuePair<string, object>>())
        dictionary["animation"] = !(json["animation"] is bool) ? json["animation"] : (object) false;
      if (this.Templates.Any<NotificationTemplateSettings>())
        dictionary["templates"] = (object) this.Templates.Select<NotificationTemplateSettings, IDictionary<string, object>>((Func<NotificationTemplateSettings, IDictionary<string, object>>) (t => t.Serialize()));
      writer.Write(this.Initializer.Initialize(this.Selector, nameof (Notification), (IDictionary<string, object>) dictionary));
    }

    public double? AllowHideAfter { get; set; }

    public string AppendTo { get; set; }

    public double? AutoHideAfter { get; set; }

    public bool? Button { get; set; }

    public string Height { get; set; }

    public bool? HideOnClick { get; set; }

    public NotificationPositionSettings Position { get; } = new NotificationPositionSettings();

    public string Title { get; set; }

    public string Width { get; set; }

    public NotificationStackingSettings? Stacking { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = base.SerializeSettings();
      if (this.AllowHideAfter.HasValue)
        dictionary1["allowHideAfter"] = (object) this.AllowHideAfter;
      string appendTo = this.AppendTo;
      if ((appendTo != null ? (appendTo.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["appendTo"] = (object) this.AppendTo;
      if (this.AutoHideAfter.HasValue)
        dictionary1["autoHideAfter"] = (object) this.AutoHideAfter;
      if (this.Button.HasValue)
        dictionary1["button"] = (object) this.Button;
      string height = this.Height;
      if ((height != null ? (height.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["height"] = (object) this.Height;
      if (this.HideOnClick.HasValue)
        dictionary1["hideOnClick"] = (object) this.HideOnClick;
      Dictionary<string, object> source = this.Position.Serialize();
      if (source.Any<KeyValuePair<string, object>>())
        dictionary1["position"] = (object) source;
      string title = this.Title;
      if ((title != null ? (title.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["title"] = (object) this.Title;
      string width = this.Width;
      if ((width != null ? (width.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["width"] = (object) this.Width;
      if (this.Stacking.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        NotificationStackingSettings? stacking = this.Stacking;
        ref NotificationStackingSettings? local = ref stacking;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["stacking"] = (object) str;
      }
      return dictionary1;
    }
  }
}
