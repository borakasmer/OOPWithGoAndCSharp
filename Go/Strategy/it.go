package main

import "fmt"

type IT struct{
}

func (hr *IT) SendMail(body string, cc string){
	fmt.Println("IT Mail Send :",body)
}
