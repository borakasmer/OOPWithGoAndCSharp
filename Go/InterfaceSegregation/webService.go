package main

type WebService struct{}

func NewWebService() *WebService{
	return new(WebService)
}

func (ws *WebService) CheckToken() bool{
	return true
}

func (ws *WebService) GetUserId() string{
	return "123456"
}