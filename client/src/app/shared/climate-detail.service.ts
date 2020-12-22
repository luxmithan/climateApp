import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { ClimateDetail } from './climate-detail.model';

@Injectable({
  providedIn: 'root',
})
export class ClimateDetailService {
  formData: ClimateDetail = new ClimateDetail();
  readonly baseURL = 'https://localhost:5001/api/ClimateDetail';
  list: ClimateDetail[];

  constructor(private http: HttpClient) {}

  postClimateDetail() {
    return this.http.post(this.baseURL, this.formData);
  }
  deleteClimateDetail(id: number) {
    return this.http.delete(`${this.baseURL}/${id}`);
  }

  refreshList() {
    this.http
      .get(this.baseURL)
      .toPromise()
      .then((res) => (this.list = res as ClimateDetail[]));
  }
}
