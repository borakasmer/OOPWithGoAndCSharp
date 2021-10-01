package main

import "fmt"

func main() {
	var webService = NewWebService()
	OperateWithWebService(webService)

	var mobileService = NewMobileService()
	OperateWithMobileService(mobileService)
}

func OperateWithWebService(serv WService) {
	fmt.Println("Web UserID:", serv.GetUserId())
}

func OperateWithMobileService(serv Mservice) {
	fmt.Println("Mobile Device ID:", serv.GetMobileDeviceId())
}
