import { Component } from '@angular/core';
import { Alert } from '../../interfaces/alert';
import { Router } from '@angular/router';
import { AlertServiceService } from '../../services/RestFull/alert-service.service';

@Component({
  selector: 'app-report-alerts',
  templateUrl: './report-alerts.component.html',
  styleUrl: './report-alerts.component.css'
})
export class ReportAlertsComponent {
  public Alerts: Alert[] = []
  public IsBusy: boolean = false

  constructor(private serviceIncident: AlertServiceService,
    private router: Router
  ) { }

  ngOnInit() {
    this.LoadData(1)
  }

  Back() {
    this.router.navigate([""])
  }

  LoadData(TransactionId: number) {
    this.IsBusy = true
    this.serviceIncident.GetAlerts(TransactionId)
      .subscribe({
        next: (response: Alert[]) => {
          this.IsBusy = false
          this.Alerts = response
        },
        error: (error: Error) => {
          this.IsBusy = false
          console.error(error);
        }
      });
  }
}
