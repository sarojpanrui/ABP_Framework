using System;
using System.Collections.Generic;
using System.Text;
using TodoAppLayered.Localization;
using Volo.Abp.Application.Services;

namespace TodoAppLayered;

/* Inherit your application services from this class.
 */
public abstract class TodoAppLayeredAppService : ApplicationService
{
    protected TodoAppLayeredAppService()
    {
        LocalizationResource = typeof(TodoAppLayeredResource);
    }
}
