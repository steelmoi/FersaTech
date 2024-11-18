import { Component, inject } from '@angular/core';
import { Alert } from '../../interfaces/alert';
import { ActivatedRoute, Router } from '@angular/router';
import { AlertServiceService } from '../../services/RestFull/alert-service.service';

@Component({
  selector: 'app-report-alerts',
  templateUrl: './report-alerts.component.html',
  styleUrl: './report-alerts.component.css'
})
export class ReportAlertsComponent {
  public Alerts: Alert[] = []
  public IsBusy: boolean = false
  private route = inject(ActivatedRoute);

  constructor(private serviceIncident: AlertServiceService,
    private router: Router
  ) { }

  ngOnInit() {
    this.route.paramMap.subscribe((params) => {
      let TransactionId: number = Number(params.get('id')) | 0;
      this.LoadData(TransactionId)
    });
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
