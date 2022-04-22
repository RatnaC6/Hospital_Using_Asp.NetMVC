import { Injectable } from '@angular/core';
import { Idoctors } from './idoctors';

@Injectable({
  providedIn: 'root'
})
export class SdoctorsService {

  specDocTwo : Idoctors[] = [];

  doctors : Idoctors[] = [
    {
      dName:"Dr. Abhay Kumar",
      dQualification:["MD", "DM", "DNB"],
      dExperience: 25,
      dSpeciality:"Cardiology",
      dLanguages:["English", "Hindi","Marathi"]
    },

    {
      dName:"Dr. Rahul Bhat",
      dQualification:["MBBS", "MD (Gen Medicine)", "DM (Neurology)"],
      dExperience: 16,
      dSpeciality:"Neurology",
      dLanguages:["English", "Hindi"]
    },

    {
      dName:"Dr. Rani Shetty",
      dQualification:["MS (General Surgery)", "DNB (General Surgery)", "FRCS (General Surgery)"],
      dExperience: 30,
      dSpeciality:"Cancer Care",
      dLanguages:["English", "Hindi","Marathi","French"]
    },

    {
      dName:"Dr. Amol Ghalme",
      dQualification:["M.D. (Internal Medicine)", "D.M. (Pulmonary and critical care)"],
      dExperience: 10,
      dSpeciality:"Dermatology",
      dLanguages:["English", "Hindi"]
    },

    {
      dName:"Dr. Abhishek Srivastava",
      dQualification:["MBBS", "MD - General Medicine", "DNB - General Medicine", "DM - Gastroenterology", "DNB - Gastroenterology"],
      dExperience: 20,
      dSpeciality:"Gastroenterology",
      dLanguages:["English", "Hindi","Marathi"]
    },

    {
      dName:"Dr. Bhavana Patil",
      dQualification:["MS (General Surgery)", "DNB (General Surgery)", "FRCS (General Surgery)"],
      dExperience: 15,
      dSpeciality:"Hair Transplant",
      dLanguages:["English", "Hindi","Marathi","Malayalam"]
    },

    {
      dName:"Dr. Akshat Kayal",
      dQualification:["MS (General Surgery)", "DNB (General Surgery)", "FRCS (General Surgery)"],
      dExperience: 5,
      dSpeciality:"Hair Transplant",
      dLanguages:["English", "Hindi","Telugu","Tamil"]
    },

    {
      dName:"Dr. Prerna Bhurat",
      dQualification:["MBBS", "MD(Internal Medicine)","DM (Cardiology)"],
      dExperience: 28,
      dSpeciality:"Cardiology",
      dLanguages:["English", "Hindi","Gujarati"]
    },

    {
      dName:"Dr. Subha Hegde",
      dQualification:["MS (General Surgery)", "DNB (General Surgery)", "FRCS (General Surgery)"],
      dExperience: 25,
      dSpeciality:"Hair Transplant",
      dLanguages:["English", "Hindi","Marathi","German"]
    },

    {
      dName:"Dr. Mohit Bhatt",
      dQualification:["MS (General Surgery)", "DNB (General Surgery)", "FRCS (General Surgery)", "FRCS (Neurosurgery)"],
      dExperience: 40,
      dSpeciality:"Neurology",
      dLanguages:["English", "Hindi","Bengali"]
    },

    {
      dName:"Dr. Dheeraj Kapoor",
      dQualification:["MBBS", "DM - Gastroenterology"],
      dExperience: 25,
      dSpeciality:"Gastroenterology",
      dLanguages:["English", "Hindi","Punjabi","Marathi"]
    },
  ];

  getAllDocs() : Idoctors[]{
    return this.doctors;
  }

  getDocBySpec(speciality : string) : string[] {
      let specDoc : string[] = [];
       
      let i = 0;
      for(i=0; i<this.doctors.length; i++)
      {
        if(this.doctors[i].dSpeciality.toLowerCase() === speciality.toLowerCase())
        {
            specDoc.push(this.doctors[i].dName);
            this.specDocTwo.push(this.doctors[i]);
        }
      }
      return specDoc;
  }

  getAllDocBySpec(speciality : string) : Idoctors[] {
       
    let i = 0;
    for(i=0; i<this.doctors.length; i++)
    {
      if(this.doctors[i].dSpeciality.toLowerCase() === speciality.toLowerCase())
      {
          this.specDocTwo.push(this.doctors[i]);
      }
    }
    return this.specDocTwo;
}
  constructor() { }
}
