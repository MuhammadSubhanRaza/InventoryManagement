import { Injectable } from '@angular/core';
import { Category } from '../models/category';
import { HttpClient } from '@angular/common/http'
import { Product } from '../models/product';

@Injectable({
  providedIn: 'root'
})
export class ProductService {

  constructor(private http:HttpClient) { }

  readonly baseUrl = "http://localhost:5162/api/products";
  readonly catUrl = "http://localhost:5162/api/categories";

  formData:Product = new Product(); 
  
  getCategories()
  {
    return this.http.get(this.catUrl)
  }

  postProduct(){
    // this.formData.imagePath = "customData";
    return this.http.post(this.baseUrl,this.formData)
  }

  getProducts()
  {
    return this.http.get(this.baseUrl)
  }

}
