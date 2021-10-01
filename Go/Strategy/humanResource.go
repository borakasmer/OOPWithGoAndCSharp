package main

import "fmt"

type HumanResource struct{
}

func (hr *HumanResource) SendMail(body string, cc string){
	fmt.Println("HumanResource Mail Send :",body)
}
