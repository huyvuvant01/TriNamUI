// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.TreeListPdfSettings`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class TreeListPdfSettings<T> : PdfSettings where T : class
  {
    public override Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> instance = this.SerializeSettings();
      DictionaryExtensions.Merge(instance, (IDictionary<string, object>) base.Serialize());
      return instance;
    }

    public bool? AllPages { get; set; }

    public string Author { get; set; }

    public bool? AutoPrint { get; set; }

    public bool? AvoidLinks { get; set; }

    public string Creator { get; set; }

    public DateTime? Date { get; set; }

    public string FileName { get; set; }

    public bool? ForceProxy { get; set; }

    public double? JpegQuality { get; set; }

    public bool? KeepPNG { get; set; }

    public string Keywords { get; set; }

    public bool? Landscape { get; set; }

    public string ProxyURL { get; set; }

    public string ProxyTarget { get; set; }

    public string Subject { get; set; }

    public string Title { get; set; }

    public Kendo.Mvc.UI.TreeList<T> TreeList { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.AllPages.HasValue)
        dictionary["allPages"] = (object) this.AllPages;
      string author = this.Author;
      if ((author != null ? (author.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["author"] = (object) this.Author;
      if (this.AutoPrint.HasValue)
        dictionary["autoPrint"] = (object) this.AutoPrint;
      if (this.AvoidLinks.HasValue)
        dictionary["avoidLinks"] = (object) this.AvoidLinks;
      string creator = this.Creator;
      if ((creator != null ? (creator.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["creator"] = (object) this.Creator;
      if (this.Date.HasValue)
        dictionary["date"] = (object) this.Date;
      string fileName = this.FileName;
      if ((fileName != null ? (fileName.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["fileName"] = (object) this.FileName;
      if (this.ForceProxy.HasValue)
        dictionary["forceProxy"] = (object) this.ForceProxy;
      if (this.JpegQuality.HasValue)
        dictionary["jpegQuality"] = (object) this.JpegQuality;
      if (this.KeepPNG.HasValue)
        dictionary["keepPNG"] = (object) this.KeepPNG;
      string keywords = this.Keywords;
      if ((keywords != null ? (keywords.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["keywords"] = (object) this.Keywords;
      if (this.Landscape.HasValue)
        dictionary["landscape"] = (object) this.Landscape;
      string proxyUrl = this.ProxyURL;
      if ((proxyUrl != null ? (proxyUrl.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["proxyURL"] = (object) this.ProxyURL;
      string proxyTarget = this.ProxyTarget;
      if ((proxyTarget != null ? (proxyTarget.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["proxyTarget"] = (object) this.ProxyTarget;
      string subject = this.Subject;
      if ((subject != null ? (subject.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["subject"] = (object) this.Subject;
      string title = this.Title;
      if ((title != null ? (title.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["title"] = (object) this.Title;
      return dictionary;
    }
  }
}
