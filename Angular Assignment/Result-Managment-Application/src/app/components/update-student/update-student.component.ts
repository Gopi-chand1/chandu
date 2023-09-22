import { Component, OnInit } from '@angular/core';
import {FormGroup,FormControl} from '@angular/forms';
import {ActivatedRoute,Router} from '@angular/router';
import {StudentService} from '../../shared/services/student/student.service'

@Component({
  selector: 'app-update-student',
  templateUrl: './update-student.component.html',
  styleUrls: ['./update-student.component.css']
})
export class UpdateStudentComponent implements OnInit {
  editStudent = new FormGroup({
    name : new FormControl(''),
    roll : new FormControl(''),
    dob : new FormControl(''),
    score : new FormControl('')
  })

  constructor(private router:ActivatedRoute,private student:StudentService,private router1 : Router) { }
  array:any = []
  ngOnInit(): void {
    console.warn(this.router.snapshot.params['id'])
    this.student.getStudent(this.router.snapshot.params['id']).subscribe((result)=>{
      this.array = result
      this.editStudent = new FormGroup({
        name : new FormControl(this.array['name']),
        roll : new FormControl(this.array['roll']),
        dob : new FormControl(this.array['dob']),
        score : new FormControl(this.array['score'])
    })
  })
}
  collection(){
    console.warn(this.editStudent.value);
    this.student.updateStudent(this.router.snapshot.params['id'],this.editStudent.value).subscribe((result)=>{
      console.warn("result",result)
    })
    setTimeout(() => {
      this.router1.navigate(['/teacher/list'])
    }, 1000);
    
  }


}
