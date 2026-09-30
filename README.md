# Blazor MultiSelect Dropdown RefreshDataAsync with Remote Data Adaptors

## Overview

This sample demonstrates how to refresh remote data in the Syncfusion [Blazor MultiSelect](https://www.syncfusion.com/blazor-components/blazor-multiselect-dropdown)component using the `RefreshDataAsync()` method. The application showcases dynamic data reloading scenarios where the underlying data source URL is changed at runtime and the MultiSelect component retrieves the updated data without requiring component reinitialization.
 
The project includes three adaptor-based implementations: `ODataV4Adaptor`, `WebApiAdaptor`, and `UrlAdaptor`. Each sample page updates the associated `SfDataManager.Url` property and invokes `RefreshDataAsync()` from button-click and filtering events to demonstrate how remote datasets can be refreshed on demand.
 
The repository also includes ASP.NET Core Web API controllers, Entity Framework Core data access components, custom OData query handling, and server-side filtering, sorting, searching, and paging logic used to support the remote data operations performed by the MultiSelect component.

## Key Features

- Demonstrates the Syncfusion `SfMultiSelect` component with remote data binding.
- Uses the `RefreshDataAsync()` method to reload data from remote endpoints without recreating the component.
- Integrates `SfDataManager` for remote data communication.
- Demonstrates data refresh scenarios using `ODataV4Adaptor`.
- Demonstrates data refresh scenarios using `WebApiAdaptor`.
- Demonstrates data refresh scenarios using `UrlAdaptor`.
- Dynamically updates the `SfDataManager.Url` property before refreshing data.
- Uses the `Filtering` event to trigger data refresh operations while filtering.
- Supports remote searching, filtering, sorting, paging, and record count retrieval.
- Uses Syncfusion `DataManagerRequest` and `DataOperations` APIs for server-side query processing.
- Includes a custom Web API endpoint (`ValuesController`) that handles searching, filtering, sorting, skip, take, and count operations.
- Includes a custom Web API endpoint (`DefaultController`) that processes OData query parameters such as `$filter`, `$orderby`, `$skip`, `$top`, and `$inlinecount`.
- Demonstrates remote data retrieval from the public Northwind OData service.
- Includes Entity Framework Core-based data access through `OrderContext` and `OrderDataAccessLayer`.
- Supports refresh operations initiated through both user actions and filtering interactions.

## Prerequisites

- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) or [Visual Studio Code](https://code.visualstudio.com/)
- [.NET SDK](https://dotnet.microsoft.com/en-us/download/dotnet) compatible with the project's target framework

## How to Run the Project

**Visual Studio 2022**

1. Clone or download this repository.
2. Open `RefreshDataAsyncSample.sln`.
3. Restore NuGet packages if prompted.
4. Ensure `RefreshDataAsyncSample` is the startup project.
5. Build the solution.
6. Run the application using `Ctrl+F5`.

**Visual Studio Code**

1. Open the repository folder in Visual Studio Code.
2. Open a terminal and navigate to the project directory.
3. Execute the following commands:

```bash
dotnet restore
dotnet run
```

4. Open the application URL displayed in the console after startup.

## Project Structure

`Pages/Index.razor` - Demonstrates `RefreshDataAsync()` using `UrlAdaptor` and a custom Web API endpoint.

`Pages/ODataAdaptor.razor` - Demonstrates refreshing MultiSelect data using `ODataV4Adaptor` and the Northwind OData service.

`Pages/WebApiAdaptor.razor` - Demonstrates refreshing MultiSelect data using `WebApiAdaptor` and a custom ASP.NET Core Web API endpoint.

`Pages/UrlAdaptor.razor` - Demonstrates refreshing MultiSelect data using `UrlAdaptor` with dynamically updated URLs.

`Pages/FetchData.razor` - Default Blazor weather forecast sample page included in the project template.

`Controller/DefaultController.cs` - Web API controller that processes OData-style requests including filtering, sorting, paging, and inline count operations.

`Controller/ValuesController.cs` - Web API controller that handles Syncfusion `DataManagerRequest` operations such as searching, filtering, sorting, paging, and record count retrieval.

`Data/OrderContext.cs` - Entity Framework Core database context used to access the Orders dataset.

`Data/OrderDataAccessLayer.cs` - Data access layer providing CRUD operations for Order records.

`Data/Orders.cs` - Order entity model used by the Web API adaptor sample.

`Data/Offers.cs` - Employee-related data models used by the UrlAdaptor sample.

`Data/WeatherForecast.cs` - Weather forecast model included with the Blazor project template.

`Data/WeatherForecastService.cs` - Service that generates sample weather forecast data.

`Shared/SurveyPrompt.razor` - Default Blazor template survey component.

`App_Data/NORTHWND.MDF` - Northwind database file used by the Entity Framework data access layer.

## Support and Feedback

- For general product questions, visit the [Syncfusion Community Forum](https://www.syncfusion.com/forums) or [Syncfusion Support](https://www.syncfusion.com/support).
- To report an issue specific to this sample, open a GitHub issue in this repository.
- Documentation: https://blazor.syncfusion.com/documentation/multiselect-dropdown/data-binding

## License

This is a Syncfusion sample project provided to demonstrate product usage. Review the [Syncfusion license terms](https://www.syncfusion.com/sales/pricing?category=ui-components) before using Syncfusion components in your own applications.