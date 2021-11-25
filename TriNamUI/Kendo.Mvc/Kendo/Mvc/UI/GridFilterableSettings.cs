// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.GridFilterableSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class GridFilterableSettings : JsonObject
  {
    public GridFilterableSettings()
    {
      this.Mode = GridFilterMode.Menu;
      this.Messages = new GridFilterableMessages();
      this.Operators = new GridFilterableOperators();
    }

    public bool Enabled { get; set; }

    public bool? Extra { get; set; }

    public GridFilterMode Mode { get; set; }

    public GridFilterableMessages Messages { get; }

    public GridFilterableOperators Operators { get; set; }

    protected override void Serialize(IDictionary<string, object> json)
    {
      if (this.Extra.HasValue)
        json["extra"] = (object) this.Extra;
      if (this.Mode == (GridFilterMode.Row | GridFilterMode.Menu))
        json["mode"] = (object) "menu, row";
      else if (this.Mode != GridFilterMode.Menu)
        json["mode"] = (object) this.Mode;
      IDictionary<string, object> json1 = this.Messages.ToJson();
      if (json1.Any<KeyValuePair<string, object>>())
        json["messages"] = (object) json1;
      IDictionary<string, object> json2 = this.Operators.ToJson();
      if (!json2.Any<KeyValuePair<string, object>>())
        return;
      json["operators"] = (object) json2;
    }
  }
}
