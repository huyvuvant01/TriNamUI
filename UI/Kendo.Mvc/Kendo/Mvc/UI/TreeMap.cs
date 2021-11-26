// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.TreeMap
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class TreeMap : WidgetBase
  {
    public TreeMap(ViewContext viewContext)
      : base(viewContext)
    {
      this.DataSource = new DataSource(this.ModelMetadataProvider);
      this.DataSource.ModelType(typeof (object));
    }

    public DataSource DataSource { get; private set; }

    public List<string[]> ColorRanges { get; set; } = new List<string[]>();

    protected override void WriteHtml(TextWriter writer)
    {
      this.Generator.GenerateTag("div", this.ViewContext, this.Id, this.Name, this.HtmlAttributes).WriteTo(writer, this.HtmlEncoder);
      base.WriteHtml(writer);
    }

    public override void WriteInitializationScript(TextWriter writer)
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      if (string.IsNullOrEmpty(this.DataSource.Transport.Read.Url))
      {
        DataSourceType? type = this.DataSource.Type;
        DataSourceType dataSourceType = DataSourceType.Custom;
        if (!(type.GetValueOrDefault() == dataSourceType & type.HasValue))
        {
          if (this.DataSource.Data != null)
          {
            dictionary["dataSource"] = (object) this.DataSource.Data;
            goto label_5;
          }
          else
            goto label_5;
        }
      }
      dictionary["dataSource"] = (object) this.DataSource.ToJson();
label_5:
      if (this.Colors == null || !((IEnumerable<string>) this.Colors).Any<string>())
      {
        List<string[]> colorRanges = this.ColorRanges;
        if ((colorRanges != null ? (colorRanges.Any<string[]>() ? 1 : 0) : 0) != 0)
          dictionary["colors"] = (object) this.ColorRanges;
      }
      writer.Write(this.Initializer.Initialize(this.Selector, nameof (TreeMap), (IDictionary<string, object>) dictionary));
    }

    public bool? AutoBind { get; set; }

    public string Theme { get; set; }

    public string ValueField { get; set; }

    public string ColorField { get; set; }

    public string TextField { get; set; }

    public string Template { get; set; }

    public string TemplateId { get; set; }

    public string[] Colors { get; set; }

    public TreeMapType? Type { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = base.SerializeSettings();
      if (this.AutoBind.HasValue)
        dictionary1["autoBind"] = (object) this.AutoBind;
      string theme = this.Theme;
      if ((theme != null ? (theme.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["theme"] = (object) this.Theme;
      string valueField = this.ValueField;
      if ((valueField != null ? (valueField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["valueField"] = (object) this.ValueField;
      string colorField = this.ColorField;
      if ((colorField != null ? (colorField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["colorField"] = (object) this.ColorField;
      string textField = this.TextField;
      if ((textField != null ? (textField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["textField"] = (object) this.TextField;
      if (this.TemplateId.HasValue())
        dictionary1["template"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.TemplateId)
        };
      else if (this.Template.HasValue())
        dictionary1["template"] = (object) this.Template;
      string[] colors = this.Colors;
      if ((colors != null ? (((IEnumerable<string>) colors).Any<string>() ? 1 : 0) : 0) != 0)
        dictionary1["colors"] = (object) this.Colors;
      if (this.Type.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        TreeMapType? type = this.Type;
        ref TreeMapType? local = ref type;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["type"] = (object) str;
      }
      return dictionary1;
    }
  }
}
