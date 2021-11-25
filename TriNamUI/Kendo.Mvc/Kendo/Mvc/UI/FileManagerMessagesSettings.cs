// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.FileManagerMessagesSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class FileManagerMessagesSettings
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public FileManagerMessagesToolbarSettings Toolbar { get; } = new FileManagerMessagesToolbarSettings();

    public FileManagerMessagesViewsSettings Views { get; } = new FileManagerMessagesViewsSettings();

    public FileManagerMessagesDialogsSettings Dialogs { get; } = new FileManagerMessagesDialogsSettings();

    public FileManagerMessagesPreviewPaneSettings PreviewPane { get; } = new FileManagerMessagesPreviewPaneSettings();

    public FileManager FileManager { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      Dictionary<string, object> source1 = this.Toolbar.Serialize();
      if (source1.Any<KeyValuePair<string, object>>())
        dictionary["toolbar"] = (object) source1;
      Dictionary<string, object> source2 = this.Views.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
        dictionary["views"] = (object) source2;
      Dictionary<string, object> source3 = this.Dialogs.Serialize();
      if (source3.Any<KeyValuePair<string, object>>())
        dictionary["dialogs"] = (object) source3;
      Dictionary<string, object> source4 = this.PreviewPane.Serialize();
      if (source4.Any<KeyValuePair<string, object>>())
        dictionary["previewPane"] = (object) source4;
      return dictionary;
    }
  }
}
