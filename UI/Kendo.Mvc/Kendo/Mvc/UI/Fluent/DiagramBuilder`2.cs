// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.DiagramBuilder`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.UI.Diagram.Fluent;
using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class DiagramBuilder<TShapeModel, TConnectionModel> : 
    WidgetBuilderBase<Kendo.Mvc.UI.Diagram<TShapeModel, TConnectionModel>, DiagramBuilder<TShapeModel, TConnectionModel>>
    where TShapeModel : class
    where TConnectionModel : class
  {
    public DiagramBuilder(Kendo.Mvc.UI.Diagram<TShapeModel, TConnectionModel> component)
      : base(component)
    {
    }

    public DiagramBuilder<TShapeModel, TConnectionModel> DataSource(
      Action<DiagramDataSourceBuilder<TShapeModel>> configurator)
    {
      configurator(new DiagramDataSourceBuilder<TShapeModel>(this.Component.DataSource, this.Component.ViewContext, this.Component.UrlGenerator));
      return this;
    }

    public DiagramBuilder<TShapeModel, TConnectionModel> ConnectionsDataSource(
      Action<DiagramConnectionDataSourceBuilder<TConnectionModel>> configurator)
    {
      configurator(new DiagramConnectionDataSourceBuilder<TConnectionModel>(this.Component.ConnectionsDataSource, this.Component.ViewContext, this.Component.UrlGenerator));
      return this;
    }

    public DiagramBuilder<TShapeModel, TConnectionModel> AutoBind(bool value)
    {
      this.Container.AutoBind = new bool?(value);
      return this;
    }

    public DiagramBuilder<TShapeModel, TConnectionModel> ConnectionDefaults(
      Action<DiagramConnectionDefaultsSettingsBuilder<TShapeModel, TConnectionModel>> configurator)
    {
      this.Container.ConnectionDefaults.Diagram = this.Container;
      configurator(new DiagramConnectionDefaultsSettingsBuilder<TShapeModel, TConnectionModel>(this.Container.ConnectionDefaults));
      return this;
    }

    public DiagramBuilder<TShapeModel, TConnectionModel> Connections(
      Action<DiagramConnectionFactory<TShapeModel, TConnectionModel>> configurator)
    {
      configurator(new DiagramConnectionFactory<TShapeModel, TConnectionModel>(this.Container.Connections)
      {
        Diagram = this.Container
      });
      return this;
    }

    public DiagramBuilder<TShapeModel, TConnectionModel> Editable(
      Action<DiagramEditableSettingsBuilder<TShapeModel, TConnectionModel>> configurator)
    {
      this.Container.Editable.Enabled = new bool?(true);
      this.Container.Editable.Diagram = this.Container;
      configurator(new DiagramEditableSettingsBuilder<TShapeModel, TConnectionModel>(this.Container.Editable));
      return this;
    }

    public DiagramBuilder<TShapeModel, TConnectionModel> Editable(bool enabled)
    {
      this.Container.Editable.Enabled = new bool?(enabled);
      return this;
    }

    public DiagramBuilder<TShapeModel, TConnectionModel> Layout(
      Action<DiagramLayoutSettingsBuilder<TShapeModel, TConnectionModel>> configurator)
    {
      this.Container.Layout.Diagram = this.Container;
      configurator(new DiagramLayoutSettingsBuilder<TShapeModel, TConnectionModel>(this.Container.Layout));
      return this;
    }

    public DiagramBuilder<TShapeModel, TConnectionModel> Pannable(
      Action<DiagramPannableSettingsBuilder<TShapeModel, TConnectionModel>> configurator)
    {
      this.Container.Pannable.Enabled = new bool?(true);
      this.Container.Pannable.Diagram = this.Container;
      configurator(new DiagramPannableSettingsBuilder<TShapeModel, TConnectionModel>(this.Container.Pannable));
      return this;
    }

    public DiagramBuilder<TShapeModel, TConnectionModel> Pannable(bool enabled)
    {
      this.Container.Pannable.Enabled = new bool?(enabled);
      return this;
    }

    public DiagramBuilder<TShapeModel, TConnectionModel> Pdf(
      Action<DiagramPdfSettingsBuilder<TShapeModel, TConnectionModel>> configurator)
    {
      this.Container.Pdf.Diagram = this.Container;
      configurator(new DiagramPdfSettingsBuilder<TShapeModel, TConnectionModel>(this.Container.Pdf));
      return this;
    }

    public DiagramBuilder<TShapeModel, TConnectionModel> Selectable(
      Action<DiagramSelectableSettingsBuilder<TShapeModel, TConnectionModel>> configurator)
    {
      this.Container.Selectable.Enabled = new bool?(true);
      this.Container.Selectable.Diagram = this.Container;
      configurator(new DiagramSelectableSettingsBuilder<TShapeModel, TConnectionModel>(this.Container.Selectable));
      return this;
    }

    public DiagramBuilder<TShapeModel, TConnectionModel> Selectable(bool enabled)
    {
      this.Container.Selectable.Enabled = new bool?(enabled);
      return this;
    }

    public DiagramBuilder<TShapeModel, TConnectionModel> ShapeDefaults(
      Action<DiagramShapeDefaultsSettingsBuilder<TShapeModel, TConnectionModel>> configurator)
    {
      this.Container.ShapeDefaults.Diagram = this.Container;
      configurator(new DiagramShapeDefaultsSettingsBuilder<TShapeModel, TConnectionModel>(this.Container.ShapeDefaults));
      return this;
    }

    public DiagramBuilder<TShapeModel, TConnectionModel> Shapes(
      Action<DiagramShapeFactory<TShapeModel, TConnectionModel>> configurator)
    {
      configurator(new DiagramShapeFactory<TShapeModel, TConnectionModel>(this.Container.Shapes)
      {
        Diagram = this.Container
      });
      return this;
    }

    public DiagramBuilder<TShapeModel, TConnectionModel> Template(string value)
    {
      this.Container.Template = value;
      return this;
    }

    public DiagramBuilder<TShapeModel, TConnectionModel> TemplateId(string templateId)
    {
      this.Container.TemplateId = templateId;
      return this;
    }

    public DiagramBuilder<TShapeModel, TConnectionModel> Theme(string value)
    {
      this.Container.Theme = value;
      return this;
    }

    public DiagramBuilder<TShapeModel, TConnectionModel> Zoom(double value)
    {
      this.Container.Zoom = new double?(value);
      return this;
    }

    public DiagramBuilder<TShapeModel, TConnectionModel> ZoomMax(double value)
    {
      this.Container.ZoomMax = new double?(value);
      return this;
    }

    public DiagramBuilder<TShapeModel, TConnectionModel> ZoomMin(double value)
    {
      this.Container.ZoomMin = new double?(value);
      return this;
    }

    public DiagramBuilder<TShapeModel, TConnectionModel> ZoomRate(double value)
    {
      this.Container.ZoomRate = new double?(value);
      return this;
    }

    public DiagramBuilder<TShapeModel, TConnectionModel> Events(
      Action<DiagramEventBuilder> configurator)
    {
      configurator(new DiagramEventBuilder(this.Container.Events));
      return this;
    }
  }
}
