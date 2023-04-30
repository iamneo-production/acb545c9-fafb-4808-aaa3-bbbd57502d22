import { Component, OnInit } from '@angular/core';
//import { FormBuilder, FormGroup, Validators } from '@angular/forms';
//import { AppService } from '../app.service';


/*export class TeamModel{
  teamName!:string;
  teamDescription!:string;
  noOfplayers!:number;
  TeamLocation!:string;
  FirstName!:string;
  LastName!:string;
  Age!:number;
  Gender!:string;

}*/
@Component({
  selector: 'app-addteam',
  templateUrl: './addteam.component.html',
  styleUrls: ['./addteam.component.css']
})
export class AddteamComponent //implements OnInit//
{

  /*Gender=["Male","Female"];

  teamform!:FormGroup;
  constructor(private formbuilder: FormBuilder, public addteam:AppService){}

  ngOnInit(): void {
    this.teamform=this.formbuilder.group({
      teamName:['',[Validators.required]],
      teamDescription:['',[Validators.required]],
      noOfplayers:['',[Validators.required]],
      TeamLocation:['',[Validators.required]],
      FirstName:['',[Validators.required]],
      LastName:['',[Validators.required]],
      Age:['',[Validators.required]],
      Gender:['',[Validators.required]],
    })
  }

onSubmit():void{
  if(this.teamform.valid){
    this.addteam.Create(this.teamform.value).subscribe(res=>{console.log(res)});
  }else{
    alert('form should not be null');
  }*/
}

