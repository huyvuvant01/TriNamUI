// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.TreeListMessagesSettings`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class TreeListMessagesSettings<T> where T : class
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public TreeListMessagesCommandsSettings<T> Commands { get; } = new TreeListMessagesCommandsSettings<T>();

    public string Loading { get; set; }

    public string NoRows { get; set; }

    public string RequestFailed { get; set; }

    public string Retry { get; set; }

    public Kendo.Mvc.UI.TreeList<T> TreeList { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      Dictionary<string, object> source = this.Commands.Serialize();
      if (source.Any<KeyValuePair<string, object>>())
        dictionary["commands"] = (object) source;
      string loading = this.Loading;
      if ((loading != null ? (loading.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["loading"] = (object) this.Loading;
      string noRows = this.NoRows;
      if ((noRows != null ? (noRows.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["noRows"] = (object) this.NoRows;
      string requestFailed = this.RequestFailed;
      if ((requestFailed != null ? (requestFailed.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["requestFailed"] = (object) this.RequestFailed;
      string retry = this.Retry;
      if ((retry != null ? (retry.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["retry"] = (object) this.Retry;
      return dictionary;
    }
  }
}
