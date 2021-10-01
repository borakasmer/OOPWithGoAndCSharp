package main

type Postman struct {
	_mail Mail
}

func NewPostman(mail Mail) *Postman {
	postman := new(Postman)
	postman._mail = mail
	return postman
}

func (p *Postman) SendMail(body string, cc string) {
	p._mail.SendMail(body, cc)
}
