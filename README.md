# C# 7.3 — Extras

This small pack augments the main 7.3 demos with a few items from your checklist.

## Projects
- **P119_ExpressionVariablesMoreLocations** — Use `out var` / pattern variables in more contexts (e.g., initializers, query clauses).
- **P120_OverloadResolutionFewerAmbiguities** — Example where C# 7.3 chooses a best match instead of reporting ambiguity.
- **P121_CompilerOptionsNotes** — Notes for `-publicsign` and `-pathmap` (compiler/MSBuild options).

## Build
```bash
dotnet restore
dotnet build
dotnet run --project P119_ExpressionVariablesMoreLocations
```
