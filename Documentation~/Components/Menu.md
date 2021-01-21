# Menu Component

This Component is the base for constructing menus.

If you want to have a custom behaviour for your menu, you can inherint from this base class and override the public methods for custom behaviours.

## Properties
| Property | Description | Type |
|----------|-------------|------|
| Is Self Contained | If enabled, it will automatically set the Menu GameObject to the attached GameObject. | boolean
| Menu Game Object | Reference to the GameObject to activate/deactivate when the Menu opens or closes. | GameObject

## Public Methods
| Method name | Description |
|-------------|-------------|
| [Open](Menu.Open) | Opens the current Menu and sets the previous Menu
| [Close](Menu.Close) | Closes the current Menu
| [Return](Menu.Return) | Return from the current Menu to the previous Menu

## Behaviour
You can add this Component to a GameObject corresponding to your menu.

For your buttons, you can use the [Open](Menu.Open) method to open an other [Menu](Menu) or use the [Return](Menu.Return) method to return to the previous [Menu](Menu).

## Example