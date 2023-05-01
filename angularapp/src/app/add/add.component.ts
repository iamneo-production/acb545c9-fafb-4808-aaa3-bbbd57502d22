import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { venueService } from '../venueservice.service';

@Component({
  selector: 'app-add',
  templateUrl: './add.component.html',
  styleUrls: ['./add.component.css']
})
export class AddComponent {
  venues: any;
  router: any;
  venueId: any;
  venueName: any;
  venueImageURL: any;
  venueDescription: any;
  venueLocation: any;

  constructor(private userservice: venueService) {
    this.userservice.getData().subscribe((data: any) => {
      console.log("data", data);

      this.venues = data;

    })
  }
  

  userForm = new FormGroup(

    {

      venueId: new FormControl('', [Validators.required]),

      venueName: new FormControl('', [Validators.required]),

      venueImageUrl: new FormControl('', [Validators.required]),

      venueDescription: new FormControl('', [Validators.required]),

      venueLocation: new FormControl('', [Validators.required]),






    }

  )

  addvenues(data: any) {

    this.userservice.addvenue(data).subscribe((res: any) => { console.log(res) });




    console.log(this.userForm.value);

    alert("sucessfully Added");

  }




  deletevenues(data: any) {

    this.userservice.DeleteData(data).subscribe((res: any) => {

      console.warn(res);



    })

  }

  updatevenues() {

    let updatevenue = {

      "id": this.venueId,

      "name": this.venueName,

      "imageurl": this.venueImageURL,

      "description": this.venueDescription,

      "location": this.venueLocation,




    }
    // this.userservice.update(this.venueId,updatevenue).subscribe((res: any)=>{

    // console.warn(res)

    // })

  }



}

