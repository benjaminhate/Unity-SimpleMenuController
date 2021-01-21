# [Menu](Menu).Open

public virtual void Open([Menu](Menu) previousMenu);

## Description

Opens the [Menu](Menu) with the previousMenu as last [Menu](Menu) in the hierarchy.

If previousMenu is not null, calls the [Close](Menu.Close) function on it.

Can be `override` to place a custom behaviour when the [Menu](Menu) opens.
**WARNING**: Do not forget to call `base.Open(previousMenu);` in order for the system to work as intended.