using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TriNamUI.Extensions;
using TriNamUI.Infrastructure;
using TriNamUI.Rendering;

namespace TriNamUI.TagHelpers
{
    /// <summary>
    /// Xây dựng class TagHelper dùng để build component, mở rộng thẻ Html trong razor view 
    /// </summary>
    public abstract partial class TagHelperBase : TagHelper
    {
        #region Fields

        internal static readonly string DeferredScriptsKey = "$DeferredScriptsKeys";

        private static readonly Regex StringFormatExpression = new("(?<=\\{\\d:)(.)*(?=\\})", RegexOptions.Compiled);

        private static readonly Regex UnicodeEntityExpression = new("\\\\+u(\\d+)\\\\*#(\\d+;)", RegexOptions.Compiled);

        protected const string MinimumValidator = "min";

        protected const string MaximumValidator = "max";

        #endregion

        #region Properties

        [HtmlAttributeNotBound]
        [ViewContext]
        public ViewContext ViewContext { get; set; }

        [HtmlAttributeNotBound]
        protected ITriNamHtmlGenerator Generator { get; set; }

        [HtmlAttributeNotBound]
        public IJavaScriptInitializer Initializer { get; set; }

        public string Name { get; set; }

        [HtmlAttributeNotBound]
        public string Id { get; set; }

        public string Selector => IdPrefix + Id;

        public string IdPrefix
        {
            get
            {
                if (!IsInClientTemplate)
                {
                    return "#";
                }
                return "\\#";
            }
        }

        public bool IsInClientTemplate { get; set; }

        public bool Deferred { get; set; }

        #endregion

        #region Ctor

        public TagHelperBase(ITriNamHtmlGenerator generator)
            : base()
        {
            Generator = generator;
            Initializer = new JavaScriptInitializer();
        }

        #endregion

        #region Ultilities

        /// <summary>
        /// Render Html script: 
        /// </summary>
        /// <param name="script"></param>
        private void AppendScriptToContext(string script)
        {
            IDictionary<object, object> items = ViewContext.HttpContext.Items;
            List<KeyValuePair<string, string>> list = new();
            if (items.ContainsKey(DeferredScriptsKey))
            {
                list = (List<KeyValuePair<string, string>>)items[DeferredScriptsKey];
            }
            else
            {
                items[DeferredScriptsKey] = list;
            }
            list.Add(new KeyValuePair<string, string>(Name, script));
        }

        /// <summary>
        /// Wrapper script in render tag
        /// </summary>
        /// <param name="initializationScript"></param>
        /// <returns></returns>
        private string WrapInScriptTag(string initializationScript)
        {
            string text = "<script>" + initializationScript + "</script>";
            if (IsInClientTemplate)
            {
                text = text.Replace("</script>", "<\\/script>");
            }
            return text;
        }

        /// <summary>
        /// VerifySettings
        /// </summary>
        protected virtual void VerifySettings()
        {
        }

        #endregion

        #region ITagHelper

        /// <summary>
        /// Phương thức đồng bộ: Khởi tạo xử lý TagHelperContext nhằm build html tag
        /// </summary>
        /// <param name="context"></param>
        /// <param name="output"></param>
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            VerifySettings();
            WriteHtml(output);
            string text = GetInitializationScript();
            if (IsInClientTemplate)
            {
                text = UnicodeEntityExpression.Replace(text, (Match m) => WebUtility.HtmlDecode(Regex.Unescape("\\u" + m.Groups[1].Value + "#" + m.Groups[2].Value)));
                text = WebUtility.HtmlDecode(text);
            }
            string htmlContent = WrapInScriptTag(text);
            if (Deferred)
            {
                AppendScriptToContext(text);
            }
            else
            {
                output.PostElement.SetHtmlContent(htmlContent);
            }
        }

        /// <summary>
        /// Phương thức bất đồng bộ nhằm khởi tạo build Html Tag
        /// </summary>
        /// <param name="context"></param>
        /// <param name="output"></param>
        /// <returns></returns>
        public override Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            return base.ProcessAsync(context, output);
        }

        #endregion

        #region Abstract

        /// <summary>
        /// Abstract method render html
        /// </summary>
        /// <param name="output"></param>
        protected abstract void WriteHtml(TagHelperOutput output);

        /// <summary>
        /// Get init scripts
        /// </summary>
        /// <returns></returns>
        protected abstract string GetInitializationScript();

        protected virtual Dictionary<string, object> SerializeSettings()
        {
            return SerializeEvents();
        }

        protected abstract Dictionary<string, object> SerializeEvents();

        protected void GenerateId(TagHelperOutput output)
        {
            string fullHtmlFieldName = ViewContext.GetFullHtmlFieldName(Name);
            if (output.Attributes.ContainsName("id"))
            {
                Id = output.Attributes["id"].Value.ToString();
                Name = (string.IsNullOrEmpty(fullHtmlFieldName) ? Id : fullHtmlFieldName);
            }
            else
            {
                Id = fullHtmlFieldName;
            }
            Id = Generator.SanitizeId(Id);
        }

        protected ClientHandlerDescriptor CreateHandler(string handler)
        {
            return new ClientHandlerDescriptor
            {
                HandlerName = handler
            };
        }

        protected TValue? GetRangeValidationParameter<TValue>(ModelExplorer explorer, string parameter) where TValue : struct
        {
            if (explorer.Metadata.ValidatorMetadata.FirstOrDefault((object attr) => attr is RangeAttribute) is RangeAttribute rangeAttribute && rangeAttribute != null)
            {
                return (TValue)Convert.ChangeType((parameter == "min") ? rangeAttribute.Minimum : rangeAttribute.Maximum, typeof(TValue));
            }
            return null;
        }

        protected string ExtractEditFormat(string format)
        {
            if (string.IsNullOrEmpty(format))
            {
                return string.Empty;
            }
            return StringFormatExpression.Match(format).ToString();
        }

        protected Dictionary<string, object> ToDictionaryHandler(IDictionary<string, string> rules)
        {
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            foreach (string key in rules.Keys)
            {
                dictionary[key] = CreateHandler(rules[key]);
            }
            return dictionary;
        }

        #endregion
    }
}
