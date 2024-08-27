using Microsoft.AspNetCore.Mvc;

namespace ResumeApp.Web.Areas.Admin.Components;

public class LeftSideViewComponent : ViewComponent
{
    #region Methods

    public async Task<IViewComponentResult> InvokeAsync()
    {
        return View("LeftSideBar");
    }

    #endregion
}