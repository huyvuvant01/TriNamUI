﻿// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.EditorImageBrowserSchemaModelFieldsSizeSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class EditorImageBrowserSchemaModelFieldsSizeSettings
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Field { get; set; }

    public ClientHandlerDescriptor Parse { get; set; }

    public Editor Editor { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string field = this.Field;
      if ((field != null ? (field.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["field"] = (object) this.Field;
      ClientHandlerDescriptor parse = this.Parse;
      if ((parse != null ? (parse.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["parse"] = (object) this.Parse;
      return dictionary;
    }
  }
}
