import { Component, OnInit } from '@angular/core';
import {FormGroup,FormControl} from '@angular/forms'
import { Router} from '@angular/router';
import {StudentService} from '../../shared/services/student/student.service'

@Component({
  selector: 'app-student',
  templateUrl: './student.component.html',
  styleUrls: ['./student.component.css']
})
export class StudentComponent implements OnInit {
  viewStudent = new FormGroup({
    roll : new FormControl(''),
    dob : new FormControl('')
  })
  constructor(private student:StudentService,private router:Router) { }
  collection:any = []
  ngOnInit(): void {
  }
  result(){
    this.student.fetchStudent(this.viewStudent.value['roll'],this.viewStudent.value['dob']).subscribe(res=>{
     console.log(res);
     this.router.navigate(['/view']);
     this.viewStudent.reset();
       //console.log("result",result)
    //    if(this.collection=result )
    //   {
    //     alert("result is ready");
    //     this.router.navigate(['/view'])
    //   }
    //   else{
    //     alert("User not found!!");
    //     this.router.navigate(['student'])
    //   }
      
    },
    err=>{
      alert("User not found!!");
    }
    )
    //  if(this.collection.name=='')
    //  {
    //   this.router.navigate(['/view'])
    //  }
    //  else 
    //  {
    //   alert("User not found!!")
    //  }
    // console.log(this.collection)
    // console.log(this.collection.name)
  }

}
