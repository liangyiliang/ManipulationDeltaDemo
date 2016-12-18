using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

namespace ManipulationDeltaDemo {
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            Btn.ManipulationMode = ManipulationModes.TranslateY | ManipulationModes.TranslateX;
        }
        private void Btn_ManipulationDelta(object sender, ManipulationDeltaRoutedEventArgs e) {
            double moveX = Canvas.GetLeft(Btn) + e.Delta.Translation.X;
            double moveY = Canvas.GetTop(Btn) + e.Delta.Translation.Y;
            if(moveX >= 0 && moveX <= MyCanvas.ActualWidth - Btn.ActualWidth) Canvas.SetLeft(Btn, moveX);
            if(moveY >= 0 && moveY <= MyCanvas.ActualHeight - Btn.ActualHeight) Canvas.SetTop(Btn, moveY);
        }
    }
}
