import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class SalesService {

  readonly productUrl = "http://localhost:5162/api/products";
  readonly prodUrl = "http://localhost:5162/api/products";
  readonly supUrl = "http://localhost:5162/api/suppliers";

  
  constructor(private http:HttpClient) { }

  getProducts()
  {
    return this.http.get(this.prodUrl)
  }
  
  // getSuppliers()
  // {
  //   return this.http.get(this.supUrl)
  // }
  // getProducts()
  // {
  //   return this.http.get(this.prodUrl)
  // }

  // postPurchase(){
  //   return this.http.post(this.baseUrl,this.formData)
  // }

  // getPurchases()
  // {
  //   return this.http.get(this.baseUrl)
  // }


}
