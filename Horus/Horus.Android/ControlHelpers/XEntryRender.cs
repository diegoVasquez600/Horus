using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Horus.Droid.ControlHelpers;
using Horus.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
#pragma warning disable CS0612 // El tipo o el miembro están obsoletos
[assembly: ExportRenderer(typeof(XEntry), typeof(XEntryRender))]
#pragma warning restore CS0612 // El tipo o el miembro están obsoletos
namespace Horus.Droid.ControlHelpers
{
    [Obsolete]
    public class XEntryRender : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.Background = new ColorDrawable(Android.Graphics.Color.Transparent);
            }
        }
    }
}