// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.DiagramConnectionDefaultsEditableSettingsToolButtonBuilder`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class DiagramConnectionDefaultsEditableSettingsToolButtonBuilder<TShapeModel, TConnectionModel>
    where TShapeModel : class
    where TConnectionModel : class
  {
    public DiagramConnectionDefaultsEditableSettingsToolButtonBuilder(
      DiagramConnectionDefaultsEditableSettingsToolButton<TShapeModel, TConnectionModel> container)
    {
      this.Container = container;
    }

    protected DiagramConnectionDefaultsEditableSettingsToolButton<TShapeModel, TConnectionModel> Container { get; private set; }

    public DiagramConnectionDefaultsEditableSettingsToolButtonBuilder<TShapeModel, TConnectionModel> HtmlAttributes(
      IDictionary<string, object> value)
    {
      this.Container.HtmlAttributes = value;
      return this;
    }

    public DiagramConnectionDefaultsEditableSettingsToolButtonBuilder<TShapeModel, TConnectionModel> HtmlAttributes(
      object value)
    {
      this.Container.HtmlAttributes = value.ToDictionary();
      return this;
    }

    public DiagramConnectionDefaultsEditableSettingsToolButtonBuilder<TShapeModel, TConnectionModel> Click(
      string handler)
    {
      this.Container.Click = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public DiagramConnectionDefaultsEditableSettingsToolButtonBuilder<TShapeModel, TConnectionModel> Click(
      Func<object, object> handler)
    {
      this.Container.Click = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public DiagramConnectionDefaultsEditableSettingsToolButtonBuilder<TShapeModel, TConnectionModel> Enable(
      bool value)
    {
      this.Container.Enable = new bool?(value);
      return this;
    }

    public DiagramConnectionDefaultsEditableSettingsToolButtonBuilder<TShapeModel, TConnectionModel> Group(
      string value)
    {
      this.Container.Group = value;
      return this;
    }

    public DiagramConnectionDefaultsEditableSettingsToolButtonBuilder<TShapeModel, TConnectionModel> Icon(
      string value)
    {
      this.Container.Icon = value;
      return this;
    }

    public DiagramConnectionDefaultsEditableSettingsToolButtonBuilder<TShapeModel, TConnectionModel> Id(
      string value)
    {
      this.Container.Id = value;
      return this;
    }

    public DiagramConnectionDefaultsEditableSettingsToolButtonBuilder<TShapeModel, TConnectionModel> ImageUrl(
      string value)
    {
      this.Container.ImageUrl = value;
      return this;
    }

    public DiagramConnectionDefaultsEditableSettingsToolButtonBuilder<TShapeModel, TConnectionModel> Selected(
      bool value)
    {
      this.Container.Selected = new bool?(value);
      return this;
    }

    public DiagramConnectionDefaultsEditableSettingsToolButtonBuilder<TShapeModel, TConnectionModel> ShowIcon(
      string value)
    {
      this.Container.ShowIcon = value;
      return this;
    }

    public DiagramConnectionDefaultsEditableSettingsToolButtonBuilder<TShapeModel, TConnectionModel> ShowText(
      string value)
    {
      this.Container.ShowText = value;
      return this;
    }

    public DiagramConnectionDefaultsEditableSettingsToolButtonBuilder<TShapeModel, TConnectionModel> SpriteCssClass(
      string value)
    {
      this.Container.SpriteCssClass = value;
      return this;
    }

    public DiagramConnectionDefaultsEditableSettingsToolButtonBuilder<TShapeModel, TConnectionModel> Toggle(
      string handler)
    {
      this.Container.Toggle = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public DiagramConnectionDefaultsEditableSettingsToolButtonBuilder<TShapeModel, TConnectionModel> Toggle(
      Func<object, object> handler)
    {
      this.Container.Toggle = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public DiagramConnectionDefaultsEditableSettingsToolButtonBuilder<TShapeModel, TConnectionModel> Togglable(
      bool value)
    {
      this.Container.Togglable = new bool?(value);
      return this;
    }

    public DiagramConnectionDefaultsEditableSettingsToolButtonBuilder<TShapeModel, TConnectionModel> Text(
      string value)
    {
      this.Container.Text = value;
      return this;
    }

    public DiagramConnectionDefaultsEditableSettingsToolButtonBuilder<TShapeModel, TConnectionModel> Url(
      string value)
    {
      this.Container.Url = value;
      return this;
    }
  }
}
