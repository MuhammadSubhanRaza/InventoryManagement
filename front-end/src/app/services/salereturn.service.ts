import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Salesreturn } from '../models/salesreturn';

@Injectable({
  providedIn: 'root'
})
export class SalereturnService {

  // constructor(private http:HttpClient) { }

  // readonly productUrl = "http://localhost:5162/api/products";
  // readonly baseUrl = "http://localhost:5162/api/salesreturns";

  // formData:Salesreturn = new Salesreturn(); 
  
  // getSalesReturn()
  // {
  //   return this.http.get(this.baseUrl)
  // }

  // postSalesReturn(){
  //   // this.formData.imagePath = "customData";
  //   return this.http.post(this.baseUrl,this.formData)
  // }

  // getProducts()
  // {
  //   return this.http.get(this.productUrl)
  // }
}
