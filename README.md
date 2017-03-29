# Lab 7 Walkthrough

This assumes that your `lab-six` branch looks like mine. See [FisherInsuranceApi - Lab 6](https://github.com/amis-3610-sp17/FisherInsuranceApi/tree/lab-six)


## Exercise 0

We start by removing project.json and adding FisherInsuaranceApi.csproj.

When you build, you may get the following error:

*Program.cs(13,18): error CS1061: 'ConfigurationBuilder' does not contain a definition for 'AddCommandLine' and no extension method 'AddCommandLine' accepting a first argument of type 'ConfigurationBuilder' could be found (are you missing a using directive or an assembly reference?) [C:\Dojo\amis\FisherInsuranceApi\FisherInsuranceApi.csproj]*

You have two options:
1. Remove the offending lines of code
2. Add the missing references. I am going to add the missing reference:
* `dotnet add package Microsoft.Extensions.Configuration.CommandLine`

We could have gone either way here. `AddCommandLine()` method allows us to pass aruments into our run command: `dotnet run --environment "Staging"` 

Your project should build successfully. 

## Exercise 1

For some reason, on Step 2, many people had issues with `using Microsoft.AspNetCore.Identity.EntityFrameworkCore;` not resolving. There are two different solutions that appeard to work.
1. Close FisherContext.cs and run `dotnet restore` and `dotnet build`
2. Close VS Code and run `dotnet restore` and `dotnet build` in a seperate terminal (Powershell for Win, Terminal for Mac; if your are running Linux, see me for 5 free bonus points)

On step 3, the original lab said to have FisherContext inherit like this: `IdentityDbContext<Applicationuser>` with a lower-cased 'user'. The correct implementation should have been `IdentityDbContext<ApplicationUser>` with upper-case 'User'. Some people had issues with the 'Lightbulb' giving the option to generate the new file. If that happened to you, simply create an ApplicationUser.cs file in the Data folder. Be sure to give it a namespace of 'FisherInsuranceApi.Data'

On Step 5, it is not explicit that you need to add the proper using statement `using Microsoft.AspNetCore.Identity.EntityFrameworkCore;`

## Exercise 2

The original lab had was missing a '/' in the token URL. the TokenEndPoint should be:
`public static string TokenEndPoint = "/api/connect/token";`

On Step 12, you of course will need to hit the 'Lightbuld' to add the following using statements:
      `using Microsoft.IdentityModel.Tokens;`
      `using FisherInsuranceApi.Security;`

You still may see the following error:

*Startup.cs(48,27): error CS1061: 'ILoggerFactory' does not contain a definition for 'AddDebug' and no extension method 'AddDebug' accepting a first argument of type 'ILoggerFactory' could be found (are you missing a using directive or an assembly reference?) [C:\Dojo\amis\FisherInsuranceApi\FisherInsuranceApi.csproj]*

You can fix this by deleting the offending line of code or by running `dotnet add package Microsoft.Extensions.Logging.Debug`

## Exercise 3

If you follow the directions, this exercise should 'just work'.

## Exercise 4

There were some updates from the initial lab to the lab currently on Carmen. Be sure that you have the latest lab.

If you follow the updated lab, things should work.

You should be able to note the following:
* When you try to login, you will receive an error in the UI: "Warning: Username or Password mismatch"
* If you open the browser's dev tools, you should be able to see a '400: Bad Request' coming back from 'api/connect/token'


