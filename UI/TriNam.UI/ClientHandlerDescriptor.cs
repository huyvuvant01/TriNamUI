using System;

namespace TriNamUI
{
    public partial class ClientHandlerDescriptor
    {
        #region Properties

        public virtual Func<object, object> TemplateDelegate { get; set; }

        public virtual string HandlerName { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Kiểm tra ClientHandlerDescription validate
        /// </summary>
        /// <returns></returns>
        public virtual bool HasValue()
        {
            return !(string.IsNullOrWhiteSpace(HandlerName) || TemplateDelegate == null);
        }

        #endregion
    }
}
