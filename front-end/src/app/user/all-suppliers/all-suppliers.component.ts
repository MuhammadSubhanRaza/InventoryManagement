import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { Supplier } from 'src/app/models/supplier';
import { SupplierService } from 'src/app/services/supplier.service';

@Component({
  selector: 'app-all-suppliers',
  templateUrl: './all-suppliers.component.html',
  styleUrls: ['./all-suppliers.component.css']
})
export class AllSuppliersComponent implements OnInit {

  dtOptions: any = {};

  suppliers : Supplier[]

  constructor(public service:SupplierService, private toastr:ToastrService) {
    this.loadSuppliers()
   }

  ngOnInit(): void {
    this.ExtendDataTable()
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

  loadSuppliers()
  {
    this.service.getSuppliers().subscribe(
      res=>{
        this.suppliers = res as Supplier[]
        console.log(res)
      },
      err=>{
        this.toastr.error("Some error occurred while fetching data")
      }
    )
  }

}
