# [Menu](Menu).Open

public virtual void Open([Menu](Menu) previousMenu);

## Description

Opens the [Menu](Menu) with the previousMenu as last [Menu](Menu) in the hierarchy.

If previousMenu is not null, calls the [Close](Menu.Close) function on it.

Can be `override` to place a custom behaviour when the [Menu](Menu) opens.
**WARNING**: Do not forget to call `base.Open(previousMenu);` in order for the system to work as intended.

## Usage in Unity

You can easily call with method in a button UI.

The following picture shows how to reference to Open function and what arguments to put.
The **green** section references the Menu you want to **open**.
The **blue** section references the **previous** Menu, e.g the Menu that contains the button.

![Image not found](https://github.com/benjaminhate/Unity-SimpleMenuController/raw/main/Documentation~/Components/Public%20Methods/Images/Menu%20-%20Open%20button%20UI.PNG "Open button UI")