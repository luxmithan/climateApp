import { Component, OnInit } from '@angular/core';
import { ClimateDetailService } from '../shared/climate-detail.service';

@Component({
  selector: 'app-climate-details',
  templateUrl: './climate-details.component.html',
  styleUrls: ['./climate-details.component.css'],
})
export class ClimateDetailsComponent implements OnInit {
  constructor(public service: ClimateDetailService) {}

  ngOnInit(): void {
    this.service.refreshList();
  }

  populateForm(selectedRecord) {
    this.service.formData = Object.assign({}, selectedRecord);
  }

  onDelete(cdId: number) {
    if (confirm('Wollen Sie wirklich diesen Eintrag löschen?')) {
      this.service.deleteClimateDetail(cdId).subscribe(
        (res) => {
          this.service.refreshList();
        },
        (err) => {
          console.log(err);
        }
      );
    }
  }
}
