using System;
using System.Collections.Generic;

namespace DemoViewFramework
{
  public class SimplePageFactory : ISimplePageFactory
  {
    private static readonly Dictionary<Type, Type> ViewMap = 
      new Dictionary<Type, Type>();

    public void RegisterPageViewModel<TViewModel, TView>()
        where TView : BaseContentPage
        where TViewModel : IPageViewModelBase
    {
      ViewMap[typeof(TViewModel)] = typeof(TView);
    }

    public BaseContentPage CreatePageFor<TViewModel>(INavigationService navigationService)
    {
      var page = (BaseContentPage)Activator.CreateInstance(ViewMap[typeof(TViewModel)]);
      var viewModel = (IPageViewModelBase)Activator.CreateInstance(typeof(TViewModel));
      viewModel.NavigationService = navigationService;
      page.BindingContext = viewModel;

      return page;
    }
  }
}