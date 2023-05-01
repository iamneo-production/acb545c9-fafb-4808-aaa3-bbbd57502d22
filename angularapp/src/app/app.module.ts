import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { RouterModule, Route,Routes } from '@angular/router';
import { RouterOutlet } from '@angular/router';
import { RouterLinkActive } from '@angular/router';


import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { AddRefereeComponent } from './add-referee/add-referee.component';

import { VenuesComponent } from './venues/venues.component';
import { TeamsComponent } from './teams/teams.component';
import { LogoutComponent } from './logout/logout.component';
import { AddComponent } from './add/add.component';


@NgModule({
  declarations: [
    AppComponent,
    AddRefereeComponent,
    VenuesComponent,
    TeamsComponent,
    LogoutComponent,
    AddComponent 
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
