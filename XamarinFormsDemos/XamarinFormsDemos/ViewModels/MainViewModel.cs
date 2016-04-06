using DemoViewFramework;
using Xamarin.Forms;
using XamarinFormsDemos.Views;

namespace XamarinFormsDemos.ViewModels
{
  public class MainViewModel : PageViewModelBase
  {
    public MainViewModel()
    {
      AnimationBehaviorsCommand = new Command(() => NavigationService.NavigateTo<AnimationBehaviorsViewModel>());
    }

    public Command AnimationBehaviorsCommand { get; private set; }
  }
}