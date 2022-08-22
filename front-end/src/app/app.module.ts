import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { SidebarComponent } from './common/sidebar/sidebar.component';
import { TopbarComponent } from './common/topbar/topbar.component';
import { ProductComponent } from './user/product/product.component';
import { CategoryComponent } from './user/category/category.component';
import { PurchaseComponent } from './user/purchase/purchase.component';
import { SalesComponent } from './user/sales/sales.component';
import { SupplierComponent } from './user/supplier/supplier.component';
import { StockComponent } from './user/stock/stock.component';
import { AddProductComponent } from './user/add-product/add-product.component';
import { AddPurchaseComponent } from './user/add-purchase/add-purchase.component';
import { PricingComponent } from './user/pricing/pricing.component';
import { EmployeesComponent } from './admin/employees/employees.component';
import { AddEmployeeComponent } from './admin/add-employee/add-employee.component';
import { SetSalesReturnComponent } from './admin/set-sales-return/set-sales-return.component';
import { SalesReturnComponent } from './user/sales-return/sales-return.component';
import { SetOfferComponent } from './admin/set-offer/set-offer.component';
import { LoginComponent } from './common/login/login.component';
import { LoaderComponent } from './common/loader/loader.component';
import { SuccessAlertComponent } from './common/success-alert/success-alert.component';
import { FailureAlertComponent } from './common/failure-alert/failure-alert.component';

@NgModule({
  declarations: [
    AppComponent,
    SidebarComponent,
    TopbarComponent,
    ProductComponent,
    CategoryComponent,
    PurchaseComponent,
    SalesComponent,
    SupplierComponent,
    StockComponent,
    AddProductComponent,
    AddPurchaseComponent,
    PricingComponent,
    EmployeesComponent,
    AddEmployeeComponent,
    SetSalesReturnComponent,
    SalesReturnComponent,
    SetOfferComponent,
    LoginComponent,
    LoaderComponent,
    SuccessAlertComponent,
    FailureAlertComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
