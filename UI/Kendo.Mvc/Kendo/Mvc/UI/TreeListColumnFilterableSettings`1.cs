// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.TreeListColumnFilterableSettings`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class TreeListColumnFilterableSettings<T> where T : class
  {
    public TreeListColumnFilterableSettings()
    {
      this.Enabled = new bool?(true);
      this.FilterUIHandler = new ClientHandlerDescriptor();
      this.CellSettings = new GridColumnFilterableCellSettings((IModelMetadataProvider) null);
    }

    public GridFilterUIRole FilterUIRole { get; set; }

    public ClientHandlerDescriptor FilterUIHandler { get; set; }

    public bool? Enabled { get; set; }

    public Kendo.Mvc.UI.TreeList<T> TreeList { get; set; }

    public GridColumnFilterableCellSettings CellSettings { get; }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.FilterUIHandler.HasValue())
        dictionary["ui"] = (object) this.FilterUIHandler;
      else if (this.FilterUIRole != GridFilterUIRole.Default)
        dictionary["ui"] = (object) Enum.GetName(typeof (GridFilterUIRole), (object) this.FilterUIRole).ToLowerInvariant();
      IDictionary<string, object> json = this.CellSettings.ToJson();
      if (json.Any<KeyValuePair<string, object>>())
        dictionary["cell"] = (object) json;
      return dictionary;
    }
  }
}
