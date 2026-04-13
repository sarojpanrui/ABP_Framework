using TodoAppLayered.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace TodoAppLayered.Permissions;

public class TodoAppLayeredPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(TodoAppLayeredPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(TodoAppLayeredPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<TodoAppLayeredResource>(name);
    }
}
