import { Component } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-update-event',
  templateUrl: './update-event.component.html',
  styleUrls: ['./update-event.component.css']
})
export class UpdateEventComponent {

  loginForms=new FormGroup(
    {
      EventName:new FormControl(''),
      ApplicantName:new FormControl(''),
      ApplicantAddress: new FormControl(''),
      ApplicantMobile:new FormControl(''),
      ApplicantEmail:new FormControl(''),
      EventAddress:new FormControl(''),
      EventFromDate:new FormControl(''),
      EventToDate:new FormControl('')
      
    })
    loginUser()
    {
      console.log(this.loginForms.value);
    }

}
