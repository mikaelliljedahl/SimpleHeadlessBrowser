// -----------------------------------------------------------------------
// <copyright file="NavigationState.cs" company="SimpleBrowser">
// Copyright © 2010 - 2019, Nathan Ridley and the SimpleBrowser contributors.
// See https://github.com/SimpleBrowserDotNet/SimpleBrowser/blob/master/readme.md
// </copyright>
// -----------------------------------------------------------------------

namespace SimpleBrowser
{
    using System;
    using System.Collections.Generic;
    using System.Xml.Linq;

    internal class NavigationState
    {
        public Uri Uri;
        public string ContentType;
        public string Html;
        internal XDocument XDocument;
        public Uri Referer { get; set; }

        public readonly List<HtmlElement> Elements = new List<HtmlElement>();

        public void Invalidate()
        {
            this.Elements.ForEach(e => e.Invalidate());
        }
    }
}