import { Component, OnInit } from '@angular/core';
import { resetFakeAsyncZone } from '@angular/core/testing';
import {FormGroup,FormControl} from '@angular/forms'
import {StudentService} from '../../shared/services/student/student.service'

@Component({
  selector: 'app-add-student',
  templateUrl: './add-student.component.html',
  styleUrls: ['./add-student.component.css']
})
export class AddStudentComponent implements OnInit {

  addStudent = new FormGroup({
    name : new FormControl(''),
    roll : new FormControl(''),
    dob : new FormControl(''),
    score : new FormControl('')
  })
  constructor(private student:StudentService) { }

  ngOnInit(): void {
  }
  CollectStudent(){
    this.student.saveStudent(this.addStudent.value).subscribe((result)=>{
      console.warn("result is here",result)
    })
    this.addStudent.reset()
  }

}
