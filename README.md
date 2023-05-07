Issue登録用の再現リポ。



## Introduction

This problem may not be caused by this library. Please let me know what you know.


## Describe the bug

Build succeeds, but publish fails.


## Steps to reproduce

1. Create a new WPF project in .NET 7.
2. Follow the `Getting Started` instructions.
3. Build -> Succeed
4. Publish -> Failed

Below is the reproduced repository.



## Expected behavior

Build and publish results should match.

## Actual behavior

Only the publish fails.  This is the same result for both Framework-dependent and Self-contained.

## Environment

- Wpf.Extensions.Hosting: 1.1.2
- OS: Windows 11 22H2 22621.1635
- Target Framework: .NET 7
- Visual Studio 1: 2022 17.5.5
- Visual Studio 2: 2022 17.6.0 Preview 6.0

## Screenshots

![demo.gif](https://github.com/hsytkm/WpfExtensionsHostingDemo/blob/main/publish_error.gif)