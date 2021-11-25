// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.EditorBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class EditorBuilder : WidgetBuilderBase<Editor, EditorBuilder>
  {
    public EditorBuilder(Editor component)
      : base(component)
    {
    }

    public EditorBuilder Value(Action value)
    {
      this.Component.ValueAction = value;
      return this;
    }

    public EditorBuilder Value(Func<object, object> value)
    {
      this.Component.ValueHandler = value;
      return this;
    }

    public EditorBuilder StyleSheets(Action<EditorStyleSheetBuilder> configurator)
    {
      configurator(new EditorStyleSheetBuilder((IList<string>) this.Component.StyleSheets));
      return this;
    }

    public EditorBuilder ExportAs(Action<EditorExportAsSettingsBuilder> configurator)
    {
      EditorExportAsSettingsBuilder asSettingsBuilder = new EditorExportAsSettingsBuilder(this.Component.ExportAsSettings);
      configurator(asSettingsBuilder);
      return this;
    }

    public EditorBuilder Import(Action<EditorImportSettingsBuilder> configurator)
    {
      EditorImportSettingsBuilder importSettingsBuilder = new EditorImportSettingsBuilder(this.Component.ImportSettings);
      configurator(importSettingsBuilder);
      return this;
    }

    public EditorBuilder Deserialization(
      Action<EditorDeserializationSettingsBuilder> configurator)
    {
      this.Container.Deserialization.Editor = this.Container;
      configurator(new EditorDeserializationSettingsBuilder(this.Container.Deserialization));
      return this;
    }

    public EditorBuilder Domain(string value)
    {
      this.Container.Domain = value;
      return this;
    }

    public EditorBuilder Encoded(bool value)
    {
      this.Container.Encoded = new bool?(value);
      return this;
    }

    public EditorBuilder Immutables(
      Action<EditorImmutablesSettingsBuilder> configurator)
    {
      this.Container.Immutables.Enabled = new bool?(true);
      this.Container.Immutables.Editor = this.Container;
      configurator(new EditorImmutablesSettingsBuilder(this.Container.Immutables));
      return this;
    }

    public EditorBuilder Immutables()
    {
      this.Container.Immutables.Enabled = new bool?(true);
      return this;
    }

    public EditorBuilder Immutables(bool enabled)
    {
      this.Container.Immutables.Enabled = new bool?(enabled);
      return this;
    }

    public EditorBuilder Messages(Action<EditorMessagesSettingsBuilder> configurator)
    {
      this.Container.Messages.Editor = this.Container;
      configurator(new EditorMessagesSettingsBuilder(this.Container.Messages));
      return this;
    }

    public EditorBuilder PasteCleanup(
      Action<EditorPasteCleanupSettingsBuilder> configurator)
    {
      this.Container.PasteCleanup.Editor = this.Container;
      configurator(new EditorPasteCleanupSettingsBuilder(this.Container.PasteCleanup));
      return this;
    }

    public EditorBuilder Pdf(Action<EditorPdfSettingsBuilder> configurator)
    {
      this.Container.Pdf.Editor = this.Container;
      configurator(new EditorPdfSettingsBuilder(this.Container.Pdf));
      return this;
    }

    public EditorBuilder Placeholder(string value)
    {
      this.Container.Placeholder = value;
      return this;
    }

    public EditorBuilder Resizable(
      Action<EditorResizableSettingsBuilder> configurator)
    {
      this.Container.Resizable.Enabled = new bool?(true);
      this.Container.Resizable.Editor = this.Container;
      configurator(new EditorResizableSettingsBuilder(this.Container.Resizable));
      return this;
    }

    public EditorBuilder Resizable()
    {
      this.Container.Resizable.Enabled = new bool?(true);
      return this;
    }

    public EditorBuilder Resizable(bool enabled)
    {
      this.Container.Resizable.Enabled = new bool?(enabled);
      return this;
    }

    public EditorBuilder Serialization(
      Action<EditorSerializationSettingsBuilder> configurator)
    {
      this.Container.Serialization.Editor = this.Container;
      configurator(new EditorSerializationSettingsBuilder(this.Container.Serialization));
      return this;
    }

    public EditorBuilder Tools(Action<EditorToolFactory> configurator)
    {
      configurator(new EditorToolFactory(this.Container.Tools)
      {
        Editor = this.Container
      });
      return this;
    }

    public EditorBuilder ImageBrowser(
      Action<EditorImageBrowserSettingsBuilder> configurator)
    {
      this.Container.ImageBrowser.Editor = this.Container;
      configurator(new EditorImageBrowserSettingsBuilder(this.Container.ImageBrowser));
      return this;
    }

    public EditorBuilder FileBrowser(
      Action<EditorFileBrowserSettingsBuilder> configurator)
    {
      this.Container.FileBrowser.Editor = this.Container;
      configurator(new EditorFileBrowserSettingsBuilder(this.Container.FileBrowser));
      return this;
    }

    public EditorBuilder Tag(string value)
    {
      this.Container.Tag = value;
      return this;
    }

    public EditorBuilder Value(string value)
    {
      this.Container.Value = value;
      return this;
    }

    public EditorBuilder Events(Action<EditorEventBuilder> configurator)
    {
      configurator(new EditorEventBuilder(this.Container.Events));
      return this;
    }
  }
}
