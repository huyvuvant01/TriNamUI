// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.OrgChart`1
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
  public class OrgChart<T> : WidgetBase where T : class
  {
    public OrgChart(ViewContext viewContext)
      : base(viewContext)
    {
      this.DataSource = new DataSource(this.ModelMetadataProvider)
      {
        Type = new DataSourceType?(DataSourceType.Ajax)
      };
      this.DataSource.Schema.Model = (ModelDescriptor) new OrgChartModelDescriptor(typeof (T), this.ModelMetadataProvider);
    }

    public string[] CardsColors { get; set; }

    public DataSource DataSource { get; private set; }

    public string DataSourceId { get; set; }

    protected override void WriteHtml(TextWriter writer)
    {
      this.Generator.GenerateTag("div", this.ViewContext, this.Id, this.Name, this.HtmlAttributes).WriteTo(writer, this.HtmlEncoder);
      base.WriteHtml(writer);
    }

    public override void WriteInitializationScript(TextWriter writer)
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      if (this.CardsColors != null)
        dictionary["cardsColors"] = (object) this.CardsColors;
      if (string.IsNullOrEmpty(this.DataSourceId))
      {
        if (string.IsNullOrEmpty(this.DataSource.Transport.Read.Url))
        {
          DataSourceType? type = this.DataSource.Type;
          DataSourceType dataSourceType = DataSourceType.Custom;
          if (!(type.GetValueOrDefault() == dataSourceType & type.HasValue))
          {
            if (this.DataSource.Data != null)
            {
              dictionary["dataSource"] = (object) this.DataSource.Data;
              goto label_9;
            }
            else
              goto label_9;
          }
        }
        dictionary["dataSource"] = (object) this.DataSource.ToJson();
      }
      else
        dictionary["dataSourceId"] = (object) this.DataSourceId;
label_9:
      writer.Write(this.Initializer.Initialize(this.Selector, nameof (OrgChart<T>), (IDictionary<string, object>) dictionary));
    }

    public OrgChartEditableSettings<T> Editable { get; } = new OrgChartEditableSettings<T>();

    public string GroupField { get; set; }

    public string GroupHeaderTemplate { get; set; }

    public string GroupHeaderTemplateId { get; set; }

    public OrgChartMessagesSettings<T> Messages { get; } = new OrgChartMessagesSettings<T>();

    public string Template { get; set; }

    public string TemplateId { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = base.SerializeSettings();
      Dictionary<string, object> source1 = this.Editable.Serialize();
      if (source1.Any<KeyValuePair<string, object>>())
        dictionary["editable"] = (object) source1;
      else if (this.Editable.Enabled.HasValue)
        dictionary["editable"] = (object) this.Editable.Enabled;
      string groupField = this.GroupField;
      if ((groupField != null ? (groupField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["groupField"] = (object) this.GroupField;
      if (this.GroupHeaderTemplateId.HasValue())
        dictionary["groupHeaderTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.GroupHeaderTemplateId)
        };
      else if (this.GroupHeaderTemplate.HasValue())
        dictionary["groupHeaderTemplate"] = (object) this.GroupHeaderTemplate;
      Dictionary<string, object> source2 = this.Messages.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
        dictionary["messages"] = (object) source2;
      if (this.TemplateId.HasValue())
        dictionary["template"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.TemplateId)
        };
      else if (this.Template.HasValue())
        dictionary["template"] = (object) this.Template;
      return dictionary;
    }
  }
}
