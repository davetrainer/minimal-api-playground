namespace Minimal.API.Endpoints
{
    public static class TestEndpoints
    {
        public static void MapTestEndpoints(this WebApplication app)
        {
            app.MapGet("/", () => "Hello World!");
        }
    }
}
