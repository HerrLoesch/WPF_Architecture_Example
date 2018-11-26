namespace FotoMaX.UI.MVVM
{
    using System.Windows;

    public class ViewModelDiscoverer : DependencyObject
    {
        public static readonly DependencyProperty AutoWireViewModelsProperty = DependencyProperty.Register("AutoWireViewModels", typeof(bool), typeof(ViewModelDiscoverer), new PropertyMetadata(default(bool)));

        public bool AutoWireViewModels
        {
            get
            {
                return (bool)this.GetValue(AutoWireViewModelsProperty);
            }
            set
            {
                this.SetValue(AutoWireViewModelsProperty, value);
            }
        }
    }
}
