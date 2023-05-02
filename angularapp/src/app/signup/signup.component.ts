import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators, NgForm } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { RegisterService } from 'src/service/register.service';

export class RegisterModel {
  Email!: string;
  UserName!: string;
  Password!: string;
  MobileNumber: any;
  UserRole!: string;
}
@Component({
  selector: 'app-signup',
  templateUrl: './signup.component.html',
  styleUrls: ['./signup.component.css']
})
export class SignupComponent implements OnInit {
  registerForm!: FormGroup;


  constructor(private formBuilder: FormBuilder, public registerservice: RegisterService, private toastr : ToastrService) { }

  ngOnInit(): void {
    this.registerForm = this.formBuilder.group({
      UserName: ['', Validators.required],
      Email: ['', Validators.required],
      Password: ['', Validators.required],
      MobileNumber: ['', Validators.required],
      UserRole: ['', Validators.required]

    });
  }
  onSubmit(): void {
    if (this.registerForm.valid) {
      this.registerservice.Create(this.registerForm.value).subscribe(res=>{console.log(res)}); 
      this.toastr.success("Registration Successfully !!!");
      this.registerForm.reset(); 
      
    } else {
      //alert('Form should not be null');
      this.toastr.error("Error ");
    }    
  }
}

