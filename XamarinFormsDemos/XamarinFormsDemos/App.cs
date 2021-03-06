﻿using System.Reflection;
using DemoViewFramework;
using Wortell.XamarinForms.Extensions;
using Xamarin.Forms;
using XamarinFormsDemos.ViewModels;
using XamarinFormsDemos.Views;

namespace XamarinFormsDemos
{
  public partial class App : Application
  {
    public App()
    {
      InitializeComponent();
      ImageResourceExtension.ResourcePrefix = "XamarinFormsDemos.Assets.Images";
      ImageResourceExtension.Assembly = this.GetType().GetTypeInfo().Assembly;

      if (Current.Resources == null)
      {
        Current.Resources = new ResourceDictionary();
      }

      var pageFactory = new SimplePageFactory();
      pageFactory.RegisterPageViewModel<MainViewModel, StartPage>();
      pageFactory.RegisterPageViewModel<AnimationBehaviorsViewModel, AnimationBehaviorsPage>();
      pageFactory.RegisterPageViewModel<MenuFromTopViewModel, MenuFromTopPage>();
      pageFactory.RegisterPageViewModel<MenuSlideInViewModel, MenuSlideInPage>();
      pageFactory.RegisterPageViewModel<PopupViewModel, PopupPage>();
      pageFactory.RegisterPageViewModel<FloatingPopupViewModel, FloatingPopupPage>();

      var mainNavigationPage = new NavigationPage();
      MainPage = mainNavigationPage;

      var navService = new NavigationService(mainNavigationPage.Navigation, pageFactory);
      mainNavigationPage.Navigation.PushAsync(pageFactory.CreatePageFor<MainViewModel>(navService));
    }

    protected override void OnStart()
    {
      // Handle when your app starts
    }

    protected override void OnSleep()
    {
      // Handle when your app sleeps
    }

    protected override void OnResume()
    {
      // Handle when your app resumes
    }
  }
}
