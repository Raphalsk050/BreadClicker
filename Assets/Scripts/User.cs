using Cursors;
using Breads;
using System.Collections.Generic;

public static class User {
    public static int BreadCoin { get; set; }
    public static int ClickCount { get; set; }
    private static List<AutoCursor> ActiveAutoCursors { get; set; }

    public static void Click() => UserCursor.Instance.ClickAsUser();
}
