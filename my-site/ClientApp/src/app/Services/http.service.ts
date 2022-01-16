import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class HttpService {

  constructor(private http: HttpClient) { }

  httpOptions = {
    headers: new HttpHeaders({
      'Content-Type': 'application/json'
    })
  }

  get(endpoint: string) {
    return this.http.get(endpoint)
  }

  post(endpoint:string, payload:any) {
   return this.http.post(window.location.origin + endpoint, payload, this.httpOptions)
  }
}
