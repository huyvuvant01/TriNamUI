// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.FileManagerContextMenuSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class FileManagerContextMenuSettings
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public List<FileManagerContextMenuSettingsItem> Items { get; set; } = new List<FileManagerContextMenuSettingsItem>();

    public ClientHandlerDescriptor Close { get; set; }

    public ClientHandlerDescriptor Open { get; set; }

    public ClientHandlerDescriptor Activate { get; set; }

    public ClientHandlerDescriptor Deactivate { get; set; }

    public ClientHandlerDescriptor Select { get; set; }

    public bool? Enabled { get; set; }

    public FileManager FileManager { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      IEnumerable<Dictionary<string, object>> source = this.Items.Select<FileManagerContextMenuSettingsItem, Dictionary<string, object>>((Func<FileManagerContextMenuSettingsItem, Dictionary<string, object>>) (i => i.Serialize()));
      if (source.Any<Dictionary<string, object>>())
        dictionary["items"] = (object) source;
      ClientHandlerDescriptor close = this.Close;
      if ((close != null ? (close.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["close"] = (object) this.Close;
      ClientHandlerDescriptor open = this.Open;
      if ((open != null ? (open.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["open"] = (object) this.Open;
      ClientHandlerDescriptor activate = this.Activate;
      if ((activate != null ? (activate.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["activate"] = (object) this.Activate;
      ClientHandlerDescriptor deactivate = this.Deactivate;
      if ((deactivate != null ? (deactivate.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["deactivate"] = (object) this.Deactivate;
      ClientHandlerDescriptor select = this.Select;
      if ((select != null ? (select.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["select"] = (object) this.Select;
      return dictionary;
    }
  }
}
