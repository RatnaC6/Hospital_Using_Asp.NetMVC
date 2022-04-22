import { Component, Inject, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { ContactusService } from 'src/app/contactus.service';

@Inject(ContactusService)

@Component({
  selector: 'app-contactus',
  templateUrl: './contactus.component.html',
  styleUrls: ['./contactus.component.css']
})
export class ContactusComponent implements OnInit {

  
  enquiry = new FormGroup(
    {
      FirstName : new FormControl(""),
      LastName : new FormControl(""),
      MobileNo : new FormControl(""),         
      Email : new FormControl(""),
      Message : new FormControl("")
    });

  constructor(private contactService : ContactusService) { }

  ngOnInit(): void {
  }

  ask(){
    this.contactService.enquiry(this.enquiry.value).subscribe((data)=>
    {
      console.log(data);
    });
    this.showResponse();
    this.clearForm();
    
  }

  clearForm(){
    (<HTMLFormElement>document.getElementById("enquiry-form")).reset();
   }
  showResponse(){
    alert("Thank you for reaching us! We'll solve your query within two working days\r\n"
    +"First Name: "+this.enquiry.get("FirstName")?.value+"\r\n"
    +"Last Name: "+this.enquiry.get("LastName")?.value+"\r\n"
    +"Mobile No.: "+this.enquiry.get("MobileNo")?.value+"\r\n"
    +"Email: "+this.enquiry.get("Email")?.value+"\r\n"
    +"Message: "+this.enquiry.get("Message")?.value+"\r\n"
    );
  }
}
