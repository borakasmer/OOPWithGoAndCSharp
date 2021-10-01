package main

import "fmt"

type Worker struct{
}

func (hr *Worker) SendMail(body string, cc string){
	fmt.Println("Worker Mail Send :",body)
}