import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Purchase } from '../models/purchase';

@Injectable({
  providedIn: 'root'
})
export class PurchaseService {

  constructor(private http:HttpClient) { }

  
  readonly baseUrl = "http://localhost:5162/api/purchases";
  readonly prodUrl = "http://localhost:5162/api/products";
  readonly supUrl = "http://localhost:5162/api/suppliers";

  formData:Purchase = new Purchase(); 
  
  getSuppliers()
  {
    return this.http.get(this.supUrl)
  }
  getProducts()
  {
    return this.http.get(this.prodUrl)
  }

  postPurchase(){
    return this.http.post(this.baseUrl,this.formData)
  }

  getPurchases()
  {
    return this.http.get(this.baseUrl)
  }

  
  
}
