﻿// Copyright (c) The Perspex Project. All rights reserved.
// Licensed under the MIT license. See licence.md file in the project root for full license information.

using System;

namespace Perspex.Controls.Templates
{
    /// <summary>
    /// Creates a control from a <see cref="Func{TControl}"/>.
    /// </summary>
    /// <typeparam name="TControl">The type of control.</typeparam>
    public class FuncTemplate<TControl> : ITemplate<TControl> where TControl : IControl
    {
        private readonly Func<TControl> _func;

        /// <summary>
        /// Initializes a new instance of the <see cref="FuncTemplate{TControl}"/> class.
        /// </summary>
        /// <param name="func">The function used to create the control.</param>
        public FuncTemplate(Func<TControl> func)
        {
            Contract.Requires<ArgumentNullException>(func != null);

            _func = func;
        }

        /// <summary>
        /// Creates the control.
        /// </summary>
        /// <returns>
        /// The created control.
        /// </returns>
        public TControl Build()
        {
            return _func();
        }
    }
}