// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.EditorExportAsSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;
using System.Net;

namespace Kendo.Mvc.UI
{
  public class EditorExportAsSettings : JsonObject
  {
    private readonly Editor editor;

    public EditorExportAsSettings(Editor editorComponent)
    {
      this.editor = editorComponent;
      this.Proxy = (INavigatable) new RequestSettings();
    }

    public string FileName { get; set; }

    public INavigatable Proxy { get; set; }

    protected override void Serialize(IDictionary<string, object> json)
    {
      if (!string.IsNullOrEmpty(this.FileName))
        json["fileName"] = (object) this.FileName;
      if (!this.Proxy.HasValue())
        return;
      Func<string, string> func = (Func<string, string>) (url => !this.editor.IsSelfInitialized ? url : WebUtility.UrlDecode(url));
      json["proxyURL"] = (object) func(this.Proxy.GenerateUrl(this.editor.ViewContext, this.editor.UrlGenerator));
    }
  }
}
