import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoadFileComponent } from './Components/load-file/load-file.component';
import { ReportTrasactionComponent } from './Components/report-trasaction/report-trasaction.component';
import { HomeComponent } from './Components/home/home.component';
import { ReportIncidentsComponent } from './Components/report-incidents/report-incidents.component';
import { ReportAlertsComponent } from './Components/report-alerts/report-alerts.component';

const routes: Routes = [
  { path: "", component: HomeComponent },
  { path: 'load-file', component: LoadFileComponent, pathMatch: 'full' },
  { path: 'report-transaction/:id', component: ReportTrasactionComponent },
  { path: 'report-incidencias/:id', component: ReportIncidentsComponent },
  { path: 'report-alerts/:id', component: ReportAlertsComponent}

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
