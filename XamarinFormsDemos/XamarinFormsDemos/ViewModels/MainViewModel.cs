using DemoViewFramework;
using Xamarin.Forms;

namespace XamarinFormsDemos.ViewModels
{
  public class MainViewModel : PageViewModelBase
  {
    public MainViewModel()
    {
      AnimationBehaviorsCommand = new Command(() => NavigationService.NavigateTo<AnimationBehaviorsViewModel>());
      FloatingPopupBehaviorsCommand = new Command(() => NavigationService.NavigateTo<FloatingPopupViewModel>());
    }

    public Command AnimationBehaviorsCommand { get; private set; }

    public Command FloatingPopupBehaviorsCommand { get; private set; }
  }
}