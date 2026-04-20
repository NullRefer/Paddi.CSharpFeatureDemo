# Paddi.CSharpFeatureDemo

用于演示不同 C# 版本特性的示例项目集合。

## 项目结构

- `src/Paddi.CSharpFeatureDemo.VersionEight`：C# 8.0 示例
- `src/Paddi.CSharpFeatureDemo.VersionNine`：C# 9.0 示例
- `src/Paddi.CSharpFeatureDemo.VersionTen`：C# 10.0 示例
- `src/Paddi.CSharpFeatureDemo.VersionEleven`：C# 11.0 示例
- `src/Paddi.CSharpFeatureDemo.VersionTwelve`：C# 12.0 示例
- `src/Paddi.CSharpFeatureDemo.VersionThirteen`：C# 13.0 示例
- `src/Paddi.CSharpFeatureDemo.VersionFourteen`：C# 14.0（Preview）示例
- `src/Paddi.CSharpFeatureDemo.AdvanceConcept`：补充示例

## 环境要求

- .NET SDK 10（可同时构建 net8.0 / net9.0 / net10.0）

## 快速开始

```bash
dotnet restore Paddi.CSharpFeatureDemo.sln
dotnet build Paddi.CSharpFeatureDemo.sln
```

## 运行示例

```bash
dotnet run --project src/Paddi.CSharpFeatureDemo.VersionEight
dotnet run --project src/Paddi.CSharpFeatureDemo.VersionNine
dotnet run --project src/Paddi.CSharpFeatureDemo.VersionTen
dotnet run --project src/Paddi.CSharpFeatureDemo.VersionEleven
dotnet run --project src/Paddi.CSharpFeatureDemo.VersionTwelve
dotnet run --project src/Paddi.CSharpFeatureDemo.VersionThirteen
dotnet run --project src/Paddi.CSharpFeatureDemo.VersionFourteen
dotnet run --project src/Paddi.CSharpFeatureDemo.AdvanceConcept
```
