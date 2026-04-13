using Microsoft.Extensions.Localization;
using TodoAppLayered.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace TodoAppLayered;

[Dependency(ReplaceServices = true)]
public class TodoAppLayeredBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<TodoAppLayeredResource> _localizer;

    public TodoAppLayeredBrandingProvider(IStringLocalizer<TodoAppLayeredResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
