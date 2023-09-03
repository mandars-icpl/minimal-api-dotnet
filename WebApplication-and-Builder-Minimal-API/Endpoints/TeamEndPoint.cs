namespace WebApplication_and_Builder_Minimal_API.Endpoints
{
    public class TeamEndPoint
    {
        private static List<string> teams = new List<string> {
            "Red Team",
            "Blue Team",
            "Green Team",
            "Orange Team",
            "Purple Team"
        };
        public static void Map(WebApplication app)
        {
            app.MapGet("/teams", async context =>
            {
                await context.Response.WriteAsJsonAsync(new { Message = "Welcome to Infopercept Team Endpoint" });
            });

            app.MapGet("/teams/list", async context =>
            {
                await context.Response.WriteAsJsonAsync(new { Message = "List Of Teams", List = teams });
            });

            app.MapGet("/teams/{name}", async (string name) =>
            {
                var team = teams.FirstOrDefault(t => string.Equals(t, name, StringComparison.OrdinalIgnoreCase));
                if (team != null)
                {
                    return Results.Json(new { Message = "Team is present" });
                }
                else
                {
                    return Results.Json(new { Message = "Team is not present" });
                }

            });
        }
    }
}
