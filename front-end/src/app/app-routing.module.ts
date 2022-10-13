import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddEmployeeComponent } from './admin/add-employee/add-employee.component';
import { AdminDashboardComponent } from './admin/admin-dashboard/admin-dashboard.component';
import { EmployeesComponent } from './admin/employees/employees.component';
import { OffersComponent } from './admin/offers/offers.component';
import { SetOfferComponent } from './admin/set-offer/set-offer.component';
import { SetSalesReturnComponent } from './admin/set-sales-return/set-sales-return.component';
import { AddProductComponent } from './user/add-product/add-product.component';
import { AddPurchaseComponent } from './user/add-purchase/add-purchase.component';
import { AllSuppliersComponent } from './user/all-suppliers/all-suppliers.component';
import { CategoryComponent } from './user/category/category.component';
import { ProductComponent } from './user/product/product.component';
import { PurchaseComponent } from './user/purchase/purchase.component';
import { SalesReturnComponent } from './user/sales-return/sales-return.component';
import { SalesComponent } from './user/sales/sales.component';
import { StockComponent } from './user/stock/stock.component';
import { SupplierComponent } from './user/supplier/supplier.component';

const routes: Routes = [
  {
    component:CategoryComponent,
    path:'category'
  } ,
  {
    component:ProductComponent,
    path:'products'
  } ,
  {
    component:AddProductComponent,
    path:'add-product'
  } ,
  {
    component:SupplierComponent,
    path:'add-supplier'
  } ,
  {
    component:AllSuppliersComponent,
    path:'suppliers'
  } ,
  {
    component:AddEmployeeComponent,
    path:'add-employee'
  },
  {
    component:EmployeesComponent,
    path:'employees'
  },
  {
    component:AddPurchaseComponent,
    path:'add-purchase'
  },
  {
    component:PurchaseComponent,
    path:'purchases'
  },
  {
    component:StockComponent,
    path:'add-stock'
  },
  {
    component:SetOfferComponent,
    path:'add-offer'
  },
  {
    component:OffersComponent,
    path:'offers'
  },
  {
    component:SalesComponent,
    path:'add-sales'
  },
  {
    component:SalesReturnComponent,
    path:'add-salesreturn'
  },
  {
    component:SetSalesReturnComponent,
    path:'set-salesreturn'
  },
  {
    component:AdminDashboardComponent,
    path:'dashboard'
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
