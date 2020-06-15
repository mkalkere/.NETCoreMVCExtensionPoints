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

### 4. Controlling Application flow with Filters

- Filters inject logic into the MVC Pipeline

- Action filters run logic before and after Action Methods

- Result Filters similarly run logic before and after Action Results

- Exception Filters can intercept the exceptions in the scope of MVC

- Authorization Filters run first and validate incoming requests

- Resource filters wrap the MVC Life Cycle

- Type and Service Filters enable Dependency Injection

