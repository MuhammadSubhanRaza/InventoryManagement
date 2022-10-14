import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Dashboard } from '../models/dashboard';

@Injectable({
  providedIn: 'root'
})
export class DashboardService {

  constructor(private http:HttpClient) { }

  readonly baseUrl = "http://localhost:5162/api/dashboard";

  formData:Dashboard = new Dashboard(); 
  
  getDetails()
  {
    return this.http.get(this.baseUrl)
  }

}
