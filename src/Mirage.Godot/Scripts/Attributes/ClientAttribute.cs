﻿using System;

namespace Mirage
{
    /// <summary>
    /// Prevents this method from running if client is not active.
    /// <para>Can only be used inside a NetworkBehaviour</para>
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    public class ClientAttribute : Attribute
    {
        /// <summary>
        /// If true,  when the method is called from a client, it throws an error
        /// If false, no error is thrown, but the method won't execute
        /// useful for unity built in methods such as Await, Update, Start, etc.
        /// </summary>
        public bool error = true;
    }
}
