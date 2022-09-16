import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { City } from 'src/app/models/city';
import { Supplier } from 'src/app/models/supplier';
import { SupplierService } from 'src/app/services/supplier.service';

@Component({
  selector: 'app-supplier',
  templateUrl: './supplier.component.html',
  styleUrls: ['./supplier.component.css']
})
export class SupplierComponent implements OnInit {

  cities : City[]

  constructor(public service:SupplierService, private toastr:ToastrService) { 
    this.loadCities()
  }

  ngOnInit(): void {
  }


  onSubmit(form:NgForm)
  {
    this.service.postSupplier().subscribe(
      res => {
        this.toastr.success("Supplier added successfully! ")
        this.resetForm(form)
        this.loadCities()
      },
      err =>{
        console.log(err)
      }
    )
  }


  loadCities()
  {
    this.service.getCities().subscribe(
      res=>{
        this.cities = res as City[]
      },
      err=>{
        this.toastr.error("Some error occurred while fetching data")
      }
    )
  }

  resetForm(form:NgForm)
  {
    form.form.reset();
    this.service.formData = new Supplier();
  }

}
