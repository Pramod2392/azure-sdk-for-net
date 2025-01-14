// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    public partial class AppPlatformGatewayRouteConfigProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(AppResourceId))
            {
                writer.WritePropertyName("appResourceId");
                writer.WriteStringValue(AppResourceId);
            }
            if (Optional.IsDefined(OpenApi))
            {
                writer.WritePropertyName("openApi");
                writer.WriteObjectValue(OpenApi);
            }
            if (Optional.IsDefined(Protocol))
            {
                writer.WritePropertyName("protocol");
                writer.WriteStringValue(Protocol.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Routes))
            {
                writer.WritePropertyName("routes");
                writer.WriteStartArray();
                foreach (var item in Routes)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static AppPlatformGatewayRouteConfigProperties DeserializeAppPlatformGatewayRouteConfigProperties(JsonElement element)
        {
            Optional<AppPlatformGatewayProvisioningState> provisioningState = default;
            Optional<ResourceIdentifier> appResourceId = default;
            Optional<GatewayRouteConfigOpenApiProperties> openApi = default;
            Optional<AppPlatformGatewayRouteConfigProtocol> protocol = default;
            Optional<IList<AppPlatformGatewayApiRoute>> routes = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    provisioningState = new AppPlatformGatewayProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("appResourceId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    appResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("openApi"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    openApi = GatewayRouteConfigOpenApiProperties.DeserializeGatewayRouteConfigOpenApiProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("protocol"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    protocol = new AppPlatformGatewayRouteConfigProtocol(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("routes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<AppPlatformGatewayApiRoute> array = new List<AppPlatformGatewayApiRoute>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AppPlatformGatewayApiRoute.DeserializeAppPlatformGatewayApiRoute(item));
                    }
                    routes = array;
                    continue;
                }
            }
            return new AppPlatformGatewayRouteConfigProperties(Optional.ToNullable(provisioningState), appResourceId.Value, openApi.Value, Optional.ToNullable(protocol), Optional.ToList(routes));
        }
    }
}
