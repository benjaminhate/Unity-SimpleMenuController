# MenuController

## Component
**Unity Component**:
> Simple Menu Controller > Menu Controller

This Component is the main controller of the package.

This Component is only used at start, to activate the main menu.

## Properties
| Property | Description | Type |
|----------|-------------|------|
| Auto Detect Menus | If enabled, it will automatically detect the [Menu](Menu) Components to use. This will only detect Components that are children of the MenuController Component. The first [Menu](Menu) child detected will be the main menu. | boolean
| Menus | If Auto Detect is disabled, you need to reference all your [Menu](Menu) Components. The first [Menu](Menu) in this list will be the main menu. | list of [Menu](Menu)

## Behaviour
When the MenuController starts, it will [Close](Menu.Close) all menus referenced or auto-detected and will [Open](Menu.Open) the main menu.

## Example

You can see in the pictures bellow how the [Menu Controller](MenuController) component is attached to a Unity GameObject.

If the **"Auto Detect Menus"** property is disabled, you must reference the **"Menus"** property and add manually all [Menu](Menu) that you wish to control with this controller.

![Image not found](https://github.com/benjaminhate/Unity-SimpleMenuController/raw/main/Documentation~/Components/Images/Menu%20Controller%20-%20not%20Auto%20detect.PNG "Menu Controller, not auto detect")

![Image not found](https://github.com/benjaminhate/Unity-SimpleMenuController/raw/main/Documentation~/Components/Images/Menu%20Controller%20-%20Auto%20detect.PNG "Menu Controller, auto detect")