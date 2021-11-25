// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.FileManagerMessagesDialogsUploadSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class FileManagerMessagesDialogsUploadSettings
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Title { get; set; }

    public string Clear { get; set; }

    public string Done { get; set; }

    public FileManager FileManager { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string title = this.Title;
      if ((title != null ? (title.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["title"] = (object) this.Title;
      string clear = this.Clear;
      if ((clear != null ? (clear.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["clear"] = (object) this.Clear;
      string done = this.Done;
      if ((done != null ? (done.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["done"] = (object) this.Done;
      return dictionary;
    }
  }
}
