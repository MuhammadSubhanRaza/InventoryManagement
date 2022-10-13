import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Supplier } from '../models/supplier';

@Injectable({
  providedIn: 'root'
})
export class SupplierService {

  constructor(private http:HttpClient) { }

  readonly baseUrl = "http://localhost:5162/api/suppliers";
  // readonly citiesUrl = "https://localhost:5162/api/cities";

  
  formData:Supplier = new Supplier(); 
  
  // getCities()
  // {
  //   return this.http.get(this.citiesUrl)
  // }

  postSupplier(){
    return this.http.post(this.baseUrl,this.formData)
  }

  getSuppliers()
  {
    return this.http.get(this.baseUrl)
  }

}
