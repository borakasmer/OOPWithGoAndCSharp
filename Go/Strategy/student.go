package main

import "fmt"

type Student struct{
}

func (hr *Student) SendMail(body string, cc string){
	fmt.Println("Student Mail Send :",body)
}
