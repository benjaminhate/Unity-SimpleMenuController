# [Menu](Menu).Return

public virtual void Return();

## Description

Returns from the current [Menu](Menu) to the previous [Menu](Menu).

[Closes](Menu.Close) the current [Menu](Menu) and [opens](Menu.Open) the previous [Menu](Menu) with it's hierarchy reset.

If the previous [Menu](Menu) is not set (e.g to `null`), this function won't do anything.

Can be `override` to place a custom behaviour when the [Menu](Menu) returns.
**WARNING**: Do not forget to call `base.Return();` in order for the system to work as intended.

## Usage in Unity

You can easily call with method in a button UI.

The following picture shows how to reference to Return function and what arguments to put.
The **green** section references the **current** Menu, e.g the Menu that contains the button.

![Image not Found](https://github.com/benjaminhate/Unity-SimpleMenuController/raw/main/Documentation~/Components/Public%20Methods/Images/Menu%20-%20Return%20button%20UI.PNG "Return button UI")