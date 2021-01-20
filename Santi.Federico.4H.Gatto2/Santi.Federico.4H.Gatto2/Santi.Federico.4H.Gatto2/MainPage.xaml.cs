using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using SkiaSharp;
using SkiaSharp.Views.Forms;
using System.Diagnostics;


namespace Santi.Federico._4H.Gatto2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        void rozzirefresh(object sender, SkiaSharp.Views.Forms.SKPaintSurfaceEventArgs e)
        {
            SKImageInfo info = e.Info;
            SKSurface surface = e.Surface;

            SKCanvas canvas = surface.Canvas;

            canvas.Clear();

            SKPath Diagonale1 = new SKPath();

            SKPoint p = new SKPoint(0, 0);
            Diagonale1.MoveTo(p);

            p = new SKPoint(200, 200);
            Diagonale1.LineTo(p);

            p = new SKPoint(400, 0);
            Diagonale1.LineTo(p);

            SKPaint paint1 = new SKPaint
            {
                Style = SKPaintStyle.Stroke,
                Color = SKColors.DarkGreen,
                StrokeWidth = 3

            };

            canvas.DrawPath(Diagonale1, paint1);

        }
    }
}
