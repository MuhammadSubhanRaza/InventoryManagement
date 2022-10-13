import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Employee } from '../models/employee';

@Injectable({
  providedIn: 'root'
})
export class EmployeeService {

  constructor(private http:HttpClient) { }

  readonly baseUrl = "http://localhost:5162/api/employees";

  formData:Employee = new Employee(); 
  
  getEmployees()
  {
    return this.http.get(this.baseUrl)
  }

  postEmployee(){
    return this.http.post(this.baseUrl,this.formData)
  }

}
