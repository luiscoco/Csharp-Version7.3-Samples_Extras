# C# 7.3 – Samples & Features (Extras Repo)

This repository contains focused examples for **C# 7.3** using the projects in **Csharp-Version7.3-Samples_Extras**.  
Each sample highlights a specific refinement introduced in C# 7.3, plus notes on related compiler options.

---

## What’s in this repo

### P123_ExpressionVariablesMoreLocations
- **What’s new**: `out var` / pattern variables can appear in **more contexts** than before (e.g., field/property initializers, attribute arguments, query clauses, constructor initializers).
- **Example**:
  ```csharp
  // Field initializer using an expression variable (C# 7.3+)
  private readonly int _parsed = int.TryParse("42", out var i) ? i : 0;

  public Foo(string s) : this(int.TryParse(s, out var v) ? v : 0) { }
  ```
- **Why it helps**: Keeps parsing or pattern checks *at the point of initialization*, avoiding awkward refactors.

---

### P124_OverloadResolutionFewerAmbiguities
- **What’s new**: The compiler is better at picking the **best** overload in tricky cases, reducing “ambiguous call” errors.
- **Example** (illustrative):
  ```csharp
  void M(object x) { }
  void M(string x) { }

  var s = "hello";
  M(s); // Prefers M(string) in more edge cases than prior versions
  ```
- **Why it helps**: Libraries can expose richer overload sets without surprising consumers.

---

### P125_CompilerOptionsNotes
- **Topics shown**:
  - `-publicsign` — produce a publicly signed assembly (useful for OSS where you don’t share a private key).
  - `-pathmap` — remap source paths in PDBs (deterministic builds, SourceLink, reproducibility).

> These are **tooling options** (not language syntax), but commonly used alongside C# 7.x work.

---

## Other notable C# 7.3 features (context)

While this “extras” repo focuses on the three topics above, C# 7.3 added several more improvements you may see in other samples:

- **New generic constraints**
  - `where T : unmanaged`
  - `where T : System.Enum`
  - `where T : System.Delegate`
- **`ref` local/parameter reassignment** — you can reassign a `ref` local/param to refer to a different location.
- **`stackalloc` initializers** — e.g., `Span<int> s = stackalloc[] { 1, 2, 3 };`
- **Fixed buffer indexing** — simpler indexing of `fixed` buffers.
- **Tuple equality operators** — `==` and `!=` on tuples.

These fit the broader 7.x theme of performance, interop, and expressiveness.

---

## Repository structure

- `P123_ExpressionVariablesMoreLocations` → expression variables in additional contexts  
- `P124_OverloadResolutionFewerAmbiguities` → improved overload resolution  
- `P125_CompilerOptionsNotes` → notes on `-publicsign`, `-pathmap`

---

## 🔧 Requirements

- C# 7.3 language version (default for many .NET Framework, .NET Core 2.x, and .NET Standard 2.0 projects at the time).  
- Set `<LangVersion>7.3</LangVersion>` in your `.csproj` if needed.

**Build & run:**
```bash
dotnet restore
dotnet build
dotnet run --project P119_ExpressionVariablesMoreLocations
# or
dotnet run --project P120_OverloadResolutionFewerAmbiguities
```

---

## 📖 References

- Microsoft Docs – *C# language version history*  
- .NET Blog – *C# 7.3 improvements* (generic constraints, ref reassignment, stackalloc initializers, tuple equality, etc.)
