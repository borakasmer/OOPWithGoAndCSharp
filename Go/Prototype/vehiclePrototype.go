package main

type VehiclePrototype interface {
	Clone() VehiclePrototype
}

type BaseVehicle struct {
	ChassisNumber string
}

