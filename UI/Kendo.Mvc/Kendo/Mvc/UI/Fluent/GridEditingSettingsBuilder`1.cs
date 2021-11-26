// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.GridEditingSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class GridEditingSettingsBuilder<T> : IHideObjectMembers where T : class
  {
    private readonly GridEditableSettings<T> settings;

    public GridEditingSettingsBuilder(GridEditableSettings<T> settings)
    {
      this.settings = settings;
      this.settings.Enabled = true;
    }

    public GridEditingSettingsBuilder<T> Enabled(bool value)
    {
      this.settings.Enabled = value;
      return this;
    }

    public GridEditingSettingsBuilder<T> Mode(GridEditMode mode)
    {
      this.settings.Mode = mode;
      return this;
    }

    public GridEditingSettingsBuilder<T> Window(
      Action<WindowBuilder> configurator)
    {
      configurator(new WindowBuilder(this.settings.PopUp));
      return this;
    }

    public GridEditingSettingsBuilder<T> TemplateName(string templateName)
    {
      this.settings.TemplateName = templateName;
      return this;
    }

    public GridEditingSettingsBuilder<T> AdditionalViewData(
      object additionalViewData)
    {
      this.settings.AdditionalViewData = additionalViewData;
      return this;
    }

    public GridEditingSettingsBuilder<T> DisplayDeleteConfirmation(
      bool value)
    {
      this.settings.DisplayDeleteConfirmation = value;
      return this;
    }

    public GridEditingSettingsBuilder<T> DisplayDeleteConfirmation(
      string message)
    {
      this.settings.Confirmation = message;
      this.settings.DisplayDeleteConfirmation = true;
      return this;
    }

    public GridEditingSettingsBuilder<T> DisplayDeleteConfirmation(
      Func<object, object> handler)
    {
      this.settings.ConfirmationHandler = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      this.settings.DisplayDeleteConfirmation = true;
      return this;
    }

    public GridEditingSettingsBuilder<T> ConfirmDelete(string text)
    {
      this.settings.ConfirmDelete = text;
      return this;
    }

    public GridEditingSettingsBuilder<T> CancelDelete(string text)
    {
      this.settings.CancelDelete = text;
      return this;
    }

    private static void MergeAttributes(
      IDictionary<string, object> target,
      IDictionary<string, object> attributes)
    {
      target.Clear();
      DictionaryExtensions.Merge(target, attributes);
    }

    public GridEditingSettingsBuilder<T> CreateAt(
      GridInsertRowPosition position)
    {
      this.settings.CreateAt = position;
      return this;
    }

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
