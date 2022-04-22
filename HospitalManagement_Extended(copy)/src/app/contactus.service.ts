import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ContactusService {

  constructor(private httpClient : HttpClient) { }

  enquiry(enquiry : any){
    return this.httpClient.post("https://localhost:44301/enquiry/ask",enquiry,
    {
      headers: {
        "Access-Control-Allow-Origin" : "*"
      }
    });
    
  }
}
