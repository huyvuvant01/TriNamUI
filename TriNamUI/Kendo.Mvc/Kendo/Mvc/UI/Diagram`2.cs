// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Diagram`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI.Diagram;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


#nullable enable
namespace Kendo.Mvc.UI
{
  public class Diagram<TShapeModel, TConnectionModel> : WidgetBase
    where TShapeModel : 
    #nullable disable
    class
    where TConnectionModel : class
  {
    public Diagram(ViewContext viewContext)
      : base(viewContext)
    {
      this.DataSource = new DataSource(this.ModelMetadataProvider);
      this.DataSource.Type = new DataSourceType?(DataSourceType.Ajax);
      this.DataSource.ModelType(typeof (object));
      this.ConnectionsDataSource = new DataSource(this.ModelMetadataProvider);
      this.ConnectionsDataSource.Type = new DataSourceType?(DataSourceType.Ajax);
      this.ConnectionsDataSource.Schema.Model = (ModelDescriptor) new DiagramConnectionModelDescriptor(typeof (TConnectionModel), this.ModelMetadataProvider);
    }

    public DataSource DataSource { get; private set; }

    public DataSource ConnectionsDataSource { get; private set; }

    public string DataSourceId { get; set; }

    protected override void WriteHtml(TextWriter writer)
    {
      this.Generator.GenerateTag("div", this.ViewContext, this.Id, this.Name, this.HtmlAttributes).WriteTo(writer, this.HtmlEncoder);
      base.WriteHtml(writer);
    }

    public override void WriteInitializationScript(TextWriter writer)
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      if (string.IsNullOrEmpty(this.ConnectionsDataSource.Transport.Read.Url))
      {
        DataSourceType? type = this.ConnectionsDataSource.Type;
        DataSourceType dataSourceType = DataSourceType.Custom;
        if (!(type.GetValueOrDefault() == dataSourceType & type.HasValue))
        {
          if (this.ConnectionsDataSource.Data != null)
          {
            dictionary["connectionsDataSource"] = (object) this.ConnectionsDataSource.Data;
            goto label_5;
          }
          else
            goto label_5;
        }
      }
      dictionary["connectionsDataSource"] = (object) this.ConnectionsDataSource.ToJson();
label_5:
      this.SerializeCustomSettings((IDictionary<string, object>) dictionary);
      writer.Write(this.Initializer.Initialize(this.Selector, nameof (Diagram<TShapeModel, TConnectionModel>), (IDictionary<string, object>) dictionary));
    }

    public override void ProcessSettings()
    {
      bool? enabled = this.Editable.Enabled;
      bool flag = true;
      if (enabled.GetValueOrDefault() == flag & enabled.HasValue)
        this.InitializeShapeEditor();
      base.ProcessSettings();
    }

    protected virtual void SerializeCustomSettings(IDictionary<string, object> settings) => this.SerializeDataSource(settings);

    protected virtual void SerializeDataSource(IDictionary<string, object> settings)
    {
      if (this.DataSourceId.HasValue())
      {
        settings["dataSourceId"] = (object) this.DataSourceId;
      }
      else
      {
        if (string.IsNullOrEmpty(this.DataSource.Transport.Read.Url))
        {
          DataSourceType? type = this.DataSource.Type;
          DataSourceType dataSourceType = DataSourceType.Custom;
          if (!(type.GetValueOrDefault() == dataSourceType & type.HasValue))
          {
            if (this.DataSource.Data == null)
              return;
            settings["dataSource"] = (object) this.DataSource.Data;
            return;
          }
        }
        settings["dataSource"] = (object) this.DataSource.ToJson();
      }
    }

    private string ShapeEditorForModel(
      IHtmlHelper htmlHelper,
      string templateName,
      IEnumerable<Action<IDictionary<string, object>, object>> foreignKeyData,
      object additionalViewData)
    {
      ViewContext viewContext = this.ViewContext.ViewContextForType<TShapeModel>(this.ModelMetadataProvider);
      ((IViewContextAware) htmlHelper).Contextualize(viewContext);
      IHtmlContent htmlContent = !templateName.HasValue() ? htmlHelper.EditorForModel(additionalViewData) : htmlHelper.EditorForModel(templateName, additionalViewData);
      StringBuilder sb = new StringBuilder();
      using (StringWriter stringWriter = new StringWriter(sb))
        htmlContent.WriteTo((TextWriter) stringWriter, this.HtmlEncoder);
      return sb.ToString();
    }

    private void InitializeShapeEditor()
    {
      if (!this.Editable.ShapeTemplateName.HasValue())
        return;
      HtmlHelper<TShapeModel> htmlHelper = this.ViewContext.CreateHtmlHelper<TShapeModel>();
      Regex regex = new Regex("(?<=data-val-regex-pattern=\")([^\"]*)", RegexOptions.Multiline);
      this.Editable.ShapeEditorHtml = this.ShapeEditorForModel((IHtmlHelper) htmlHelper, this.Editable.ShapeTemplateName, (IEnumerable<Action<IDictionary<string, object>, object>>) null, (object) null);
      this.Editable.ShapeEditorHtml = regex.Replace(this.Editable.ShapeEditorHtml, (MatchEvaluator) (match => match.Groups[0].Value.Replace("\\", "\\\\")));
    }

