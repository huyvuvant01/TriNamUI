// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.DiagramShapeEditableSettingsToolMenuButtonBuilder`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class DiagramShapeEditableSettingsToolMenuButtonBuilder<TShapeModel, TConnectionModel>
    where TShapeModel : class
    where TConnectionModel : class
  {
    public DiagramShapeEditableSettingsToolMenuButtonBuilder(
      DiagramShapeEditableSettingsToolMenuButton<TShapeModel, TConnectionModel> container)
    {
      this.Container = container;
    }

    protected DiagramShapeEditableSettingsToolMenuButton<TShapeModel, TConnectionModel> Container { get; private set; }

    public DiagramShapeEditableSettingsToolMenuButtonBuilder<TShapeModel, TConnectionModel> HtmlAttributes(
      IDictionary<string, object> value)
    {
      this.Container.HtmlAttributes = value;
      return this;
    }

    public DiagramShapeEditableSettingsToolMenuButtonBuilder<TShapeModel, TConnectionModel> HtmlAttributes(
      object value)
    {
      this.Container.HtmlAttributes = value.ToDictionary();
      return this;
    }

    public DiagramShapeEditableSettingsToolMenuButtonBuilder<TShapeModel, TConnectionModel> Enable(
      bool value)
    {
      this.Container.Enable = new bool?(value);
      return this;
    }

    public DiagramShapeEditableSettingsToolMenuButtonBuilder<TShapeModel, TConnectionModel> Icon(
      string value)
    {
      this.Container.Icon = value;
      return this;
    }

    public DiagramShapeEditableSettingsToolMenuButtonBuilder<TShapeModel, TConnectionModel> Id(
      string value)
    {
      this.Container.Id = value;
      return this;
    }

    public DiagramShapeEditableSettingsToolMenuButtonBuilder<TShapeModel, TConnectionModel> ImageUrl(
      string value)
    {
      this.Container.ImageUrl = value;
      return this;
    }

    public DiagramShapeEditableSettingsToolMenuButtonBuilder<TShapeModel, TConnectionModel> SpriteCssClass(
      string value)
    {
      this.Container.SpriteCssClass = value;
      return this;
    }

    public DiagramShapeEditableSettingsToolMenuButtonBuilder<TShapeModel, TConnectionModel> Text(
      string value)
    {
      this.Container.Text = value;
      return this;
    }

    public DiagramShapeEditableSettingsToolMenuButtonBuilder<TShapeModel, TConnectionModel> Url(
      string value)
    {
      this.Container.Url = value;
      return this;
    }
  }
}
