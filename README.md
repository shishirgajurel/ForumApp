# Forum App (2026 version) — work in progress

A Reddit-inspired forum app built step by step through an assignment series in the **DNP (.NET) course** at VIA University College. Each assignment adds a new layer, ending with a fully working forum.

## Current state
- **Entities**: `User`, `Post`, `Comment`
- **Repository contracts**: `IUserRepository`, `IPostRepository`, `ICommentRepository`
- **In-memory repositories** implementing those contracts

Next steps: a CLI, file storage, a Web API and a Blazor front end.
A finished earlier version of the same idea is in [ForumAppSolution](https://github.com/shishirgajurel/ForumAppSolution).

## Run / build
Requires the **.NET SDK**.
```bash
dotnet build ForumApp.sln
```

## Tech
C# · .NET · repository pattern
