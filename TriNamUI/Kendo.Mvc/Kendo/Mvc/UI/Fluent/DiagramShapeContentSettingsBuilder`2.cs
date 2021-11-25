// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.DiagramShapeContentSettingsBuilder`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class DiagramShapeContentSettingsBuilder<TShapeModel, TConnectionModel>
    where TShapeModel : class
    where TConnectionModel : class
  {
    public DiagramShapeContentSettingsBuilder(
      DiagramShapeContentSettings<TShapeModel, TConnectionModel> container)
    {
      this.Container = container;
    }

    protected DiagramShapeContentSettings<TShapeModel, TConnectionModel> Container { get; private set; }

    public DiagramShapeContentSettingsBuilder<TShapeModel, TConnectionModel> Align(
      string value)
    {
      this.Container.Align = value;
      return this;
    }

    public DiagramShapeContentSettingsBuilder<TShapeModel, TConnectionModel> Color(
      string value)
    {
      this.Container.Color = value;
      return this;
    }

    public DiagramShapeContentSettingsBuilder<TShapeModel, TConnectionModel> FontFamily(
      string value)
    {
      this.Container.FontFamily = value;
      return this;
    }

    public DiagramShapeContentSettingsBuilder<TShapeModel, TConnectionModel> FontSize(
      double value)
    {
      this.Container.FontSize = new double?(value);
      return this;
    }

    public DiagramShapeContentSettingsBuilder<TShapeModel, TConnectionModel> FontStyle(
      string value)
    {
      this.Container.FontStyle = value;
      return this;
    }

    public DiagramShapeContentSettingsBuilder<TShapeModel, TConnectionModel> FontWeight(
      string value)
    {
      this.Container.FontWeight = value;
      return this;
    }

    public DiagramShapeContentSettingsBuilder<TShapeModel, TConnectionModel> Template(
      string value)
    {
      this.Container.Template = value;
      return this;
    }

    public DiagramShapeContentSettingsBuilder<TShapeModel, TConnectionModel> TemplateId(
      string templateId)
    {
      this.Container.TemplateId = templateId;
      return this;
    }

    public DiagramShapeContentSettingsBuilder<TShapeModel, TConnectionModel> Text(
      string value)
    {
      this.Container.Text = value;
      return this;
    }
  }
}
