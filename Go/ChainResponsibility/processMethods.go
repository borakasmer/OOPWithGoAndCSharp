package main

import "fmt"

type ProcessMethods struct{}

func(pm *ProcessMethods) CallCrm(){
	fmt.Println("Call Crm")
}
func(pm *ProcessMethods) CallFinance(){
	fmt.Println("Call Finance")
}
func(pm *ProcessMethods) CallService(){
	fmt.Println("Call Service")
}
func(pm *ProcessMethods) BackCrm(){
	fmt.Println("Back Crm")
}
func(pm *ProcessMethods) BackFinance(){
	fmt.Println("Back Finance")
}
func(pm *ProcessMethods) BackService(){
	fmt.Println("Back Service")
}

func(pm * ProcessMethods) NextKommunity(){
	fmt.Println("Next Kommunity")
}
func(pm *ProcessMethods) BackKommunity(){
	fmt.Println("Back Kommunity")
}
