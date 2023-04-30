import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-event',
  templateUrl: './event.component.html',
  styleUrls: ['./event.component.css']
})
export class EventComponent implements OnInit
{
  ngOnInit(): void {
    throw new Error('Method not implemented.');
  }

  eventwork: any;
  // ngOnInit(): void {
  //   throw new Error('Method not implemented.');
  // }

  // eventmodule:Event[]=[];
  // event: Event=
  // {
  //   eventId:'',
  //   eventName:'',
  //   applicantName:'',
  //   applicantAddress:'',
  //   applicantMobile:'',
  //   applicantEmail:'',
  //   eventAddress:'',
  //   eventFromDate:'',
  //   eventToDate:'',

  // }

  // onSubmit(){
  //   this.eventwork.Create(this.user)
  //   .subscribe(
  //     (response)=>{
  //       this.getallproducts();
  //       this.user =
  //       {
  //         eventId:'',
  //         eventName:'',
  //         applicantName:'',
  //         applicantAddress:'',
  //         applicantMobile:'',
  //         applicantEmail:'',
  //         eventAddress:'',
  //         eventFromDate:'',
  //         eventToDate:'',   
  //       }  
  //     })
  // }
  // getallproducts() {
  //   throw new Error('Method not implemented.');
  // }


  loginForm=new FormGroup(
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
    console.log(this.loginForm.value);
  }

}
