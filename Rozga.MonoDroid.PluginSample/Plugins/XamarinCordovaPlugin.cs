/* Copyright (c) 2013 Szymon Rozga
 *
 * See the file LICENSE.txt for copying permission. */

using System;
using Org.Apache.Cordova;
using Org.Apache.Cordova.Api;

namespace Rozga.MonoDroid.PluginSample.Plugins
{
    public abstract class XamarinCordovaPlugin : CordovaPlugin
    {
        private CordovaWebView webView;
        private DroidGap context;

        public override bool Execute(String action, CordovaArgs args, CallbackContext context)
        {
            return false;
        }
        public virtual void InitializePlugin(CordovaWebView webView, DroidGap context)
        {
            this.webView = webView;
            this.context = context;
        }
    }
}