# ASPWebAPIDemoA .NET net10.0 Upgrade Tasks

## Overview

This document tracks the atomic All-At-Once upgrade of the repository's single project to `net10.0`. The procedure verifies prerequisites, performs a single coordinated framework and package update with compilation fixes, validates tests (if present), and finishes with a final commit.

**Progress**: 1/4 tasks complete (25%) ![0%](https://progress-bar.xyz/25)

---

## Tasks

### [✓] TASK-001: Verify prerequisites *(Completed: 2026-02-09 09:34)*
**References**: Plan §Prerequisites, Plan §Source Control Strategy

- [✓] (1) Verify .NET 10 SDK is installed on the build machine / CI agents per Plan §Prerequisites
- [✓] (2) Runtime/SDK version meets minimum requirements (**Verify**)
- [✓] (3) Verify `global.json` (if present) references a .NET SDK that supports `net10.0` per Plan §Prerequisites
- [✓] (4) `global.json` is compatible with `net10.0` or updated as needed (**Verify**)

### [▶] TASK-002: Atomic framework and package upgrade with compilation fixes
**References**: Plan §Project-by-Project Plans, Plan §Package Update Reference, Plan §Breaking Changes Catalog

- [✓] (1) Update project file(s): ensure `ASPWebAPIDemoA.csproj` contains `<TargetFramework>net10.0</TargetFramework>` per Plan §Project-by-Project Plans
- [▶] (2) Update package references per Plan §Package Update Reference (only to versions verified to support `net10.0`)
- [ ] (3) Restore dependencies (`dotnet restore`) at solution root per Plan §Project-by-Project Plans
- [ ] (4) Build solution and fix all compilation errors caused by framework/package updates per Plan §Breaking Changes Catalog
- [ ] (5) Solution builds with 0 errors (**Verify**)

### [ ] TASK-003: Run tests and validate upgrade
**References**: Plan §Testing & Validation Strategy, Plan §Project-by-Project Plans

- [ ] (1) Confirm there are no test projects for this repository per Plan §Detailed Dependency Analysis / Plan §Project-by-Project Plans (**Verify**)
- [ ] (2) If test projects are listed in Plan §Testing & Validation Strategy, run tests in those explicit test project(s) per Plan §Testing & Validation Strategy
- [ ] (3) All tests pass with 0 failures (**Verify**)

### [ ] TASK-004: Final commit
**References**: Plan §Source Control Strategy

- [ ] (1) Commit all remaining changes with message: "TASK-004: Complete upgrade to net10.0"




