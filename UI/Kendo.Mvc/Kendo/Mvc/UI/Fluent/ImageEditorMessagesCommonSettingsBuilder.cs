// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ImageEditorMessagesCommonSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class ImageEditorMessagesCommonSettingsBuilder
  {
    public ImageEditorMessagesCommonSettingsBuilder(ImageEditorMessagesCommonSettings container) => this.Container = container;

    protected ImageEditorMessagesCommonSettings Container { get; private set; }

    public ImageEditorMessagesCommonSettingsBuilder Width(
      string value)
    {
      this.Container.Width = value;
      return this;
    }

    public ImageEditorMessagesCommonSettingsBuilder Height(
      string value)
    {
      this.Container.Height = value;
      return this;
    }

    public ImageEditorMessagesCommonSettingsBuilder Cancel(
      string value)
    {
      this.Container.Cancel = value;
      return this;
    }

    public ImageEditorMessagesCommonSettingsBuilder Confirm(
      string value)
    {
      this.Container.Confirm = value;
      return this;
    }

    public ImageEditorMessagesCommonSettingsBuilder LockAspectRatio(
      string value)
    {
      this.Container.LockAspectRatio = value;
      return this;
    }
  }
}
