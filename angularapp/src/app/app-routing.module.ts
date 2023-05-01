import { Component, NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

//import { TeamsComponent } from './teams/teams.component';
import { RefereeComponent } from './referee/referee.component';
import { VenueComponent } from './venue/venue.component';
import { AddComponent } from './add/add.component';




const routes: Routes = [
  {
    path:'venue',component:VenueComponent
  },

  // {
  //   path:'teams',
  //   component:TeamsComponent,
  // },
  {
    path:'add',
    component:AddComponent,

  },
  {
    path:'refree',
    component:RefereeComponent,

  },

  
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
