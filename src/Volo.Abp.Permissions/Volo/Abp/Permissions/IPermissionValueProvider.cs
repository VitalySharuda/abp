﻿using System.Threading.Tasks;
using JetBrains.Annotations;

namespace Volo.Abp.Permissions
{
    public interface IPermissionValueProvider
    {
        string Name { get; }

        //Task SetAsync([NotNull] PermissionDefinition permission, bool isGranted, [CanBeNull] string providerKey);

        //Task ClearAsync([NotNull] PermissionDefinition permission, [CanBeNull] string providerKey);

        Task<bool> IsGrantedAsync(PermissionDefinition permission);
    }
}