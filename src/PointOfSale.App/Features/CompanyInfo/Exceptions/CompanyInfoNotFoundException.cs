﻿using PointOfSale.BuildingBlocks.Exception;

namespace PointOfSale.App.Features.CompanyInfo.Exceptions;

public class CompanyInfoNotFoundException : NotFoundException
{
    public CompanyInfoNotFoundException(int id) : base($"can't find a person with id '{id}' in the database.")
    {
    }
}