# State Maintenance in Blazor Tabs

## Overview

This sample demonstrates how to maintain form values when users navigate between tabs in the Syncfusion [Blazor Tabs](https://www.syncfusion.com/blazor-components/blazor-tabs) component. The application compares dynamic, on-demand, and initial content-rendering modes and uses a shared form service where content is recreated during tab navigation. This helps developers understand how each rendering mode affects component state and prevents users from unexpectedly losing entered information.

## Key Features

- Uses the Syncfusion Blazor `SfTab` component to present a three-step tab-based workflow.
- Uses `SelectedItem` to track and programmatically change the active tab.
- Uses `TabItems` to define the tabs displayed by the component.
- Uses individual `TabItem` components for sign-in, product information, and feedback content.
- Uses `TabHeader` to define the visible text for each tab.
- Demonstrates the default dynamic rendering behavior, where tab content is recreated during navigation.
- Injects `FormService` into the dynamic-rendering example to retain the user name and email address when tab content is recreated.
- Uses `LoadOn="ContentLoad.Demand"` to render content when a tab is selected for the first time and retain it for subsequent navigation.
- Uses `LoadOn="ContentLoad.Init"` to render the content of every tab during the initial page load.
- Uses the Syncfusion Blazor TextBox component (`SfTextBox`) to collect sign-in and feedback values.
- Uses the Syncfusion Blazor Button component (`SfButton`) to submit information, skip the sign-in step, and move to the next tab.
- Displays a validation message when required form values are not provided.
- Demonstrates how the selected rendering mode affects component state and entered values during tab navigation.

## Prerequisites

- Visual Studio 2022 or Visual Studio Code
- .NET SDK compatible with the project's target framework

## How to Run the Project

**Visual Studio 2022**

1. Clone or download this repository.
2. Open the project file:  

   `BlazorStateMaintenance.csproj`
   
3. Restore the NuGet packages by rebuilding the project.
4. Build the project.
5. Run the application using `Ctrl+F5`.
6. Open the application URL displayed by Visual Studio after launch.
7. Navigate between the dynamic, on-demand, and initial rendering examples, enter values in the form fields, and verify how each content-rendering mode maintains the state of the tab content.

**Visual Studio Code**

1. Clone or download this repository.
2. Open the repository folder in Visual Studio Code.
3. Open the integrated terminal.
4. Navigate to the project directory:

```bash
cd state-maintenance-in-blazor-tabs
```

5. Restore the NuGet packages:

```bash
dotnet restore
```

6. Run the project:

```bash
dotnet run
```

7. Open the local URL displayed in the terminal after the application starts.
8. Navigate between the dynamic, on-demand, and initial rendering examples, enter values in the form fields, and verify how each content-rendering mode maintains the state of the tab content.

## Project Structure

- `Pages/Index.razor` — Demonstrates dynamic tab-content rendering and uses the shared form service to retain sign-in values.
- `Pages/DemandRendering.razor` — Demonstrates on-demand tab-content rendering using `ContentLoad.Demand`.
- `Pages/InitialRendering.razor` — Demonstrates initial rendering of all tab content using `ContentLoad.Init`.
- `Data/FormService.cs` — Stores the user name and email address used by the dynamic-rendering example.

## Support and Feedback

- For general product questions, visit the [Syncfusion Community Forum](https://www.syncfusion.com/forums) or [Syncfusion Support](https://www.syncfusion.com/support).
- To report an issue specific to this sample, open a GitHub issue in this repository.
- Official documentation: [Blazor Tabs getting started documentation](https://blazor.syncfusion.com/documentation/tabs/getting-started)

## License

This is a Syncfusion sample project provided to demonstrate product usage. Review the [Syncfusion license terms](https://www.syncfusion.com/sales/pricing?category=ui-components) before using Syncfusion components in your own applications.