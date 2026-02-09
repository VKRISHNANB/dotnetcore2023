# .NET Upgrade Plan

Table of contents

- [Executive Summary](#executive-summary)
- [Migration Strategy](#migration-strategy)
- [Detailed Dependency Analysis](#detailed-dependency-analysis)
- [Project-by-Project Plans](#project-by-project-plans)
- [Package Update Reference](#package-update-reference)
- [Breaking Changes Catalog](#breaking-changes-catalog)
- [Testing & Validation Strategy](#testing--validation-strategy)
- [Risk Management](#risk-management)
- [Complexity & Effort Assessment](#complexity--effort-assessment)
- [Source Control Strategy](#source-control-strategy)
- [Success Criteria](#success-criteria)

---

## Executive Summary

Selected Strategy

**All-At-Once Strategy** - All projects upgraded simultaneously in a single atomic operation.

Rationale

- Solution contains 1 project (`ASPWebAPIDemoA.csproj`) and is small in size (493 LOC).
- Assessment shows the project is already compatible with `net10.0` and NuGet packages are reported as compatible.
- Low dependency complexity, no circular dependencies, and no security vulnerabilities reported.

Scope

- Projects: `E:\classroom\dotnetCore\2026\webapi\code\1ASPWebAPIDemoA\ASPWebAPIDemoA.csproj` (all projects simultaneously).
- Target framework: `net10.0`.
- Operations: project file verification/edits, NuGet package updates (if chosen), restore, build, fix compilation issues, run tests, finalize.


## Migration Strategy

Approach

- Use the All-At-Once strategy: perform an atomic upgrade of all projects in the repository (single coordinated operation).
- This plan treats the repository as a single scope and expects one atomic TASK for the framework+package upgrade, followed by a test execution task.

Key principles for this upgrade

- Update project files (TargetFramework) and package references across all projects in one pass.
- Restore and build the full solution to surface compilation issues, then fix all compilation problems as part of the same atomic change.
- Run all automated tests after the atomic upgrade completes.
- Use a single commit or a small set of commits that represent the atomic change; prefer one logical commit if feasible.


## Detailed Dependency Analysis

Summary

- Project count: 1
- Dependency depth: 0 (project has no project-to-project dependencies)
- Leaf nodes: `ASPWebAPIDemoA.csproj` (also root)
- No circular dependencies detected

Project path

- `E:\classroom\dotnetCore\2026\webapi\code\1ASPWebAPIDemoA\ASPWebAPIDemoA.csproj`


## Project-by-Project Plans

### Project: `ASPWebAPIDemoA.csproj`

Current State

- Current TargetFramework: `net10.0` (assessment: net10.0)
- SDK-style: True
- Project type: AspNetCore
- Files: ~16, LOC: 493
- Packages referenced (see §Package Update Reference)

Target State

- TargetFramework: `net10.0` (confirmed)
- All referenced packages compatible with `net10.0` and no security vulnerabilities remain

Migration Steps (atomic operation for all projects)

1. Prerequisites
   - Ensure .NET 10 SDK is installed on the build machine or CI agents.
   - Verify `global.json` (if present) references a .NET SDK that supports `net10.0`. Update `global.json` only if necessary and coordinate with team.

2. Update project file(s)
   - Verify `<TargetFramework>net10.0</TargetFramework>` exists in `ASPWebAPIDemoA.csproj`.
   - Verify SDK-style project format is intact and there are no imported legacy targets that assume older frameworks.

3. Update package references
   - Review the packages listed in §Package Update Reference. The assessment marks them as compatible. Optionally update to versions that explicitly support `net10.0`.
   - If you choose to upgrade package versions, do so for all projects in this atomic pass.

4. Restore & Build
   - Run `dotnet restore` at the solution root.
   - Run `dotnet build` to identify compile-time issues.
   - Fix all compilation errors caused by framework/package changes in the same atomic update.

5. Run Tests
   - Discover and run all test projects. If tests are present, execute them and resolve failures.

6. Validation
   - Solution compiles with 0 errors.
   - Tests pass (if present).
   - No security vulnerabilities reported for NuGet packages.

Deliverables

- Solution builds successfully targeting `net10.0`.
- All automated tests pass.
- A single commit (or logical grouped commits) containing project file updates and package updates.


## Package Update Reference

The assessment lists the following NuGet packages. None are flagged as requiring immediate upgrade; all are reported as compatible with `net10.0`. Include them in the atomic package review step and update versions only to explicitly supported ones if desired.

| Package | Current Version | Projects Affected | Notes |
|---|---:|---|---|
| `Microsoft.AspNetCore.Cors` | 2.2.0 | ASPWebAPIDemoA.csproj | Compatible (legacy minor version). Consider upgrading to an ASP.NET Core package aligned with `net10.0` if feature parity required. |
| `Microsoft.AspNetCore.Mvc.NewtonsoftJson` | 3.1.32 | ASPWebAPIDemoA.csproj | Compatible. Newer versions are available; update if desired. |
| `Microsoft.EntityFrameworkCore.SqlServer` | 3.1.1 | ASPWebAPIDemoA.csproj | Compatible. Consider updating to EF Core version that targets .NET 10 if you need new features. |
| `Microsoft.EntityFrameworkCore.Tools` | 3.1.1 | ASPWebAPIDemoA.csproj | Tools package; update in dev/test frameworks as needed. |
| `Microsoft.Extensions.Logging.Console` | 3.1.1 | ASPWebAPIDemoA.csproj | Compatible. Optional update for improved logging features. |
| `System.Text.Json` | 5.0.2 | ASPWebAPIDemoA.csproj | Compatible. .NET 10 ships newer `System.Text.Json`; consider aligning to runtime version or removing explicit reference if not needed. |

Notes

- The assessment did not include "Suggested Version" entries. Do not pick arbitrary versions; choose package versions verified to support `net10.0` in your environment.
- Address security vulnerabilities if scanning tools identify them later. The assessment reports no vulnerabilities.


## Breaking Changes Catalog

- The automated analysis reported no source or binary incompatible API issues for this project when targeting `net10.0`.
- Common areas to watch while building:
  - APIs that were obsoleted between .NET Core 3.1 and later runtime versions.
  - Startup/Program hosting model differences (this project already uses `Startup.cs` and appears compatible).
  - Entity Framework Core provider compatibility — if you upgrade EF Core, validate migrations.

?? Requires validation: If you choose to upgrade package versions beyond assessment versions, re-run builds and tests to discover breaking changes introduced by those package updates.


## Testing & Validation Strategy

Validation checkpoints

- Prerequisite check: .NET 10 SDK available on build agents.
- Post-update: `dotnet restore` succeeds.
- Build checkpoint: `dotnet build` completes with 0 errors.
- Test checkpoint: `dotnet test` (for discovered test projects) runs and all tests pass.
- Security check: No known vulnerable package versions remain.

Automated tests

- Discover test projects using `dotnet sln list` / `upgrade_discover_test_projects` / test discovery tooling.
- Run tests after the atomic upgrade and resolve failures as part of the same upgrade commit.

Manual checks (documented but not included in automation)

- Manual sanity smoke test for main application endpoints once build+tests succeed.


## Risk Management

Risk summary

- Overall risk: Low — single small project, assessment reports compatibility.

Potential risks and mitigations

- Risk: Unexpected compile errors after package version changes.
  - Mitigation: Keep package updates minimal; perform package upgrades only if necessary. Fix compile errors in same atomic pass.

- Risk: EF Core provider incompatibilities if EF is upgraded.
  - Mitigation: Validate EF migrations locally and in CI; run integration tests that cover data access.

- Risk: CI runner lacks .NET 10 SDK.
  - Mitigation: Verify and update CI images before running the atomic upgrade task.

Rollback plan

- If the atomic upgrade introduces regressions that cannot be resolved quickly, revert the upgrade branch (`upgrade-to-NET10`) or reset to the pre-upgrade commit on that branch.


## Complexity & Effort Assessment

- Solution complexity: Low
- Per-project complexity: `ASPWebAPIDemoA.csproj` — Low (small LOC, few dependencies)
- Risk level: Low


## Source Control Strategy

- Branch: `upgrade-to-NET10` (already created and checked out).
- Commit approach: Prefer one atomic commit that includes all project file and package updates. If that is impractical, use a small set of logically grouped commits but keep them together on `upgrade-to-NET10`.
- PR: Create a pull request from `upgrade-to-NET10` to `main` after verification. Include the assessment and this plan in PR description.


## Success Criteria

The migration is complete when all of the following are true:

1. All projects target `net10.0` (project files updated where needed).
2. All package updates from the atomic pass are applied and documented.
3. `dotnet restore` and `dotnet build` complete with 0 errors.
4. All automated tests pass.
5. No known security vulnerabilities remain in NuGet packages.
6. A single logical commit (or small set of commits) on `upgrade-to-NET10` contains the upgrade and is ready for PR/merge.


---

Generated from assessment at `E:\classroom\dotnetCore\.github\upgrades\assessment.md`.
