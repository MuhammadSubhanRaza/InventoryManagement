import { Injectable } from '@angular/core';
import { Category } from '../models/category';
import { HttpClient } from '@angular/common/http'


@Injectable({
  providedIn: 'root'
})
export class CategoryService {

  constructor(private http:HttpClient) { }

  readonly baseUrl = "http://localhost:5162/api/categories";
  formData:Category = new Category(); 

  getCategories()
  {
    return this.http.get(this.baseUrl)
  }

  postCategory(){
    return this.http.post(this.baseUrl,this.formData)
  }

 


}
