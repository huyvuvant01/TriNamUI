// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.SpreadsheetPdfSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class SpreadsheetPdfSettings
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Area { get; set; }

    public string Author { get; set; }

    public bool? AutoPrint { get; set; }

    public string Creator { get; set; }

    public DateTime? Date { get; set; }

    public string FileName { get; set; }

    public bool? FitWidth { get; set; }

    public bool? ForceProxy { get; set; }

    public bool? Guidelines { get; set; }

    public bool? HCenter { get; set; }

    public double? JpegQuality { get; set; }

    public bool? KeepPNG { get; set; }

    public string Keywords { get; set; }

    public bool? Landscape { get; set; }

    public SpreadsheetPdfMarginSettings Margin { get; } = new SpreadsheetPdfMarginSettings();

    public string PaperSize { get; set; }

    public string ProxyURL { get; set; }

    public string ProxyTarget { get; set; }

    public string Subject { get; set; }

    public string Title { get; set; }

    public bool? VCenter { get; set; }

    public Spreadsheet Spreadsheet { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string area = this.Area;
      if ((area != null ? (area.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["area"] = (object) this.Area;
      string author = this.Author;
      if ((author != null ? (author.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["author"] = (object) this.Author;
      bool? nullable = this.AutoPrint;
      if (nullable.HasValue)
        dictionary["autoPrint"] = (object) this.AutoPrint;
      string creator = this.Creator;
      if ((creator != null ? (creator.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["creator"] = (object) this.Creator;
      if (this.Date.HasValue)
        dictionary["date"] = (object) this.Date;
      string fileName = this.FileName;
      if ((fileName != null ? (fileName.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["fileName"] = (object) this.FileName;
      nullable = this.FitWidth;
      if (nullable.HasValue)
        dictionary["fitWidth"] = (object) this.FitWidth;
      nullable = this.ForceProxy;
      if (nullable.HasValue)
        dictionary["forceProxy"] = (object) this.ForceProxy;
      nullable = this.Guidelines;
      if (nullable.HasValue)
        dictionary["guidelines"] = (object) this.Guidelines;
      nullable = this.HCenter;
      if (nullable.HasValue)
        dictionary["hCenter"] = (object) this.HCenter;
      if (this.JpegQuality.HasValue)
        dictionary["jpegQuality"] = (object) this.JpegQuality;
      nullable = this.KeepPNG;
      if (nullable.HasValue)
        dictionary["keepPNG"] = (object) this.KeepPNG;
      string keywords = this.Keywords;
      if ((keywords != null ? (keywords.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["keywords"] = (object) this.Keywords;
      nullable = this.Landscape;
      if (nullable.HasValue)
        dictionary["landscape"] = (object) this.Landscape;
      Dictionary<string, object> source = this.Margin.Serialize();
      if (source.Any<KeyValuePair<string, object>>())
        dictionary["margin"] = (object) source;
      string paperSize = this.PaperSize;
      if ((paperSize != null ? (paperSize.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["paperSize"] = (object) this.PaperSize;
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
      nullable = this.VCenter;
      if (nullable.HasValue)
        dictionary["vCenter"] = (object) this.VCenter;
      return dictionary;
    }
  }
}
