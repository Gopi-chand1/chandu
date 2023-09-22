import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { AddStudentComponent } from './components/add-student/add-student.component';
import { UpdateStudentComponent } from './components/update-student/update-student.component';
import { ListStudentComponent } from './components/list-student/list-student.component';
import { TeacherComponent } from './components/teacher/teacher.component';
import { StudentComponent } from './components/student/student.component';
import { HomeComponent } from './components/home/home.component';
import {HttpClientModule} from '@angular/common/http';
import {ReactiveFormsModule} from '@angular/forms';
import { ViewStudentComponent } from './components/view-student/view-student.component'

@NgModule({
  declarations: [
    AppComponent,
    AddStudentComponent,
    UpdateStudentComponent,
    ListStudentComponent,
    TeacherComponent,
    StudentComponent,
    HomeComponent,
    ViewStudentComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
