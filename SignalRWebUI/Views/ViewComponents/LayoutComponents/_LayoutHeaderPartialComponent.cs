using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUI.Views.ViewComponents.LayoutComponents
{
    public class _LayoutHeaderPartialComponent:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
