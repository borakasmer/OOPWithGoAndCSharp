package main

func main() {
	/*var postman = NewPostman(new(IT))
	postman.SendMail("Publish yapalım", "bora@borakasmer.com")

	var postman2 = NewPostman(new(HumanResource))
	postman2.SendMail("Maaşa zam, işe son", "bora@borakasmer.com")*/

	var postman3=NewPostman(new(Student))
	postman3.SendMail("Studentlar seminere bayıldı!","bora@borakasmer.com")
}
