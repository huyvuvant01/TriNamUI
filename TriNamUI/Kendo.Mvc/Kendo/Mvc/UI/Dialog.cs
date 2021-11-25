// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Dialog
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
  public class Dialog : WidgetBase
  {
    public Dialog(ViewContext viewContext)
      : base(viewContext)
    {
      this.Modal = true;
    }

    public PopupAnimation Animation { get; } = new PopupAnimation();

    public object Title { get; set; }

    public bool Modal { get; set; }

    public string Height { get; set; }

    public string MaxHeight { get; set; }

    public string MaxWidth { get; set; }

    public string MinHeight { get; set; }

    public string MinWidth { get; set; }

    public string Width { get; set; }

    public DialogModalSettings ModalSettings { get; } = new DialogModalSettings();

    protected override void WriteHtml(TextWriter writer)
    {
      this.Generator.GenerateTag("div", this.ViewContext, this.Id, this.Name, this.HtmlAttributes).WriteTo(writer, this.HtmlEncoder);
      base.WriteHtml(writer);
    }

    public override void WriteInitializationScript(TextWriter writer)
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      IDictionary<string, object> json = this.Animation.ToJson();
      if (json.Any<KeyValuePair<string, object>>())
        dictionary["animation"] = !(json["animation"] is bool) ? json["animation"] : (object) false;
      if (this.Title != null)
        dictionary["title"] = this.Title;
      if (!this.Modal)
        dictionary["modal"] = (object) this.Modal;
      else if (this.ModalSettings != null)
      {
        Dictionary<string, object> source = this.ModalSettings.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["modal"] = (object) source;
      }
      if (!string.IsNullOrEmpty(this.Height))
        dictionary["height"] = (object) this.Height;
      if (!string.IsNullOrEmpty(this.MaxHeight))
        dictionary["maxHeight"] = (object) this.MaxHeight;
      if (!string.IsNullOrEmpty(this.MaxWidth))
        dictionary["maxWidth"] = (object) this.MaxWidth;
      if (!string.IsNullOrEmpty(this.MinHeight))
        dictionary["minHeight"] = (object) this.MinHeight;
      if (!string.IsNullOrEmpty(this.MinWidth))
        dictionary["minWidth"] = (object) this.MinWidth;
      if (!string.IsNullOrEmpty(this.Width))
        dictionary["width"] = (object) this.Width;
      writer.Write(this.Initializer.Initialize(this.Selector, nameof (Dialog), (IDictionary<string, object>) dictionary));
    }

    public List<DialogAction> Actions { get; set; } = new List<DialogAction>();

    public string ButtonLayout { get; set; }

    public bool? Closable { get; set; }

    public DialogMessagesSettings Messages { get; } = new DialogMessagesSettings();

    public bool? Visible { get; set; }

    public string Size { get; set; }

    public string Content { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = base.SerializeSettings();
      IEnumerable<Dictionary<string, object>> source1 = this.Actions.Select<DialogAction, Dictionary<string, object>>((Func<DialogAction, Dictionary<string, object>>) (i => i.Serialize()));
      if (source1.Any<Dictionary<string, object>>())
        dictionary["actions"] = (object) source1;
      string buttonLayout = this.ButtonLayout;
      if ((buttonLayout != null ? (buttonLayout.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["buttonLayout"] = (object) this.ButtonLayout;
      bool? nullable = this.Closable;
      if (nullable.HasValue)
        dictionary["closable"] = (object) this.Closable;
      Dictionary<string, object> source2 = this.Messages.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
        dictionary["messages"] = (object) source2;
      nullable = this.Visible;
      if (nullable.HasValue)
        dictionary["visible"] = (object) this.Visible;
      string size = this.Size;
      if ((size != null ? (size.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["size"] = (object) this.Size;
      string content = this.Content;
      if ((content != null ? (content.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["content"] = (object) this.Content;
      return dictionary;
    }
  }
}
