namespace DemoViewFramework
{
  public interface IPageViewModelBase
  {
    void OnViewInitialized(bool value);

    void OnViewAppearing(object state = null );

    void OnViewDisappearing();

    INavigationService NavigationService { get; set; }

  }
}
