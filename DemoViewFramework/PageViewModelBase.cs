using GalaSoft.MvvmLight;

namespace DemoViewFramework
{
  public class PageViewModelBase : ViewModelBase, IPageViewModelBase
  {
    public virtual void OnViewInitialized(bool value)
    {
      ViewIsInitialized = value;
    }

    private bool _viewIsInitialized;

    public bool ViewIsInitialized
    {
      get { return _viewIsInitialized; }
      set { Set(() => ViewIsInitialized, ref _viewIsInitialized, value); }
    }

    public virtual void OnViewAppearing(object state = null)
    {
      ViewHasAppeared = true;
    }

    public virtual void OnViewDisappearing()
    {
      ViewHasAppeared = false;
    }

    private bool _viewHasAppeared;
    public bool ViewHasAppeared
    {
      get { return _viewHasAppeared; }
      set { Set(() => ViewHasAppeared, ref _viewHasAppeared, value); }
    }


    public INavigationService NavigationService { get; set; }
  }
}
