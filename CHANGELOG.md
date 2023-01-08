# CHANGELOG
All notable changes to this project will be documented in this file.

## [Unreleased]

## [0.0.1] - 2021-04-02
### Added
- Initial Version

## [0.0.2] - 2021-05-05
### Added
- AppleLogger

### Modified
- Existing scripts moved under `Editor` directory

## [0.0.3] - 2021-05-07
### Modified
- AppleLogger now forwards logs from all threads to NSLog

## [0.0.5] - 2021-07-29
### Modified
- AppleBuildProfile DefaultProfile creation properly creates sub-asset AppleBuildSteps
- Loading DefaultProfile from disk loads all assets

## [0.0.6] - 2021-08-13
### Modified
- UserManagement is disabled by default
- BuildSteps appear in alphabetical order

## [0.0.7] - 2021-10-26
### Modified
- DefaultAppleBuildProfile deserialization / discovery issue resolved

## [0.0.8] - 2022-03-28
### Modified
- Support for multiple minimum OS version definitions in Build Settings
- Update native project with bundle ID fixes
- Updating native project with aggregate build targets and supporting schemes
- Added library processor to ensure correct framework settings on import
- Added utility function to find correct library paths based upon name and BuildPlatform
