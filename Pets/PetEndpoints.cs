using System;

namespace MinApiValidationRepro.Pets;

public static class PetEndpoints
{
    public static void MapPetEndpoints(this IEndpointRouteBuilder routes)
    {
        routes.MapPost("/pets", (Entity entity) =>
        {
            return TypedResults.Ok(entity);
        });
    }
}
