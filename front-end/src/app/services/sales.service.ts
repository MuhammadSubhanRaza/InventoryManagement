import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Saleitems } from '../models/saleitems';

@Injectable({
  providedIn: 'root'
})
export class SalesService {

  readonly productUrl = "http://localhost:5162/api/products";
  readonly baseUrl = "http://localhost:5162/api/Sales";

  
  constructor(private http:HttpClient) { }

  getProducts()
  {
    return this.http.get(this.productUrl)
  }

  getSales()
  {
    return this.http.get(this.baseUrl)
  }
  

  postSales(allItems:Saleitems[])
  {
      return this.http.post(this.baseUrl,allItems)
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
