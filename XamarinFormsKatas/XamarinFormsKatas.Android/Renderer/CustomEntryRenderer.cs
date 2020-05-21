using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Text;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XamarinFormsKatas.Droid;
using XamarinFormsKatas.Katas_UI.Kata_j.Control;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer))]
[assembly: ExportRenderer(typeof(XamarinFormsKatas.Katas_UI.Kata_q.Control.CustomEntry), typeof(CustomEntryRenderer))]
namespace XamarinFormsKatas.Droid
{
    public class CustomEntryRenderer : EntryRenderer
    {
        public CustomEntryRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if(Control != null)
            {
                GradientDrawable gd = new GradientDrawable();
                gd.SetColor(global::Android.Graphics.Color.Transparent);
                this.Control.SetBackground(gd);
                this.Control.SetRawInputType(InputTypes.TextFlagNoSuggestions);
                Control.SetHintTextColor(ColorStateList.ValueOf(global::Android.Graphics.Color.Black));
            }
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            if (e.PropertyName == "BorderColor")
            {
                var entry = (Xamarin.Forms.Entry)sender;
                var result = new GradientDrawable();
                result.SetShape(ShapeType.Rectangle);
                result.SetStroke(2, Android.Graphics.Color.Red);
                Control.SetBackground(result);
            }
        }
    }
}