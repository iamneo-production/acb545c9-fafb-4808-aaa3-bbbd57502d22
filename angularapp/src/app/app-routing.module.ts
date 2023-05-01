import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddRefereeComponent } from './add-referee/add-referee.component';
import { TeamsComponent }  from './teams/teams.component';
import { VenuesComponent } from './venues/venues.component';
import { LogoutComponent } from './logout/logout.component';


const routes: Routes = [

  {
    path:'Referee',
    component:AddRefereeComponent
  },
  {
    path:'Teams',
    component:TeamsComponent
  },
  {
    path:'Venues',
    component:VenuesComponent
  },
  {path:'logout',component:LogoutComponent}
];
  


@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
