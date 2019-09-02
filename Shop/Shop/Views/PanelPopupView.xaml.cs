namespace Shop.Views
{
    using System;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PanelPopupView : ContentView
    {
        public delegate void TapDelegate();

        public PanelPopupView()
        {
            InitializeComponent();
            GoToState("Collapsed");
        }

        public int HeaderHeight { get; private set; } = 70;

        public TapDelegate OnExpandTapped { get; set; }
        public TapDelegate OnCollapseTapped { get; set; }

        private void ExpandTapped(object sender, EventArgs e)
        {
            GoToState("Expanded");
            OnExpandTapped?.Invoke();
        }

        private void CollapseTapped(object sender, EventArgs e)
        {
            GoToState("Collapsed");
            OnCollapseTapped?.Invoke();
        }
        private void GoToState(string visualState)
        {
            //VisualStateManager.GoToState(BasketSummary, visualState);
            //VisualStateManager.GoToState(CollapseButton, visualState);
            //VisualStateManager.GoToState(ExpandButton, visualState);
        }
    }
}