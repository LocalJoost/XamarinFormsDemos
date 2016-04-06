using Xamarin.Forms;

namespace DemoViewFramework
{
  public class BaseContentPage : ContentPage
  {
    protected override void OnAppearing()
    {
      base.OnAppearing();
      Context?.OnViewAppearing();
    }

    protected override void OnSizeAllocated(double width, double height)
    {
      base.OnSizeAllocated(width, height);
      Context?.OnViewInitialized(true);
    }

    protected override void OnDisappearing()
    {
      base.OnDisappearing();
      Context?.OnViewInitialized(false);
      Context?.OnViewDisappearing();
    }

    private IPageViewModelBase Context => (IPageViewModelBase)BindingContext;
  }
}
