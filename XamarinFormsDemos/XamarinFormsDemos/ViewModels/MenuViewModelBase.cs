using DemoViewFramework;
using Xamarin.Forms;

namespace XamarinFormsDemos.ViewModels
{
  public class MenuViewModelBase : PageViewModelBase
  {
    private bool _isMenuVisible;

    public MenuViewModelBase()
    {
      ToggleMenuCommand = new Command(() => IsMenuVisible = !IsMenuVisible);
    }

    public bool IsMenuVisible
    {
      get { return _isMenuVisible; }
      set { Set(() => IsMenuVisible, ref _isMenuVisible, value); }
    }

    public Command ToggleMenuCommand { get; private set; }
  }
}