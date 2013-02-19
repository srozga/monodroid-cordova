/* Copyright (c) 2013 Szymon Rozga
 *
 * See the file LICENSE.txt for copying permission. */
using Android.App;
using Android.OS;
using Org.Apache.Cordova;
using Org.Apache.Cordova.Api;
using Rozga.MonoDroid.PluginSample.Plugins;

namespace Rozga.MonoDroid.PluginSample
{
    [Activity(Label = "MonoDroidSampleApp", MainLauncher = true, Icon = "@drawable/icon")]
    public class CordovaActivity : DroidGap
    {
        public override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            Init(); // call this to ensure AppView.PluginManager is initialized
            InitXamarinPlugins(AppView, AppView.PluginManager);
            LoadUrl(Config.StartUrl);
        }

        private void InitXamarinPlugins(CordovaWebView webView, PluginManager pluginManager)
        {
            pluginManager.AddService(new XamarinCordovaPluginEntry<SamplePlugin>("Sample", webView, this));
        }
    }
}

