﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Dnn.EditBar.Library.Items
{
    [DataContract]
    public abstract class BaseMenuItem
    {
        /// <summary>
        /// the menu item name
        /// </summary>
        [DataMember(Name = "name")]
        public abstract string Name { get; }

        /// <summary>
        /// the content will render as the menu item.
        /// </summary>
        [DataMember(Name = "button")]
        public abstract string Button { get; }

        /// <summary>
        /// the css class for menu item.
        /// </summary>
        [DataMember(Name = "cssClass")]
        public abstract string CssClass { get; }

        /// <summary>
        /// parent which the menu item will stay in.
        /// currently we have LeftMenu and RightMenu defined in edit bar.
        /// if the edit bar modified and add new position, this value can extend with more values.
        /// </summary>
        [DataMember(Name = "parent")]
        public abstract string Parent { get; }

        /// <summary>
        /// the menu order.
        /// </summary>
        [DataMember(Name = "order")]
        public virtual int Order { get; } = 0;

        /// <summary>
        /// the menu script path, which will handle the button click event.
        /// </summary>
        [DataMember(Name = "loader")]
        public abstract string Loader { get; }

        /// <summary>
        /// menu custom settings.
        /// </summary>
        [DataMember(Name = "settings")]
        public virtual IDictionary<string, object> Settings { get; } = new Dictionary<string, object>();

        /// <summary>
        /// whether the menu is visible in current context.
        /// </summary>
        /// <returns></returns>
        public virtual bool Visible()
        {
            return true;
        }
    }
}
