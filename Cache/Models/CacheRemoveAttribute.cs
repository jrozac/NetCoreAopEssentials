﻿using System;

namespace NetCoreAopEssentials.Cache.Models
{

    /// <summary>
    /// Cache remove attribute. Used to register method to remove cache.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    public class CacheRemoveAttribute : Attribute
    {

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="keyTemplate"></param>
        /// <param name="groupId"></param>
        /// <param name="provider"></param>
        /// <param name="useCustomProvider"></param>
        public CacheRemoveAttribute(string keyTemplate, string groupId = null,
            EnumCacheProvider provider = EnumCacheProvider.Memory, bool useCustomProvider = false)
        {
            KeyTemplate = keyTemplate;
            GroupId = groupId;
            Provider = useCustomProvider ? new EnumCacheProvider?(provider) : null;
        }

        /// <summary>
        /// Custom cache provider
        /// </summary>
        public EnumCacheProvider? Provider { get; private set; }

        /// <summary>
        /// Key template 
        /// </summary>
        public string KeyTemplate { get; private set; }

        /// <summary>
        /// Group id 
        /// </summary>
        public string GroupId { get; private set; }

    }
}