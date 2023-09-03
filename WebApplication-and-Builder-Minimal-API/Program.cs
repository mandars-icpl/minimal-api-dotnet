using WebApplication_and_Builder_Minimal_API;
using WebApplication_and_Builder_Minimal_API.Endpoints;

var builder = WebApplication.CreateBuilder(args);
var app =   builder.Build();;
app.MapGet("/", () => "Hello Welcome to Infopercept");
//working with multiple ports
app.Urls.Add("http://localhost:3030");
app.Urls.Add("http://localhost:4040");
app.Urls.Add("http://localhost:5050");

//Loging using the system log 
app.Logger.LogInformation("The app has started");


// Routing in minimal api 

//given type of handler is an inline labmda 
app.MapGet("/routing", () => "This is a GET request");
app.MapPost("/routing", () => "This is a POST request");
app.MapPut("/routing", () => "This is a PUT request");
app.MapDelete("/routing", () =>"This is a DELETE reqeust");


/*Route Handlers : These are sync/async methods that gets executed when routes matches. Route handlers can be 
1.Lamda Expression
2.Local Function
3.Instance Method or a Static Method
 */

//1.Lamda Expression 
var handler = () => "This is an Lamda Expression";
app.MapGet("/routing/lamdahandler", handler);

//2.Local Function 
string LocalFunction() => "This is local function";
app.MapGet("/routing/localfunction", LocalFunction);

//3.Instance Method
var instancehandler = new Hello();
app.MapGet("/routing/instancehandler", instancehandler.SayHello);
app.MapGet("routing/statichandler", Hello.SayBye);

TeamEndPoint.Map(app);
app.Run();
//app.Run("http://localhost:3030");