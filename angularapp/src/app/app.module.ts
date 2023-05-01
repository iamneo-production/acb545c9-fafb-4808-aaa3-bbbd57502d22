import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { RefereeComponent } from './referee/referee.component';
//import { TeamsComponent } from './teams/teams.component';
import { LogoutComponent } from './logout/logout.component';
import { VenueComponent } from './venue/venue.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import  {HttpClient,HttpClientModule}from '@angular/common/http';
import { AddComponent } from './add/add.component';
//import { TeamComponent } from './team/team.component';






@NgModule({
  declarations: [
    AppComponent,
    //TeamsComponent,
    RefereeComponent,
    LogoutComponent,
    VenueComponent,
    AddComponent,
    //TeamComponent,
 
   
    
   
  ],
  imports: [
    BrowserModule,
    FormsModule,
    AppRoutingModule,
     HttpClientModule,
     ReactiveFormsModule
    
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
