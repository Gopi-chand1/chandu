import { Component, OnInit } from '@angular/core';
import {StudentService} from '../../shared/services/student/student.service';


@Component({
  selector: 'app-view-student',
  templateUrl: './view-student.component.html',
  styleUrls: ['./view-student.component.css']
})
export class ViewStudentComponent implements OnInit {
  constructor(private student:StudentService) { }
  collection:any = []
  //valiedstudent:boolean=false
  ngOnInit(): void {
    this.student.viewStudent().subscribe((result:any) =>{
      console.warn("result",result)
      this.collection = result
    });
    //  if(this.collection.length==0){
    //   this.valiedstudent=true
    // }
    }


}

