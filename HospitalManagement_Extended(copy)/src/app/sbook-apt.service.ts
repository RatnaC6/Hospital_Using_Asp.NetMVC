import { Injectable, Input } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { IbookApt } from './ibook-apt';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class SbookAptService {

  constructor(private httpClient : HttpClient) { }

  // THIS IS GET METHOD FOR DB
  getAllPatients() : Observable< IbookApt[]>{

     return this.httpClient.get< IbookApt[]>("https://localhost:44301/patient/register",
    {
      headers: {
        "Access-Control-Allow-Origin" : "*"
      }
    });
  }

  // THIS IS POST METHOD FOR DB
  addPatient(aptDetails : any){
    return this.httpClient.post("https://localhost:44301/patient/register",aptDetails,
    {
      headers: {
        "Access-Control-Allow-Origin" : "*"
      }
    });
    
  }
}


//https://localhost:44301/api/BookAppointments