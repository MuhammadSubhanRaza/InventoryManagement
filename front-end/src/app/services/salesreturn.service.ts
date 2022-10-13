import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Salesratios } from '../models/salesratios';

@Injectable({
  providedIn: 'root'
})
export class SalesreturnService {

  constructor(private http:HttpClient) { }

  readonly baseUrl = "http://localhost:5162/api/salesratios";
  readonly updateUrl = "http://localhost:5162/api/salesratios/1";

  formData:Salesratios = new Salesratios(); 
  
  postSalesratio(){
    // this.formData.imagePath = "customData";
    return this.http.post(this.baseUrl,this.formData)
  }

  putSalesratio(){
    // this.formData.imagePath = "customData";
    return this.http.put(this.updateUrl,this.formData)
  }

}
