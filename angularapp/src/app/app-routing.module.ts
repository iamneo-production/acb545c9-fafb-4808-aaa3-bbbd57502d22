import { Component, NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { EventComponent } from './event/event.component';
import { ViewEventComponent } from './view-event/view-event.component';
import { UpdateEventComponent } from './update-event/update-event.component';
import { HomeComponent } from './home/home.component';
import { DeleteComponent } from './delete/delete.component';

const routes: Routes = [
  {
    path: 'home',
    component:HomeComponent
  },
  {
    path:'event',
    component:EventComponent

  },
  {
    path:'view-event',
    component:ViewEventComponent
  },
  {
    path:'update-event',
    component:UpdateEventComponent
  },
  {
    path: 'delete',
    component:DeleteComponent
  },

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { 
  
}
