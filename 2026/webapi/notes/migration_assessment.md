# Projects and dependencies analysis

This document provides a comprehensive overview of the projects and their dependencies in the context of upgrading to .NETCoreApp,Version=v10.0.

## Table of Contents

- [Executive Summary](#executive-Summary)
  - [Highlevel Metrics](#highlevel-metrics)
  - [Projects Compatibility](#projects-compatibility)
  - [Package Compatibility](#package-compatibility)
  - [API Compatibility](#api-compatibility)
- [Aggregate NuGet packages details](#aggregate-nuget-packages-details)
- [Top API Migration Challenges](#top-api-migration-challenges)
  - [Technologies and Features](#technologies-and-features)
  - [Most Frequent API Issues](#most-frequent-api-issues)
- [Projects Relationship Graph](#projects-relationship-graph)
- [Project Details](#project-details)

  - [ASPWebAPIDemoA.csproj](#aspwebapidemoacsproj)


## Executive Summary

### Highlevel Metrics

| Metric | Count | Status |
| :--- | :---: | :--- |
| Total Projects | 1 | 0 require upgrade |
| Total NuGet Packages | 6 | All compatible |
| Total Code Files | 14 |  |
| Total Code Files with Incidents | 0 |  |
| Total Lines of Code | 493 |  |
| Total Number of Issues | 0 |  |
| Estimated LOC to modify | 0+ | at least 0.0% of codebase |

### Projects Compatibility

| Project | Target Framework | Difficulty | Package Issues | API Issues | Est. LOC Impact | Description |
| :--- | :---: | :---: | :---: | :---: | :---: | :--- |
| [ASPWebAPIDemoA.csproj](#aspwebapidemoacsproj) | net10.0 | ✅ None | 0 | 0 |  | AspNetCore, Sdk Style = True |

### Package Compatibility

| Status | Count | Percentage |
| :--- | :---: | :---: |
| ✅ Compatible | 6 | 100.0% |
| ⚠️ Incompatible | 0 | 0.0% |
| 🔄 Upgrade Recommended | 0 | 0.0% |
| ***Total NuGet Packages*** | ***6*** | ***100%*** |

### API Compatibility

| Category | Count | Impact |
| :--- | :---: | :--- |
| 🔴 Binary Incompatible | 0 | High - Require code changes |
| 🟡 Source Incompatible | 0 | Medium - Needs re-compilation and potential conflicting API error fixing |
| 🔵 Behavioral change | 0 | Low - Behavioral changes that may require testing at runtime |
| ✅ Compatible | 0 |  |
| ***Total APIs Analyzed*** | ***0*** |  |

## Aggregate NuGet packages details

| Package | Current Version | Suggested Version | Projects | Description |
| :--- | :---: | :---: | :--- | :--- |
| Microsoft.AspNetCore.Cors | 2.2.0 |  | [ASPWebAPIDemoA.csproj](#aspwebapidemoacsproj) | ✅Compatible |
| Microsoft.AspNetCore.Mvc.NewtonsoftJson | 3.1.32 |  | [ASPWebAPIDemoA.csproj](#aspwebapidemoacsproj) | ✅Compatible |
| Microsoft.EntityFrameworkCore.SqlServer | 3.1.1 |  | [ASPWebAPIDemoA.csproj](#aspwebapidemoacsproj) | ✅Compatible |
| Microsoft.EntityFrameworkCore.Tools | 3.1.1 |  | [ASPWebAPIDemoA.csproj](#aspwebapidemoacsproj) | ✅Compatible |
| Microsoft.Extensions.Logging.Console | 3.1.1 |  | [ASPWebAPIDemoA.csproj](#aspwebapidemoacsproj) | ✅Compatible |
| System.Text.Json | 5.0.2 |  | [ASPWebAPIDemoA.csproj](#aspwebapidemoacsproj) | ✅Compatible |

## Top API Migration Challenges

### Technologies and Features

| Technology | Issues | Percentage | Migration Path |
| :--- | :---: | :---: | :--- |

### Most Frequent API Issues

| API | Count | Percentage | Category |
| :--- | :---: | :---: | :--- |

## Projects Relationship Graph

Legend:
📦 SDK-style project
⚙️ Classic project

```mermaid
flowchart LR
    P1["<b>📦&nbsp;ASPWebAPIDemoA.csproj</b><br/><small>net10.0</small>"]
    click P1 "#aspwebapidemoacsproj"

```

## Project Details

<a id="aspwebapidemoacsproj"></a>
### ASPWebAPIDemoA.csproj

#### Project Info

- **Current Target Framework:** net10.0✅
- **SDK-style**: True
- **Project Kind:** AspNetCore
- **Dependencies**: 0
- **Dependants**: 0
- **Number of Files**: 16
- **Lines of Code**: 493
- **Estimated LOC to modify**: 0+ (at least 0.0% of the project)

#### Dependency Graph

Legend:
📦 SDK-style project
⚙️ Classic project

```mermaid
flowchart TB
    subgraph current["ASPWebAPIDemoA.csproj"]
        MAIN["<b>📦&nbsp;ASPWebAPIDemoA.csproj</b><br/><small>net10.0</small>"]
        click MAIN "#aspwebapidemoacsproj"
    end

```

### API Compatibility

| Category | Count | Impact |
| :--- | :---: | :--- |
| 🔴 Binary Incompatible | 0 | High - Require code changes |
| 🟡 Source Incompatible | 0 | Medium - Needs re-compilation and potential conflicting API error fixing |
| 🔵 Behavioral change | 0 | Low - Behavioral changes that may require testing at runtime |
| ✅ Compatible | 0 |  |
| ***Total APIs Analyzed*** | ***0*** |  |

