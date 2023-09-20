# Sprint-0-Warm-Up-Template
OOP 2 Spint 0 Warm Up Template

The following is a sample of the first part of an OOP1 Midterm.

It has been slightly simplified we will work on part 2 next week in sprint 1.

Please complete the following story before next week.

Sample Program 

Flying Vehicle Tester......................................................

Airlplane.cs...............................................................
This OOPFlyingVehicle.Airplane has a max altitude of 41000 ft.
It's current altitude is 0 ft.
OOPFlyingVehicle.Engine is not started.

AireplaneTakeOffTests...............................................................

Call ap.TakeOff():
OOPFlyingVehicle.Airplane can't fly it's engine is not started.

Call ap.StartEngine():
OOPFlyingVehicle.Airplane is flying

Fly up Tests...................................................................
Call ap.FlyUp() fly to 1,000ft default
This OOPFlyingVehicle.Airplane has a max altitude of 41000 ft.
It's current altitude is 1000 ft.
OOPFlyingVehicle.Engine is started.

Call ap.FlyUp(44000) Fly up to 45,000ft:
This OOPFlyingVehicle.Airplane has a max altitude of 41000 ft.
It's current altitude is 1000 ft.
OOPFlyingVehicle.Engine is started.

Call ap.FlyUp(44000) Fly up another 40,000ft shouldn't work
This OOPFlyingVehicle.Airplane has a max altitude of 41000 ft.
It's current altitude is 41000 ft.
OOPFlyingVehicle.Engine is started.

Fly Down.................................................................
Call ap.FlyDown(50000) Fly Down 50,000 ft
This OOPFlyingVehicle.Airplane has a max altitude of 41000 ft.
It's current altitude is 41000 ft.
OOPFlyingVehicle.Engine is started.
Call ap.FlyDown(ap.CurrentAltitude) this should land
This OOPFlyingVehicle.Airplane has a max altitude of 41000 ft.
It's current altitude is 0 ft.
OOPFlyingVehicle.Engine is started.
