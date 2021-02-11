# OKZeppelin
A rigidbody based zeppelin/blimp/airship controller for Unity3D. It was made because my little brother wanted to fly a zeppelin. Controls like the airships in Guns of Icarus.

This is old code that I've now open-sourced, it's provided as-is and not supported. Would appreciate being credited if you use it for a purpose.

Controls: Unity default vertical and horizontal for altitude and yaw, LShift and LCtrl to shift gears and go forward and backward.

The gear system currently starts in gear 1, which is neutral in the example. 0 would generally be reverse, and any gear above 1 is forward at progressively increasing speeds. I would advise messing with your drag and angular drag values to tune ship agility on top of the vlues provided in script.

Includes a primitive bomb and low poly blimp model. This version uses KeyCodes to take shifting input, so it's entirely portable between projects.
