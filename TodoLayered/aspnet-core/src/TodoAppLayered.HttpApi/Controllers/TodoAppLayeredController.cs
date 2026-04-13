using TodoAppLayered.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace TodoAppLayered.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class TodoAppLayeredController : AbpControllerBase
{
    protected TodoAppLayeredController()
    {
        LocalizationResource = typeof(TodoAppLayeredResource);
    }
}
