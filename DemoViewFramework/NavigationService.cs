using Xamarin.Forms;

namespace DemoViewFramework
{
  public class NavigationService : INavigationService
  {
    private readonly INavigation _navigation;
    private readonly ISimplePageFactory _pageFactory;

    public NavigationService(INavigation navigation, ISimplePageFactory pageFactory)
    {
      _navigation = navigation;
      _pageFactory = pageFactory;
    }

    public void NavigateTo<TViewModel>()
    {
      var page = _pageFactory.CreatePageFor<TViewModel>(this);
      _navigation.PushAsync(page);
    }
  }
}
