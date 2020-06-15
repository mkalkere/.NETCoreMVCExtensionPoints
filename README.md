# .NET Core MVC Extension Points
Improving .NET Core MVC Using Extension Points

### 1. Overview

### 2. Getting the most out of MVC

### 3. Improving Views and Layouts

Tag Helpers
-   Transform HTML elements
- Applied as new elements, or as new attributes on existing elements
- Inherit from Tag Helper base class
- Override the Process method

View Components
- Create reusable UI components
- Inherit from the View Component base Class
- Define an InvokeAsync method with Logic

Tag Helpers and View Components both support DI and MVC Context

### 4. Controlling Application Flow with Filters

- Filters inject logic into the MVC Pipeline

- Action filters run logic before and after Action Methods

- Result Filters similarly run logic before and after Action Results

- Exception Filters can intercept the exceptions in the scope of MVC

- Authorization Filters run first and validate incoming requests

- Resource filters wrap the MVC Life Cycle

- Type and Service Filters enable Dependency Injection

### 5. Enhancing Data Binding and Validation

- Model Validation maintains the integrity of incoming request data

- Validation Attributes can be used to customize property validation

- IValidatableObject can be used to implement custom Model level validation

- Model Binding Providers determine which Binder should be used for a request

- Value Providers supply the Binder with data

- Input Formatters serilize  request body data

- Custom Model Binders can be used to handle difficult or incomplete data



