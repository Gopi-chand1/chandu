import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http'

@Injectable({
  providedIn: 'root'
})
export class StudentService {
  collection:any = []
  url = "http://localhost:3000/Students"
  constructor(private http:HttpClient) { }
  getList(){
    return this.http.get(this.url)
  }
  saveStudent(data:any){
    return this.http.post(this.url,data)
  }
  deleteStudent(id:any){
    return this.http.delete(`${this.url}/${id}`)
  }
  getStudent(id:any){
    return this.http.get(`${this.url}/${id}`)
  }
  updateStudent(id:any,data:any){
    return this.http.put(`${this.url}/${id}`,data)

  }
  fetchStudent(roll:any,dob:any){
    this.collection =  this.http.get(`http://localhost:3000/Students?roll=${roll}&dob=${dob}`)
    return this.http.get(`http://localhost:3000/Students?roll=${roll}&dob=${dob}`)
  }
  viewStudent(){
    return this.collection
  }
}
