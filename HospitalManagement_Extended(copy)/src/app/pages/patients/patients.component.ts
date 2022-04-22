import { Component, OnInit } from '@angular/core';
import { BookAppointmentComponent } from './book-appointment/book-appointment.component';
import { Cpatients } from 'src/app/cpatients';
@Component({
  selector: 'app-patients',
  templateUrl: './patients.component.html',
  styleUrls: ['./patients.component.css']
})
export class PatientsComponent implements OnInit {

  patient : Cpatients =
    {
      firstName: this.bkapt.bookAppointment.get("pFirstName")?.value,
      lastName : this.bkapt.bookAppointment.get("pLastName")?.value,
      gender: this.bkapt.bookAppointment.get("gender")?.value,
      mobile_no: this.bkapt.bookAppointment.get("mobile")?.value,
      email : this.bkapt.bookAppointment.get("email")?.value
    }
 
  
  constructor(private bkapt : BookAppointmentComponent) { }

  ngOnInit(): void {
  }

}
