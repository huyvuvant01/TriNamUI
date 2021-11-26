// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.FileManagerUploadSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class FileManagerUploadSettings
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public ClientHandlerDescriptor Cancel { get; set; }

    public ClientHandlerDescriptor Clear { get; set; }

    public ClientHandlerDescriptor Complete { get; set; }

    public ClientHandlerDescriptor Error { get; set; }

    public ClientHandlerDescriptor Pause { get; set; }

    public ClientHandlerDescriptor Progress { get; set; }

    public ClientHandlerDescriptor Resume { get; set; }

    public ClientHandlerDescriptor Remove { get; set; }

    public ClientHandlerDescriptor Select { get; set; }

    public ClientHandlerDescriptor Success { get; set; }

    public ClientHandlerDescriptor Upload { get; set; }

    public FileManagerUploadAsyncSettings Async { get; } = new FileManagerUploadAsyncSettings();

    public bool? Directory { get; set; }

    public FileManagerUploadLocalizationSettings Localization { get; } = new FileManagerUploadLocalizationSettings();

    public bool? Multiple { get; set; }

    public bool? ShowFileList { get; set; }

    public FileManagerUploadValidationSettings Validation { get; } = new FileManagerUploadValidationSettings();

    public FileManager FileManager { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      ClientHandlerDescriptor cancel = this.Cancel;
      if ((cancel != null ? (cancel.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["cancel"] = (object) this.Cancel;
      ClientHandlerDescriptor clear = this.Clear;
      if ((clear != null ? (clear.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["clear"] = (object) this.Clear;
      ClientHandlerDescriptor complete = this.Complete;
      if ((complete != null ? (complete.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["complete"] = (object) this.Complete;
      ClientHandlerDescriptor error = this.Error;
      if ((error != null ? (error.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["error"] = (object) this.Error;
      ClientHandlerDescriptor pause = this.Pause;
      if ((pause != null ? (pause.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["pause"] = (object) this.Pause;
      ClientHandlerDescriptor progress = this.Progress;
      if ((progress != null ? (progress.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["progress"] = (object) this.Progress;
      ClientHandlerDescriptor resume = this.Resume;
      if ((resume != null ? (resume.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["resume"] = (object) this.Resume;
      ClientHandlerDescriptor remove = this.Remove;
      if ((remove != null ? (remove.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["remove"] = (object) this.Remove;
      ClientHandlerDescriptor select = this.Select;
      if ((select != null ? (select.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["select"] = (object) this.Select;
      ClientHandlerDescriptor success = this.Success;
      if ((success != null ? (success.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["success"] = (object) this.Success;
      ClientHandlerDescriptor upload = this.Upload;
      if ((upload != null ? (upload.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["upload"] = (object) this.Upload;
      Dictionary<string, object> source1 = this.Async.Serialize();
      if (source1.Any<KeyValuePair<string, object>>())
        dictionary["async"] = (object) source1;
      bool? nullable = this.Directory;
      if (nullable.HasValue)
        dictionary["directory"] = (object) this.Directory;
      Dictionary<string, object> source2 = this.Localization.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
        dictionary["localization"] = (object) source2;
      nullable = this.Multiple;
      if (nullable.HasValue)
        dictionary["multiple"] = (object) this.Multiple;
      nullable = this.ShowFileList;
      if (nullable.HasValue)
        dictionary["showFileList"] = (object) this.ShowFileList;
      Dictionary<string, object> source3 = this.Validation.Serialize();
      if (source3.Any<KeyValuePair<string, object>>())
        dictionary["validation"] = (object) source3;
      return dictionary;
    }
  }
}
