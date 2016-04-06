using DemoViewFramework;
using Xamarin.Forms;
using XamarinFormsDemos.Views;

namespace XamarinFormsDemos.ViewModels
{
  public class AnimationBehaviorsViewModel : PageViewModelBase
  {
    public AnimationBehaviorsViewModel()
    {
      MenuFromTopCommand = new Command(() => NavigationService.NavigateTo<MenuFromTopViewModel>());
      MenuSlideInCommand = new Command(() => NavigationService.NavigateTo<MenuSlideInViewModel>());
    }

    public Command MenuFromTopCommand { get; private set; }
    public Command MenuSlideInCommand { get; private set; }
  }
}