import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { RouterModule, Route, Routes } from '@angular/router';
import { RouterOutlet} from '@angular/router';
import { ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';

import { RegisterModel, SignupComponent } from './signup/signup.component';
import { LoginComponent } from './login/login.component';

import { LoginService } from 'src/service/login.service';
import { RegisterService } from 'src/service/register.service';
import { AdminComponent } from './admin/admin.component';
import { ToastrModule } from 'ngx-toastr';
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
//import { RegisterComponent } from './register/register.component'


const routes: Routes = [
  {path:'',redirectTo:'user/login',pathMatch:'full'},
  { path: 'user/login', component:LoginComponent},
  { path: 'logout', component: LoginComponent },
  { path: 'user/signup', component:SignupComponent},
  { path : 'admin', component :AdminComponent }
  
  ];
@NgModule({
  declarations: [
    AppComponent,
    
    SignupComponent,
    LoginComponent,
    AdminComponent,
    //RegisterComponent
    
    
    
    
  ],
  imports: [
    BrowserModule,
    FormsModule,
    RouterModule.forRoot(routes),
    ReactiveFormsModule,
    HttpClientModule,
    ToastrModule.forRoot(),
    BrowserAnimationsModule

  
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { 
}
