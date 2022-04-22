import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http'

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavbarComponent } from './sourcepage/navbar/navbar.component';
import { FooterComponent } from './sourcepage/footer/footer.component';
import { HomeComponent } from './pages/home/home.component';
import { AboutComponent } from './pages/about/about.component';
import { DoctorsComponent } from './pages/doctors/doctors.component';
import { ContactusComponent } from './pages/contactus/contactus.component';
import { PatientsComponent } from './pages/patients/patients.component';
import { BookAppointmentComponent } from './pages/patients/book-appointment/book-appointment.component';
import { SdoctorsService } from './sdoctors.service';
import { SbookAptService } from './sbook-apt.service';
import { MessagePageComponent } from './message-page/message-page.component';
import { SpecdocsComponent } from './specdocs/specdocs.component';

import { CardiologyComponent } from './pages/cardiology/cardiology.component';
import { DermatologyComponent } from './pages/dermatology/dermatology.component';
import { HairtransplantComponent } from './pages/hairtransplant/hairtransplant.component';
import { GastroComponent } from './pages/gastro/gastro.component';
import { CancercareComponent } from './pages/cancercare/cancercare.component';
import { NeurologyComponent } from './pages/neurology/neurology.component';

@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    FooterComponent,
    HomeComponent,
    AboutComponent,
    DoctorsComponent,
    ContactusComponent,
    PatientsComponent,
    BookAppointmentComponent,
    MessagePageComponent,
    SpecdocsComponent,
    CardiologyComponent,
    DermatologyComponent,
    HairtransplantComponent,
    GastroComponent,
    CancercareComponent,
    NeurologyComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule
  ],
  providers: [SdoctorsService, SbookAptService],
  bootstrap: [AppComponent]
})
export class AppModule { }
