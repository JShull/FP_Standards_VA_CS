# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [Unreleased]

## [0.2.0] - 2023-11-11

Fixing an issue with zero sized list in stat reporters and accounting for division by zero catches by adjusting the calculators to be a (double, bool) return type to screen against for when we waterfall through different calculations. The false return works it's way up the waterfall.

### 0.2.0 Added

- None

### 0.2.0 Changed

- [@JShull](https://github.com/jshull)
  - FP_Analytics.cs
    - All Calculators return types are now (double,bool)
    - Replaced exception throws with (0,false) returns
  - FP_Stat.cs
    - _statCalculations dictionary is now a (double,bool) to align with calculator returns
  - FP_StatReporter.cs
    - Matching previous updates from FP_Stat
    - All derived classes were updated to match as well
  - FP_StatManager.cs
    - Gave the user an option to destroy on load
  
### 0.2.0 Fixed

- This fixes the null issue within cases of 0 items being added to the stat reporter
- It will return a NaN value that you can screen against in your own use cases

### 0.2.0 Removed

- None...

## [0.1.0] - 2023-11-02

### 0.1.0 Added

- [@JShull](https://github.com/jshull).
  - Moved all test files to a Unity Package Distribution
  - Setup the ChangeLog.md
  - FP_Utility_Analytics Asmdef
    - FP_Analytics.cs
    - FP_Stat.cs
    - FP_Stat_Bool.cs
    - FP_Stat_Int.cs
    - FP_Stat_Float.cs
    - FP_Stat_Event.cs
    - FP_Stat_DisplayDetails.cs
    - FP_Stat_Type.cs
    - FP_StatManager.cs
    - FP_StatReporter.cs
    - FP_StatReporter_Float.cs
    - FP_StatReporter_Bool.cs
    - FP_StatReporter_Int.cs
  - All of these are considered utility analytic base classes. The FP_Analytics.cs contains the calculators. This package requires FP_Utility and is designed to be modified and extended with additional calculators and/or other 'base' classes, current calculators:
    - Sum, //SumCalculator
    - Average, //AverageCalculator
    - AverageTimeBetweenEvents, //TimeBetweenCalculator
    - MaxEvent, //MaxEventCalculator
    - MinEvent, //MinEventCalculator
    - StandardDeviation, //StandardDevCalculator
    - Variance, //VarianceCalculator
    - TotalTimeThere
  - Samples/SamplesURP
    - Install this!

### 0.1.0 Changed

- None... yet

### 0.1.0 Fixed

- Setup the contents to align with Unity naming conventions

### 0.1.0 Removed

- None... yet
