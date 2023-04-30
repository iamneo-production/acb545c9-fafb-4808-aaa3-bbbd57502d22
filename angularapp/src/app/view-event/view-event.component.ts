import { Component } from '@angular/core';
import { EventworkService } from '../services/eventwork.service';

@Component({
  selector: 'app-view-event',
  templateUrl: './view-event.component.html',
  styleUrls: ['./view-event.component.css']
})

// export class ViewEventModel 
// { 
//     EventName !: string ;
//     ApplicantName !: string;
//     ApplicantMobile !: string;
//     ApplicantEmail !: string;
//     EventFromDate !: string;
// }
export class ViewEventComponent
{
  event:any;
  constructor(private eventwork:EventworkService)
  {

    // eventwork.event().subscribe((data: any)=>
    // {
    //   console.log("data", data);
    //   this.event=data;
    // })
    
  }

}
