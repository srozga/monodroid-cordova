/* Copyright (c) 2013 Szymon Rozga
 *
 * See the file LICENSE.txt for copying permission. */

using System;
using Org.Apache.Cordova;
using Org.Apache.Cordova.Api;

namespace Rozga.MonoDroid.PluginSample.Plugins
{
    public class SamplePlugin : XamarinCordovaPlugin
    {
        private int counter = 0;

        public override bool Execute(String action, CordovaArgs args, CallbackContext context)
        {
            counter++;
            context.Success(counter.ToString());
            return true;
        }

    }
}