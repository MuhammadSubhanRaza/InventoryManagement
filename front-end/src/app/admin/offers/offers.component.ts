import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { Offer } from 'src/app/models/offer';
import { OfferService } from 'src/app/services/offer.service';

@Component({
  selector: 'app-offers',
  templateUrl: './offers.component.html',
  styleUrls: ['./offers.component.css']
})
export class OffersComponent implements OnInit {


  offers : Offer[]

  constructor(public service:OfferService, private toastr:ToastrService) {
    this.loadAllOffers()
   }

   
  loadAllOffers()
  {
    this.service.getOffers().subscribe(
      res=>{
        // console.log(res as Employee[])
        this.offers = res as Offer[]
        // this.ExtendDataTable()
      },
      err=>{
        this.toastr.error("Some error occurred while fetching data")
      }
    )
  }


  ngOnInit(): void {
  }

}
