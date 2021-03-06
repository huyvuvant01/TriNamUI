// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.FileManagerDialogsSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class FileManagerDialogsSettings
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public FileManagerDialogsUploadSettings Upload { get; } = new FileManagerDialogsUploadSettings();

    public FileManagerDialogsMoveConfirmSettings MoveConfirm { get; } = new FileManagerDialogsMoveConfirmSettings();

    public FileManagerDialogsDeleteConfirmSettings DeleteConfirm { get; } = new FileManagerDialogsDeleteConfirmSettings();

    public FileManagerDialogsRenamePromptSettings RenamePrompt { get; } = new FileManagerDialogsRenamePromptSettings();

    public FileManager FileManager { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      Dictionary<string, object> source1 = this.Upload.Serialize();
      if (source1.Any<KeyValuePair<string, object>>())
        dictionary["upload"] = (object) source1;
      Dictionary<string, object> source2 = this.MoveConfirm.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
        dictionary["moveConfirm"] = (object) source2;
      Dictionary<string, object> source3 = this.DeleteConfirm.Serialize();
      if (source3.Any<KeyValuePair<string, object>>())
        dictionary["deleteConfirm"] = (object) source3;
      Dictionary<string, object> source4 = this.RenamePrompt.Serialize();
      if (source4.Any<KeyValuePair<string, object>>())
        dictionary["renamePrompt"] = (object) source4;
      return dictionary;
    }
  }
}
