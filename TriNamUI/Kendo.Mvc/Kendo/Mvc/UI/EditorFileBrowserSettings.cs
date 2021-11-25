// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.EditorFileBrowserSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Kendo.Mvc.UI
{
  public class EditorFileBrowserSettings
  {
    public const string DefaultFileTypes = "*.*";

    public EditorFileBrowserSettings()
    {
      this.FileTypes = "*.*";
      this.Create = new EditorFileBrowserOperation();
      this.Destroy = new EditorFileBrowserOperation();
      this.File = new EditorFileBrowserOperation();
      this.Read = new EditorFileBrowserOperation();
      this.Upload = new EditorFileBrowserOperation();
    }

    public EditorFileBrowserOperation Create { get; set; }

    public EditorFileBrowserOperation File { get; set; }

    public EditorFileBrowserOperation Destroy { get; set; }

    public EditorFileBrowserOperation Read { get; set; }

    public EditorFileBrowserOperation Upload { get; set; }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary1 = this.SerializeSettings();
      Dictionary<string, object> source1 = this.Read.Serialize();
      if (source1.Any<KeyValuePair<string, object>>())
      {
        Dictionary<string, object> dictionary2 = new Dictionary<string, object>();
        dictionary1["transport"] = (object) dictionary2;
        dictionary2["read"] = (object) source1;
        dictionary2["type"] = (object) "filebrowser-aspnetmvc";
        Dictionary<string, object> source2 = this.Create.Serialize();
        if (source2.Any<KeyValuePair<string, object>>())
          dictionary2["create"] = (object) source2;
        Dictionary<string, object> source3 = this.Destroy.Serialize();
        if (source3.Any<KeyValuePair<string, object>>())
          dictionary2["destroy"] = (object) source3;
        string url = this.File.Url;
        if (url.HasValue())
        {
          string str = Regex.Replace(Regex.Replace(url, "(%20)*%7B0(%20)*", "{0", RegexOptions.IgnoreCase), "(%20)*%7D(%20)*", "}", RegexOptions.IgnoreCase);
          dictionary2["fileUrl"] = (object) str;
        }
        Dictionary<string, object> source4 = this.Upload.Serialize();
        if (source4.Any<KeyValuePair<string, object>>())
          dictionary2["uploadUrl"] = source4["url"];
      }
      return dictionary1;
    }

    public string FileTypes { get; set; }

    public string Path { get; set; }

    public EditorFileBrowserTransportSettings Transport { get; } = new EditorFileBrowserTransportSettings();

    public EditorFileBrowserSchemaSettings Schema { get; } = new EditorFileBrowserSchemaSettings();

    public EditorFileBrowserMessagesSettings Messages { get; } = new EditorFileBrowserMessagesSettings();

    public Editor Editor { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string fileTypes = this.FileTypes;
      if ((fileTypes != null ? (fileTypes.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["fileTypes"] = (object) this.FileTypes;
      string path = this.Path;
      if ((path != null ? (path.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["path"] = (object) this.Path;
      Dictionary<string, object> source1 = this.Transport.Serialize();
      if (source1.Any<KeyValuePair<string, object>>())
        dictionary["transport"] = (object) source1;
      Dictionary<string, object> source2 = this.Schema.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
        dictionary["schema"] = (object) source2;
      Dictionary<string, object> source3 = this.Messages.Serialize();
      if (source3.Any<KeyValuePair<string, object>>())
        dictionary["messages"] = (object) source3;
      return dictionary;
    }
  }
}
