using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace orientationhandleing
{
    [Activity(Label = "Preventingrestart",
    ConfigurationChanges=Android.Content.PM.ConfigChanges.Orientation |
Android.Content.PM.ConfigChanges.ScreenSize)]

public class Preventingrestart : Activity

    {

        TextView _tv;

        LinearLayout.LayoutParams _layoutParamsPortrait;

        LinearLayout.LayoutParams _layoutParamsLandscape;

        protected override void OnCreate(Bundle bundle)
        {   var rl = new LinearLayout(this);
            var layoutParams = new LinearLayout.LayoutParams
            (ViewGroup.LayoutParams.FillParent, ViewGroup.LayoutParams.FillParent);
            rl.LayoutParameters = layoutParams;
            var surfaceOrientation = WindowManager.DefaultDisplay.Rotation;
            _layoutParamsPortrait = new LinearLayout.LayoutParams
            (ViewGroup.LayoutParams.FillParent, ViewGroup.LayoutParams.WrapContent);

            _layoutParamsLandscape = new LinearLayout.LayoutParams
            (ViewGroup.LayoutParams.FillParent, ViewGroup.LayoutParams.WrapContent);

            _layoutParamsLandscape.LeftMargin = 100;

            _layoutParamsLandscape.TopMargin = 100;

            _tv = new TextView(this);

            if (surfaceOrientation == SurfaceOrientation.Rotation0 || surfaceOrientation ==
            SurfaceOrientation.Rotation180)
            {

                _tv.LayoutParameters = _layoutParamsPortrait;

            }
            else
            {

                _tv.LayoutParameters = _layoutParamsLandscape;

            }

            _tv.Text = "Programmatic layout";

            
            rl.AddView(_tv);

            SetContentView(rl);

        }

        public override void OnConfigurationChanged(Android.Content.Res.Configuration
        newConfig)

        {

            base.OnConfigurationChanged(newConfig);

            if (newConfig.Orientation == Android.Content.Res.Orientation.Portrait)
            {

                _tv.LayoutParameters = _layoutParamsPortrait;

                _tv.Text = "Changed to portrait";

            }
            else if (newConfig.Orientation == Android.Content.Res.Orientation.Landscape)
            {

                _tv.LayoutParameters = _layoutParamsLandscape;

                _tv.Text = "Changed to landscape";

            }

        }

    }
}