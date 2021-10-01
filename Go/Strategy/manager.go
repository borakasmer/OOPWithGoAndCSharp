package main

import "fmt"

type Manager struct{
}

func (hr *Manager) SendMail(body string, cc string){
	fmt.Println("Manager Mail Send :",body)
}
