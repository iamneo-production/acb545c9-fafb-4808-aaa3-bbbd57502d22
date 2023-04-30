import { Component } from '@angular/core';

@Component({
  selector: 'app-delete',
  templateUrl: './delete.component.html',
  styleUrls: ['./delete.component.css']
})
export class DeleteComponent {

  event:any;
  constructor(private eventwork:DeleteComponent)
  {
   
    // eventwork.event().subscribe((data: any)=>
    // {
    //   console.log("data", data);
    //   this.event=data;
    // })
    
  }
}
