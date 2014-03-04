using System;
using System.Collections.Generic;
using Hrbu.Teaching.Utility;

namespace Hrbu.Teaching.Domain
{
    public static class RegistryModeFactory
    {
        internal static List<Func<RegistryMode>> _conditions;

        public static RegistryMode GetCurrentMode()
        {
            var mode = default(RegistryMode);
            if (_conditions == null || _conditions.Count == 0)
            {
                mode = GetModeFromEnvConfig(mode);
            }
            else
            {
                mode = GetModeFromConditions();
            }

            return mode;
        }

        private static RegistryMode GetModeFromEnvConfig(RegistryMode mode)
        {
            if (RuntimeHelper.IsInDebugMode())
            {
                mode = RegistryMode.Debug;
            }
            else if (RuntimeHelper.IsInReleaseMode())
            {
                mode = RegistryMode.Release;
            }
            else if (RuntimeHelper.IsInLiveMode())
            {
                mode = RegistryMode.Live;
            }
            return mode;
        }

        private static RegistryMode GetModeFromConditions()
        {
            var mode = default(RegistryMode);

            if (_conditions != null)
            {
                foreach (var condition in _conditions)
                {
                    mode = mode | condition();
                }
            }

            return mode;
        }


        internal static void AddCondition(Func<RegistryMode> condition)
        {
            if (_conditions == null) _conditions = new List<Func<RegistryMode>>();

            _conditions.Add(condition);
        }

        internal static void ClearConditions()
        {
            if (_conditions != null) _conditions.Clear();
        }

    }
}
