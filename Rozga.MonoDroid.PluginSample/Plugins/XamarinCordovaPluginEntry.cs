/* Copyright (c) 2013 Szymon Rozga
 *
 * See the file LICENSE.txt for copying permission. */

using System;
using Org.Apache.Cordova;
using Org.Apache.Cordova.Api;

namespace Rozga.MonoDroid.PluginSample.Plugins
{
    public class XamarinCordovaPluginEntry<T> : PluginEntry where T : XamarinCordovaPlugin, new()
    {
        public XamarinCordovaPluginEntry(String service, CordovaWebView webView, DroidGap context)
            : base(service, string.Empty, false)
        {
            CreatePlugin(webView, context);
        }

        protected CordovaPlugin CreatePlugin(CordovaWebView webView, DroidGap context)
        {
            var t = new T();
            t.InitializePlugin(webView, context);
            Plugin = t; // this will ensure Cordova finds the Plugin
            return Plugin;
        }
    }
}