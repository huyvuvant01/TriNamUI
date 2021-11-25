// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.ListBoxMessagesToolsSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Resources;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class ListBoxMessagesToolsSettings
  {
    public ListBoxMessagesToolsSettings()
    {
      this.MoveDown = Messages.ListBox_MoveDown;
      this.MoveUp = Messages.ListBox_MoveUp;
      this.Remove = Messages.ListBox_Remove;
      this.TransferAllFrom = Messages.ListBox_TransferAllFrom;
      this.TransferAllTo = Messages.ListBox_TransferAllTo;
      this.TransferFrom = Messages.ListBox_TransferFrom;
      this.TransferTo = Messages.ListBox_TransferTo;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string MoveDown { get; set; }

    public string MoveUp { get; set; }

    public string Remove { get; set; }

    public string TransferAllFrom { get; set; }

    public string TransferAllTo { get; set; }

    public string TransferFrom { get; set; }

    public string TransferTo { get; set; }

    public ListBox ListBox { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string moveDown = this.MoveDown;
      if ((moveDown != null ? (moveDown.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["moveDown"] = (object) this.MoveDown;
      string moveUp = this.MoveUp;
      if ((moveUp != null ? (moveUp.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["moveUp"] = (object) this.MoveUp;
      string remove = this.Remove;
      if ((remove != null ? (remove.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["remove"] = (object) this.Remove;
      string transferAllFrom = this.TransferAllFrom;
      if ((transferAllFrom != null ? (transferAllFrom.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["transferAllFrom"] = (object) this.TransferAllFrom;
      string transferAllTo = this.TransferAllTo;
      if ((transferAllTo != null ? (transferAllTo.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["transferAllTo"] = (object) this.TransferAllTo;
      string transferFrom = this.TransferFrom;
      if ((transferFrom != null ? (transferFrom.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["transferFrom"] = (object) this.TransferFrom;
      string transferTo = this.TransferTo;
      if ((transferTo != null ? (transferTo.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["transferTo"] = (object) this.TransferTo;
      return dictionary;
    }
  }
}
