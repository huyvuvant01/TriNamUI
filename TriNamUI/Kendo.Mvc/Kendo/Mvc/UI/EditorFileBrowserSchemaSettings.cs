﻿// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.EditorFileBrowserSchemaSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class EditorFileBrowserSchemaSettings
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public EditorFileBrowserSchemaModelSettings Model { get; } = new EditorFileBrowserSchemaModelSettings();

    public Editor Editor { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      Dictionary<string, object> source = this.Model.Serialize();
      if (source.Any<KeyValuePair<string, object>>())
        dictionary["model"] = (object) source;
      return dictionary;
    }
  }
}