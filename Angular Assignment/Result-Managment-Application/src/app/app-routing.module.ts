import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import {AddStudentComponent} from './components/add-student/add-student.component'
import {UpdateStudentComponent} from './components/update-student/update-student.component'
import {ListStudentComponent} from './components/list-student/list-student.component'
import {TeacherComponent} from './components/teacher/teacher.component'
import {StudentComponent} from './components/student/student.component'
import {HomeComponent} from './components/home/home.component'
import {ViewStudentComponent} from './components/view-student/view-student.component'

const routes: Routes = [
  {
    path:'',
    redirectTo:'home',pathMatch:'full'
  },
  {
    component:AddStudentComponent,
    path:'teacher/add'
  },
  {
    component:UpdateStudentComponent,
    path:'update/:id'
  },
  {
    component:ListStudentComponent,
    path:'teacher/list'
  },
  {
    component:StudentComponent,
    path:'student'
  },
  {
    component:TeacherComponent,
    path:'teacher'
  },
  {
    component:HomeComponent,
    path:''
  },
  {component:ViewStudentComponent,
  path:'view'
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
