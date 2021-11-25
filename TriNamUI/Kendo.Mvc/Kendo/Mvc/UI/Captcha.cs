// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Captcha
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class Captcha : WidgetBase, IFormEditor
  {
    public string CaptchaImage { get; set; }

    public CrudOperation AudioHandler { get; set; }

    public ClientHandlerDescriptor AudioHandlerFunction { get; set; }

    public CrudOperation Handler { get; set; }

    public ClientHandlerDescriptor HandlerFunction { get; set; }

    public CrudOperation ValidationHandler { get; set; }

    public ClientHandlerDescriptor ValidationHandlerFunction { get; set; }

    public Captcha(ViewContext viewContext)
      : base(viewContext)
    {
    }

    protected override void WriteHtml(TextWriter writer)
    {
      this.Generator.GenerateInput(this.ViewContext, this.Explorer ?? ExpressionMetadataProvider.FromStringExpression(this.Name, this.HtmlHelper.ViewData, this.HtmlHelper.MetadataProvider), this.Id, this.Name, (object) null, string.Empty, string.Empty, this.HtmlAttributes).WriteTo(writer, this.HtmlEncoder);
      base.WriteHtml(writer);
    }

    public override void WriteInitializationScript(TextWriter writer)
    {
      IDictionary<string, object> options = this.Serialize();
      writer.Write(this.Initializer.Initialize(this.Selector, nameof (Captcha), options));
    }

    public IDictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      if (this.AudioHandler != null)
        dictionary["audioHandler"] = (object) this.AudioHandler.ToJson();
      else if (this.AudioHandlerFunction != null)
        dictionary["audioHandler"] = (object) this.AudioHandlerFunction;
      if (this.Handler != null)
        dictionary["handler"] = (object) this.Handler.ToJson();
      else if (this.HandlerFunction != null)
        dictionary["handler"] = (object) this.HandlerFunction;
      if (this.ValidationHandler != null)
        dictionary["validationHandler"] = (object) this.ValidationHandler.ToJson();
      else if (this.ValidationHandlerFunction != null)
        dictionary["validationHandler"] = (object) this.ValidationHandlerFunction;
      string captchaImage = this.CaptchaImage;
      if ((captchaImage != null ? (captchaImage.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["captcha"] = (object) this.CaptchaImage;
      return (IDictionary<string, object>) dictionary;
    }

    public bool? AudioButton { get; set; }

    public string CaptchaId { get; set; }

    public string DataCaptchaField { get; set; }

    public string DataCaptchaIdField { get; set; }

    public CaptchaMessagesSettings Messages { get; } = new CaptchaMessagesSettings();

    public bool? ResetButton { get; set; }

    public bool? ValidateOnBlur { get; set; }

    public bool? VolumeControl { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = base.SerializeSettings();
      if (this.AudioButton.HasValue)
        dictionary["audioButton"] = (object) this.AudioButton;
      string captchaId = this.CaptchaId;
      if ((captchaId != null ? (captchaId.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["captchaId"] = (object) this.CaptchaId;
      string dataCaptchaField = this.DataCaptchaField;
      if ((dataCaptchaField != null ? (dataCaptchaField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataCaptchaField"] = (object) this.DataCaptchaField;
      string dataCaptchaIdField = this.DataCaptchaIdField;
      if ((dataCaptchaIdField != null ? (dataCaptchaIdField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataCaptchaIdField"] = (object) this.DataCaptchaIdField;
      Dictionary<string, object> source = this.Messages.Serialize();
      if (source.Any<KeyValuePair<string, object>>())
        dictionary["messages"] = (object) source;
      if (this.ResetButton.HasValue)
        dictionary["resetButton"] = (object) this.ResetButton;
      if (this.ValidateOnBlur.HasValue)
        dictionary["validateOnBlur"] = (object) this.ValidateOnBlur;
      if (this.VolumeControl.HasValue)
        dictionary["volumeControl"] = (object) this.VolumeControl;
      return dictionary;
    }
  }
}
