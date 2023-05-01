import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
//import { AddComponent, Addmodel } from '../add/add.component';
const url = 'https://localhost:44378/api/Venue/CreateVenue';
@Injectable({
  providedIn: 'root'
})
export class AddvenueserviceService {

  constructor(private http : HttpClient) { }
}
  
  //getdata(data : Addmodel): Observable <any>
//{
  //  return this.http.post<Addmodel>(url,data);
  //}
//}
