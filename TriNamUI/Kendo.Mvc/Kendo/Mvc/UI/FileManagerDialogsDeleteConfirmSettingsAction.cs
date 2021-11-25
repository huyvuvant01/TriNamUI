// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.FileManagerDialogsDeleteConfirmSettingsAction
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class FileManagerDialogsDeleteConfirmSettingsAction
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Text { get; set; }

    public ClientHandlerDescriptor Action { get; set; }

    public bool? Primary { get; set; }

    public FileManager FileManager { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string text = this.Text;
      if ((text != null ? (text.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["text"] = (object) this.Text;
      ClientHandlerDescriptor action = this.Action;
      if ((action != null ? (action.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["action"] = (object) this.Action;
      if (this.Primary.HasValue)
        dictionary["primary"] = (object) this.Primary;
      return dictionary;
    }
  }
}
