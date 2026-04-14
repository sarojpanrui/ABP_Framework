namespace BookStore.Permissions;

public static class BookStorePermissions
{
    public const string GroupName = "BookStore";

    //Add your own permission names. Example:
    //public const string MyPermission1 = GroupName + ".MyPermission1";
    public static class Books
    {
        public const string Default = GroupName + ".Books";
        public const string Create = Default + ".Create";
        public const string Edit = Default + ".Edit";
        public const string Delete = Default + ".Delete";
    }
    //This is a hierarchical way of defining permission names.For example, "create book" 
    //    permission name was defined 
    //    as BookStore.Books.Create.ABP doesn't force you to a structure,
    //    but we find this way useful.
}
