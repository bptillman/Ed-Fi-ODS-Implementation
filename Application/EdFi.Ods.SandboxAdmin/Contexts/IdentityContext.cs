﻿// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.

using System.Data.Entity;

namespace EdFi.Ods.Sandbox.Admin.Contexts
{
    // TODO Address on spike ODS-4538
    // public class IdentityContext : IdentityDbContext
    // {
    //     public const string ConnectionStringName = "EdFi_Admin";
    //
    //     protected IdentityContext(string connectionString)
    //         : base(connectionString) { }
    //
    //     protected override void OnModelCreating(DbModelBuilder modelBuilder)
    //     {
    //         base.OnModelCreating(modelBuilder);
    //         ApplyProviderSpecificMappings(modelBuilder);
    //     }
    //
    //     /// <remarks>
    //     /// Sub-classes should override this to provide database system-specific column and/or
    //     /// table mappings: for example, if a linking table column in Postgres needs to map to a
    //     /// name other than the default provided by Entity Framework.
    //     /// </remarks>
    //     protected virtual void ApplyProviderSpecificMappings(DbModelBuilder modelBuilder) { }
    // }
}
