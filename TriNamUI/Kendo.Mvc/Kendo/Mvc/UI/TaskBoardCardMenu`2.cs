// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.TaskBoardCardMenu`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class TaskBoardCardMenu<TCard, TColumn>
    where TCard : class
    where TColumn : class
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Name { get; set; }

    public string Text { get; set; }

    public string Icon { get; set; }

    public string SpriteCssClass { get; set; }

    public string Command { get; set; }

    public string Options { get; set; }

    public Kendo.Mvc.UI.TaskBoard<TCard, TColumn> TaskBoard { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string name = this.Name;
      if ((name != null ? (name.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["name"] = (object) this.Name;
      string text = this.Text;
      if ((text != null ? (text.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["text"] = (object) this.Text;
      string icon = this.Icon;
      if ((icon != null ? (icon.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["icon"] = (object) this.Icon;
      string spriteCssClass = this.SpriteCssClass;
      if ((spriteCssClass != null ? (spriteCssClass.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["spriteCssClass"] = (object) this.SpriteCssClass;
      string command = this.Command;
      if ((command != null ? (command.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["command"] = (object) this.Command;
      string options = this.Options;
      if ((options != null ? (options.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["options"] = (object) this.Options;
      return dictionary;
    }
  }
}
