﻿// Copyright (c) The Perspex Project. All rights reserved.
// Licensed under the MIT license. See licence.md file in the project root for full license information.

using System.Threading.Tasks;

namespace Perspex.Animation
{
    /// <summary>
    /// Interface for animations that transition between two pages.
    /// </summary>
    public interface IPageTransition
    {
        /// <summary>
        /// Starts the animation.
        /// </summary>
        /// <param name="from">
        /// The control that is being transitioned away from. May be null.
        /// </param>
        /// <param name="to">
        /// The control that is being transitioned to. May be null.
        /// </param>
        /// <param name="forward">
        /// If the animation is bidirectional, controls the direction of the animation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> that tracks the progress of the animation.
        /// </returns>
        Task Start(IVisual from, IVisual to, bool forward);
    }
}