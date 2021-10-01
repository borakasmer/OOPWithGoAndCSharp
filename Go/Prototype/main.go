package main

import (
	"fmt"
	"reflect"
	"strconv"
	"time"
)

func main() {
	var vehicleList = make([]VehiclePrototype, 0)

	//CBR650R
	for i := 0; i < 10; i++ {
		vehicle, isHave := IsExists(reflect.TypeOf(&Cbr650R{}).String(), vehicleList)
		var newCbr *Cbr650R
		if !isHave {
			newCbr = NewCbr650R()
		} else {
			newCbr, _ = vehicle.Clone().(*Cbr650R)
		}
		newCbr.Year = time.Now().Year()
		newCbr.ChassisNumber = strconv.Itoa(i) + "Cbr650"
		vehicleList = append(vehicleList, newCbr)
	}

	//AfricaTwin
	for i := 0; i < 10; i++ {
		vehicle, isHave := IsExists(reflect.TypeOf(&AfricaTwin{}).String(), vehicleList)
		var newAfr *AfricaTwin
		if !isHave {
			newAfr = NewAfricaTwin()
		} else {
			newAfr, _ = vehicle.Clone().(*AfricaTwin)
		}
		newAfr.Year = time.Now().Year()
		newAfr.ChassisNumber = strconv.Itoa(i) + "AfricaTwin"
		vehicleList = append(vehicleList, newAfr)
	}

	//Final List
	for _, motor := range vehicleList {
		switch reflect.TypeOf(motor).String() {
		case reflect.TypeOf(&Cbr650R{}).String():
			cb, _ := motor.(*Cbr650R)
			fmt.Println("Motor ChassisNumber: ", cb.ChassisNumber)
		case reflect.TypeOf(&AfricaTwin{}).String():
			af, _ := motor.(*AfricaTwin)
			fmt.Println("Motor ChassisNumber: ", af.ChassisNumber)
		}
	}

}

func IsExists(kind string, vehicleList []VehiclePrototype) (VehiclePrototype, bool) {
	for _, vehicle := range vehicleList {
		if kind == reflect.TypeOf(vehicle).String() {
			return vehicle, true
		}
	}
	return nil, false
}
