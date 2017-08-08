## R4MVC

[![Build status](https://ci.appveyor.com/api/projects/status/sw4jwy7gtedra5bv?svg=true)](https://ci.appveyor.com/project/T4MVC/r4mvc)

R4MVC is a Roslyn code generator for ASP.NET MVC Core apps that creates strongly typed helpers that eliminate the use of literal strings in many places.  

It is a re-implementation of [T4MVC](https://github.com/T4MVC/T4MVC) for ASP.NET Core projects, as T4 templates are [not supported](https://github.com/aspnet/Home/issues/272).

## ** NEW MAINTAINTERS WANTED **

We are currently looking for new maintainers.  Please see issue [#42](https://github.com/T4MVC/R4MVC/issues/42) for more details.

## Usage

Instead of

````c#
@Html.ActionLink("Dinner Details", "Details", "Dinners", new { id = Model.DinnerID }, null)
````

R4MVC lets you write

````c#
@Html.ActionLink("Dinner Details", MVC.Dinners.Details(Model.DinnerID))
````

and that's just the beginning!
