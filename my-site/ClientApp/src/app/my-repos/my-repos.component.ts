import { Component, OnInit } from '@angular/core';
import {HttpService} from  '../Services/http.service'

@Component({
  selector: 'app-my-repos',
  templateUrl: './my-repos.component.html',
  styleUrls: ['./my-repos.component.css']
})
export class MyReposComponent {

  constructor(private httpService: HttpService) {
    this.httpService.get("https://api.github.com/users/alex-woods89/repos").subscribe(
      (data: []) => {
        this.repos = data
        this.mySite = this.repos.find(x => x.name == 'my-site')
      })
  }
  repos = []
  mySite = {
    "name": "",
    "language": "",
    "html_url": ""
  }
}
