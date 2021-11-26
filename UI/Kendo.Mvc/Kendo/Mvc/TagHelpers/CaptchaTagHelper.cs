// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.CaptchaTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("kendo-captcha", TagStructure = TagStructure.NormalOrSelfClosing)]
  [HtmlTargetElement("captcha-editor", ParentTag = "form-item", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("messages", new string[] {"handler", "audio-handler", "validation-handler"})]
  public class CaptchaTagHelper : TagHelperBase, IKendoFormEditor
  {
    public 
    #nullable disable
    ModelExpression For { get; set; }

    [HtmlAttributeNotBound]
    public CaptchaHandlerSettingsTagHelper Handler { get; set; }

    [HtmlAttributeNotBound]
    public CaptchaValidationHandlerSettingsTagHelper ValidationHandler { get; set; }

    [HtmlAttributeNotBound]
    public CaptchaAudioHandlerSettingsTagHelper AudioHandler { get; set; }

    [HtmlAttributeNotBound]
    public bool IsNested { get; set; }

    public string CaptchaImage { get; set; }

    [HtmlAttributeName("datacaptchafield")]
    public string DataCaptchaField { get; set; }

    [HtmlAttributeName("datacaptchaidfield")]
    public string DataCaptchaIdField { get; set; }

    public CaptchaTagHelper(IKendoHtmlGenerator generator)
      : base(generator)
    {
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      CaptchaTagHelper captchaTagHelper = this;
      context.Items[(object) captchaTagHelper.GetType()] = (object) captchaTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      // ISSUE: explicit non-virtual call
      if (__nonvirtual (captchaTagHelper.TryAddToForm(context)))
        output.SuppressOutput();
      // ISSUE: reference to a compiler-generated method
      await captchaTagHelper.\u003C\u003En__0(context, output);
    }

    protected override void WriteHtml(TagHelperOutput output)
    {
      ModelExplorer modelExplorer = (ModelExplorer) null;
      if (this.For != null)
      {
        modelExplorer = this.For.ModelExplorer;
        this.Name = this.For.Name;
      }
      if (this.IsNested && string.IsNullOrEmpty(this.Name))
        this.Name = Guid.NewGuid().ToString();
      this.GenerateId(output);
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      TagBuilder input = this.Generator.GenerateInput(this.ViewContext, modelExplorer, this.Id, this.Name, (object) null, string.Empty, string.Empty, (IDictionary<string, object>) dictionary);
      output.TagName = "input";
      output.TagMode = TagMode.StartTagAndEndTag;
      output.MergeAttributes(input);
    }

    protected override string GetInitializationScript() => this.Initializer.Initialize(this.Selector, "Captcha", (IDictionary<string, object>) this.Serialize());

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      string dataCaptchaField = this.DataCaptchaField;
      if ((dataCaptchaField != null ? (dataCaptchaField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataCaptchaField"] = (object) this.DataCaptchaField;
      string dataCaptchaIdField = this.DataCaptchaIdField;
      if ((dataCaptchaIdField != null ? (dataCaptchaIdField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataCaptchaIdField"] = (object) this.DataCaptchaIdField;
      string captchaImage = this.CaptchaImage;
      if ((captchaImage != null ? (captchaImage.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["captcha"] = (object) this.CaptchaImage;
      if (this.Handler != null)
      {
        Dictionary<string, object> source = this.Handler.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
        {
          dictionary["handler"] = (object) source;
        }
        else
        {
          string functionHandler = this.Handler.FunctionHandler;
          if ((functionHandler != null ? (functionHandler.HasValue() ? 1 : 0) : 0) != 0)
            dictionary["handler"] = (object) this.CreateHandler(this.Handler.FunctionHandler);
        }
      }
      if (this.AudioHandler != null)
      {
        Dictionary<string, object> source = this.AudioHandler.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
        {
          dictionary["audioHandler"] = (object) source;
        }
        else
        {
          string functionHandler = this.AudioHandler.FunctionHandler;
          if ((functionHandler != null ? (functionHandler.HasValue() ? 1 : 0) : 0) != 0)
            dictionary["audioHandler"] = (object) this.CreateHandler(this.AudioHandler.FunctionHandler);
        }
      }
      if (this.ValidationHandler != null)
      {
        Dictionary<string, object> source = this.ValidationHandler.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
        {
          dictionary["validationHandler"] = (object) source;
        }
        else
        {
          string functionHandler = this.ValidationHandler.FunctionHandler;
          if ((functionHandler != null ? (functionHandler.HasValue() ? 1 : 0) : 0) != 0)
            dictionary["validationHandler"] = (object) this.CreateHandler(this.ValidationHandler.FunctionHandler);
        }
      }
      return dictionary;
    }

    public bool TryAddToForm(TagHelperContext context)
    {
      foreach (KeyValuePair<object, object> keyValuePair in context.Items.Reverse<KeyValuePair<object, object>>())
      {
        if (keyValuePair.Value is FormItemTagHelper formItemTagHelper1)
        {
          this.IsNested = true;
          formItemTagHelper1.EditorOptions = this.Serialize();
          formItemTagHelper1.Editor = "Captcha";
          return true;
        }
      }
      return false;
    }

    public string OnChange { get; set; }

    public string OnRequestEnd { get; set; }

    public string OnRequestStart { get; set; }

    public string OnError { get; set; }

    protected override Dictionary<string, object> SerializeEvents()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string onChange = this.OnChange;
      if ((onChange != null ? (onChange.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["change"] = (object) this.CreateHandler(this.OnChange);
      string onRequestEnd = this.OnRequestEnd;
      if ((onRequestEnd != null ? (onRequestEnd.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["requestEnd"] = (object) this.CreateHandler(this.OnRequestEnd);
      string onRequestStart = this.OnRequestStart;
      if ((onRequestStart != null ? (onRequestStart.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["requestStart"] = (object) this.CreateHandler(this.OnRequestStart);
      string onError = this.OnError;
      if ((onError != null ? (onError.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["error"] = (object) this.CreateHandler(this.OnError);
      return dictionary;
    }

    public bool? AudioButton { get; set; }

    public string CaptchaId { get; set; }

    [HtmlAttributeNotBound]
    public CaptchaMessagesSettingsTagHelper Messages { get; set; }

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
      if (this.Messages != null)
      {
        Dictionary<string, object> source = this.Messages.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["messages"] = (object) source;
      }
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
