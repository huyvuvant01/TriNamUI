// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Switch
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class Switch : WidgetBase, IFormEditor
  {
    public Switch(ViewContext viewContext)
      : base(viewContext)
    {
    }

    protected override void WriteHtml(TextWriter writer)
    {
      new SwitchHtmlBuilder(this, this.Generator, this.Explorer ?? ExpressionMetadataProvider.FromStringExpression(this.Name, this.HtmlHelper.ViewData, this.HtmlHelper.MetadataProvider)).WriteHtml(writer, this.HtmlEncoder);
      base.WriteHtml(writer);
    }

    public IDictionary<string, object> Serialize() => (IDictionary<string, object>) this.SerializeSettings();

    public override void WriteInitializationScript(TextWriter writer) => writer.Write(this.Initializer.Initialize(this.Selector, nameof (Switch), this.Serialize()));

    public bool? Checked { get; set; }

    public bool? Enabled { get; set; }

    public bool? Readonly { get; set; }

    public SwitchMessagesSettings Messages { get; } = new SwitchMessagesSettings();

    public double? Width { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = base.SerializeSettings();
      if (this.Checked.HasValue)
        dictionary["checked"] = (object) this.Checked;
      if (this.Enabled.HasValue)
        dictionary["enabled"] = (object) this.Enabled;
      if (this.Readonly.HasValue)
        dictionary["readonly"] = (object) this.Readonly;
      Dictionary<string, object> source = this.Messages.Serialize();
      if (source.Any<KeyValuePair<string, object>>())
        dictionary["messages"] = (object) source;
      if (this.Width.HasValue)
        dictionary["width"] = (object) this.Width;
      return dictionary;
    }
  }
}
