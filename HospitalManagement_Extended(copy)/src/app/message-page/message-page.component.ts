import { Component, OnInit } from '@angular/core';
import { BookAppointmentComponent } from '../pages/patients/book-appointment/book-appointment.component';
import { SbookAptService } from '../sbook-apt.service';

@Component({
  selector: 'app-message-page',
  templateUrl: './message-page.component.html',
  styleUrls: ['./message-page.component.css']
})
export class MessagePageComponent implements OnInit {

  bookedApt : any;
  lastEntry : any;
  
  constructor(private book_apt : SbookAptService) { }

  ngOnInit(): void {
    this.getPatient();
    
  }
    
  getPatient(){
//THIS IS GET FUNCTION FOR DB
this.book_apt.getAllPatients().subscribe((data)=> {
  console.log(data);
  this.bookedApt = data;
  this.lastEntry = this.bookedApt[this.bookedApt.length-1];
  });
  }
}
