# [Menu](Menu).Close

public virtual void Close();

## Description

Closes the current [Menu](Menu).

Deactivate the menu GameObject referenced in the [Menu](Menu) Component.

Can be `override` to place a custom behaviour when the [Menu](Menu) closes.
**WARNING**: Do not forget to call `base.Close();` in order for the system to work as intended.