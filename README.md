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