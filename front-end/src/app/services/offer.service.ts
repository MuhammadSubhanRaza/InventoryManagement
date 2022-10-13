import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Offer } from '../models/offer';

@Injectable({
  providedIn: 'root'
})
export class OfferService {

  constructor(private http:HttpClient) { }

  readonly baseUrl = "http://localhost:5162/api/offers";

  formData:Offer = new Offer(); 
  
  getOffers()
  {
    return this.http.get(this.baseUrl)
  }

  postOffer(){
    return this.http.post(this.baseUrl,this.formData)
  }

}
