This repo functions as a minimal example reproducing a bug described in https://github.com/dotnet/aspnetcore/issues/34694

The things to observe upon running `dotnet test` are:
- When targeting .NET 5.0, the tests run successfully, i.e. a type is generated for `Test{}.razor`.
  - The same when targeting .NET 6.0 preview 1.
- When targeting .NET 6.0 preview 2 or higher, the tests don't run successfully, and no type representing `Test{}.razor` is present in the assembly.
  - When targeting .NET 6.0 preview 2 or higher, the test in `MyTestComponent` as inherited through `Test{}.razor` is not executed by `dotnet test`.
  - When the special characters `{}` are removed, then the tests run successfully for .NET 5 and 6, all preview versions.



