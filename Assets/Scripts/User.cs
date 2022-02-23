using Cursors;
using System.Collections.Generic;

public static class User {
    public static int BreadCoin { get; set; }
    public static int ClickCount { get; private set; }
    private static List<AutoCursor> EnabledAutoCursors { get; set; }

    public static void Click() => UserCursor.Instance.ClickAsUser();

    public static void IncrementClickCount(int increment = 1) =>
        ClickCount += increment;
}
