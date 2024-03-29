﻿using Microsoft.AspNetCore.Routing;
using System.Text.RegularExpressions;

namespace PointOfSale.BuildingBlocks.WebApi;

public class SlugApiParameters : IOutboundParameterTransformer
{
    public string? TransformOutbound(object value)
    {
        return value == null
            ? null
            : Regex.Replace(value.ToString() ?? string.Empty, "([a-z])([A-Z])", "$1-$2").ToLower();
    }
}