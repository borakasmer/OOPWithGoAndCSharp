package main

type MobileService struct{}

func NewMobileService() *MobileService{
	return new(MobileService)
}

func (ws *MobileService) CheckToken() bool{
	return true
}

func (ws *MobileService) GetUserId() string{
	return "123456"
}

func (ws *MobileService) GetMobileDeviceId() string{
	return "352698276144152"
}

func (ws *MobileService) CheckMobileVersion() bool{
	return true
}

func (ws *MobileService) GetMobilePlatform() string{
	return "ios"
}