// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.TreeListEditableSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class TreeListEditableSettingsBuilder<T> where T : class
  {
    public TreeListEditableSettingsBuilder(TreeListEditableSettings<T> container) => this.Container = container;

    protected TreeListEditableSettings<T> Container { get; private set; }

    public TreeListEditableSettingsBuilder<T> Mode(string value)
    {
      this.Container.Mode = new TreeListEditMode?(value.ToLowerInvariant() == "inline" ? TreeListEditMode.InLine : TreeListEditMode.PopUp);
      return this;
    }

    public TreeListEditableSettingsBuilder<T> Move(
      Action<TreeListEditableMoveSettingsBuilder<T>> configurator)
    {
      this.Container.Move.Enabled = new bool?(true);
      this.Container.Move.TreeList = this.Container.TreeList;
      configurator(new TreeListEditableMoveSettingsBuilder<T>(this.Container.Move));
      return this;
    }

    public TreeListEditableSettingsBuilder<T> Move()
    {
      this.Container.Move.Enabled = new bool?(true);
      return this;
    }

    public TreeListEditableSettingsBuilder<T> Move(bool enabled)
    {
      this.Container.Move.Enabled = new bool?(enabled);
      return this;
    }

    public TreeListEditableSettingsBuilder<T> Template(string value)
    {
      this.Container.Template = value;
      return this;
    }

    public TreeListEditableSettingsBuilder<T> TemplateId(
      string templateId)
    {
      this.Container.TemplateId = templateId;
      return this;
    }

    public TreeListEditableSettingsBuilder<T> TemplateName(
      string value)
    {
      this.Container.TemplateName = value;
      return this;
    }

    public TreeListEditableSettingsBuilder<T> Mode(
      TreeListEditMode value)
    {
      this.Container.Mode = new TreeListEditMode?(value);
      return this;
    }
  }
}
