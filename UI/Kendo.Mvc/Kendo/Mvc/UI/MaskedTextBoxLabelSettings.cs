// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.MaskedTextBoxLabelSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class MaskedTextBoxLabelSettings
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Content { get; set; }

    public ClientHandlerDescriptor ContentHandler { get; set; }

    public bool? Floating { get; set; }

    public MaskedTextBox MaskedTextBox { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      ClientHandlerDescriptor contentHandler = this.ContentHandler;
      if ((contentHandler != null ? (contentHandler.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary["content"] = (object) this.ContentHandler;
      }
      else
      {
        string content = this.Content;
        if ((content != null ? (content.HasValue() ? 1 : 0) : 0) != 0)
          dictionary["content"] = (object) this.Content;
      }
      if (this.Floating.HasValue)
        dictionary["floating"] = (object) this.Floating;
      return dictionary;
    }
  }
}
