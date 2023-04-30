import { Component, NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { TeamComponent } from './team/team.component';
import { AddteamComponent } from './addteam/addteam.component';


const routes: Routes = [
  {path:'team', component: TeamComponent},
 {path:'addteam',component:AddteamComponent}
  
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
