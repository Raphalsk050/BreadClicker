using Click;
using System.Collections.Generic;
using UnityEngine;

public static class User {
    public static List<BaseClick> ActiveCursors { get; set; }
    public static int BreadCoin { get; set; }
    public static int ClickCount { get; set; }
    private static readonly UserClick userClick = GameObject.FindWithTag("UserCursor").GetComponent<UserClick>();
}
