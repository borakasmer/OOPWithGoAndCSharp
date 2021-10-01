package main

type WService interface{
	CheckToken() bool
	GetUserId() string
}

type Mservice interface {
	WService
	GetMobileDeviceId() string
	CheckMobileVersion() bool
	GetMobilePlatform() string
}
