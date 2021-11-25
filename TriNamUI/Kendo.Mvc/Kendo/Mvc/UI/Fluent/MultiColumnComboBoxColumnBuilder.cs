// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.MultiColumnComboBoxColumnBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class MultiColumnComboBoxColumnBuilder
  {
    public MultiColumnComboBoxColumnBuilder(MultiColumnComboBoxColumn container) => this.Container = container;

    protected MultiColumnComboBoxColumn Container { get; private set; }

    public MultiColumnComboBoxColumnBuilder Field(string value)
    {
      this.Container.Field = value;
      return this;
    }

    public MultiColumnComboBoxColumnBuilder Title(string value)
    {
      this.Container.Title = value;
      return this;
    }

    public MultiColumnComboBoxColumnBuilder Template(string value)
    {
      this.Container.Template = value;
      return this;
    }

    public MultiColumnComboBoxColumnBuilder TemplateId(
      string templateId)
    {
      this.Container.TemplateId = templateId;
      return this;
    }

    public MultiColumnComboBoxColumnBuilder HeaderTemplate(
      string value)
    {
      this.Container.HeaderTemplate = value;
      return this;
    }

    public MultiColumnComboBoxColumnBuilder HeaderTemplateId(
      string templateId)
    {
      this.Container.HeaderTemplateId = templateId;
      return this;
    }

    public MultiColumnComboBoxColumnBuilder Width(string value)
    {
      this.Container.Width = value;
      return this;
    }
  }
}
