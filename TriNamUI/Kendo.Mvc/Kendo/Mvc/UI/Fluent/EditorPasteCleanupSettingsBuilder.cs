// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.EditorPasteCleanupSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class EditorPasteCleanupSettingsBuilder
  {
    public EditorPasteCleanupSettingsBuilder(EditorPasteCleanupSettings container) => this.Container = container;

    protected EditorPasteCleanupSettings Container { get; private set; }

    public EditorPasteCleanupSettingsBuilder All(bool value)
    {
      this.Container.All = new bool?(value);
      return this;
    }

    public EditorPasteCleanupSettingsBuilder All()
    {
      this.Container.All = new bool?(true);
      return this;
    }

    public EditorPasteCleanupSettingsBuilder Css(bool value)
    {
      this.Container.Css = new bool?(value);
      return this;
    }

    public EditorPasteCleanupSettingsBuilder Css()
    {
      this.Container.Css = new bool?(true);
      return this;
    }

    public EditorPasteCleanupSettingsBuilder Custom(string handler)
    {
      this.Container.Custom = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public EditorPasteCleanupSettingsBuilder Custom(
      Func<object, object> handler)
    {
      this.Container.Custom = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public EditorPasteCleanupSettingsBuilder KeepNewLines(
      bool value)
    {
      this.Container.KeepNewLines = new bool?(value);
      return this;
    }

    public EditorPasteCleanupSettingsBuilder KeepNewLines()
    {
      this.Container.KeepNewLines = new bool?(true);
      return this;
    }

    public EditorPasteCleanupSettingsBuilder MsAllFormatting(
      bool value)
    {
      this.Container.MsAllFormatting = new bool?(value);
      return this;
    }

    public EditorPasteCleanupSettingsBuilder MsAllFormatting()
    {
      this.Container.MsAllFormatting = new bool?(true);
      return this;
    }

    public EditorPasteCleanupSettingsBuilder MsConvertLists(
      bool value)
    {
      this.Container.MsConvertLists = new bool?(value);
      return this;
    }

    public EditorPasteCleanupSettingsBuilder MsTags(bool value)
    {
      this.Container.MsTags = new bool?(value);
      return this;
    }

    public EditorPasteCleanupSettingsBuilder None(bool value)
    {
      this.Container.None = new bool?(value);
      return this;
    }

    public EditorPasteCleanupSettingsBuilder None()
    {
      this.Container.None = new bool?(true);
      return this;
    }

    public EditorPasteCleanupSettingsBuilder Span(bool value)
    {
      this.Container.Span = new bool?(value);
      return this;
    }

    public EditorPasteCleanupSettingsBuilder Span()
    {
      this.Container.Span = new bool?(true);
      return this;
    }
  }
}
