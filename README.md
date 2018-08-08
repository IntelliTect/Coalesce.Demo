# Coalesce

Coalesce is a framework for rapid-development of ASP.NET Core web applications. It works from the Entity Framework Core data model that you design, automating the creation of the glue - DTOs, API Controllers, and TypeScript - that sit between your data and the UI of your application. 

# Coalesce Demo

This is the demo hosted at the [Coalesce Web Site](https://coalesce.intellitect.com/demo).

# Build Notes
In the 'Debug' solution configuration, these projects rely on project reference to the Coalesce source code.  It assumes that the Coalesce repository is checked out in the folder called "Coalesce" next to the the "Coalesce.Demo" repository.  If this is not the case, change the path in the Directory.Build.Props file to point to the Coalesce repository and fix the paths in the "Coalesce.Demo.sln" solution file.