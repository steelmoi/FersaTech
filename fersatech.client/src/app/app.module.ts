import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { LoadFileComponent } from './Components/load-file/load-file.component';
import { RouterModule, RouterOutlet } from '@angular/router';
import { ReportTrasactionComponent } from './Components/report-trasaction/report-trasaction.component';
import { HomeComponent } from './Components/home/home.component';
import { ReportAlertsComponent } from './Components/report-alerts/report-alerts.component';
import { ReportIncidentsComponent } from './Components/report-incidents/report-incidents.component';

@NgModule({
  declarations: [
    AppComponent,
    LoadFileComponent,
    ReportTrasactionComponent,
    HomeComponent,
    ReportAlertsComponent,
    ReportIncidentsComponent
  ],
  imports: [
    BrowserModule, HttpClientModule, FormsModule, ReactiveFormsModule,
    RouterModule, RouterOutlet,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
