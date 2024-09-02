<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/419782202/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1038519)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# Pivot Grid for WinForms - How to Aggregate Data by the Field's First Value

This example shows how to aggregate data by the field's first value.

<!-- default file list -->
## Files to Review

* [Form1.cs](./CS/Win_Pivot_CustomAggregates/Form1.cs) (VB: [Form1.vb](./VB/Win_Pivot_CustomAggregates/Form1.vb))
* [Program.cs](./CS/Win_Pivot_CustomAggregates/Program.cs) (VB: [Program.vb](./VB/Win_Pivot_CustomAggregates/Program.vb))
* [FirstValueFunction.cs](./CS/Win_Pivot_CustomAggregates/FirstValueFunction.cs) (VB: [FirstValueFunction.vb](./VB/Win_Pivot_CustomAggregates/FirstValueFunction.vb))
<!-- default file list end -->


## Overview

This example adds the `FirstValue([ProductName])` expression to the _First Sold Product_ field. The expression returns the first sold product by _Sales Persons_ in each product category.

![first value function](images/image.png)

| Data Field | Expression |
| --- | --- |
| First Sold Product | ``` FirstValue([ProductName]) ``` |

Call the [CriteriaOperator.RegisterCustomFunction](https://docs.devexpress.com/CoreLibraries/DevExpress.Data.Filtering.CriteriaOperator.RegisterCustomFunction(DevExpress.Data.Filtering.ICustomFunctionOperator)) method to register a custom function in your project (see [Program.cs](./CS/Win_Pivot_CustomAggregates/Program.cs#L18)/[Program.vb](./VB/Win_Pivot_CustomAggregates/Program.vb#L18))


## Documentation

- [Pivot Grid Expression Syntax](https://docs.devexpress.com/CoreLibraries/120512/devexpress-pivot-grid-core-library/pivot-grid-expression-syntax)
- [PivotGridControl](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.PivotGridControl)

## More Examples

[Pivot Grid for Web Forms - How to Aggregate Data by the Field's First Value](https://github.com/DevExpress-Examples/aspnet-pivot-grid-custom-aggregates)

<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-pivot-grid-custom-aggregates&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-pivot-grid-custom-aggregates&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
