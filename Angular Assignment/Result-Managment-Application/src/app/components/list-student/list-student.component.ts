import { Component, OnInit } from '@angular/core';
import {StudentService} from '../../shared/services/student/student.service';

@Component({
  selector: 'app-list-student',
  templateUrl: './list-student.component.html',
  styleUrls: ['./list-student.component.css']
})
export class ListStudentComponent implements OnInit {

  constructor(private student:StudentService) { }
  collection:any = [];
  ngOnInit(): void {
    this.student.getList().subscribe((result)=>{
      console.warn(result)
      this.collection = result
    })
  }
  deleteStudent(item:any){
    this.collection.splice(item-1,1)
    this.student.deleteStudent(item).subscribe((result)=>{
      console.warn("result",result)
    })
  }
}
