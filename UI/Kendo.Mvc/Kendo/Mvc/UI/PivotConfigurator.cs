// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.PivotConfigurator
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class PivotConfigurator : WidgetBase
  {
    public PivotConfigurator(ViewContext viewContext)
      : base(viewContext)
    {
    }

    public PivotConfiguratorMessages Messages { get; } = new PivotConfiguratorMessages();

    protected override void WriteHtml(TextWriter writer)
    {
      this.Generator.GenerateTag("div", this.ViewContext, this.Id, this.Name, this.HtmlAttributes).WriteTo(writer, this.HtmlEncoder);
      base.WriteHtml(writer);
    }

    public override void WriteInitializationScript(TextWriter writer)
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      IDictionary<string, object> json = this.Messages.ToJson();
      if (json.Count > 0)
        dictionary["messages"] = (object) json;
      writer.Write(this.Initializer.Initialize(this.Selector, nameof (PivotConfigurator), (IDictionary<string, object>) dictionary));
    }

    public bool? Filterable { get; set; }

    public PivotConfiguratorSortableSettings Sortable { get; } = new PivotConfiguratorSortableSettings();

    public double? Height { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = base.SerializeSettings();
      if (this.Filterable.HasValue)
        dictionary["filterable"] = (object) this.Filterable;
      Dictionary<string, object> source = this.Sortable.Serialize();
      if (source.Any<KeyValuePair<string, object>>())
        dictionary["sortable"] = (object) source;
      else if (this.Sortable.Enabled.HasValue)
        dictionary["sortable"] = (object) this.Sortable.Enabled;
      if (this.Height.HasValue)
        dictionary["height"] = (object) this.Height;
      return dictionary;
    }
  }
}
