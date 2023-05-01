import { Component } from '@angular/core';
export class venuemodel
{
  
  venueName!:any
  venueImageURL!:any
  venueDescription!:any
  VenueLocation!:any
}
@Component({
  selector: 'app-venue',
  templateUrl: './venue.component.html',
  styleUrls: ['./venue.component.css']
})
export class VenueComponent {
  constructor(){}
  add(data: any) {
    
  }
  ref() {
    throw new Error('Method not implemented.');
  }

}
