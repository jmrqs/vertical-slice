# Notes

## Technologies

- [x] .NET 6 https://github.com/dotnet/core
- [x] MediatR https://github.com/jbogard/MediatR
- [x] FluentValidation https://github.com/FluentValidation
- [x] Mapster https://github.com/MapsterMapper
- [ ] Dapper 
- [ ] MySQL https://github.com/mysql
- [ ] MongoDB https://github.com/mongodb/
- [ ] EasyCaching https://github.com/dotnetcore/EasyCaching
- [ ] Redis https://github.com/redis/

### .NET 6

**Reference:** https://learn.microsoft.com/en-us/dotnet/core/whats-new/dotnet-6

.NET 6 unifies the SDK, base libraries, and runtime across mobile, desktop, IoT, and cloud apps

**Simplified development:** Getting started is easy. New language features in C# 10 reduce the amount of code you need to write. And investments in the web stack and minimal APIs make it easy to quickly write smaller, faster microservices.

**Better performance:** .NET 6 is the fastest full stack web framework, which lowers compute costs if you're running in the cloud.

**Ultimate productivity:** .NET 6 and Visual Studio 2022 provide hot reload, new git tooling, intelligent code editing, robust diagnostics and testing tools, and better team collaboration.

#### Hot reload
Hot reload is a feature that lets you modify your app's source code and instantly apply those changes to your running app. The feature's purpose is to increase your productivity by avoiding app restarts between edits. Hot reload is available in Visual Studio 2022 and the _dotnet watch_ command-line tool. 

### .NET MAUI
.NET Multi-platform App UI (.NET MAUI) is still in preview, with a release candidate coming in the first quarter of 2022 and general availability (GA) in the second quarter of 2022. .NET MAUI makes it possible to build native client apps for desktop and mobile operating systems with a single codebase. 

#### Other new APIs
New serialization interfaces for validation and defaulting values:

```cs
IJsonOnDeserialized
IJsonOnDeserializing
IJsonOnSerialized
IJsonOnSerializing
```

#### HTTP/3
.NET 6 includes preview support for HTTP/3, a new version of HTTP. HTTP/3 solves some existing functional and performance challenges by using a new underlying connection protocol called QUIC. 

#### New LINQ APIs

```cs
Enumerable.Chunk<TSource>(IEnumerable<TSource>, Int32)	Splits the elements of a sequence into chunks of a specified size.
Enumerable.FirstOrDefault<TSource>(IEnumerable<TSource>, TSource) and Enumerable.FirstOrDefault<TSource>(IEnumerable<TSource>, Func<TSource,Boolean>, TSource)
Enumerable.LastOrDefault<TSource>(IEnumerable<TSource>, TSource) and Enumerable.LastOrDefault<TSource>(IEnumerable<TSource>, Func<TSource,Boolean>, TSource)
Enumerable.SingleOrDefault<TSource>(IEnumerable<TSource>, TSource) and Enumerable.SingleOrDefault<TSource>(IEnumerable<TSource>, Func<TSource,Boolean>, TSource)
```
