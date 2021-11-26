// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.EditorImportSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;
using System.Net;

namespace Kendo.Mvc.UI
{
  public class EditorImportSettings : JsonObject
  {
    private readonly Editor editor;

    public EditorImportSettings(Editor editorComponent)
    {
      this.editor = editorComponent;
      this.Proxy = (INavigatable) new RequestSettings();
      this.Complete = new ClientHandlerDescriptor();
      this.Error = new ClientHandlerDescriptor();
      this.Progress = new ClientHandlerDescriptor();
      this.Select = new ClientHandlerDescriptor();
      this.Success = new ClientHandlerDescriptor();
    }

    public ClientHandlerDescriptor Complete { get; set; }

    public ClientHandlerDescriptor Error { get; set; }

    public ClientHandlerDescriptor Progress { get; set; }

    public ClientHandlerDescriptor Select { get; set; }

    public ClientHandlerDescriptor Success { get; set; }

    public INavigatable Proxy { get; set; }

    public string[] AllowedExtensions { get; set; }

    public double? MaxFileSize { get; set; }

    protected override void Serialize(IDictionary<string, object> json)
    {
      if (this.Proxy.HasValue())
      {
        Func<string, string> func = (Func<string, string>) (url => !this.editor.IsSelfInitialized ? url : WebUtility.UrlDecode(url));
        json["proxyURL"] = (object) func(this.Proxy.GenerateUrl(this.editor.ViewContext, this.editor.UrlGenerator));
      }
      if (this.AllowedExtensions != null)
        json["allowedExtensions"] = (object) this.AllowedExtensions;
      if (this.MaxFileSize.HasValue)
        json["maxFileSize"] = (object) this.MaxFileSize;
      if (this.Complete.HasValue())
        json["complete"] = (object) this.Complete;
      if (this.Error.HasValue())
        json["error"] = (object) this.Error;
      if (this.Progress.HasValue())
        json["progress"] = (object) this.Progress;
      if (this.Select.HasValue())
        json["select"] = (object) this.Select;
      if (!this.Success.HasValue())
        return;
      json["success"] = (object) this.Success;
    }
  }
}
