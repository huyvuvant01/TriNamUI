// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Popover
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Kendo.Mvc.UI
{
  public class Popover : WidgetBase
  {
    private string container;

    public Popover(ViewContext viewContext)
      : base(viewContext)
    {
    }

    public PopupAnimation Animation { get; } = new PopupAnimation();

    public string Container
    {
      get => this.container;
      set => this.Name = this.container = value;
    }

    protected override void WriteHtml(TextWriter writer) => base.WriteHtml(writer);

    public override void WriteInitializationScript(TextWriter writer)
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      IDictionary<string, object> json = this.Animation.ToJson();
      if (json.Any<KeyValuePair<string, object>>())
        dictionary["animation"] = !(json["animation"] is bool) ? json["animation"] : (object) false;
      if (this.Filter.HasValue())
        dictionary["filter"] = (object) this.SanitizeSelector(this.Filter);
      writer.Write(this.Initializer.InitializeFor(this.Container, nameof (Popover), (IDictionary<string, object>) dictionary));
    }

    private string SanitizeSelector(string selector)
    {
      if (string.IsNullOrWhiteSpace(selector))
        return string.Empty;
      if (!this.IsInClientTemplate)
        return selector;
      StringBuilder stringBuilder = new StringBuilder(selector.Length);
      int num1 = selector.IndexOf("#=");
      int num2 = selector.LastIndexOf("#");
      if (num2 > num1 && num1 > -1)
      {
        stringBuilder.Append(selector.Substring(0, num1).Replace("#", "\\#"));
        stringBuilder.Append(selector.Substring(num1, num2 - num1 + 1));
        stringBuilder.Append(selector.Substring(num2 + 1).Replace("#", "\\#"));
      }
      else
        stringBuilder.Append(selector.Replace("#", "\\#"));
      return stringBuilder.ToString();
    }

    public List<PopoverAction> Actions { get; set; } = new List<PopoverAction>();

    public string Body { get; set; }

    public ClientHandlerDescriptor BodyHandler { get; set; }

    public string Filter { get; set; }

    public string Header { get; set; }

    public ClientHandlerDescriptor HeaderHandler { get; set; }

    public double? Height { get; set; }

    public bool? ToggleOnClick { get; set; }

    public double? Width { get; set; }

    public double? Offset { get; set; }

    public PopoverActionsLayout? ActionsLayout { get; set; }

    public PopoverPosition? Position { get; set; }

    public PopoverShowOn? ShowOn { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = base.SerializeSettings();
      IEnumerable<Dictionary<string, object>> source = this.Actions.Select<PopoverAction, Dictionary<string, object>>((Func<PopoverAction, Dictionary<string, object>>) (i => i.Serialize()));
      if (source.Any<Dictionary<string, object>>())
        dictionary1["actions"] = (object) source;
      ClientHandlerDescriptor bodyHandler = this.BodyHandler;
      if ((bodyHandler != null ? (bodyHandler.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary1["body"] = (object) this.BodyHandler;
      }
      else
      {
        string body = this.Body;
        if ((body != null ? (body.HasValue() ? 1 : 0) : 0) != 0)
          dictionary1["body"] = (object) this.Body;
      }
      ClientHandlerDescriptor headerHandler = this.HeaderHandler;
      if ((headerHandler != null ? (headerHandler.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary1["header"] = (object) this.HeaderHandler;
      }
      else
      {
        string header = this.Header;
        if ((header != null ? (header.HasValue() ? 1 : 0) : 0) != 0)
          dictionary1["header"] = (object) this.Header;
      }
      double? nullable = this.Height;
      if (nullable.HasValue)
        dictionary1["height"] = (object) this.Height;
      if (this.ToggleOnClick.HasValue)
        dictionary1["toggleOnClick"] = (object) this.ToggleOnClick;
      nullable = this.Width;
      if (nullable.HasValue)
        dictionary1["width"] = (object) this.Width;
      nullable = this.Offset;
      if (nullable.HasValue)
        dictionary1["offset"] = (object) this.Offset;
      PopoverActionsLayout? actionsLayout = this.ActionsLayout;
      if (actionsLayout.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        actionsLayout = this.ActionsLayout;
        ref PopoverActionsLayout? local = ref actionsLayout;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["actionsLayout"] = (object) str;
      }
      PopoverPosition? position = this.Position;
      if (position.HasValue)
      {
        Dictionary<string, object> dictionary3 = dictionary1;
        position = this.Position;
        ref PopoverPosition? local = ref position;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary3["position"] = (object) str;
      }
      PopoverShowOn? showOn = this.ShowOn;
      if (showOn.HasValue)
      {
        Dictionary<string, object> dictionary4 = dictionary1;
        showOn = this.ShowOn;
        ref PopoverShowOn? local = ref showOn;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary4["showOn"] = (object) str;
      }
      return dictionary1;
    }
  }
}
