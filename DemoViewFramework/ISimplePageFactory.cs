namespace DemoViewFramework
{
  public interface ISimplePageFactory
  {
    BaseContentPage CreatePageFor<TViewModel>(INavigationService natNavigationService);
  }
}