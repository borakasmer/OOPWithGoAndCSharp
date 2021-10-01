package main

type Mail interface {
	SendMail(body string, cc string)
}
