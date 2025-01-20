# Specialization

- Look to each class and ask yourself if you can create a subclass of that class.
- If you can create a subclass then this class is a candidate for specialization.

# Car

| Field       | Type   |
| ----------- | ------ |
| PlateNumber | string |
| Model       | string |
| Year        | int    |
| Color       | string |
| Price       | double |

## Specialized Classes

### ElectricCar

| Field        | Type |
| ------------ | ---- |
| BatteryLife  | int  |
| ChargingTime | int  |

### GasCar

| Field      | Type   |
| ---------- | ------ |
| FuelType   | string |
| TankSize   | int    |
| EngineSize | int    |

Redundancy vs Coupling

- Redundancy is the duplication of data or functionality within a system.
- Coupling is the degree of interdependence between software modules; a measure of how closely connected two routines or modules are. (Like Multiple Inheritance)

How to solve the coupling problem?

