import { Component, OnInit } from '@angular/core';
import { Idoctors } from '../idoctors';
import { SdoctorsService } from '../sdoctors.service';

@Component({
  selector: 'app-specdocs',
  templateUrl: './specdocs.component.html',
  styleUrls: ['./specdocs.component.css']
})
export class SpecdocsComponent implements OnInit {

  cardio : Idoctors[] = [];
  
  constructor(private docService : SdoctorsService) { }

  ngOnInit(): void {
  }

}
