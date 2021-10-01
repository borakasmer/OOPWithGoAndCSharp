package main

import (
	"github.com/jinzhu/copier"
	"time"
)

type AfricaTwin struct {
	Height, WarrantyYear, Km, Engine, Year int
	Weight, Price                          float64
	Color                                  string
	BaseVehicle
}

func NewAfricaTwin() *AfricaTwin {
	var afr = AfricaTwin{WarrantyYear: 3, Km: 0, Weight: 245, Engine: 1000, Year: time.Now().Year(), Height: 85}
	return &afr
}

func (afr *AfricaTwin) Clone() VehiclePrototype {
	//var clone VehiclePrototype = new(AfricaTwin)
	var clone = AfricaTwin{}
	//clone := afr

	//copier.Copy(&clone, &afr)
	copier.CopyWithOption(&clone, &afr, copier.Option{IgnoreEmpty: true, DeepCopy: true})

	return &clone
}
