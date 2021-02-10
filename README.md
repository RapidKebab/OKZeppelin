# OKZeppelin
A rigidbody based zeppelin/blimp controller for Unity3D. Old Code that I've now open-sourced. Provided as-is.
Controls: Unity default vertical and horizontal for altitude and yaw, LShift and LCtrl to shift gears and go forward and backward.
The gear system currently starts in gear 1, which is neutral in the example. 0 would generally be reverse, and any gear above 1 is forward at progressively increasing speeds.
Includes a primitive bomb and low poly blimp model. This version uses KeyCodes to take shifting input, so it's entirely portable between projects.
