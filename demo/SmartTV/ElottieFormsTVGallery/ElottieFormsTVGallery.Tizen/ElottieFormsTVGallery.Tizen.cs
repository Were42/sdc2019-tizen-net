using Xamarin.Forms;
using Xamarin.Forms.Platform.Tizen;

namespace ElottieFormsTVGallery
{
    class Program : FormsApplication
    {
        protected override void OnCreate()
        {
            base.OnCreate();
            LoadApplication(new App());
        }

        static void Main(string[] args)
        {
            var app = new Program();
            Forms.Init(app);
            app.Run(args);
        }
    }
}
