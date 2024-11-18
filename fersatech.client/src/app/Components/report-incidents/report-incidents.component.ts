import { Component, OnInit, inject } from '@angular/core';
import { Incident } from '../../interfaces/incident';
import { IncidentServiceService } from '../../services/RestFull/incident-service.service';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-report-incidents',
  templateUrl: './report-incidents.component.html',
  styleUrl: './report-incidents.component.css'
})
export class ReportIncidentsComponent implements OnInit {
  public Incidents: Incident[] = []
  public IsBusy: boolean = false
  private route = inject(ActivatedRoute);

  constructor(private serviceIncident: IncidentServiceService,
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
    this.serviceIncident.GetIncidents(TransactionId)
      .subscribe({
        next: (response: Incident[]) => {
          this.IsBusy = false
          this.Incidents = response
        },
        error: (error: Error) => {
          this.IsBusy = false
          console.error(error);
        }
      });
  }
}
