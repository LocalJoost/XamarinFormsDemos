using DemoViewFramework;
using Xamarin.Forms;

namespace XamarinFormsDemos.ViewModels
{
  public class AnimationBehaviorsViewModel : PageViewModelBase
  {
    public AnimationBehaviorsViewModel()
    {
      MenuFromTopCommand = new Command(() => NavigationService.NavigateTo<MenuFromTopViewModel>());
      MenuSlideInCommand = new Command(() => NavigationService.NavigateTo<MenuSlideInViewModel>());
      PopupCommand = new Command(() => NavigationService.NavigateTo<PopupViewModel>());
    }

    public Command MenuFromTopCommand { get; private set; }
    public Command MenuSlideInCommand { get; private set; }
    public Command PopupCommand { get; private set; }
  }
}