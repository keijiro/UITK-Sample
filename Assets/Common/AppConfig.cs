using UnityEngine;

#if UNITY_IOS && !UNITY_EDITOR

static class AppConfig
{
    [RuntimeInitializeOnLoadMethod]
    static void Initialize()
    {
        Application.targetFrameRate = 60;
    }
}

#endif
