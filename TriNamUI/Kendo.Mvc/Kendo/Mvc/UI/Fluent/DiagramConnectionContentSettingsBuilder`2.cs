// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.DiagramConnectionContentSettingsBuilder`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class DiagramConnectionContentSettingsBuilder<TShapeModel, TConnectionModel>
    where TShapeModel : class
    where TConnectionModel : class
  {
    public DiagramConnectionContentSettingsBuilder(
      DiagramConnectionContentSettings<TShapeModel, TConnectionModel> container)
    {
      this.Container = container;
    }

    protected DiagramConnectionContentSettings<TShapeModel, TConnectionModel> Container { get; private set; }

    public DiagramConnectionContentSettingsBuilder<TShapeModel, TConnectionModel> Color(
      string value)
    {
      this.Container.Color = value;
      return this;
    }

    public DiagramConnectionContentSettingsBuilder<TShapeModel, TConnectionModel> FontFamily(
      string value)
    {
      this.Container.FontFamily = value;
      return this;
    }

    public DiagramConnectionContentSettingsBuilder<TShapeModel, TConnectionModel> FontSize(
      double value)
    {
      this.Container.FontSize = new double?(value);
      return this;
    }

    public DiagramConnectionContentSettingsBuilder<TShapeModel, TConnectionModel> FontStyle(
      string value)
    {
      this.Container.FontStyle = value;
      return this;
    }

    public DiagramConnectionContentSettingsBuilder<TShapeModel, TConnectionModel> FontWeight(
      string value)
    {
      this.Container.FontWeight = value;
      return this;
    }

    public DiagramConnectionContentSettingsBuilder<TShapeModel, TConnectionModel> Template(
      string value)
    {
      this.Container.Template = value;
      return this;
    }

    public DiagramConnectionContentSettingsBuilder<TShapeModel, TConnectionModel> TemplateId(
      string templateId)
    {
      this.Container.TemplateId = templateId;
      return this;
    }

    public DiagramConnectionContentSettingsBuilder<TShapeModel, TConnectionModel> Text(
      string value)
    {
      this.Container.Text = value;
      return this;
    }

    public DiagramConnectionContentSettingsBuilder<TShapeModel, TConnectionModel> Visual(
      string handler)
    {
      this.Container.Visual = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public DiagramConnectionContentSettingsBuilder<TShapeModel, TConnectionModel> Visual(
      Func<object, object> handler)
    {
      this.Container.Visual = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }
  }
}
