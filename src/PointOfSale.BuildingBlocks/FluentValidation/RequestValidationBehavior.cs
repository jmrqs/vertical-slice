using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace PointOfSale.BuildingBlocks.FluentValidation;

public class RequestValidationBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    where TRequest : notnull, IRequest<TResponse>
    where TResponse : notnull
{
    private readonly IServiceProvider _serviceProvider;
    private IValidator<TRequest>? _validator;

    public RequestValidationBehavior(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider ?? throw new ArgumentNullException(nameof(serviceProvider));
    }

    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken
        cancellationToken)
    {
        _validator = _serviceProvider.GetService<IValidator<TRequest>>();

        if (_validator is null)
            return await next();

        var validationResult = await _validator.ValidateAsync(request, cancellationToken);
        
        if (!validationResult.IsValid)
            throw new ValidationException("Validation failed.");

        var response = await next();

        return response;
    }
}
