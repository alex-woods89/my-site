import { Component, Inject } from '@angular/core';
import { Email } from './email';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { HttpService } from '../Services/http.service';

@Component({
  selector: 'app-contact-me',
  templateUrl: './contact-me.component.html',
  styleUrls: ['./contact-me.component.css']
})
export class ContactMeComponent {

  constructor(private httpService: HttpService) { }

  email: Email = new Email()

  resetForm() {
    this.email.emailBody = ""
    this.email.sendersEmailAddress = ""
    this.email.sendersName = ""
    this.email.subject = ""
  }

  onSubmit() {
    this.httpService.post("/email", this.email).subscribe(
      () => {
        this.resetForm();
      },
      (error) => console.log("error" + error)
    )}
  }
