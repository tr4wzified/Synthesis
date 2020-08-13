﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Mutagen.Bethesda.Synthesis
{
    public class UserPreferences
    {
        /// <summary>
        /// An enumerable of ModKeys to allow into the patcher.<br />
        /// Any mod not on the list will not be present in the supplied load order<br />
        /// Null means to include all mods
        /// </summary>
        public IEnumerable<ModKey>? InclusionMods;

        /// <summary>
        /// An enumerable of ModKeys to disallow into the patcher.<br />
        /// Any mod on the list will not be present in the supplied load order<br />
        /// Null means to include all mods
        /// </summary>
        public IEnumerable<ModKey>? ExclusionMods;

        /// <summary>
        /// If program args are empty, what actions should be taken
        /// </summary>
        public RunDefaultPatcher? ActionsForEmptyArgs = null;

        /// <summary>
        /// Optional cancellation token that will signal to the patcher to stop early
        /// </summary>
        public CancellationToken Cancel = CancellationToken.None;
    }
}
