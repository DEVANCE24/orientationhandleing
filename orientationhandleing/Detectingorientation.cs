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
    [Activity(Label = "Detectingorientation", Theme = "@style/AppTheme", MainLauncher = false)]
    public class Detectingorientation : Activity
    {
        protected override void OnCreate(Bundle bundle)

        {
            base.OnCreate(bundle);
            var rl = new LinearLayout(this);

            var layoutParams = new RelativeLayout.LayoutParams
            (ViewGroup.LayoutParams.FillParent, ViewGroup.LayoutParams.FillParent);

            rl.LayoutParameters = layoutParams;

            var surfaceOrientation = WindowManager.DefaultDisplay.Rotation;

            RelativeLayout.LayoutParams tvLayoutParams;

            if (surfaceOrientation == SurfaceOrientation.Rotation0 || surfaceOrientation ==
            SurfaceOrientation.Rotation180)
            {
                tvLayoutParams = new RelativeLayout.LayoutParams
                (ViewGroup.LayoutParams.FillParent, ViewGroup.LayoutParams.WrapContent);

            }
            else
            {
                tvLayoutParams = new RelativeLayout.LayoutParams
                (ViewGroup.LayoutParams.FillParent, ViewGroup.LayoutParams.WrapContent);

                tvLayoutParams.LeftMargin = 100;

                tvLayoutParams.TopMargin = 100;

            }

            var tv = new TextView(this);
            tv.LayoutParameters = tvLayoutParams;
            tv.Text = "Programmatic layout";
            rl.AddView(tv);
            SetContentView(rl);

        } 
    }


    
}
