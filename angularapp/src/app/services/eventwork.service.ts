import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
// import { ViewEventModel } from '../view-event/view-event.component';

const URL:any="https://localhost:7129/api/controller/ReadById";
@Injectable({
  providedIn: 'root'
})
export class EventworkService {

  createurl='https://localhost:7129/api/controller/create';

  events() {
    throw new Error('Method not implemented.');
  }

  constructor(private http:HttpClient) { }
  // Read(data:ViewEventModel) : Observable<any>
  // {
  //   return this.http.post<ViewEventModel>(URL,data);
  // }

  Create(eventmodule:Event): Observable<any>{
    return this.http.post(this.createurl,eventmodule);
  }
}
