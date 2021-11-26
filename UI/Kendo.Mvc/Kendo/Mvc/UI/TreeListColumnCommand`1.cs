// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.TreeListColumnCommand`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class TreeListColumnCommand<T> where T : class
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string ClassName { get; set; }

    public string ImageClass { get; set; }

    public ClientHandlerDescriptor Click { get; set; }

    public string Name { get; set; }

    public string Text { get; set; }

    public Kendo.Mvc.UI.TreeList<T> TreeList { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string className = this.ClassName;
      if ((className != null ? (className.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["className"] = (object) this.ClassName;
      string imageClass = this.ImageClass;
      if ((imageClass != null ? (imageClass.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["imageClass"] = (object) this.ImageClass;
      ClientHandlerDescriptor click = this.Click;
      if ((click != null ? (click.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["click"] = (object) this.Click;
      string name = this.Name;
      if ((name != null ? (name.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["name"] = (object) this.Name;
      string text = this.Text;
      if ((text != null ? (text.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["text"] = (object) this.Text;
      return dictionary;
    }
  }
}
