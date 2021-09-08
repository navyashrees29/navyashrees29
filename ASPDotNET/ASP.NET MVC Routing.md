# ASP.NET MVC Routing

In MVC, routing is a process of mapping the browser request to the controller action and return response back. Each MVC application has default routing for the default **HomeController**. We can set custom routing for newly created controller.

public static void RegisterRoutes(RouteCollection routes) 

   { 

​     routes.IgnoreRoute("{resource}.axd/{*pathInfo}"); 

​    routes.MapRoute( 

​     name: "Default", 

​      url: "{controller}/{action}/{id}", 

​        defaults: **new** { controller = "Home", action = "Index", id = UrlParameter.Optional } 

​     ); 

​    } 

# Default Route

Every route has a unique name. The name of the default route is Default. The url attribute describes the pattern of the url. The default pattern is Controller/Action/Id. The defaults property sets default properties for the controller, action and sets the id as optional. The default values are used when no values for the attribute is passed.

public static void RegisterRoutes(RouteCollection routes) 

   { 

​     routes.IgnoreRoute("{resource}.axd/{*pathInfo}"); 

​    routes.MapRoute( 

​     name: "Default", 

​      url: "{controller}/{action}/{id}", 

​        defaults: **new** { controller = "Home", action = "Index", id = UrlParameter.Optional } 

​     ); 

​    } 

# Route Constraints

We can also apply restrictions on the value of the parameter by configuring route constraints.

 For example, the following route applies a limitation on the id parameter that the id's value must be numeric.if you give non-numeric value for id parameter, then that request will be handled by another route or, if there are no matching routes, then `"The resource could not be found"` error will be thrown.

routes.MapRoute(
                name: "Student",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                constraints: new { id = @"\d+" }
            );



# ViewData v/s ViewBag

| ViewData                                                     | ViewBag                                                      |
| :----------------------------------------------------------- | :----------------------------------------------------------- |
| ViewData is derived from the ViewDataDictionary class and is basically a Dictionary object i.e. Keys and Values where Keys are String while Values will be objects. | ViewBag is a Wrapper built around ViewData.                  |
| Data is stored as Object in ViewData.                        | ViewBag is a dynamic property and it makes use of the C# 4.0 dynamic features. |
| While retrieving, the data it needs to be Type Casted to its original type as the data is stored as objects and it also requires NULL checks while retrieving. | While retrieving, there is no need for Type Casting data.    |



# Action Result in ASP.NET MVC



Action Result is the return type of an action method. The action result is an abstract class. It is the base class for all types that an action method returns.  View, Partial View, Redirect, Json, Content, File, RedirectResult, etc. are derived from the abstract Action Result class and these types can also be used as the return type of an action method.



1. **ViewResult –** Represents HTML and markup.

2. **EmptyResult** – Represents no result.

3. **ContentResult** – Represents a text result.

4. **FileResult** - It represents the content of the file.

5. **JavaScriptResult** – Represents a JavaScript script.

6. **RedirectResult** – Represents a redirection to a new URL.

7. **PartialViewResult –** Represents HTML and markup.

8. **JsonResult** - Represents a JavaScript Object Notation result that can be used in an AJAX application.

   

