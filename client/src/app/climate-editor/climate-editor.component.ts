import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';

import { ClimateDetail } from '../shared/climate-detail.model';
import { ClimateDetailService } from '../shared/climate-detail.service';

@Component({
  selector: 'app-climate-editor',
  templateUrl: './climate-editor.component.html',
  styleUrls: ['./climate-editor.component.css'],
})
export class ClimateEditorComponent implements OnInit {
  constructor(public service: ClimateDetailService) {}

  ngOnInit(): void {}

  resetForm(form: NgForm) {
    form.form.reset();
    this.service.formData = new ClimateDetail();
  }

  onSubmit(form: NgForm) {
    this.insertRecord(form);
  }

  insertRecord(form: NgForm) {
    this.service.postClimateDetail().subscribe(
      (res) => {
        this.resetForm(form);
        this.service.refreshList();
      },
      (err) => {
        console.log(err);
      }
    );
  }
}
