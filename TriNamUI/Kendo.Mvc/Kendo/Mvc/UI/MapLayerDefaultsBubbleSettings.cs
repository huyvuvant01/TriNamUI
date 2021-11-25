// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.MapLayerDefaultsBubbleSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class MapLayerDefaultsBubbleSettings
  {
    public string SymbolName { get; set; }

    public ClientHandlerDescriptor SymbolHandler { get; set; }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      if (this.SymbolHandler != null)
        dictionary["symbol"] = (object) this.SymbolHandler;
      else if (this.SymbolName.HasValue())
        dictionary["symbol"] = (object) this.SymbolName;
      else if (this.Symbol.HasValue)
        dictionary["symbol"] = (object) this.Symbol.ToString().ToLowerInvariant();
      return dictionary;
    }

    public string Attribution { get; set; }

    public double? Opacity { get; set; }

    public double? MaxSize { get; set; }

    public double? MinSize { get; set; }

    public MapLayerDefaultsBubbleStyleSettings Style { get; } = new MapLayerDefaultsBubbleStyleSettings();

    public MapSymbol? Symbol { get; set; }

    public Map Map { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = new Dictionary<string, object>();
      string attribution = this.Attribution;
      if ((attribution != null ? (attribution.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["attribution"] = (object) this.Attribution;
      double? nullable = this.Opacity;
      if (nullable.HasValue)
        dictionary1["opacity"] = (object) this.Opacity;
      nullable = this.MaxSize;
      if (nullable.HasValue)
        dictionary1["maxSize"] = (object) this.MaxSize;
      nullable = this.MinSize;
      if (nullable.HasValue)
        dictionary1["minSize"] = (object) this.MinSize;
      Dictionary<string, object> source = this.Style.Serialize();
      if (source.Any<KeyValuePair<string, object>>())
        dictionary1["style"] = (object) source;
      MapSymbol? symbol = this.Symbol;
      if (symbol.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        symbol = this.Symbol;
        ref MapSymbol? local = ref symbol;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["symbol"] = (object) str;
      }
      return dictionary1;
    }
  }
}
