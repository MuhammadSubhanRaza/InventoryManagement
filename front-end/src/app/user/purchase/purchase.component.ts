import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { Purchase } from 'src/app/models/purchase';
import { PurchaseService } from 'src/app/services/purchase.service';

@Component({
  selector: 'app-purchase',
  templateUrl: './purchase.component.html',
  styleUrls: ['./purchase.component.css']
})
export class PurchaseComponent implements OnInit {

  dtOptions: any = {};

  purchases : Purchase[]

  constructor(public service:PurchaseService, private toastr:ToastrService) {
    
    this.loadAllPurchases()
   }


  ngOnInit(): void {
  }

  
  loadAllPurchases()
  {
    this.service.getPurchases().subscribe(
      res=>{
        this.purchases = res as Purchase[]
        // this.ExtendDataTable()
      },
      err=>{
        this.toastr.error("Some error occurred while fetching data")
      }
    )
  }

  

  ExtendDataTable()
  {
    this.dtOptions = {
      dom: 'Blfrtip',
      buttons: [
        'copy',
        'print',
        'csv',
        'excel',
        'pdf'
      ]
    };
  }


}
