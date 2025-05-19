using System;

namespace MinApiValidationRepro.Persons;

public static class PersonEndpoints
{
    public static void MapPersonEndpoints(this IEndpointRouteBuilder routes)
    {
        routes.MapPost("/persons", (Entity entity) =>
        {
            return TypedResults.Ok(entity);
        });

        routes.MapPost("/personsdict", (Dictionary<string, Entity> dict) =>
        {
            return TypedResults.Ok(dict);
        });
    }
}
