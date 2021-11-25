// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.OrgChartMessagesSettings`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class OrgChartMessagesSettings<T> where T : class
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Label { get; set; }

    public string Create { get; set; }

    public string Edit { get; set; }

    public string Destroy { get; set; }

    public string DestroyContent { get; set; }

    public string DestroyTitle { get; set; }

    public string Cancel { get; set; }

    public string Save { get; set; }

    public string MenuLabel { get; set; }

    public string UploadAvatar { get; set; }

    public string Parent { get; set; }

    public string Name { get; set; }

    public string Title { get; set; }

    public string None { get; set; }

    public string Expand { get; set; }

    public string Collapse { get; set; }

    public Kendo.Mvc.UI.OrgChart<T> OrgChart { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string label = this.Label;
      if ((label != null ? (label.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["label"] = (object) this.Label;
      string create = this.Create;
      if ((create != null ? (create.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["create"] = (object) this.Create;
      string edit = this.Edit;
      if ((edit != null ? (edit.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["edit"] = (object) this.Edit;
      string destroy = this.Destroy;
      if ((destroy != null ? (destroy.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["destroy"] = (object) this.Destroy;
      string destroyContent = this.DestroyContent;
      if ((destroyContent != null ? (destroyContent.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["destroyContent"] = (object) this.DestroyContent;
      string destroyTitle = this.DestroyTitle;
      if ((destroyTitle != null ? (destroyTitle.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["destroyTitle"] = (object) this.DestroyTitle;
      string cancel = this.Cancel;
      if ((cancel != null ? (cancel.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["cancel"] = (object) this.Cancel;
      string save = this.Save;
      if ((save != null ? (save.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["save"] = (object) this.Save;
      string menuLabel = this.MenuLabel;
      if ((menuLabel != null ? (menuLabel.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["menuLabel"] = (object) this.MenuLabel;
      string uploadAvatar = this.UploadAvatar;
      if ((uploadAvatar != null ? (uploadAvatar.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["uploadAvatar"] = (object) this.UploadAvatar;
      string parent = this.Parent;
      if ((parent != null ? (parent.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["parent"] = (object) this.Parent;
      string name = this.Name;
      if ((name != null ? (name.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["name"] = (object) this.Name;
      string title = this.Title;
      if ((title != null ? (title.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["title"] = (object) this.Title;
      string none = this.None;
      if ((none != null ? (none.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["none"] = (object) this.None;
      string expand = this.Expand;
      if ((expand != null ? (expand.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["expand"] = (object) this.Expand;
      string collapse = this.Collapse;
      if ((collapse != null ? (collapse.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["collapse"] = (object) this.Collapse;
      return dictionary;
    }
  }
}
