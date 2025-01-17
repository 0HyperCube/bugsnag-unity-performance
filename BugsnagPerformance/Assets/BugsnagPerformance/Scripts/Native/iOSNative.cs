﻿using System.Collections;
using System.Collections.Generic;
#if UNITY_IOS && !UNITY_EDITOR

using System.Runtime.InteropServices;

#endif

using UnityEngine;

namespace BugsnagUnityPerformance
{
    internal class iOSNative
    {
#if UNITY_IOS && !UNITY_EDITOR
        const string Import = "__Internal";

        [DllImport(Import)]
        internal static extern string bugsnag_performance_getBundleVersion();

        [DllImport(Import)]
        internal static extern string bugsnag_performance_get_arch();
#endif

        public static string GetBundleVersion()
        {
#if UNITY_IOS && !UNITY_EDITOR
            return bugsnag_performance_getBundleVersion();
#endif
            return null;
        }

        public static string GetArch()
        {
#if UNITY_IOS && !UNITY_EDITOR
            return bugsnag_performance_get_arch();
#endif
            return null;
        }
    }
}