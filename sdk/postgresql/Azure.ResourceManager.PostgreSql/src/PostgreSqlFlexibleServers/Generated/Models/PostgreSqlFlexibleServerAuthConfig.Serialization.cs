// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    public partial class PostgreSqlFlexibleServerAuthConfig : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ActiveDirectoryAuth))
            {
                writer.WritePropertyName("activeDirectoryAuth");
                writer.WriteStringValue(ActiveDirectoryAuth.Value.ToString());
            }
            if (Optional.IsDefined(PasswordAuth))
            {
                writer.WritePropertyName("passwordAuth");
                writer.WriteStringValue(PasswordAuth.Value.ToString());
            }
            if (Optional.IsDefined(TenantId))
            {
                writer.WritePropertyName("tenantId");
                writer.WriteStringValue(TenantId.Value);
            }
            writer.WriteEndObject();
        }

        internal static PostgreSqlFlexibleServerAuthConfig DeserializePostgreSqlFlexibleServerAuthConfig(JsonElement element)
        {
            Optional<PostgreSqlFlexibleServerActiveDirectoryAuthEnum> activeDirectoryAuth = default;
            Optional<PostgreSqlFlexibleServerPasswordAuthEnum> passwordAuth = default;
            Optional<Guid> tenantId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("activeDirectoryAuth"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    activeDirectoryAuth = new PostgreSqlFlexibleServerActiveDirectoryAuthEnum(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("passwordAuth"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    passwordAuth = new PostgreSqlFlexibleServerPasswordAuthEnum(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tenantId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    tenantId = property.Value.GetGuid();
                    continue;
                }
            }
            return new PostgreSqlFlexibleServerAuthConfig(Optional.ToNullable(activeDirectoryAuth), Optional.ToNullable(passwordAuth), Optional.ToNullable(tenantId));
        }
    }
}
