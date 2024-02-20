﻿using WheelsCatalog.Application.Contracts.Persistence.Common;
using WheelsCatalog.Domain.CurrencyAggregate;

namespace WheelsCatalog.Application.Contracts.Persistence;

public interface ICurrencyRepository : IReadRepositoryBase<Currency>
{
    
}