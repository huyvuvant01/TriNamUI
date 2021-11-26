// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.EditorToolBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Kendo.Mvc.UI.Fluent
{
  public class EditorToolBuilder
  {
    public EditorToolBuilder(EditorTool container) => this.Container = container;

    protected EditorTool Container { get; private set; }

    public EditorToolBuilder Palette(IEnumerable<string> colors)
    {
      this.Container.PaletteColors = colors;
      this.Container.Palette = new ColorPickerPalette?();
      return this;
    }

    public EditorToolBuilder Palette(ColorPickerPalette palette)
    {
      this.Container.PaletteColors = (IEnumerable<string>) null;
      this.Container.Palette = new ColorPickerPalette?(palette);
      return this;
    }

    [Obsolete("The property is deprecated. Please use the Tooltip property instead.")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public EditorToolBuilder ToolTip(string value)
    {
      this.Container.Tooltip = value;
      return this;
    }

    public EditorToolBuilder Name(string value)
    {
      this.Container.Name = value;
      return this;
    }

    public EditorToolBuilder Tooltip(string value)
    {
      this.Container.Tooltip = value;
      return this;
    }

    public EditorToolBuilder Exec(string handler)
    {
      this.Container.Exec = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public EditorToolBuilder Exec(Func<object, object> handler)
    {
      this.Container.Exec = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public EditorToolBuilder Items(Action<EditorToolItemFactory> configurator)
    {
      configurator(new EditorToolItemFactory(this.Container.Items)
      {
        Editor = this.Container.Editor
      });
      return this;
    }

    public EditorToolBuilder Columns(int value)
    {
      this.Container.Columns = new int?(value);
      return this;
    }

    public EditorToolBuilder Template(string value)
    {
      this.Container.Template = value;
      return this;
    }

    public EditorToolBuilder TemplateId(string templateId)
    {
      this.Container.TemplateId = templateId;
      return this;
    }
  }
}
