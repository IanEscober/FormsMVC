# Design Patterns
A concise example on applying the Model-View-Controller (MVC) and Strategy pattern on a legacy Windows Forms application. It accepts a simple string which it sorts in different sorting algorithms. The algorithms are dynamically instatiated with the Strategy pattern. Lastly, the UI is updated with adherence to the MVC pattern.

## MVC Implementation
The flow of data on the MVC pattern can be decomposed in several parts:
- __Binding__ of a model on the view.
- __Calling__ a controller method which invokes a change.
- __Parsing__ of the model from the view into a model accepted by the controller method.
- __Validating__ the parsed model _(Optional)_.
- __Returning__ a view with an updated model.

### Implementation Summary
| Concept       | Implementation                             |
| ------------- | ------------------------------------------ | 
| Binding       | [View Constructor](https://github.com/IanEscober/DesignPatterns/blob/master/src/DesignPatterns/View/DesignPatternsView.cs)                   |
| Calling       | [Events](https://github.com/IanEscober/DesignPatterns/blob/master/src/DesignPatterns/View/DesignPatternsView.cs)                                       |
| Parsing       | [Custom Parsing](https://github.com/IanEscober/DesignPatterns/blob/master/src/DesignPatterns/Parsing/DesignPatternsModelParsing.cs)        |
| Validating    | [Custom Validation](https://github.com/IanEscober/DesignPatterns/blob/master/src/DesignPatterns/Validation/DesignPatternsModelValidation.cs)  |
| Returning     | [ViewManager](https://github.com/IanEscober/DesignPatterns/blob/master/src/DesignPatterns/ViewManager.cs)                                              |

### ViewManager
The [ViewManager](https://github.com/IanEscober/DesignPatterns/blob/master/src/DesignPatterns/ViewManager.cs) is the core of the MVC implementation. It enables the Views to be updated by closing the stale View with an updated View through an updater function.
```csharp
public static void UpdateView<T, U>(Form currentView, Func<T,U> updater, T model)
{
    var updatedView = updater(model);
    Update(currentView, updatedView as Form);
}

public static void Update(Form currentView, Form updatedView)
{
    currentView.Close();
    currentView.Dispose();

    var thread = new Thread(() => Application.Run(updatedView));
    thread.SetApartmentState(ApartmentState.STA);
    thread.Start();
}
```

## Contribution
Yeet a Pull Request

## License
[MIT](https://github.com/IanEscober/DesignPatterns/blob/master/LICENSE)