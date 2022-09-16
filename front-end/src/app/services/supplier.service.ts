import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Supplier } from '../models/supplier';

@Injectable({
  providedIn: 'root'
})
export class SupplierService {

  constructor(private http:HttpClient) { }

  readonly baseUrl = "https://localhost:7023/api/suppliers";
  readonly citiesUrl = "https://localhost:7023/api/cities";

  
  formData:Supplier = new Supplier(); 
  
  getCities()
  {
    return this.http.get(this.citiesUrl)
  }

  postSupplier(){
    console.log(this.formData)
    return this.http.post(this.baseUrl,this.formData)
  }

  getSuppliers()
  {
    return this.http.get(this.baseUrl)
  }

}
