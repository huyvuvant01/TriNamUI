// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.DiagramEditableSettingsToolBuilder`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class DiagramEditableSettingsToolBuilder<TShapeModel, TConnectionModel>
    where TShapeModel : class
    where TConnectionModel : class
  {
    public DiagramEditableSettingsToolBuilder(
      DiagramEditableSettingsTool<TShapeModel, TConnectionModel> container)
    {
      this.Container = container;
    }

    protected DiagramEditableSettingsTool<TShapeModel, TConnectionModel> Container { get; private set; }

    public DiagramEditableSettingsToolBuilder<TShapeModel, TConnectionModel> Name(
      string value)
    {
      this.Container.Name = value;
      return this;
    }

    public DiagramEditableSettingsToolBuilder<TShapeModel, TConnectionModel> Step(
      double value)
    {
      this.Container.Step = new double?(value);
      return this;
    }

    public DiagramEditableSettingsToolBuilder<TShapeModel, TConnectionModel> HtmlAttributes(
      IDictionary<string, object> value)
    {
      this.Container.HtmlAttributes = value;
      return this;
    }

    public DiagramEditableSettingsToolBuilder<TShapeModel, TConnectionModel> HtmlAttributes(
      object value)
    {
      this.Container.HtmlAttributes = value.ToDictionary();
      return this;
    }

    public DiagramEditableSettingsToolBuilder<TShapeModel, TConnectionModel> Buttons(
      Action<DiagramEditableSettingsToolButtonFactory<TShapeModel, TConnectionModel>> configurator)
    {
      configurator(new DiagramEditableSettingsToolButtonFactory<TShapeModel, TConnectionModel>(this.Container.Buttons)
      {
        Diagram = this.Container.Diagram
      });
      return this;
    }

    public DiagramEditableSettingsToolBuilder<TShapeModel, TConnectionModel> Click(
      string handler)
    {
      this.Container.Click = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public DiagramEditableSettingsToolBuilder<TShapeModel, TConnectionModel> Click(
      Func<object, object> handler)
    {
      this.Container.Click = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public DiagramEditableSettingsToolBuilder<TShapeModel, TConnectionModel> Enable(
      bool value)
    {
      this.Container.Enable = new bool?(value);
      return this;
    }

    public DiagramEditableSettingsToolBuilder<TShapeModel, TConnectionModel> Group(
      string value)
    {
      this.Container.Group = value;
      return this;
    }

    public DiagramEditableSettingsToolBuilder<TShapeModel, TConnectionModel> Icon(
      string value)
    {
      this.Container.Icon = value;
      return this;
    }

    public DiagramEditableSettingsToolBuilder<TShapeModel, TConnectionModel> Id(
      string value)
    {
      this.Container.Id = value;
      return this;
    }

    public DiagramEditableSettingsToolBuilder<TShapeModel, TConnectionModel> ImageUrl(
      string value)
    {
      this.Container.ImageUrl = value;
      return this;
    }

    public DiagramEditableSettingsToolBuilder<TShapeModel, TConnectionModel> MenuButtons(
      Action<DiagramEditableSettingsToolMenuButtonFactory<TShapeModel, TConnectionModel>> configurator)
    {
      configurator(new DiagramEditableSettingsToolMenuButtonFactory<TShapeModel, TConnectionModel>(this.Container.MenuButtons)
      {
        Diagram = this.Container.Diagram
      });
      return this;
    }

    public DiagramEditableSettingsToolBuilder<TShapeModel, TConnectionModel> Overflow(
      string value)
    {
      this.Container.Overflow = value;
      return this;
    }

    public DiagramEditableSettingsToolBuilder<TShapeModel, TConnectionModel> OverflowTemplate(
      string value)
    {
      this.Container.OverflowTemplate = value;
      return this;
    }

    public DiagramEditableSettingsToolBuilder<TShapeModel, TConnectionModel> OverflowTemplateId(
      string templateId)
    {
      this.Container.OverflowTemplateId = templateId;
      return this;
    }

    public DiagramEditableSettingsToolBuilder<TShapeModel, TConnectionModel> Primary(
      bool value)
    {
      this.Container.Primary = new bool?(value);
      return this;
    }

    public DiagramEditableSettingsToolBuilder<TShapeModel, TConnectionModel> Selected(
      bool value)
    {
      this.Container.Selected = new bool?(value);
      return this;
    }

    public DiagramEditableSettingsToolBuilder<TShapeModel, TConnectionModel> ShowIcon(
      string value)
    {
      this.Container.ShowIcon = value;
      return this;
    }

    public DiagramEditableSettingsToolBuilder<TShapeModel, TConnectionModel> ShowText(
      string value)
    {
      this.Container.ShowText = value;
      return this;
    }

    public DiagramEditableSettingsToolBuilder<TShapeModel, TConnectionModel> SpriteCssClass(
      string value)
    {
      this.Container.SpriteCssClass = value;
      return this;
    }

    public DiagramEditableSettingsToolBuilder<TShapeModel, TConnectionModel> Template(
      string value)
    {
      this.Container.Template = value;
      return this;
    }

    public DiagramEditableSettingsToolBuilder<TShapeModel, TConnectionModel> TemplateId(
      string templateId)
    {
      this.Container.TemplateId = templateId;
      return this;
    }

    public DiagramEditableSettingsToolBuilder<TShapeModel, TConnectionModel> Text(
      string value)
    {
      this.Container.Text = value;
      return this;
    }

    public DiagramEditableSettingsToolBuilder<TShapeModel, TConnectionModel> Togglable(
      bool value)
    {
      this.Container.Togglable = new bool?(value);
      return this;
    }

    public DiagramEditableSettingsToolBuilder<TShapeModel, TConnectionModel> Toggle(
      string handler)
    {
      this.Container.Toggle = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public DiagramEditableSettingsToolBuilder<TShapeModel, TConnectionModel> Toggle(
      Func<object, object> handler)
    {
      this.Container.Toggle = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public DiagramEditableSettingsToolBuilder<TShapeModel, TConnectionModel> Type(
      string value)
    {
      this.Container.Type = value;
      return this;
    }

    public DiagramEditableSettingsToolBuilder<TShapeModel, TConnectionModel> Url(
      string value)
    {
      this.Container.Url = value;
      return this;
    }
  }
}
