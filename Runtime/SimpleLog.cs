using UnityEngine;

namespace SimpleTools
{
    public static class SimpleLog
    {
        public static void Print(string message)
        {
            Debug.Log($"[我的工具包] {message}");
        }
    }
}