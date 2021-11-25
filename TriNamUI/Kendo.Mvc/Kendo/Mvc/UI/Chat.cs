// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Chat
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class Chat : WidgetBase
  {
    public Chat(ViewContext viewContext)
      : base(viewContext)
    {
    }

    protected override void WriteHtml(TextWriter writer)
    {
      this.Generator.GenerateTag("div", this.ViewContext, this.Id, this.Name, this.HtmlAttributes).WriteTo(writer, this.HtmlEncoder);
      base.WriteHtml(writer);
    }

    public override void WriteInitializationScript(TextWriter writer)
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      writer.Write(this.Initializer.Initialize(this.Selector, nameof (Chat), (IDictionary<string, object>) dictionary));
    }

    public ChatMessagesSettings Messages { get; } = new ChatMessagesSettings();

    public ChatUserSettings User { get; } = new ChatUserSettings();

    public ChatToolbarSettings Toolbar { get; } = new ChatToolbarSettings();

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = base.SerializeSettings();
      Dictionary<string, object> source1 = this.Messages.Serialize();
      if (source1.Any<KeyValuePair<string, object>>())
        dictionary["messages"] = (object) source1;
      Dictionary<string, object> source2 = this.User.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
        dictionary["user"] = (object) source2;
      Dictionary<string, object> source3 = this.Toolbar.Serialize();
      if (source3.Any<KeyValuePair<string, object>>())
        dictionary["toolbar"] = (object) source3;
      return dictionary;
    }
  }
}
