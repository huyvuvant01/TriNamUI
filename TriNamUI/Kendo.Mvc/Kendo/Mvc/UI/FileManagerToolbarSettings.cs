﻿// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.FileManagerToolbarSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class FileManagerToolbarSettings
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public List<FileManagerToolbarSettingsItem> Items { get; set; } = new List<FileManagerToolbarSettingsItem>();

    public ClientHandlerDescriptor Click { get; set; }

    public ClientHandlerDescriptor Close { get; set; }

    public ClientHandlerDescriptor Open { get; set; }

    public ClientHandlerDescriptor Toggle { get; set; }

    public ClientHandlerDescriptor OverflowClose { get; set; }

    public ClientHandlerDescriptor OverflowOpen { get; set; }

    public bool? Enabled { get; set; }

    public FileManager FileManager { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      IEnumerable<Dictionary<string, object>> source = this.Items.Select<FileManagerToolbarSettingsItem, Dictionary<string, object>>((Func<FileManagerToolbarSettingsItem, Dictionary<string, object>>) (i => i.Serialize()));
      if (source.Any<Dictionary<string, object>>())
        dictionary["items"] = (object) source;
      ClientHandlerDescriptor click = this.Click;
      if ((click != null ? (click.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["click"] = (object) this.Click;
      ClientHandlerDescriptor close = this.Close;
      if ((close != null ? (close.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["close"] = (object) this.Close;
      ClientHandlerDescriptor open = this.Open;
      if ((open != null ? (open.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["open"] = (object) this.Open;
      ClientHandlerDescriptor toggle = this.Toggle;
      if ((toggle != null ? (toggle.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["toggle"] = (object) this.Toggle;
      ClientHandlerDescriptor overflowClose = this.OverflowClose;
      if ((overflowClose != null ? (overflowClose.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["overflowClose"] = (object) this.OverflowClose;
      ClientHandlerDescriptor overflowOpen = this.OverflowOpen;
      if ((overflowOpen != null ? (overflowOpen.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["overflowOpen"] = (object) this.OverflowOpen;
      return dictionary;
    }
  }
}