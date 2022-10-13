import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Stock } from '../models/stock';

@Injectable({
  providedIn: 'root'
})
export class StockService {

  constructor(private http:HttpClient) { }

  readonly baseUrl = "http://localhost:5162/api/stocks";

  formData:Stock = new Stock(); 
  
  getStock()
  {
    return this.http.get(this.baseUrl)
  }

  // postEmployee(){
  //   return this.http.post(this.baseUrl,this.formData)
  // }
}
