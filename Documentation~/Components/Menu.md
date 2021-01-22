# Menu

## Component
**Unity Component**:
> Simple Menu Controller > Menu

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

### Base Menu

You can see in the pictures bellow how the [Menu](Menu) component is attached to a Unity GameObject.

If the **"Is Self Contained"** property is disabled, you must reference the **"Menu Game Object"** property and add manually the Unity GameObject you want to control with this [Menu](Menu).

![Image not found](https://github.com/benjaminhate/Unity-SimpleMenuController/raw/main/Documentation~/Components/Images/Base%20Menu%20-%20not%20Self%20Contained.PNG "Base Menu, not self contained")

![Image not found](https://github.com/benjaminhate/Unity-SimpleMenuController/raw/main/Documentation~/Components/Images/Base%20Menu%20-%20Self%20Contained.PNG "Base Menu, self contained")

### Custom Menu

You can create custom [Menu](Menu) by inherit the [Menu](Menu) base class.

In the example bellow, you can see a Main Menu that inherit the [Menu](Menu) base class.
You can add custom property in addition to the base properties defined by the [Menu](Menu) class.

![Image not found](https://github.com/benjaminhate/Unity-SimpleMenuController/raw/main/Documentation~/Components/Images/Custom%20Menu.PNG "Custom Menu")