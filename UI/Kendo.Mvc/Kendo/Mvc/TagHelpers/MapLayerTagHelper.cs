// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.MapLayerTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.TagHelpers.Map;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("layer", ParentTag = "layers", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("tooltip", new string[] {"map-style", "datasource"})]
  [SuppressTagRendering]
  public class MapLayerTagHelper : 
    TagHelperCollectionItemBase,
    IDataBoundWidget<
    #nullable disable
    DataSourceTagHelper>,
    IMapToolTipParent<MapTooltipTagHelper>,
    IMapStyleParent<MapStyleSettingsTagHelper>
  {
    public MapStyleSettingsTagHelper Style { get; set; }

    public MapTooltipTagHelper Tooltip { get; set; }

    public string DatasourceId { get; set; }

    public DataSourceTagHelper Datasource { get; set; }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      System.Type type = typeof (MapLayersTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as MapLayersTagHelper).Add(this);
    }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary1 = this.SerializeSettings();
      if (this.Tooltip != null)
      {
        Dictionary<string, object> source = this.Tooltip.SerializeSettings();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["tooltip"] = (object) source;
      }
      if (this.Shape.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        MapMarkersShape? shape = this.Shape;
        ref MapMarkersShape? local = ref shape;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["shape"] = (object) str;
      }
      if (this.Style != null)
      {
        Dictionary<string, object> source = this.Style.SerializeSettings();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["style"] = (object) source;
      }
      if (this.DatasourceId.HasValue())
        dictionary1["dataSourceId"] = (object) this.DatasourceId;
      else if (this.Datasource != null)
        dictionary1["dataSource"] = (object) this.Datasource.Serialize();
      return dictionary1;
    }

    public string Attribution { get; set; }

    public bool? AutoBind { get; set; }

    public double[] Extent { get; set; }

    public string Key { get; set; }

    public string Culture { get; set; }

    public string LocationField { get; set; }

    public double? TileSize { get; set; }

    public string TitleField { get; set; }

    public double? MaxSize { get; set; }

    public double? MinSize { get; set; }

    public double? MaxZoom { get; set; }

    public double? MinZoom { get; set; }

    public double? Opacity { get; set; }

    public string[] Subdomains { get; set; }

    public string UrlTemplate { get; set; }

    public string UrlTemplateId { get; set; }

    public string ValueField { get; set; }

    public double? ZIndex { get; set; }

    public MapLayerType? Type { get; set; }

    public MapLayersImagerySet? ImagerySet { get; set; }

    public MapSymbol? Symbol { get; set; }

    public string SymbolHandler { get; set; }

    public MapMarkersShape? Shape { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = new Dictionary<string, object>();
      string attribution = this.Attribution;
      if ((attribution != null ? (attribution.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["attribution"] = (object) this.Attribution;
      if (this.AutoBind.HasValue)
        dictionary1["autoBind"] = (object) this.AutoBind;
      double[] extent = this.Extent;
      if ((extent != null ? (((IEnumerable<double>) extent).Any<double>() ? 1 : 0) : 0) != 0)
        dictionary1["extent"] = (object) this.Extent;
      string key = this.Key;
      if ((key != null ? (key.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["key"] = (object) this.Key;
      string culture = this.Culture;
      if ((culture != null ? (culture.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["culture"] = (object) this.Culture;
      string locationField = this.LocationField;
      if ((locationField != null ? (locationField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["locationField"] = (object) this.LocationField;
      double? nullable = this.TileSize;
      if (nullable.HasValue)
        dictionary1["tileSize"] = (object) this.TileSize;
      string titleField = this.TitleField;
      if ((titleField != null ? (titleField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["titleField"] = (object) this.TitleField;
      nullable = this.MaxSize;
      if (nullable.HasValue)
        dictionary1["maxSize"] = (object) this.MaxSize;
      nullable = this.MinSize;
      if (nullable.HasValue)
        dictionary1["minSize"] = (object) this.MinSize;
      nullable = this.MaxZoom;
      if (nullable.HasValue)
        dictionary1["maxZoom"] = (object) this.MaxZoom;
      nullable = this.MinZoom;
      if (nullable.HasValue)
        dictionary1["minZoom"] = (object) this.MinZoom;
      nullable = this.Opacity;
      if (nullable.HasValue)
        dictionary1["opacity"] = (object) this.Opacity;
      string[] subdomains = this.Subdomains;
      if ((subdomains != null ? (((IEnumerable<string>) subdomains).Any<string>() ? 1 : 0) : 0) != 0)
        dictionary1["subdomains"] = (object) this.Subdomains;
      if (this.UrlTemplateId.HasValue())
        dictionary1["urlTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.UrlTemplateId)
        };
      else if (this.UrlTemplate.HasValue())
        dictionary1["urlTemplate"] = (object) this.UrlTemplate;
      string valueField = this.ValueField;
      if ((valueField != null ? (valueField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["valueField"] = (object) this.ValueField;
      nullable = this.ZIndex;
      if (nullable.HasValue)
        dictionary1["zIndex"] = (object) this.ZIndex;
      MapLayerType? type = this.Type;
      if (type.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        type = this.Type;
        ref MapLayerType? local = ref type;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["type"] = (object) str;
      }
      MapLayersImagerySet? imagerySet = this.ImagerySet;
      if (imagerySet.HasValue)
      {
        Dictionary<string, object> dictionary3 = dictionary1;
        imagerySet = this.ImagerySet;
        ref MapLayersImagerySet? local = ref imagerySet;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary3["imagerySet"] = (object) str;
      }
      string symbolHandler = this.SymbolHandler;
      if ((symbolHandler != null ? (symbolHandler.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary1["symbol"] = (object) this.CreateHandler(this.SymbolHandler);
      }
      else
      {
        MapSymbol? symbol = this.Symbol;
        if (symbol.HasValue)
        {
          Dictionary<string, object> dictionary4 = dictionary1;
          symbol = this.Symbol;
          ref MapSymbol? local = ref symbol;
          string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
          dictionary4["symbol"] = (object) str;
        }
      }
      return dictionary1;
    }
  }
}
