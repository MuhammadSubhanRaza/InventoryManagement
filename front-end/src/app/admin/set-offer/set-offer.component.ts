import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { Offer } from 'src/app/models/offer';
import { OfferService } from 'src/app/services/offer.service';

@Component({
  selector: 'app-set-offer',
  templateUrl: './set-offer.component.html',
  styleUrls: ['./set-offer.component.css']
})
export class SetOfferComponent implements OnInit {

  constructor(public service:OfferService, private toastr:ToastrService) { 
    
  }


  ngOnInit(): void {
  }


  onSubmit(form:NgForm)
  {
    this.service.postOffer().subscribe(
      res => {
        this.toastr.success("Product added successfully! ")
        this.resetForm(form)
      },
      err =>{
        console.log(err)
      }
    )
  }

  resetForm(form:NgForm)
  {
    form.form.reset();
    this.service.formData = new Offer();
  }

}
