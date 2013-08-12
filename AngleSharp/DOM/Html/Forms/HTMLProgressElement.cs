﻿using AngleSharp.DOM.Collections;
using System;

namespace AngleSharp.DOM.Html
{
    /// <summary>
    /// Represents the HTML progress element.
    /// </summary>
    [DOM("HTMLProgressElement")]
    public sealed class HTMLProgressElement : HTMLElement, ILabelabelElement
    {
        #region Constant

        /// <summary>
        /// The progress tag.
        /// </summary>
        internal const String Tag = "progress";

        #endregion

        #region Members

        NodeList labels;

        #endregion

        #region ctor

        /// <summary>
        /// Creates a new HTML progress element.
        /// </summary>
        internal HTMLProgressElement()
        {
            _name = Tag;
            labels = new NodeList();
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets if labels are supported.
        /// </summary>
        [DOM("supportsLabels")]
        public Boolean SupportsLabels
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the list of assigned labels.
        /// </summary>
        [DOM("labels")]
        public NodeList Labels
        {
            get { return labels; }
        }

        //TODO
        //http://www.w3.org/html/wg/drafts/html/master/forms.html#the-progress-element

        /// <summary>
        /// Gets or sets the current value.
        /// </summary>
        [DOM("value")]
        public Double Value
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the maximum value.
        /// </summary>
        [DOM("max")]
        public Double Max
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the position.
        /// </summary>
        [DOM("position")]
        public Double Position
        {
            get;
            private set;
        }

        #endregion

        #region Internal properties

        /// <summary>
        /// Gets if the node is in the special category.
        /// </summary>
        protected internal override Boolean IsSpecial
        {
            get { return false; }
        }

        #endregion
    }
}
