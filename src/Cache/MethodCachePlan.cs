﻿using System;
using System.Reflection;

namespace NetAopEssentials.Cache
{

    /// <summary>
    /// Method cache plan
    /// </summary>
    internal class MethodCachePlan
    {

        /// <summary>
        /// Method info 
        /// </summary>
        public MethodInfo MethodInfo { get; set; }

        /// <summary>
        /// Cache key template
        /// </summary>
        public string KeyTpl { get; set; }

        /// <summary>
        /// Cache action
        /// </summary>
        public EnumCacheAction Action { get; set; }

        /// <summary>
        /// Cache provider 
        /// </summary>
        public EnumCacheProvider Provider { get; set; }

        /// <summary>
        /// Function whihc returns whether the result should be cached or not.
        /// </summary>
        public Func<object, bool> CacheResultFunc { get; set; }

        /// <summary>
        /// Cache timeout in milliseconds 
        /// </summary>
        public long TimeoutMs { get; set; }

        /// <summary>
        /// Key prefix
        /// </summary>
        public string KeyPrefix { get; set; }

        /// <summary>
        /// Added to timeout 
        /// </summary>
        public Func<object, long> TimeoutMsOffsetFunc { get; set; }

        /// <summary>
        /// Function which returns key based 
        /// </summary>
        public Func<object[], object, string> KeyFunc { get; set; }

    }
}
