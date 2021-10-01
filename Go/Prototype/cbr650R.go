package main

//go get github.com/jinzhu/copier
import (
	"github.com/jinzhu/copier"
	"time"
)

type Cbr650R struct {
	Height, WarrantyYear, Km, Engine, Year int
	Weight, Price                          float64
	Color                                  string
	BaseVehicle
}

func NewCbr650R() *Cbr650R {
	var cbr = Cbr650R{WarrantyYear: 4, Km: 0, Weight: 207, Engine: 650, Year: time.Now().Year(), Height: 65}
	return &cbr
}

func (cbr *Cbr650R) Clone() VehiclePrototype {
	//var clone VehiclePrototype = new(Cbr650R)
	var clone = Cbr650R{}
	//clone := cbr

	//copier.Copy(&clone, &cbr)
	copier.CopyWithOption(&clone, &cbr, copier.Option{IgnoreEmpty: true, DeepCopy: true})

	return &clone
}
