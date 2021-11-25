// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Sparkline`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Kendo.Mvc.UI
{
  public class Sparkline<T> : Chart<T> where T : class
  {
    public Sparkline(ViewContext viewContext)
      : base(viewContext)
    {
    }

    public IEnumerable SeriesData { get; set; }

    public SparklineType? Type { get; set; }

    protected override TagBuilder GenerateTag(TextWriter writer)
    {
      TagBuilder tag = this.Generator.GenerateTag("span", this.ViewContext, this.Id, this.Name, this.HtmlAttributes);
      tag.AddCssClass("k-sparkline");
      return tag;
    }

    public override void WriteInitializationScript(TextWriter writer)
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      this.SerializeCustomSettings((IDictionary<string, object>) dictionary);
      writer.Write(this.Initializer.Initialize(this.Selector, nameof (Sparkline<T>), (IDictionary<string, object>) dictionary));
    }

    protected override void SerializeCustomSettings(IDictionary<string, object> settings)
    {
      base.SerializeCustomSettings(settings);
      if (!this.Type.HasValue)
        return;
      IDictionary<string, object> dictionary = settings;
      SparklineType? type = this.Type;
      ref SparklineType? local = ref type;
      string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
      dictionary["type"] = (object) str;
    }

    protected override void SerializeDataSource(IDictionary<string, object> settings)
    {
      if (this.SeriesData != null)
        settings.Add("data", (object) this.SeriesData);
      else
        base.SerializeDataSource(settings);
    }

    public double? PointWidth { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = base.SerializeSettings();
      if (this.PointWidth.HasValue)
        dictionary["pointWidth"] = (object) this.PointWidth;
      return dictionary;
    }
  }
}