    public bool? AutoBind { get; set; }

    public DiagramConnectionDefaultsSettings<TShapeModel, TConnectionModel> ConnectionDefaults { get; } = new DiagramConnectionDefaultsSettings<TShapeModel, TConnectionModel>();

    public List<DiagramConnection<TShapeModel, TConnectionModel>> Connections { get; set; } = new List<DiagramConnection<TShapeModel, TConnectionModel>>();

    public DiagramEditableSettings<TShapeModel, TConnectionModel> Editable { get; } = new DiagramEditableSettings<TShapeModel, TConnectionModel>();

    public DiagramLayoutSettings<TShapeModel, TConnectionModel> Layout { get; } = new DiagramLayoutSettings<TShapeModel, TConnectionModel>();

    public DiagramPannableSettings<TShapeModel, TConnectionModel> Pannable { get; } = new DiagramPannableSettings<TShapeModel, TConnectionModel>();

    public DiagramPdfSettings<TShapeModel, TConnectionModel> Pdf { get; } = new DiagramPdfSettings<TShapeModel, TConnectionModel>();

    public DiagramSelectableSettings<TShapeModel, TConnectionModel> Selectable { get; } = new DiagramSelectableSettings<TShapeModel, TConnectionModel>();

    public DiagramShapeDefaultsSettings<TShapeModel, TConnectionModel> ShapeDefaults { get; } = new DiagramShapeDefaultsSettings<TShapeModel, TConnectionModel>();

    public List<DiagramShape<TShapeModel, TConnectionModel>> Shapes { get; set; } = new List<DiagramShape<TShapeModel, TConnectionModel>>();

    public string Template { get; set; }

    public string TemplateId { get; set; }

    public string Theme { get; set; }

    public double? Zoom { get; set; }

    public double? ZoomMax { get; set; }

    public double? ZoomMin { get; set; }

    public double? ZoomRate { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = base.SerializeSettings();
      if (this.AutoBind.HasValue)
        dictionary["autoBind"] = (object) this.AutoBind;
      Dictionary<string, object> source1 = this.ConnectionDefaults.Serialize();
      if (source1.Any<KeyValuePair<string, object>>())
        dictionary["connectionDefaults"] = (object) source1;
      IEnumerable<Dictionary<string, object>> source2 = this.Connections.Select<DiagramConnection<TShapeModel, TConnectionModel>, Dictionary<string, object>>((Func<DiagramConnection<TShapeModel, TConnectionModel>, Dictionary<string, object>>) (i => i.Serialize()));
      if (source2.Any<Dictionary<string, object>>())
        dictionary["connections"] = (object) source2;
      Dictionary<string, object> source3 = this.Editable.Serialize();
      if (source3.Any<KeyValuePair<string, object>>())
        dictionary["editable"] = (object) source3;
      else if (this.Editable.Enabled.HasValue)
        dictionary["editable"] = (object) this.Editable.Enabled;
      Dictionary<string, object> source4 = this.Layout.Serialize();
      if (source4.Any<KeyValuePair<string, object>>())
        dictionary["layout"] = (object) source4;
      Dictionary<string, object> source5 = this.Pannable.Serialize();
      if (source5.Any<KeyValuePair<string, object>>())
        dictionary["pannable"] = (object) source5;
      else if (this.Pannable.Enabled.HasValue)
        dictionary["pannable"] = (object) this.Pannable.Enabled;
      Dictionary<string, object> source6 = this.Pdf.Serialize();
      if (source6.Any<KeyValuePair<string, object>>())
        dictionary["pdf"] = (object) source6;
      Dictionary<string, object> source7 = this.Selectable.Serialize();
      if (source7.Any<KeyValuePair<string, object>>())
        dictionary["selectable"] = (object) source7;
      else if (this.Selectable.Enabled.HasValue)
        dictionary["selectable"] = (object) this.Selectable.Enabled;
      Dictionary<string, object> source8 = this.ShapeDefaults.Serialize();
      if (source8.Any<KeyValuePair<string, object>>())
        dictionary["shapeDefaults"] = (object) source8;
      IEnumerable<Dictionary<string, object>> source9 = this.Shapes.Select<DiagramShape<TShapeModel, TConnectionModel>, Dictionary<string, object>>((Func<DiagramShape<TShapeModel, TConnectionModel>, Dictionary<string, object>>) (i => i.Serialize()));
      if (source9.Any<Dictionary<string, object>>())
        dictionary["shapes"] = (object) source9;
      if (this.TemplateId.HasValue())
        dictionary["template"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.TemplateId)
        };
      else if (this.Template.HasValue())
        dictionary["template"] = (object) this.Template;
      string theme = this.Theme;
      if ((theme != null ? (theme.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["theme"] = (object) this.Theme;
      if (this.Zoom.HasValue)
        dictionary["zoom"] = (object) this.Zoom;
      if (this.ZoomMax.HasValue)
        dictionary["zoomMax"] = (object) this.ZoomMax;
      if (this.ZoomMin.HasValue)
        dictionary["zoomMin"] = (object) this.ZoomMin;
      if (this.ZoomRate.HasValue)
        dictionary["zoomRate"] = (object) this.ZoomRate;
      return dictionary;
    }
  }
}
