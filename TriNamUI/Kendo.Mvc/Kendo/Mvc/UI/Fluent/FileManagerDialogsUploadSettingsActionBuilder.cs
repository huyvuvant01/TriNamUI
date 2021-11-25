﻿// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.FileManagerDialogsUploadSettingsActionBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class FileManagerDialogsUploadSettingsActionBuilder
  {
    public FileManagerDialogsUploadSettingsActionBuilder(
      FileManagerDialogsUploadSettingsAction container)
    {
      this.Container = container;
    }

    protected FileManagerDialogsUploadSettingsAction Container { get; private set; }

    public FileManagerDialogsUploadSettingsActionBuilder Text(
      string value)
    {
      this.Container.Text = value;
      return this;
    }

    public FileManagerDialogsUploadSettingsActionBuilder Action(
      string handler)
    {
      this.Container.Action = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public FileManagerDialogsUploadSettingsActionBuilder Action(
      Func<object, object> handler)
    {
      this.Container.Action = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public FileManagerDialogsUploadSettingsActionBuilder Primary(
      bool value)
    {
      this.Container.Primary = new bool?(value);
      return this;
    }
  }
}
