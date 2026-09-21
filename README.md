# Blazor DataGrid with Fluxor

## Overview

This repository demonstrates how to integrate a Syncfusion Blazor DataGrid with Fluxor state management in a hosted Blazor application. The solution is organized into separate Client, Server, and Shared projects and provides a reference architecture for managing Grid data through a centralized Fluxor store instead of directly binding data within UI components. The sample shows how a Syncfusion DataGrid can participate in a predictable state-management workflow while sharing models between application layers.

## Key Features

- Demonstrates integration between Syncfusion Blazor DataGrid and Fluxor state management.
- Uses a hosted Blazor application architecture with separate `Client`, `Server`, and `Shared` projects.
- Includes the solution file `FluxorSyncfusionGrid.sln`.
- Shares application models and contracts through the `Shared` project.
- Shows how DataGrid-related data can be managed through a centralized application state.
- Demonstrates a separation of concerns between UI rendering, state management, and server-side processing.
- Uses Fluxor-based state management patterns within a Syncfusion Blazor application.

## Prerequisites

- Visual Studio 2022 or Visual Studio Code
- .NET SDK compatible with the project's target framework

## How to Run the Project

**Visual Studio 2022**

1. Clone or download this repository.
2. Open `FluxorSyncfusionGrid.sln`.
3. Restore all NuGet packages.
4. Set the appropriate startup project for the hosted Blazor application if required.
5. Build the solution.
6. Run the application using `Ctrl+F5`.

**Visual Studio Code**

1. Open the repository folder in Visual Studio Code.
2. Open the integrated terminal.
3. Navigate to the repository root containing `FluxorSyncfusionGrid.sln`.

```bash
dotnet restore
dotnet run
```

4. Open the local application URL displayed after the application starts.

## Project Structure

- `Client/` — contains the Blazor client application that renders the Syncfusion DataGrid UI and interacts with Fluxor state management.
- `Server/` — contains the server-side application and APIs consumed by the client application.
- `Shared/` — contains models, DTOs, and shared types referenced by both Client and Server projects.

## Support and Feedback

- For general product questions, visit the [Syncfusion Community Forum](https://www.syncfusion.com/forums) or [Syncfusion Support](https://www.syncfusion.com/support).
- To report an issue specific to this sample, open a GitHub issue in this repository.
- For official Syncfusion DataGrid documentation, see https://help.syncfusion.com/grid-sdk/blazor/data-grid/getting-started

## License

This is a Syncfusion sample project provided to demonstrate product usage. Review the [Syncfusion license terms](https://www.syncfusion.com/sales/pricing?category=ui-components) before using Syncfusion components in your own applications.