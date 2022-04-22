import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import {HomeComponent} from './pages/home/home.component';
import {AboutComponent} from './pages/about/about.component';
import {DoctorsComponent} from './pages/doctors/doctors.component';
import {PatientsComponent} from './pages/patients/patients.component';
import {ContactusComponent} from './pages/contactus/contactus.component';
import { BookAppointmentComponent } from './pages/patients/book-appointment/book-appointment.component';
import { MessagePageComponent } from './message-page/message-page.component';

import { CardiologyComponent } from './pages/cardiology/cardiology.component';
import { DermatologyComponent } from './pages/dermatology/dermatology.component';
import { HairtransplantComponent } from './pages/hairtransplant/hairtransplant.component';
import { GastroComponent } from './pages/gastro/gastro.component';
import { CancercareComponent } from './pages/cancercare/cancercare.component';
import { NeurologyComponent } from './pages/neurology/neurology.component';


const routes: Routes = [
  {path:'',component:HomeComponent},
  {path:'aboutus',component:AboutComponent},
  {path:'doctors',component:DoctorsComponent},
  {path:'patients',component:PatientsComponent},
  {path:'contactus',component:ContactusComponent},
  {path:'book-aptmt', component:BookAppointmentComponent},
  {path:'msgpage', component:MessagePageComponent},
  {path:'cardiology',component:CardiologyComponent},
  {path:'dermatology',component:DermatologyComponent},
  {path:'gastro',component:GastroComponent},
  {path:'hairtransplant',component:HairtransplantComponent},
  {path:'neurology',component:NeurologyComponent},
  {path:'cancercare',component:CancercareComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
